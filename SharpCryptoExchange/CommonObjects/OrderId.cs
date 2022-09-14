using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCryptoExchange.CommonObjects
{
    /// <summary>
    /// Id of an order
    /// </summary>
    public class OrderId: BaseCommonObject
    {
        /// <summary>
        /// Id of an order
        /// </summary>
        public string Id { get; set; } = string.Empty;
    }
}
