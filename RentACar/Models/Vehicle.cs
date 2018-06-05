﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    public class Vehicle
    {
        public int VechicleID { get; set; }

        public string Rego { get; set; }

        public  string Make { get; set; }

        public string Model { get; set; }

        public string VehicleClass { get; set; }

        public int SeatsNumber { get; set; }

        public string Transmission { get; set; }

        public string Fuel { get; set; }

        public bool Gps { get; set; }

        public bool SunRoof { get; set; }

        public string Colour { get; set; }

        public int DailyRate { get; set; }




    }
}