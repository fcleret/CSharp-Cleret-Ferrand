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
        /// <param name="searchBar">The text into the search bar</param>
        public ActionResult Index(string searchBar)
        {
            return View(OffreViewModel.PopulatesByContain(searchBar));
        }
    }
}