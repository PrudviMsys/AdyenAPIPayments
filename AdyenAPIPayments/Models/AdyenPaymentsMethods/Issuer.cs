using System.Text.Json.Serialization;

namespace AdyenAPIPayments.Models.AdyenPaymentsMethods
{
    public class Issuer
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
