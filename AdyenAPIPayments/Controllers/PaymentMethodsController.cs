using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using AdyenAPIPayments.Models.AdyenPaymentsMethods;

namespace AdyenAPIPayments.Controllers
{
    [ApiController]
    [Route("paymentMethods")]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public PaymentMethodsController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpPost]
        public async Task<ActionResult<PaymentMethodsResponse>> Post(PaymentMethodsRequest request)
        {
            var client = _clientFactory.CreateClient();
            var url = "https://checkout-test.adyen.com/v69/paymentMethods";
            var apiKey = "YOUR-X-API-KEY";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, url);
            httpRequest.Headers.Add("x-API-key", apiKey);

            var json = JsonSerializer.Serialize(request);
            httpRequest.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var httpResponse = await client.SendAsync(httpRequest);

            if (httpResponse.IsSuccessStatusCode)
            {
                var responseJson = await httpResponse.Content.ReadAsStringAsync();
                var response = JsonSerializer.Deserialize<PaymentMethodsResponse>(responseJson);
                return response;
            }
            else
            {
                return BadRequest();
            }
        }

        
        
        
        
        //[HttpGet]
        //public async Task<ActionResult<PaymentMethodsResponse>> Get()
        //{
        //    var client = _clientFactory.CreateClient();
        //    var url = "https://checkout-test.adyen.com/v69/paymentMethods";
        //    var apiKey = "YOUR_API_key";

        //    var httpRequest = new HttpRequestMessage(HttpMethod.Get, url);
        //    httpRequest.Headers.Add("x-API-key", apiKey);

        //    var httpResponse = await client.SendAsync(httpRequest);

        //    if (httpResponse.IsSuccessStatusCode)
        //    {
        //        var responseJson = await httpResponse.Content.ReadAsStringAsync();
        //        var response = JsonSerializer.Deserialize<PaymentMethodsResponse>(responseJson);
        //        return response;
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<PaymentMethod>> GetById(string id)
        //{
        //    var client = _clientFactory.CreateClient();
        //    var url = $"https://checkout-test.adyen.com/v69/paymentMethods/{id}";
        //    var apiKey = "YOUR_API_key";

        //    var httpRequest = new HttpRequestMessage(HttpMethod.Get, url);
        //    httpRequest.Headers.Add("x-API-key", apiKey);

        //    var httpResponse = await client.SendAsync(httpRequest);

        //    if (httpResponse.IsSuccessStatusCode)
        //    {
        //        var responseJson = await httpResponse.Content.ReadAsStringAsync();
        //        var response = JsonSerializer.Deserialize<PaymentMethod>(responseJson);

        //        if (response != null)
        //        {
        //            return Ok(response);
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}
