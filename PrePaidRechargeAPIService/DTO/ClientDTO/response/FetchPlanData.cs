using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.ClientDTO.response;

public class FetchPlanData
{
  [JsonPropertyName("data")]
  public FetchPlanTypes data { get; set; }
  
}
