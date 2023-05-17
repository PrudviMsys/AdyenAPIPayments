using System.Text.Json.Serialization;

namespace AdyenAPIPayments.Models.AdyenPaymentsDetails
{
    public class PaymentDetailsResponse
    {
        [JsonPropertyName("pspReference")]
        public string? PspReference { get; set; }

        [JsonPropertyName("resultCode")]
        public string? ResultCode { get; set; }

        [JsonPropertyName("refusalReason")]
        public string? RefusalReason { get; set; }
    }
}
