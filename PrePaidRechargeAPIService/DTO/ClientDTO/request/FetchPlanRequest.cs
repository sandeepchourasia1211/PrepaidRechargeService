using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.ClientDTO.request;

public class FetchPlanRequest
{
  public  string username { get; set; }
  public string password { get; set; }
  public int circle { get; set; }
  
   [JsonPropertyName("operator")]
  public int OperatorCode { get; set; }

  // public int @operator{ get; set; }
  
  [JsonPropertyName("type")]
  public string Type { get; set; }

}
