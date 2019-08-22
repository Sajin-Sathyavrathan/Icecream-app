using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using IcecreamParlour.Service.Models;
using IceCreamParlour.Data.Entities;
using IceCreamParlour.Data.Implementation;

namespace IcecreamParlour.Service.Controllers
{
    public class IceCreamController : ApiController
    {

        private UnitOfWork uow = new UnitOfWork();
        [HttpPost]
        [Route("api/GenerateBill")]
        public IHttpActionResult GenerateBill([FromBody]IList<GenerateBillRequest> request)
        {

            IList <GenerateBillResponse> response = new List<GenerateBillResponse>();

            foreach (var req in request)
            {
                Topping topping = uow.GetToppingRepository.GetByID(req.ToppingsId);
                Flavour flavours = uow.GetFlavourRepository.GetByID(req.FlavourId);

                response.Add(new GenerateBillResponse
                {
                    Flavour = flavours.FlName,
                    Topping = topping.Name,
                    Price = req.Scoop * (flavours.FlPrice + topping.Price)

                });
            }
            return Ok(response);

        }
    }
}