using AjaxWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxWebApplication.Controllers
{
    public class GrudgeController : Controller
    {
        // GET: Grudge
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _GrudgesForRabit(int id)
        {
            List<Grudge> grudges = ((Rabit)Session["Rabit"]).Grudges;
            return PartialView(grudges);
        }
        public PartialViewResult _Create(int id)
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult _Create(Grudge model)
        {
            //Hämta från db dvs. Session
            ((Rabit)Session["Rabit"]).Grudges.Add(model);
            return RedirectToAction(actionName: "_GrudgesForRabit",
                routeValues: new { id=9});
        }

    }
}