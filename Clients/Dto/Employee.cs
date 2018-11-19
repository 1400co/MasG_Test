namespace Clients.Dto
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ContractType ContractType { get; set; }

        public double HourlySalary { get; set; }

        public double MonthlySalary { get; set; }
    }

    public enum ContractType
    {
        Monthly ,
        Hourly
    }

}
