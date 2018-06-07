using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Models
{
    public class VehicleType
    {
        public IEnumerable<SelectListItem> Type { get; set; }

        List<SelectListItem> GetAllTypes()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem { Text = "Economy", Value ="1" },
                new SelectListItem { Text = "Family", Value="2" },
                new SelectListItem { Text = "Luxury", Value="3" },
                new SelectListItem { Text= "Commercial", Value="4" }
            };
        }
    }
}