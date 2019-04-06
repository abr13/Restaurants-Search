using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickRestaurants.Models
{
    public class ManageRestaurantViewModel
    {
        public int RestaurantID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string Website { get; set; }

        public string Time { get; set; }

        public string Days { get; set; }
    }
}