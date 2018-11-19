using Clients.Dto;
using System;

namespace Poviders.Views
{
    public class EmployeeView : Clients.Dto.Employee
    {

        public double AnualSalary { get; set; }

        public Double CalculateAnualSalary()
        {
            if (ContractType == ContractType.Hourly)
                return 120 * HourlySalary * 12;
            else
                return MonthlySalary * 12;
        }
        
    }
}
