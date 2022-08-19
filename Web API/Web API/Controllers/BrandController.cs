using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API.Models;

namespace Web_API.Controllers
{
    public class BrandController : ApiController
    {
        static List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId="B001",Name="Haro"},
            new Brand(){BrandId="B002",Name="Electra"},
            new Brand(){BrandId="B003",Name="Heller"},
            new Brand(){BrandId="B004",Name="Trek"}
        };
        public HttpResponseMessage Post([FromUri]Brand brand)
        {
            brands.Add(brand);
            return Request.CreateResponse(HttpStatusCode.Created,brand);
            
        }
    }
}
