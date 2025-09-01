using System;

namespace PrePaidRechargeAPIService.DTO.ClientDTO.request;

public class RechargePlanRequest
{
  public string username { get; set; }
  public string password { get; set; }
  public string utransactionId { get; set; }
  public Int32 circlecode { get; set; }
  public Int32 operatorcode { get; set; }
  public string number { get; set; }
  public Int32 amount { get; set; } 

}
