using System;

namespace SharpCryptoExchange.Attributes
{
    /// <summary>
    /// Map a enum entry to string values
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class MapAttribute : Attribute
    {
        /// <summary>
        /// Values mapping to the enum entry
        /// </summary>
        public string[] Values { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="maps"></param>
        public MapAttribute(params string[] maps)
        {
            Values = maps;
        }
    }
}
