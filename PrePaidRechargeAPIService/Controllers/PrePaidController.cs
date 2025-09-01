using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PrePaidRechargeAPIService.DTO.MicroService.Request;
using PrePaidRechargeAPIService.PrePaidBussinessLogic.Interface;
using PrePaidRechargeAPIService.DTO.MicroService.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrePaidRechargeAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrePaidController : ControllerBase
    {
        private readonly ILogger<PrePaidController> _logger;
        private readonly IPrepaidBL _prepaidBL;

        public PrePaidController(ILogger<PrePaidController> logger,IPrepaidBL prepaidBL)
        {
            _logger = logger;
            _prepaidBL = prepaidBL;
        }

        [HttpPost("FetchPlanAsync")]
        public async Task<RechargePlanData> FetchPlanAsync(FetchPlanMSRequest request)
        {
            _logger.LogInformation($"FetchPlanAsync Log Information Started {JsonConvert.SerializeObject(request)}");
           
            var resp=await _prepaidBL.fetchPlanBL(request);
              _logger.LogInformation($"FetchPlanAsync Log Information Running {JsonConvert.SerializeObject(resp)}");
            
            // await Task.Delay();
            return resp;
                
        }

        //Recharge Async
        [HttpPost("RechargePlanAsync")]
        public async Task<RechargeMsResponse> RechargePlanAsync(RechargeMSRequest request)
        {
            _logger.LogInformation($"RechargePlanAsync Log Information Started {JsonConvert.SerializeObject(request)}");

            var resp = await _prepaidBL.rechargeBL(request);
            _logger.LogInformation($"RechargePlanAsync Log Information Running {JsonConvert.SerializeObject(resp)}");

            // await Task.Delay();
            return resp;


        }

        //RechargeStatusAsuync
         [HttpPost("RechargeStatusAsync")]
        public async Task<RechargeStatusMSResponse> RechargeStatusMSAsync(RechargeStatusMSRequest request)
        {
            _logger.LogInformation($"RechargeStatusAsync Log Information Started {JsonConvert.SerializeObject(request)}");

            var resp = await _prepaidBL.rechargeStatusBL(request);
            _logger.LogInformation($"RechargeStatusAsync Log Information Running {JsonConvert.SerializeObject(resp)}");

            // await Task.Delay();
            return resp;
        }
        
        [HttpGet("serializedeserialize")] 
        public async Task<IActionResult> serializeAndDeserializeAsync()
        {
            FetchPlanMSRequest obj= new FetchPlanMSRequest();
            var lstobj = new List<FetchPlanMSRequest>();
            //string jsonstring = JsonConvert.SerializeObject(obj);
            string jsonstring = JsonConvert.SerializeObject(lstobj);
            await Task.Delay(50);
            return Ok(jsonstring);
        }
    }
}
