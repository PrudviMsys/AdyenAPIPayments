using System.Text.Json.Serialization;

namespace AdyenAPIPayments.Models.AdyenPaymentsMethods
{
    public class PaymentMethodsResponse
    {
        [JsonPropertyName("paymentMethods")]
        public List<AdyenPaymentMethod>? PaymentMethods { get; set; }
    }
}
