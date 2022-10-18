using Microsoft.Extensions.Logging;
using SharpCryptoExchange.Sockets;

namespace SharpCryptoExchange.Interfaces
{
    /// <summary>
    /// Websocket factory interface
    /// </summary>
    public interface IWebsocketFactory
    {
        /// <summary>
        /// Create a websocket for an url
        /// </summary>
        /// <param name="logger">The logger instance</param>
        /// <param name="parameters">The parameters to use for the connection</param>
        /// <returns></returns>
        IWebsocket CreateWebsocket(ILogger logger, WebSocketParameters parameters);
    }
}
