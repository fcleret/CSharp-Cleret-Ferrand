using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Postulations;

namespace WebApp.Controllers
{
    public class PostulationController : Controller
    {
        public ActionResult Index()
        {
            return View(PostulationViewModel.PopulatesById(5));
        }
    }
}