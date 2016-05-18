using AjaxWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxWebApplication.Controllers
{
    public class RabitController : Controller
    {
        // GET: Rabit
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            Rabit rabit = new Rabit()
            {
                ID = 666,
                BirthDate = new DateTime(year: 2006, month: 06, day: 06),
                AngerLevel = 6,
                Name = "The Devil",
                Grudges = new List<Grudge>()
                {
                    new Grudge() { ID= 7, TargetName="Innocent rabits", Reason="ADHD" },
                    new Grudge() { ID= 8, TargetName="People", Reason="Snitch" },
                }              
            };
            //spara till DB... osv... vi gör fultrick... Session....
            Session["Rabit"] = rabit;
            return View(rabit);
        }
    }
}