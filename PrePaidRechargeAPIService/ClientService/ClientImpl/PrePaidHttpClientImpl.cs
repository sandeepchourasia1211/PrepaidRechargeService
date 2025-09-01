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
    public async Task<FetchPlanData> fetchPlan(FetchPlanRequest request)
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

    //RechargeRequest impl
    public async Task<RechargeDetails> rechargeRequest(RechargePlanRequest request)
    {
      RechargeDetails res = null;
      using (HttpClient client = new HttpClient())
      {
        string url = $"http://env.specificstep.com/neo/api?username={request.username}&password={request.password}&utransactionid={request.utransactionId}&circlecode={request.circlecode}&operatorcode={request.operatorcode}&number={request.number}&amount={request.amount}";
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
            res = JsonSerializer.Deserialize<RechargeDetails>(result);
            // Console.WriteLine(result);
          }
          else
          {
            Console.WriteLine($"Error: {response.StatusCode}");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Exception: {JsonSerializer.Serialize(ex)}");
        }
      }

      return res;
    }

    //RechargeStatus impl
    public async Task<RechargeStatusResponse> rechargeStatus(RechargeStatusRequest request)
    {
      RechargeStatusResponse res = null;
      using (HttpClient client = new HttpClient())
      {
        string url = $"http://env.specificstep.com/neo/api/status?username={request.username}&password={request.password}&utransactionid={request.utransactionid}&gettransid={request.gettransid}&operator_id={request.operator_id}";
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
            res = JsonSerializer.Deserialize<RechargeStatusResponse>(result);
            // Console.WriteLine(result);
          }
          else
          {
            Console.WriteLine($"Error: {response.StatusCode}");
          }
        }
        // catch (Exception ex)
        // {
        //   Console.WriteLine($"Exception: {JsonSerializer.Serialize(ex)}");
        // }

        catch (Exception ex)
        {
          var errorLog = new
          {
            Message = ex.Message,
            StackTrace = ex.StackTrace,
            Source = ex.Source,
            InnerException = ex.InnerException?.Message
          };

          Console.WriteLine($"Exception: {JsonSerializer.Serialize(errorLog)}");
        }
      }


      return res;
    }

  }
}