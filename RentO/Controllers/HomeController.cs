using Newtonsoft.Json;
using RentO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ContentResult Index(Places place)
        {
            var places = new List<Places>
            {
                new Places
                {
                    Latitude = 23.2156,
                    Longitude = 72.6369,
                    Title = "Test 1"
                },
                new Places
                {
                    Latitude = 23.241134,
                    Longitude = 72.650182,
                    Title = "Test 2"
                }
            };

            var json = JsonConvert.SerializeObject(places);
            return Content(json, "application/json");
        }

        //Method to get the distance between two points
        //private double Distance(double lat1, double lon1, double lat2, double lon2, char unit)
        //{
        //    //http://www.geodatasource.com/developers/c-sharp
        //    double theta = lon1 - lon2;
        //    double dist = Math.Sin(Deg2Rad(lat1)) * Math.Sin(Deg2Rad(lat2)) + Math.Cos(Deg2Rad(lat1)) * Math.Cos(Deg2Rad(lat2)) * Math.Cos(Deg2Rad(theta));
        //    dist = Math.Acos(dist);
        //    dist = Rad2Deg(dist);
        //    dist = dist * 60 * 1.1515;
        //    if (unit == 'K')
        //    {
        //        dist = dist * 1.609344;
        //    }
        //    else if (unit == 'N')
        //    {
        //        dist = dist * 0.8684;
        //    }
        //    return (dist);
        //}
    }
}