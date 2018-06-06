using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Economy
    {
        public int EconomyID { get; set; }

        public string Rego { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }        
        
        public int SeatsNumber { get; set; }

        public string Fuel { get; set; }

        public string Color { get; set; }
             

                
         

    }
}