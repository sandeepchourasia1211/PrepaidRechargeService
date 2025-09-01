using System;

namespace PrePaidRechargeAPIService.DTO.MicroService.Response;

public class RechargeStatusMSResponse
{
   public string TransactionID { get; set; }
   public string UtransactionID { get; set; }
   public string OperatorID { get; set; }
   public string Number { get; set; }
   public string Amount { get; set; }
   public string Status { get; set; }
   public string ResposneMessage { get; set; }
   public string MarginPercentage { get; set; }
   public string MarginAmount { get; set; }
   public Int32 ErrorCode { get; set; }

}
