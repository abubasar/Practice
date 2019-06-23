using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    public class TraineeController : Controller
    {
        private readonly DataContext context;

        public TraineeController(DataContext context)
        {
            this.context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Trainee> Get()
        {
            var trainees = context.Trainees.AsEnumerable();
            List<Trainee> list = trainees.Select(trainee => new Trainee()
            {
                Id = trainee.Id,
                Name =trainee.Name,
                Address = trainee.Address,
                Department = new Department()
                {
                    Id = trainee.Department.Id,
                    Name = trainee.Department.Name,
                    EntryAt = trainee.Department.EntryAt
                },
                DepartmentId = trainee.DepartmentId
            }).ToList();

            return list;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult GetTrainee(string id)
        {
            Trainee trainee = context.Trainees.Include(x => x.Department).Include(x => x.Enrollments).SingleOrDefault(x=>x.Id==id);
            if (trainee == null)
            {
                return NotFound();
            }
            Trainee model = new Trainee()
            {
                Id = trainee.Id,
                Name = trainee.Name,
                Address = trainee.Address,
                Department = new Department()
                {
                    Id = trainee.Department.Id,
                    Name = trainee.Department.Name,
                    EntryAt = trainee.Department.EntryAt
                },
                DepartmentId = trainee.DepartmentId,
                Enrollments = trainee.Enrollments.Select(enrollment => new Enrollment()
                {
                    Id = enrollment.Id,
                    TraineeId = enrollment.TraineeId,
                    CourseId = enrollment.CourseId,
                    Course = new Course()
                    {
                        Id = enrollment.Course.Id,
                        Name = enrollment.Course.Name,
                        Credit = enrollment.Course.Credit
                    }

                }).ToList()
        };

        
         return Ok(model);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
