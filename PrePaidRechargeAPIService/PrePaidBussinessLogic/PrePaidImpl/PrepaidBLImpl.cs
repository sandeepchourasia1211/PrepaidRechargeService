using System;
using PrePaidRechargeAPIService.PrePaidBussinessLogic.Interface;
using PrePaidRechargeAPIService.DTO.MicroService.Request;
using PrePaidRechargeAPIService.DTO.MicroService.Response;

namespace PrePaidRechargeAPIService.PrePaidBussinessLogic.PrePaidImpl
{

  public class PrepaidBLImpl : IPrepaidBL
  {
    private readonly ILogger<PrepaidBLImpl> _logger;

    public PrepaidBLImpl(ILogger<PrepaidBLImpl> logger)
    {
      _logger = logger;

    }


    public async Task<RechargePlanData> fetchPlanBL(FetchPlanMSRequest request)
    {
      _logger.LogInformation("PrepaidBLImpl : fetchPlan  ");
      return new RechargePlanData()
      {
        data = new RechargeType()
        {
          TopUp = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() },
          ThreeGFourG = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() },
          Roaming = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() },
          Combo = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() }
        }
      };
    }
  }
}
