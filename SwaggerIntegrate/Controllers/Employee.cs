using Microsoft.AspNetCore.Mvc;
using SwaggerIntegrate.Models;

namespace SwaggerIntegrate.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<Employee> Get()
        {
            return GetEmployeesDeatils();
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        public Employee Get(int id)
        {
            return GetEmployeesDeatils().Find(e => e.Id == id);
        }

        [HttpPost]
        [Produces("application/json")]
        public Employee Post([FromBody] Employee employee)
        {
            // Write logic to insert employee data
            return new Employee()
            {
                Id = 4,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                EmailId = employee.EmailId
            };
        }

        private List<Employee> GetEmployeesDeatils()
        {
            return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "Test",
                LastName = "Name",
                EmailId ="Test.Name@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Test",
                LastName = "Name1",
                EmailId ="Test.Name1@gmail.com"
            }
        };
        }
    }
}
