using System.Text.Json.Serialization;

namespace AdyenAPIPayments.Models.AdyenPaymentsDetails
{
    public class Details
    {
        [JsonPropertyName("redirectResult")]
        public string? RedirectResult { get; set; }
    }
}
