namespace AdyenAPIPayments.Models.AdyenPayments
{
    public class PaymentResponse
    {
        public string ResultCode { get; set; }
        public AdyenAction Action { get; set; }
        public bool IsSuccessStatusCode { get; internal set; }
    }
}
