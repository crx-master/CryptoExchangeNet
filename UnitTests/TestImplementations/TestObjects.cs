using Newtonsoft.Json;

namespace SharpCryptoExchange.UnitTests.TestImplementations
{
    public class TestObject
    {
        [JsonProperty("other")]
        public string StringData { get; set; }
        public int IntData { get; set; }
        public decimal DecimalData { get; set; }
    }
}
