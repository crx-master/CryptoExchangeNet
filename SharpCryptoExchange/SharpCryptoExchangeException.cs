using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCryptoExchange
{
    /// <summary>
    /// Throw specific exception from this package if needed
    /// </summary>
    /// <remarks>
    /// If you throw a general exception type, such as Exception or SystemException in a library or framework,<br />
    /// it forces consumers to catch all exceptions, including unknown exceptions that they do not know how to handle.
    /// </remarks>
    public class SharpCryptoExchangeException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Prior catch exception</param>
        public SharpCryptoExchangeException(string? message, Exception? innerException = null) : base(message, innerException)
        {
        }
    }
}
