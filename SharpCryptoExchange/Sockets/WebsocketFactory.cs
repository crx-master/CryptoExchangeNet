using SharpCryptoExchange.Interfaces;
using SharpCryptoExchange.Logging;

namespace SharpCryptoExchange.Sockets
{
    /// <summary>
    /// Default websocket factory implementation
    /// </summary>
    public class WebsocketFactory : IWebsocketFactory
    {
        /// <inheritdoc />
        public IWebsocket CreateWebsocket(Log log, WebSocketParameters parameters)
        {
            return new CryptoExchangeWebSocketClient(log, parameters);
        }
    }
}
