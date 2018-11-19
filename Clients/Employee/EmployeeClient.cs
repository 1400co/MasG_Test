using Clients.Request;
using ServiceStack;
using System.Collections.Generic;

namespace Clients.Employee
{
    public class EmployeeClient : BaseClient, IEmployeeClient
    {
        private readonly JsonServiceClient _client;

        public EmployeeClient()
        {
            _client = CreateRestClient("http://SomeOtherServer:53385/api/employees");
        }

        public List<Dto.Employee> GetEmployees()
        {
            var result = _client.Get<List<Dto.Employee>>("");

            return result;
        }

        public Dto.Employee GetEmployeeById(int id)
        {
            var result = _client.Get<Dto.Employee>(new EmployeeRequest() { Id = id });

            return result;
        }


    }
}
