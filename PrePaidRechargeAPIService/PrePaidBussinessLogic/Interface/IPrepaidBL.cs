using System;
using PrePaidRechargeAPIService.DTO.MicroService.Request;
using PrePaidRechargeAPIService.DTO.MicroService.Response;

namespace PrePaidRechargeAPIService.PrePaidBussinessLogic.Interface
{

  public interface IPrepaidBL
  {
    public Task<RechargePlanData> fetchPlanBL(FetchPlanMSRequest request);

    // RechagreBL logic
    public Task<RechargeMsResponse> rechargeBL(RechargeMSRequest request);

    //RechargeStatusBL
    public Task<RechargeStatusMSResponse> rechargeStatusBL(RechargeStatusMSRequest request);

  }


}