using Microsoft.Extensions.Logging;
using SharpCryptoExchange.Interfaces;


namespace SharpCryptoExchange.Sockets
{
    /// <summary>
    /// Default websocket factory implementation
    /// </summary>
    public class WebsocketFactory : IWebsocketFactory
    {
        /// <inheritdoc />
        public IWebsocket CreateWebsocket(ILogger logger, WebSocketParameters parameters)
        {
            return new CryptoExchangeWebSocketClient(logger, parameters);
        }
    }
}
