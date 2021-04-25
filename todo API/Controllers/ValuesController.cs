using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

     
        private List<Todo> todos = new List<Todo>();

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            todos.Add(new Todo { id = Guid.NewGuid(), text = "Eat" });
            todos.Add(new Todo { id = Guid.NewGuid(), text = "Sleep" });
            todos.Add(new Todo { id = Guid.NewGuid(), text = "Walk" });
            return Ok(todos);
        }

       
    }

    public class Todo
    {
        public Guid id { get; set; }
        public string text { get; set; }
        public bool completed { get; set; } = false;
    }

}
