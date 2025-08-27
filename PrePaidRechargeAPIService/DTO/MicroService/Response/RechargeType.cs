using System;

namespace PrePaidRechargeAPIService.DTO.MicroService.Response
{

public class RechargeType
{
  
  public List<FetchPlanMsResponse> TopUp{ get; set; }

  public List<FetchPlanMsResponse> ThreeGFourG{ get; set; }

  public List<FetchPlanMsResponse> Roaming{ get; set; }
  
  public List<FetchPlanMsResponse> Combo{ get; set; }

  
}
}