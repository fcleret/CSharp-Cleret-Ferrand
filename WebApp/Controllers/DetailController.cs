using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Offres;

namespace WebApp.Controllers
{
    public class DetailController : Controller
    {
        private Manager manager;

        public DetailController()
        {
            manager = Manager.Instance;
        }

        public ActionResult Index(int id)
        {
            return View(OffreViewModel.PopulateById(id));
        }

        public ActionResult RegisterPostulation(int id)
        {
            if (OffreViewModel.PopulateById(id).HasPostuled)
            {
                manager.RemovePostulation(id);
            }
            else
            {
                manager.InsertPostulation(id);
            }
            return View(OffreViewModel.PopulateById(id));
        }
    }
}