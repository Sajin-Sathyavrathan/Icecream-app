using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IcecreamParlour.Service.Models
{
    public class GenerateBillRequest
    {
        public int FlavourId { get; set; }

        public int ToppingsId { get; set; }

        public int Scoop { get; set; }
    }

    public class GenerateBillResponse
    {
        public string Flavour { get; set; }

        public string Topping { get; set; }

        public decimal Price { get; set; }

    
    }
}