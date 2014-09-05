using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Phoenix_Project;

namespace Phoenix_Project.Controllers
{
    public class UserController : ApiController
    {
        private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();

        // GET api/User
        /// <summary>
        /// This method will display the list of all the users
        /// </summary>
        /// <returns></returns>
        public IQueryable<User> GetUsers()
        {
            return db.Users;
        }

        // GET api/User/5
        /// <summary>
        /// This method with display the details of selected user
        /// </summary>
        /// <param name="id"> this is the id of the user</param>
        /// <returns></returns>
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT api/User/5
        /// <summary>
        /// This is to update the information of existing user
        /// </summary>
        /// <param name="id">id of the user</param>
        /// <param name="user">this is the user</param>
        /// <returns></returns>
        public IHttpActionResult PutUser(int id, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.UserId)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST api/User
        /// <summary>
        /// This is to add a new user
        /// </summary>
        /// <param name="user">this is the new user </param>
        /// <returns></returns>
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users.Add(user);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user.UserId }, user);
        }

        // DELETE api/User/5

        /// <summary>
        /// this is to delete the User 
        /// </summary>
        /// <param name="id">Id of the user </param>
        /// <returns></returns>
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            db.SaveChanges();

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserExists(int id)
        {
            return db.Users.Count(e => e.UserId == id) > 0;
        }
    }
}