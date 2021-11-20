using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JotformApp.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class FormController : ControllerBase
   {
      // GET: api/<FormController>
      [HttpGet]
      public IEnumerable<string> Get()
      {
         return new string[] { "value1", "value2" };
      }

      // GET api/<FormController>/5
      [HttpGet("{id}")]
      public string Get(int id)
      {
         return "value";
      }

      // POST api/<FormController>
      [HttpPost]
      public async Task<HttpResponseMessage> Post([FromBody] JObject data)
      {
         var a = Request;
         var b = data;
         return null;
      }

      // PUT api/<FormController>/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody] string value)
      {
      }

      // DELETE api/<FormController>/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
      }
   }
}
