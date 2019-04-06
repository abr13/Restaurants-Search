using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickRestaurants.AppCode;
using QuickRestaurants.AppCode.DAL;
using QuickRestaurants.Models;
using System.ComponentModel.DataAnnotations;

namespace QuickRestaurants.Models
{
    public class AddRestaurantViewModel
    {
        public int RestaurantID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address can't be empty!")]
        [StringLength(250)]
        public string Address { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string Days { get; set; }
    }
}