using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class GenresController : ApiController
    {
        private NewtonAssignmentAPIContext db = new NewtonAssignmentAPIContext();

        [Route("api/genres")]
        [HttpGet]
        public IQueryable<Genre> GetAll()
        {
            return db.Genres;
        }
    }
}
