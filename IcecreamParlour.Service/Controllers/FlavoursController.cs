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
    
    public class FlavoursController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/Flavours
        public IQueryable<Flavour> GetFlavours()
        {

            return unitOfWork.GetFlavourRepository.Get().AsQueryable();
        }

        // GET: api/Flavours/5
        [ResponseType(typeof(Flavour))]
        public IHttpActionResult GetFlavour(int id)
        {
            Flavour flavour = unitOfWork.GetFlavourRepository.GetByID(id);
            if (flavour == null)
            {
                return NotFound();
            }

            return Ok(flavour);
        }

        // PUT: api/Flavours/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFlavour(int id, Flavour flavour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != flavour.FlId)
            {
                return BadRequest();
            }

            unitOfWork.GetFlavourRepository.Attach(flavour);
            unitOfWork.Save();



            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Flavours
        [ResponseType(typeof(Flavour))]
        public IHttpActionResult PostFlavour(Flavour flavour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitOfWork.GetFlavourRepository.Insert(flavour);
            unitOfWork.Save();

            return CreatedAtRoute("DefaultApi", new { id = flavour.FlId }, flavour);
        }

        // DELETE: api/Flavours/5
        [ResponseType(typeof(Flavour))]
        public IHttpActionResult DeleteFlavour(int id)
        {
            Flavour flavour = unitOfWork.GetFlavourRepository.GetByID(id);
            if (flavour == null)
            {
                return NotFound();
            }

            unitOfWork.GetFlavourRepository.Delete(flavour);
        

            return Ok(flavour);
        }

     
    }
}