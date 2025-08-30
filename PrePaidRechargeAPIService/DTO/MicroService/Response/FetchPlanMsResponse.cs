using System;
using System.Text.Json.Serialization;

namespace PrePaidRechargeAPIService.DTO.MicroService.Response;

public class FetchPlanMsResponse
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
