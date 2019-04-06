using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickRestaurants.AppCode;
using QuickRestaurants.AppCode.DAL;
using QuickRestaurants.Models;

namespace QuickRestaurants.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            using (var dbContext = new QuickRestaurantsEntities())
            {
                var model = dbContext.Restaurants.ToList().Select((c, index) => new RestaurantViewModel
                {
                    RestaurantID = c.RestaurantID,
                    Name = c.Name,
                    Address = c.Address,
                    Mobile = c.Mobile,
                    Website = c.Website,
                    Time = c.Time,
                    Days = c.Days

                }).ToList();

                return View(model);
            }

        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(AddRestaurantViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var dbContext = new QuickRestaurantsEntities())
                {
                    var Restaurant = new Restaurant
                    {
                        RestaurantID = model.RestaurantID,
                        Name = model.Name,
                        Address = model.Address,
                        Mobile = model.Mobile,
                        Website = model.Website,
                        Time = model.Time,
                        Days = model.Days,
                    };
                    dbContext.Restaurants.Add(Restaurant);

                    try
                    {
                        dbContext.SaveChanges();
                        ViewBag.Message = "Successful";
                    }
                    catch (Exception e)
                    {
                        ViewBag.Message = "Failed";
                    }
                }
            }
            return View();
        }

        public ActionResult Manage(int RestaurantID)
        {
            using (var dbContext = new QuickRestaurantsEntities())
            {
                var Restaurant = dbContext.Restaurants.Find(RestaurantID);

                if (Restaurant == null)
                {
                    return RedirectToAction("Index");
                }
                return View(new ManageRestaurantViewModel
                {
                    RestaurantID = Restaurant.RestaurantID,
                    Name = Restaurant.Name,
                    Address = Restaurant.Address,
                    Mobile = Restaurant.Mobile,
                    Website = Restaurant.Website,
                    Time = Restaurant.Time,
                    Days = Restaurant.Days
                });

            }
        }

        [HttpPost]
        public ActionResult Manage(ManageRestaurantViewModel model)
        {
            using (var dbContext = new QuickRestaurantsEntities())
            {
                var Restaurant = dbContext.Restaurants.Find(model.RestaurantID);

                Restaurant.Name = model.Name;
                Restaurant.Address = model.Address;
                Restaurant.Mobile = model.Mobile;
                Restaurant.Website = model.Website;
                Restaurant.Time = model.Time;
                Restaurant.Days = model.Days;

                dbContext.SaveChanges();
                try
                {
                    dbContext.SaveChanges();
                    ViewBag.Message = "Updated";
                }
                catch (Exception e)
                {
                    ViewBag.Message = "Failed to update";
                }

                return View(model);
            }
        }
    }
}