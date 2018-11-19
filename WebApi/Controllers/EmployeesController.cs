using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Poviders.Employee;
using Poviders.Views;

namespace WebApi.Controllers
{
    [System.Web.Http.RoutePrefix("api/employees")]
    public class EmployeesController : ApiController
    {
        private IEmployeeProvider _employeeProvider;

        public EmployeesController(IEmployeeProvider employeeProvider)
        {
            _employeeProvider = employeeProvider;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("")]
        public List<EmployeeView> Get()
        {
            var employees = _employeeProvider.GetAllEmployees();
            var newList = new List<EmployeeView>();

            foreach (var VARIABLE in employees)
            {
                VARIABLE.AnualSalary = VARIABLE.CalculateAnualSalary();
                newList.Add(VARIABLE);
            }

            return newList;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("{id:int}")]
        public EmployeeView Get(int id)
        {
            var employee = _employeeProvider.GetEmployeeById(id);
            employee.AnualSalary = employee.CalculateAnualSalary();
            return employee;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}