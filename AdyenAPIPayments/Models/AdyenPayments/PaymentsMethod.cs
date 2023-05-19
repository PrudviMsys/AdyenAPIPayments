namespace AdyenAPIPayments.Models.AdyenPayments
{
    public class PaymentsMethod
    {
        public string? Type { get; set; }
        public string? EncryptedCardNumber { get; set; }
        public string? EncryptedExpiryMonth { get; set; }
        public string? EncryptedExpiryYear { get; set; }
        public string? EncryptedSecurityCode { get; set; }
    }
}
