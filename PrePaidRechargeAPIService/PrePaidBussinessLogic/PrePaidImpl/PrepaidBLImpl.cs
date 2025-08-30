using System;
using PrePaidRechargeAPIService.PrePaidBussinessLogic.Interface;
using PrePaidRechargeAPIService.DTO.MicroService.Request;
using PrePaidRechargeAPIService.DTO.MicroService.Response;
using PrePaidRechargeAPIService.ClientService.Interface;
using PrePaidRechargeAPIService.ClientService.ClientImpl;
using PrePaidRechargeAPIService.DTO.ClientDTO.request;
using Newtonsoft.Json;

namespace PrePaidRechargeAPIService.PrePaidBussinessLogic.PrePaidImpl
{

  public class PrepaidBLImpl : IPrepaidBL
  {
    private readonly ILogger<PrepaidBLImpl> _logger;
    private readonly IClientService _clientService;

    public PrepaidBLImpl(ILogger<PrepaidBLImpl> logger, IClientService clientService)
    {
      _logger = logger;
      _clientService = clientService;

    }


    public async Task<RechargePlanData> fetchPlanBL(FetchPlanMSRequest request)
    {
      _logger.LogInformation("PrepaidBLImpl : fetchPlan  ");

      FetchPlanRequest fetchPlanRequest = new FetchPlanRequest();
      fetchPlanRequest.circle=request.CircleCode;
      fetchPlanRequest.OperatorCode=request.OperatorCode;
      fetchPlanRequest.Type=request.RechargeType;
      fetchPlanRequest.username = "HR1413";
      fetchPlanRequest.password = "8368804637";

      var plan = await _clientService.fetchPlan(fetchPlanRequest);
      
      string result=JsonConvert.SerializeObject(plan);
      
      RechargePlanData rechargePlanData =JsonConvert.DeserializeObject<RechargePlanData>(result);
      // return new RechargePlan=Data()
      // {
      //   data = new RechargeType()
      //   {
      //     TOPUP = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() },
      //     ThreeGFourG = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() },
      //     Roaming = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() },
      //     COMBO = new List<FetchPlanMsResponse>() { new FetchPlanMsResponse() }
      //   }
      // };
      return rechargePlanData;
    }
  }
}
