using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using fromUpi.Models;

namespace fromUpi.Controllers
{
    public class studentController : ApiController
    {
       /* public string Get([FromUri]student std)
        {
             return ($"my id is{std.Id} and my name is{std.Name}");
            
        }*/
        public string Get([FromBody] student std)
        {
            return ($"my id is{std.Id} and my name is{std.Name}");
        }
        public IHttpActionResult Post([FromUri] student std)
        {
            //return ($"my name is {std.Name} and my id is {std.Id}");
            if(std==null)
            {
                return NotFound();
            }
            return Ok(std);
        }
        /*public string Post([FromBody] string Name)
        {
            return ($"My name is {Name}");
        }*/
      /* public string Post([FromBody] string Name,[FromUri]student std)
        {
            return ($"frombody name is {Name} and fromuri name is {std.Name}");
        }*/
    }
}
