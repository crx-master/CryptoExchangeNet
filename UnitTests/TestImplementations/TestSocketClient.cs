using System;
using System.Threading.Tasks;
using SharpCryptoExchange.Authentication;
using SharpCryptoExchange.Interfaces;
using SharpCryptoExchange.Logging;
using SharpCryptoExchange.Objects;
using SharpCryptoExchange.Sockets;
using Moq;
using Newtonsoft.Json.Linq;
using System.Diagnostics.CodeAnalysis;

namespace SharpCryptoExchange.UnitTests.TestImplementations
{
    public class TestSocketClient: BaseSocketClient
    {
        public TestSubSocketClient SubClient { get; }

        public TestSocketClient() : this(new TestOptions())
        {
        }

        public TestSocketClient(TestOptions exchangeOptions) : base("test", exchangeOptions)
        {
            SubClient = new TestSubSocketClient(exchangeOptions, exchangeOptions.SubOptions);
            SocketFactory = new Mock<IWebsocketFactory>().Object;
            Mock.Get(SocketFactory).Setup(f => f.CreateWebsocket(It.IsAny<Log>(), It.IsAny<WebSocketParameters>())).Returns(new TestSocket());
        }

        public TestSocket CreateSocket()
        {
            Mock.Get(SocketFactory).Setup(f => f.CreateWebsocket(It.IsAny<Log>(), It.IsAny<WebSocketParameters>())).Returns(new TestSocket());
            return (TestSocket)CreateSocket("https://localhost:123/");
        }

        public CallResult<bool> ConnectSocketSub(SocketConnection sub)
        {
            return ConnectSocketAsync(sub).Result;
        }


        protected override bool HandleQueryResponse<T>(SocketConnection socketConnection, object request, JToken data, [NotNullWhen(true)] out CallResult<T> callResult)
        {
            throw new NotImplementedException();
        }

        protected override bool HandleSubscriptionResponse(SocketConnection socketConnection, SocketSubscription subscription, object request, JToken data, out CallResult<object> callResult)
        {
            throw new NotImplementedException();
        }

        protected override bool MessageMatchesHandler(SocketConnection socketConnection, JToken message, object request)
        {
            throw new NotImplementedException();
        }

        protected override bool MessageMatchesHandler(SocketConnection socketConnection, JToken message, string identifier)
        {
            throw new NotImplementedException();
        }

        protected override Task<CallResult<bool>> AuthenticateSocketAsync(SocketConnection socketConnection)
        {
            throw new NotImplementedException();
        }

        protected override Task<bool> UnsubscribeAsync(SocketConnection connection, SocketSubscription subscriptionToUnsub)
        {
            throw new NotImplementedException();
        }
    }

    public class TestOptions: BaseSocketClientOptions
    {
        public ApiClientOptions SubOptions { get; set; } = new ApiClientOptions();
    }

    public class TestSubSocketClient : SocketApiClient
    {

        public TestSubSocketClient(BaseClientOptions options, ApiClientOptions apiOptions): base(options, apiOptions)
        {

        }

        protected override AuthenticationProvider CreateAuthenticationProvider(ApiCredentials credentials)
            => new TestAuthProvider(credentials);
    }
}
