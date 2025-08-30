using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.ClientDTO.response;

public class FetchPlanTypes
{
  
  [JsonPropertyName("TOPUP")]
  public List<FetchPlanDetails> TOPUP { get; set; }

  [JsonPropertyName("3G/4G")]
  public List<FetchPlanDetails> ThreeGFourG { get; set; }
  [JsonPropertyName("Romaing")]
  public List<FetchPlanDetails> Romaing { get; set; }
  [JsonPropertyName("COMBO")]
  public List<FetchPlanDetails> COMBO { get; set; }


}
