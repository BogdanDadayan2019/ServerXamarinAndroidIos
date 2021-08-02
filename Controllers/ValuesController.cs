using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // 


        //// POST: api/Values
        //[HttpPost]
        //public string Post([FromBody] string value)
        //{
        //    return value + " hello";
        //}

        // POST: api/values
        [HttpPost]
        public string Hello(string a)
        {

            StreamReader reader = new StreamReader(Request.Body);
            string text = reader.ReadToEnd();
            Console.WriteLine(Request.ContentType);
            return "KK";
    
        }


        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
