using System;
using PrePaidRechargeAPIService.DTO.ClientDTO.response;
using PrePaidRechargeAPIService.DTO.ClientDTO.request;

namespace PrePaidRechargeAPIService.ClientService.Interface
{

public interface IClientService
{
  public Task<FetchPlanData> fetchPlan(FetchPlanRequest request);
}
}