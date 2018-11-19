using System.Collections.Generic;

namespace Clients.Employee
{
    public interface IEmployeeClient
    {
        Dto.Employee GetEmployeeById(int id);
        List<Dto.Employee> GetEmployees();
    }
}