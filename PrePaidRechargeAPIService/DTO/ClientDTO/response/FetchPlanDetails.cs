using System;
using System.Text.Json.Serialization;
namespace PrePaidRechargeAPIService.DTO.ClientDTO.response;

public class FetchPlanDetails
{
  [JsonPropertyName("rs")]
    public string Rs { get; set; }

    [JsonPropertyName("desc")]
    public string Description { get; set; }

    [JsonPropertyName("validity")]
    public string Validity { get; set; }

    [JsonPropertyName("last_update")]
    public string LastUpdate { get; set; }

}
