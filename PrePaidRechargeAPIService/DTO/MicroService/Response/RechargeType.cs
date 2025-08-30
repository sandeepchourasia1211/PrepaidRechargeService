using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.MicroService.Response
{

public class RechargeType
{
  
  public List<FetchPlanMsResponse> TopUp{ get; set; }

   [JsonPropertyName("3G/4G")]   // JSON key will be "3G/4G"
  public List<FetchPlanMsResponse> ThreeGFourG { get; set; }

  public List<FetchPlanMsResponse> Roaming{ get; set; }
  
  public List<FetchPlanMsResponse> Combo{ get; set; }

  
}
}