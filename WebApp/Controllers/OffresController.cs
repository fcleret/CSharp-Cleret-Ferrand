using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BiblioClass.Entity;
using BLL;
using WebApp.Models.Offres;

namespace WebApp.Controllers
{
    public class OffresController : Controller
    {
        public ActionResult Index(string searchBar)
        {
            return View(OffreViewModel.PopulatesByContain(searchBar));
        }
    }
}