using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Models
{
    public class Vehicle
    {
        public int VechicleID { get; set; } // add in economy

        public string Rego { get; set; }

        public  string Made { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }
                
        public int SeatsNumber { get; set; }

        public string Transmission { get; set; }

        public string Fuel { get; set; }

        //public bool GPS { get; set; }

        //public bool SunRoof { get; set; }

        public string Color { get; set; }

        public int DailyRate { get; set; }

        

    }
}