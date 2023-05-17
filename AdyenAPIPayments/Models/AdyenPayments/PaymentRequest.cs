using AdyenAPIPayments.Models.AdyenPaymentsMethods;

namespace AdyenAPIPayments.Models.AdyenPayments
{
    public class PaymentRequest
    {
        public Amount Amount { get; set; }
        public string Reference { get; set; }
        public AdyenPaymentMethod PaymentMethod { get; set; }
        public string ReturnUrl { get; set; }
        public string MerchantAccount { get; set; }
    }
}
