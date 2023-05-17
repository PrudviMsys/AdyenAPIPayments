using System.Text.Json.Serialization;

namespace AdyenAPIPayments.Models.AdyenPaymentsMethods
{
    public class PaymentMethodsRequest
    {

        [JsonPropertyName("merchantAccount")]
        public string MerchantAccount { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("amount")]
        public Amount Amount { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("shopperLocale")]
        public string ShopperLocale { get; set; }
    }
}
