using AdyenAPIPayments.Models.AdyenPaymentsMethods;

namespace AdyenAPIPayments.Models.AdyenPayments
{
    public class PaymentResponse
    {
        public AdditionalData? AdditionalData { get; set; }
        public string? PspReference { get; set; }
        public string? ResultCode { get; set; }
        public Amount? Amount { get; set; }
        public string? MerchantReference { get; set; }
        public PaymentMethodResponse PaymentMethod { get; set; }
    }
}
