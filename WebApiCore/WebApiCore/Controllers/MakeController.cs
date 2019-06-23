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
    public class MakeController : ControllerBase
    {
        public DataContext Context { get; }

        public MakeController(DataContext context)
        {
            Context = context;
        }



        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Make> Get()
        {
         var list=   Context.Makes.Include(x=>x.Models).AsEnumerable();
         var makes = list.Select(x => new Make()
         {
             Id = x.Id,
             Name = x.Name,
             Models = x.Models.Select(model => new Model()
             {
                 Id = model.Id,
                 Name = model.Name
             }).ToList()
         });
         return makes;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
