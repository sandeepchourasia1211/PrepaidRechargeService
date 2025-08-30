using System;
using PrePaidRechargeAPIService.DTO.ClientDTO.response;
using PrePaidRechargeAPIService.DTO.ClientDTO.request;
using System.Text.Json.Serialization;
using PrePaidRechargeAPIService.ClientService.Interface;
using System.Text.Json;
namespace PrePaidRechargeAPIService.ClientService.ClientImpl
{


  public class PrePaidHttpClientImpl : IClientService
  {

    public  async Task<FetchPlanData> fetchPlan(FetchPlanRequest request)
    {
      FetchPlanData res = null;
      using (HttpClient client = new HttpClient())
      {
        string url = $"http://env.specificstep.com/neo/plan?username={request.username}&password={request.password}&circle={request.circle}&operator={request.OperatorCode}&type={request.Type}";
        Console.WriteLine($"url: {url}");
        try
        {
          HttpResponseMessage response = await client.GetAsync(url);

          if (response.IsSuccessStatusCode)
          {
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response:");
            Console.WriteLine(result);

// json = response string from HttpClient
           // var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            //res = JsonConvert.DeserializeObject<FetchPlanData>(result);
            res = JsonSerializer.Deserialize<FetchPlanData>(result);
          }
          else
          {
            Console.WriteLine($"Error: {response.StatusCode}");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Exception: {ex.Message}");
        }
      }

      return res;
    }
  }
}