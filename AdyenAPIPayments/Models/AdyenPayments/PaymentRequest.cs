using AdyenAPIPayments.Models.AdyenPaymentsMethods;

namespace AdyenAPIPayments.Models.AdyenPayments
{
    public class PaymentRequest
    {
        public PaymentsMethod? PaymentMethod { get; set; }
        public Amount? Amount { get; set; }
        public string? Reference { get; set; }
        public string? ReturnUrl { get; set; }
        public string? MerchantAccount { get; set; }
        //public string? ShopperReference { get; set; }
        //public string? ShopperInteraction { get; set; }
        //public string? RecurringProcessingModel { get; set; }
        //public bool StorePaymentMethod { get; set; }
    }
}
