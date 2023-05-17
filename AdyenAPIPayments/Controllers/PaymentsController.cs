using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using AdyenAPIPayments.Models.AdyenPayments;
using System.Net.Http.Headers;

namespace AdyenAPIPayments.Controllers
{
    [ApiController]
    [Route("payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public PaymentsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpPost]
        public async Task<ActionResult<PaymentResponse>> MakePaymentRequest(PaymentRequest paymentRequest)
        {
            // Replace "YOUR_API_KEY" with your actual Adyen API key
            _httpClient.DefaultRequestHeaders.Add("x-API-key", "YOUR-X-API-KEY");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var url = "https://checkout-test.adyen.com/v70/payments";

            var json = System.Text.Json.JsonSerializer.Serialize(paymentRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                var paymentResponse = System.Text.Json.JsonSerializer.Deserialize<PaymentResponse>(responseJson);
                return Ok(paymentResponse);
            }

            return BadRequest();
        }
    }
}
