using ServiceStack;

namespace Clients.Request
{
    [Route("/api/employee")]
   public class EmployeeRequest
    {
        public int Id { get; set; }
    }
}
