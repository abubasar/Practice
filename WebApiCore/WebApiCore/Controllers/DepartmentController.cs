using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Models;
using System.Net;
using System.Net.Mail;

namespace WebApiCore.Controllers
{
    [Route("api/department")]
    public class DepartmentController:ControllerBase
    {
        private readonly DataContext context;

        public DepartmentController(DataContext context)
        {
            this.context = context;
        }

        public List<Department> GetDepartments()
        {
            var departments = context.Departments.AsEnumerable();
            var list = departments.Select(x => new Department() {Id = x.Id, Name = x.Name, EntryAt = x.EntryAt}).ToList();
            return list;
        }
        [HttpGet("{id}")]
        public Department GetDepartment(string id)
        {
            var department = context.Departments.Find(id);
            return department;
        }
        [HttpPost]

        public IActionResult AddDepartments([FromBody] Department department)
        {
            department.Id = Guid.NewGuid().ToString();
            department.EntryAt=DateTime.Now;
            context.Departments.Add(department);
            context.SaveChanges();
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress("ariful.sec@gmail.com", "Arif"));
                message.From = new MailAddress("ariful.sec@gmail.com", "Ariful");
              //  message.CC.Add(new MailAddress("cc@email.com", "CC Name"));
               // message.Bcc.Add(new MailAddress("bcc@email.com", "BCC Name"));
                message.Subject = department.Id.ToString();
                message.Body = department.Name;
                message.IsBodyHtml = true;

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("ariful.sec@gmail.com", "Abubasar12345");
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }
            return Ok();
        }
    }
}
