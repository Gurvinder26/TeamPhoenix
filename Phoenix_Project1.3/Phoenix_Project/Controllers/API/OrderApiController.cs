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

namespace Phoenix_Project.Controllers.API
{
    public class OrderApiController : ApiController
    {
        private Phoenix_DatabaseEntities1 db = new Phoenix_DatabaseEntities1();

        // GET api/Order

      

        /// <summary>
        /// This method will display the list of orders
        /// </summary>
        /// <returns></returns>

        public IQueryable<Order> GetOrders()
        {
            return db.Orders;
        }

        // GET api/Order/5

        /// <summary>
        /// This method with display the details of specific order
        /// </summary>
        /// <param name="id"> this will be the id of the order</param>
        /// <returns></returns>
        [ResponseType(typeof(Order))]
        public IHttpActionResult GetOrder(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

       /// <summary>
       /// This is to update a new order
       /// </summary>
       /// <param name="id">this will be the id of the order</param>
       /// <param name="order"> this is the order</param>
       /// <returns></returns>
        public IHttpActionResult PutOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.OrderNo)
            {
                return BadRequest();
            }

            db.Entry(order).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST api/Order
        /// <summary>
        /// This is to create a new order
        /// </summary>
        /// <param name="order">this is the order object</param>
        /// <returns></returns>
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = order.OrderNo }, order);
        }

        // DELETE api/Order/5
        /// <summary>
        /// This method is to delete a order using id
        /// </summary>
        /// <param name="id">this is the id of the order</param>
        /// <returns></returns>
        [ResponseType(typeof(Order))]
        public IHttpActionResult DeleteOrder(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            db.SaveChanges();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.OrderNo == id) > 0;
        }
    }
}