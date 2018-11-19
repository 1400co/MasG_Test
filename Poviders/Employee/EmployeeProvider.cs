using Clients.Employee;
using Poviders.Mappers;
using Poviders.Views;
using System.Collections.Generic;
using System.Linq;

namespace Poviders.Employee
{
    public class EmployeeProvider : IEmployeeProvider
    {
        private readonly IEmployeeClient _employeeClient;
        private readonly EmployeeMapper _employeeMapper;

        public EmployeeProvider(IEmployeeClient employeeClient)
        {
            _employeeClient = employeeClient;
            _employeeMapper = new EmployeeMapper();
        }

        public List<EmployeeView> GetAllEmployees()
        {
            var employees = _employeeClient.GetEmployees();

            if (employees is null || !employees.Any()) return new List<EmployeeView>();

            var result = new List<EmployeeView>();
            employees.ForEach(c =>
            {
                result.Add(_employeeMapper.ToView(c, new EmployeeView()));
            });

            return result;
        }

        public EmployeeView GetEmployeeById(int id)
        {
            var employee = _employeeClient.GetEmployeeById(id);

            return employee is null ? null : _employeeMapper.ToView(employee, new EmployeeView());
        }

    }
}
