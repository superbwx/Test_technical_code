using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMechanical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicNumber : ControllerBase
    {
        // GET: api/<MechanicNumber>
        [HttpGet("/segitiga/{id}")]
        public IActionResult Segitiga(int id)
        {
            List<int> segitiga = split(id);
            return new OkObjectResult(segitiga);
        }

        // GET api/<MechanicNumber>/5
        [HttpGet("/ganjil/{id}")]
        public IActionResult Ganjil(int id)
        {
            List<int> ganjil = new List<int>();

            for (int i = 0; i < id; i++) 
            {
                if(i%2==1){ganjil.Add(i);}
            }
            return new OkObjectResult(ganjil);
        }

        // GET api/<MechanicNumber>/5
        [HttpGet("/prima/{id}")]
        public IActionResult Prima(int id)
        {
            return new OkObjectResult(id);
        }
    }
}
