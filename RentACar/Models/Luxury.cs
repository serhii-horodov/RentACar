using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
	public class Luxury
	{
        public string FamilyID { get; set; }

        public string RegNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public int SeatsNumber { get; set; }

        public string Fuel { get; set; }

        public string Color { get; set; }
        public bool GPS { get; set; }

        public bool SunRoof { get; set; }

        public int DailyRent { get; set; }


	}
}