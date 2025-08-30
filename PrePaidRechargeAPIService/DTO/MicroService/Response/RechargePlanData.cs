using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.MicroService.Response
{

public class RechargePlanData
{
  [JsonPropertyName("data")]
  public RechargeType data { get; set; }

}
}