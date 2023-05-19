namespace AdyenAPIPayments.Models.AdyenPayments
{
    public class AdditionalData
    {
        public string? AuthCode { get; set; }
        public string? AvsResult { get; set; }
        public string? CardHolderName { get; set; }
        public string? RefusalReasonRaw { get; set; }
        public string? IssuerCountry { get; set; }
        public string? CvcResult { get; set; }
        public string? AvsResultRaw { get; set; }
        public string? PaymentMethod { get; set; }
        public string? CvcResultRaw { get; set; }
        public string? AcquirerCode { get; set; }
        public string? AcquirerReference { get; set; }
    }
}
