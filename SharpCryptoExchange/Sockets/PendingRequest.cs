using Newtonsoft.Json.Linq;
using SharpCryptoExchange.Objects;
using System;
using System.Threading;

namespace SharpCryptoExchange.Sockets
{
    internal class PendingRequest
    {
        public Func<JToken, bool> Handler { get; }
        public JToken? Result { get; private set; }
        public bool Completed { get; private set; }
        public AsyncResetEvent Event { get; }
        public TimeSpan Timeout { get; }

        private readonly CancellationTokenSource _cts;

        public PendingRequest(Func<JToken, bool> handler, TimeSpan timeout)
        {
            Handler = handler;
            Event = new AsyncResetEvent(false, false);
            Timeout = timeout;

            _cts = new CancellationTokenSource(timeout);
            _cts.Token.Register(Fail, false);
        }

        public bool CheckData(JToken data)
        {
            if (Handler(data))
            {
                Result = data;
                Completed = true;
                Event.Set();
                return true;
            }

            return false;
        }

        public void Fail()
        {
            Completed = true;
            Event.Set();
        }
    }
}
