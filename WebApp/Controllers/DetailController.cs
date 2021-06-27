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
        private Manager _manager;

        public DetailController()
        {
            _manager = Manager.Instance;
        }

        /// <param name="id">The offer's id</param>
        public ActionResult Index(int id)
        {
            return View(OffreViewModel.PopulateById(id));
        }

        /// <summary>
        /// Remove or add a postulation before to return the view
        /// </summary>
        /// <param name="id">The offer's id</param>
        public ActionResult RegisterPostulation(int id)
        {
            if (OffreViewModel.PopulateById(id).HasPostuled)
            {
                _manager.RemovePostulation(id);
            }
            else
            {
                _manager.InsertPostulation(id);
            }
            return View(OffreViewModel.PopulateById(id));
        }
    }
}