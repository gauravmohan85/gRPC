using Grpc.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAggegator.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataAggregatorController : ControllerBase
    {
        private readonly ILogger<DataAggregatorController> _logger;

        public DataAggregatorController(ILogger<DataAggregatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var companyInfoServiceClient = new CompanyInfoServiceClient("https://localhost:5001");
            var result = companyInfoServiceClient.GetEmployeeFromService(101);

            return Ok(result);
        }
    }
}
