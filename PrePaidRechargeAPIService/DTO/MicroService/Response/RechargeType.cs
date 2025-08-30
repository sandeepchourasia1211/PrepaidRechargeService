using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.MicroService.Response
{

public class RechargeType
{
    [JsonPropertyName("TOPUP")]
  public List<FetchPlanMsResponse> TOPUP { get; set; }

  [JsonPropertyName("3G/4G")]
  public List<FetchPlanMsResponse> ThreeGFourG { get; set; }
  [JsonPropertyName("Romaing")]
  public List<FetchPlanMsResponse> Romaing { get; set; }
  [JsonPropertyName("COMBO")]
  public List<FetchPlanMsResponse> COMBO { get; set; }

  
}
}