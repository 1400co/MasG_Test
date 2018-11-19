using Clients.Request;
using ServiceStack;
using System.Collections.Generic;
using Clients.Dto;

namespace Clients.Employee
{
    public class EmployeeClientMock : BaseClient, IEmployeeClient
    {
        private readonly JsonServiceClient _client;

        public EmployeeClientMock()
        {
            _client = CreateRestClient("http://SomeOtherServer:53385/api/employees");
        }

        public List<Dto.Employee> GetEmployees()
        {

            return new List<Dto.Employee>()
                { new Dto.Employee()
                    {   Name = "Mocked",
                        HourlySalary = 10,
                        MonthlySalary = 100,
                        ContractType = ContractType.Hourly,
                        Id =  1},
                    new Dto.Employee()
                    {   Name = "Mocked",
                        HourlySalary = 10,
                        MonthlySalary = 100,
                        ContractType = ContractType.Monthly ,
                        Id = 2}
                };
        }

        public Dto.Employee GetEmployeeById(int id)
        {

            return new Dto.Employee() { Name = "Mocked", HourlySalary = 10, MonthlySalary = 100, ContractType = ContractType.Hourly };
        }


    }
}
