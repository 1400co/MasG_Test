using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMoq;
using Clients.Dto;
using Clients.Employee;
using Moq;
using NUnit.Framework;
using Poviders.Employee;
using Poviders.Views;

namespace Test
{
    [TestFixture]
    public class TestProvider
    {
        private AutoMoqer _automoqer;
        private IEmployeeClient _EmployeeClient;
        private IEmployeeProvider _EmployeeProvider;

        [SetUp]
        public void SetUp()
        {
            _automoqer = new AutoMoqer();

            _automoqer.GetMock<IEmployeeClient>()
                .Setup(p => p.GetEmployees())
                .Returns(new List<Employee>(){ new Employee()
                    {   Name = "Mocked",
                        HourlySalary = 10,
                        MonthlySalary = 100,
                        ContractType = ContractType.Hourly,
                        Id =  1},
                    new Employee()
                    {   Name = "Mocked",
                        HourlySalary = 10,
                        MonthlySalary = 100,
                        ContractType = ContractType.Monthly ,
                        Id = 2}
                });

            _EmployeeProvider = _automoqer.Resolve<EmployeeProvider>();
        }

        [Test]
        public void When_SendTopup_Expect_OperationCompleted()
        {
            var result = _EmployeeProvider.GetAllEmployees();

            Assert.AreEqual(2, result.Count);
        }

    }
}
