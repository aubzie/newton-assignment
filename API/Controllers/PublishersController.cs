using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using API.Models;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PublishersController : ApiController
    {
        private NewtonAssignmentAPIContext db = new NewtonAssignmentAPIContext();

        [Route("api/publishers")]
        [HttpGet]
        public IQueryable<Publisher> GetAll()
        {
            return db.Publishers;
        }

    }
}