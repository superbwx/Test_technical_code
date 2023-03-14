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
            char[] idNa = id.ToString().ToCharArray();
            List<string> segitiga = new List<string>();

            for (int i = 0; i < idNa.Length; i++) 
            {
                var number="";
                for (int j = 0; j < i+1; j++) 
                {
                    number+=idNa[i];
                }
                segitiga.Add(number);
            }

            return new OkObjectResult(segitiga);
        }

        // GET api/<MechanicNumber>/5
        [HttpGet("/ganjil/{id}")]
        public IActionResult Ganjil(int id)
        {
            List<int> ganjil = new List<int>();

            for (int i = 0; i < id+1; i++) 
            {
                if(i%2==1){ganjil.Add(i);}
            }
            return new OkObjectResult(ganjil);
        }

        // GET api/<MechanicNumber>/5
        [HttpGet("/prima/{id}")]
        public IActionResult Prima(int id)
        {
            List<int> prima = new List<int>();
            for (int i = 1; i < id+1; i++) 
            {
                var primakah=0;
                for (int j = 0; j < i+1; j++) 
                {
                    if(i%(j+1)==0){primakah++;}
                }
                if(primakah==2)prima.Add(i);
            }

            return new OkObjectResult(prima);
        }
    }
}
