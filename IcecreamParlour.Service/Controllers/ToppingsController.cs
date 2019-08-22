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
using IceCreamParlour.Data.Entities;
using IceCreamParlour.Data.Implementation;

namespace IcecreamParlour.Service.Controllers
{
    
    public class ToppingsController : ApiController
    {
       // private IceCreamDbContext db = new IceCreamDbContext();

        private UnitOfWork unitOfWork=new UnitOfWork();

        // GET: api/Toppings
        public IQueryable<Topping> GetToppings()
        {
            return unitOfWork.GetToppingRepository.Get().AsQueryable();
        }

        // GET: api/Toppings/5
        [ResponseType(typeof(Topping))]
        public IHttpActionResult GetTopping(int id)
        {
            Topping topping = unitOfWork.GetToppingRepository.GetByID(id);
            if (topping == null)
            {
                return NotFound();
            }

            return Ok(topping);
        }

        // PUT: api/Toppings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTopping(int id, Topping topping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != topping.Id)
            {
                return BadRequest();
            }

            unitOfWork.GetToppingRepository.Attach(topping);
            unitOfWork.Save();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Toppings
        [ResponseType(typeof(Topping))]
        public IHttpActionResult PostTopping(Topping topping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitOfWork.GetToppingRepository.Insert(topping);
            unitOfWork.Save();
            return CreatedAtRoute("DefaultApi", new { id = topping.Id }, topping);
        }

        // DELETE: api/Toppings/5
        [ResponseType(typeof(Topping))]
        public IHttpActionResult DeleteTopping(int id)
        {
            Topping topping = unitOfWork.GetToppingRepository.GetByID(id);
            if (topping == null)
            {
                return NotFound();
            }
            unitOfWork.GetToppingRepository.Delete(topping);
         

            return Ok(topping);
        }

      
    }
}