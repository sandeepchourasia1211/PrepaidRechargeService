using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.ClientDTO.response;

public class FetchPlanTypes
{
  public List<FetchPlanDetails> TOPUP { get; set;  }

  [JsonPropertyName("3G/4G")]   // JSON key will be "3G/4G"
    public List<FetchPlanDetails> ThreeG_FourG { get; set; }
  public List<FetchPlanDetails> ROAMING { get; set;  }
  public List<FetchPlanDetails> COMBO { get; set;  }


}
