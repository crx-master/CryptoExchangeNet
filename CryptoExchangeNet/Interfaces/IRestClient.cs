using System;
using CryptoExchangeNet.Authentication;
using CryptoExchangeNet.Objects;

namespace CryptoExchangeNet.Interfaces
{
    /// <summary>
    /// Base class for rest API implementations
    /// </summary>
    public interface IRestClient: IDisposable
    {
        /// <summary>
        /// The factory for creating requests. Used for unit testing
        /// </summary>
        IRequestFactory RequestFactory { get; set; }

        /// <summary>
        /// The total amount of requests made with this client
        /// </summary>
        int TotalRequestsMade { get; }

        /// <summary>
        /// The options provided for this client
        /// </summary>
        BaseRestClientOptions ClientOptions { get; }

        /// <summary>
        /// Set the API credentials for this client. All Api clients in this client will use the new credentials, regardless of earlier set options.
        /// </summary>
        /// <param name="credentials">The credentials to set</param>
        void SetApiCredentials(ApiCredentials credentials);
    }
}