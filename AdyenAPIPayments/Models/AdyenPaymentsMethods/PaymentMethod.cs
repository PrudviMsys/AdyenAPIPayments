using System.Text.Json.Serialization;

namespace AdyenAPIPayments.Models.AdyenPaymentsMethods
{
    public class AdyenPaymentMethod
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("issuers")]
        public List<Issuer>? Issuers { get; set; }

        [JsonPropertyName("brands")]
        public List<string>? Brands { get; set; }
    }
}
