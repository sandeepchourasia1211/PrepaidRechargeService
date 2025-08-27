using System;

namespace PrePaidRechargeAPIService.DTO.MicroService.Request
{

public class FetchPlanMSRequest
{

  public Int32 CircleCode { get; set; }
  public Int32 OperatorCode { get; set; }  
  public string RechargeType{ get; set; }
}

}
