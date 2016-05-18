using AjaxWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxWebApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            Person person = new Person()
            {
                ID = 2,
                Name = "Freddie",
                BirthDate = new DateTime(year: 1977, month: 01, day: 15)
            };
            return View(person);
        }
        public string HitMe()
        {
            return "Pow!!! Punch!!! -";
        }
    }
}