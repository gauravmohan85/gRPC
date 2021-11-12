using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace GrpcService
{
    public class CompanyInfoService : CompanyInfo.CompanyInfoBase
    {
        private readonly ILogger<CompanyInfoService> _logger;
        public CompanyInfoService(ILogger<CompanyInfoService> logger)
        {
            _logger = logger;
        }

        public override Task<Employee> GetEmployeeForEmpId(Employee request, ServerCallContext context)
        {
            return Task.FromResult(new Employee
            {
                FirstName = "Michael",
                LastName =  "Scott",
                Location = "Amsterdam",
                Department = "IT",
                SeatNo = "20A"
            }); ;
        }
    }
}
