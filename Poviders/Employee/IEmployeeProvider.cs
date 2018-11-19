using System.Collections.Generic;
using Poviders.Views;

namespace Poviders.Employee
{
    public interface IEmployeeProvider
    {
        List<EmployeeView> GetAllEmployees();
        EmployeeView GetEmployeeById(int id);
    }
}