
using Microsoft.AspNetCore.Mvc;
using Projecttt.Data;
using Projecttt.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiGrey.Server.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        AddContext _AddContext;

        public StudentController(AddContext appDbContext)
        {
            _AddContext = appDbContext;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("/Pass")]
        public IEnumerable<Admission> GetPassStudent()
        {
            return _AddContext.Admission.ToList();

            //return new string[] { "Student1", "Student2" , type };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post([FromBody] Admission admission)
        {
            try
            {
                _AddContext.Admission.Add(admission);
                _AddContext.SaveChanges();

                return Ok("Message:Save successfuly");
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {


        }
    }
}
