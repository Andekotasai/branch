using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookService.Models;

namespace BookService.Controllers
{
    public class BooksController : ApiController
    {
        public HttpResponseMessage Get()
        {
            try
            {
                using (BooksDbContext context = new BooksDbContext())
                {
                    var data = context.Books.ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Post([FromBody] Book book)
        {
            try
            {
                using (BooksDbContext context = new BooksDbContext())
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
