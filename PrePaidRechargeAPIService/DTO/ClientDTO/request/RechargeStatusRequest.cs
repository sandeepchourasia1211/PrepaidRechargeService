using System;

namespace PrePaidRechargeAPIService.DTO.ClientDTO.request;

public class RechargeStatusRequest
{

   public string username { get; set; }
   public string password { get; set; }
   public string utransactionid { get; set; }
   public bool  gettransid { get; set; }
   public string operator_id { get; set; }
}
