using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using API.Models;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class VideoGamesController : ApiController
    {
        private NewtonAssignmentAPIContext db = new NewtonAssignmentAPIContext();

        [Route("api/videogames")]
        [HttpGet]
        public IQueryable<VideoGame> GetAll()
        {
            return db.VideoGames;
        }

 
        [Route("api/videogames/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            VideoGame videoGame = await db.VideoGames.FindAsync(id);
            if (videoGame == null)
            {
                return NotFound();
            }

            return Ok(videoGame);
        }

        [Route("api/videogames/{id}")]
        [HttpPut]
        public async Task<IHttpActionResult> Update(int id, VideoGame videoGame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != videoGame.Id)
            {
                return BadRequest();
            }

            db.Entry(videoGame).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideoGameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VideoGameExists(int id)
        {
            return db.VideoGames.Count(e => e.Id == id) > 0;
        }
    }
}