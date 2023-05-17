using AdyenAPIPayments.Models.AdyenPaymentsDetails;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[ApiController]
[Route("payments")]
public class PaymentsController : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PaymentsController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpPost("details")]
    public async Task<ActionResult<PaymentDetailsResponse>> ProcessPaymentDetails(PaymentDetailsRequest request)
    {
        var apiKey = "YOUR_x-API-key";
        var apiUrl = "https://checkout-test.adyen.com/v69/payments/details";

        using var client = _httpClientFactory.CreateClient();

        // Set headers
        client.DefaultRequestHeaders.Add("x-API-key", apiKey);
        //client.DefaultRequestHeaders.Add("content-type", "application/json");

        // Serialize the request body
        var jsonRequest = JsonSerializer.Serialize(request);

        // Create the HTTP request content
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        // Send the request
        var response = await client.PostAsync(apiUrl, content);

        // Handle the response
        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var paymentResponse = JsonSerializer.Deserialize<PaymentDetailsResponse>(jsonResponse);

            return Ok(paymentResponse);
        }
        else
        {
            return StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }
    }
}
