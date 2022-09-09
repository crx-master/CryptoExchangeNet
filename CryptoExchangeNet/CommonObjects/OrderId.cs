using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoExchangeNet.CommonObjects
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
