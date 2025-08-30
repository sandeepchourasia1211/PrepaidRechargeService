using System;

namespace PrePaidRechargeAPIService.DTO.ClientDTO.request;

public class FetchPlanRequest
{
  public string username { get; set; }
  public string password { get; set; }
  public int circle { get; set; }
  public int OperatorCode{ get; set; }
  public string Type{ get; set; }

}
