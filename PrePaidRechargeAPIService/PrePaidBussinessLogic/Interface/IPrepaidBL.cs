using System;
using PrePaidRechargeAPIService.DTO.MicroService.Request;
using PrePaidRechargeAPIService.DTO.MicroService.Response;

namespace PrePaidRechargeAPIService.PrePaidBussinessLogic.Interface
{

public interface IPrepaidBL
{
  public  Task<RechargePlanData> fetchPlanBL(FetchPlanMSRequest request);

}
}