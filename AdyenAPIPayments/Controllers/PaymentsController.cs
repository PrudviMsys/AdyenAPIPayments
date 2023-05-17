using AdyenAPIPayments.Models.AdyenPaymentsMethods;
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
            _httpClient.DefaultRequestHeaders.Add("x-API-key", "YOUR_x-API-key");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(paymentRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://checkout-test.adyen.com/v69/payments", requestContent);
            var responseContent = await response.Content.ReadAsStringAsync();

            var paymentResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<PaymentResponse>(responseContent);

            //return Ok(paymentResponse);
            if (paymentResponse.IsSuccessStatusCode)
            {
                return Ok(paymentResponse);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
