using Microsoft.AspNetCore.Mvc;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/academy")]
    public class AcademyController : ControllerBase
    {
        
        [HttpGet]
        public Employee Get()
        {
            return new Employee(){Id = 1,Name = "arif"};
            
        }
        [HttpPost]
        public Employee Post([FromBody] Employee employee)
        {
            employee.Name = "Welcome" + employee.Name;
            return employee;
        }
    }
}