using System;
using System.Text.Json;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcClient;


namespace Grpc.Client
{
    public class CompanyInfoServiceClient
    {
        private string _serverAddress;

        public CompanyInfoServiceClient(string serverAddress)
        {
            _serverAddress = serverAddress;
        }
        private Employee GetEmployeeForEmpId(int empId)
        {
            using var channel = GrpcChannel.ForAddress(_serverAddress);
            var client = new CompanyInfo.CompanyInfoClient(channel);
            var employeeId = new Employee { EmployeeId = empId };

            var result = client.GetEmployeeForEmpId(new Employee());

            return result;
        }

        public string GetEmployeeFromService(int empId)
        {
            var empData =  GetEmployeeForEmpId(empId);
            return JsonSerializer.Serialize(empData);
        }
    }
}
