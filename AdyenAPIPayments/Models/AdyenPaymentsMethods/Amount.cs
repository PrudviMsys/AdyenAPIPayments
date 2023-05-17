using System.Text.Json.Serialization;

namespace AdyenAPIPayments.Models.AdyenPaymentsMethods
{
    public class Amount
    {
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }
}
