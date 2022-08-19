using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentService.Models;

namespace StudentService.Controllers
{
    public class StudentsController : ApiController
    {
        /* public IEnumerable<Student> Get()
         {
             using(StudentDBContext dbContext=new StudentDBContext())
             {
                 return dbContext.Students.ToList();

             }
         }
         public Student Get(int id)
         {
             using(StudentDBContext dbContext=new StudentDBContext())
             {
                 return dbContext.Students.FirstOrDefault(s => s.ID == id);
             }
         }*/
        public HttpResponseMessage Get()
        {
            using (StudentDBContext dbContext = new StudentDBContext())
            {
                return Request.CreateResponse(HttpStatusCode.OK, dbContext.Students.ToList());

            }
        }
        public HttpResponseMessage Get(int id)
        {
            using (StudentDBContext dbContext = new StudentDBContext())
            {
                var entity = dbContext.Students.FirstOrDefault(x => x.ID == id);
                if(entity!=null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                return Request.CreateResponse(HttpStatusCode.NotFound, $"Student with Id {id} not found");
            }
        }
    }
}
