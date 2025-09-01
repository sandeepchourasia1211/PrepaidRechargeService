using System;

namespace PrePaidRechargeAPIService.DTO.MicroService.Request;

public class RechargeStatusMSRequest
{
  public string utransactionid { get; set; }
  public Boolean gettransid { get; set; }
  public string operator_id { get; set; }

}
