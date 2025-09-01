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
      fetchPlanRequest.circle = request.CircleCode;
      fetchPlanRequest.OperatorCode = request.OperatorCode;
      fetchPlanRequest.Type = request.RechargeType;
      fetchPlanRequest.username = "HR1413";
      fetchPlanRequest.password = "8368804637";

      var plan = await _clientService.fetchPlan(fetchPlanRequest);

      string result = JsonConvert.SerializeObject(plan);

      RechargePlanData rechargePlanData = JsonConvert.DeserializeObject<RechargePlanData>(result);
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
    
  //RechargeBL 
    public async Task<RechargeMsResponse> rechargeBL(RechargeMSRequest request)
    {
      _logger.LogInformation("PrepaidBLImpl : rechargePlan  ");
      RechargeMsResponse rechargeMsResponse = new RechargeMsResponse();
      RechargePlanRequest rechargePlanRequest = new RechargePlanRequest();
      rechargePlanRequest.circlecode = request.circlecode;
      rechargePlanRequest.operatorcode = request.operatorcode;
      rechargePlanRequest.amount = request.amount;
      rechargePlanRequest.number = request.number;
      rechargePlanRequest.utransactionId = request.utransactionId;
      rechargePlanRequest.username = "HR1413";
      rechargePlanRequest.password = "8368804637";

      var plan = await _clientService.rechargeRequest(rechargePlanRequest);
      rechargeMsResponse.Amount = plan.Amount;
      rechargeMsResponse.Number = plan.Number;
      rechargeMsResponse.Status = plan.Status;
      rechargeMsResponse.ResponseMessage = plan.ResposneMessage;
      rechargeMsResponse.MarginPercentage = plan.MarginPercentage;
      rechargeMsResponse.UtransactionID = plan.UtransactionID;
      rechargeMsResponse.TransactionID = plan.TransactionID;
      rechargeMsResponse.MarginAmount = plan.MarginAmount;
      rechargeMsResponse.ErrorCode = plan.ErrorCode.ToString();
      rechargeMsResponse.OperatorID = plan.OperatorID;
      // string result = JsonConvert.SerializeObject(plan);

      // RechargeMsResponse rechargeResponse = JsonConvert.DeserializeObject<RechargeMsResponse>(result);

      return rechargeMsResponse;
    }

    //RechargeStatusBL
    public async Task<RechargeStatusMSResponse> rechargeStatusBL(RechargeStatusMSRequest request)
    {

      _logger.LogInformation("PrepaidBLImpl : rechargeStatus  ");
      RechargeStatusMSResponse rechargeStatusMsResponse = new RechargeStatusMSResponse();
      RechargeStatusRequest rechargeStatusRequest = new RechargeStatusRequest();

      rechargeStatusRequest.utransactionid = request.utransactionid;
      rechargeStatusRequest.gettransid = request.gettransid;
      rechargeStatusRequest.operator_id=request.operator_id;
      rechargeStatusRequest.username = "HR1413";
      rechargeStatusRequest.password = "8368804637";


      var plan = await _clientService.rechargeStatus(rechargeStatusRequest);

      rechargeStatusMsResponse.UtransactionID=plan.UtransactionID;
      rechargeStatusMsResponse.TransactionID = plan.TransactionID;
      rechargeStatusMsResponse.OperatorID=plan.OperatorID;
      rechargeStatusMsResponse.Number = plan.Number;
      rechargeStatusMsResponse.Amount = plan.Amount;
      rechargeStatusMsResponse.Status = plan.Status.ToString();
      rechargeStatusMsResponse.ResposneMessage = plan.ResposneMessage;
      rechargeStatusMsResponse.MarginPercentage = plan.MarginPercentage;
      rechargeStatusMsResponse.MarginAmount=plan.MarginAmount;
      rechargeStatusMsResponse.ErrorCode=plan.ErrorCode;

      return rechargeStatusMsResponse;
    }

    



  }
}
