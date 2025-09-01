using System;

namespace PrePaidRechargeAPIService.DTO.MicroService.Request;

public class RechargeMSRequest
{
  public string utransactionId { get; set; }
  public Int32 circlecode { get; set; }
  public Int32 operatorcode { get; set; }
  public string number { get; set; }
  public Int32 amount { get; set; } 

}
