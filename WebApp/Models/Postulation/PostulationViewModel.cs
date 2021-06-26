using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Employes;
using WebApp.Models.Offres;

namespace WebApp.Models.Postulations
{
    public class PostulationViewModel
    {
        public string Date { get; set; }
        public string Statut { get; set; }
        public OffreViewModel Offre { get; set; }
        public EmployeViewModel Employe { get; set; }

        public static List<PostulationViewModel> PopulatesById(int employeId)
        {
            List<Postulation> postulations = Manager.Instance.GetPostulationByEmployeId(employeId);
            List<PostulationViewModel> postulationsVm = new List<PostulationViewModel>();
            foreach (var postulation in postulations)
            {
                postulationsVm.Add(new PostulationViewModel
                {
                    Date = postulation.Date,
                    Statut = postulation.Statut,
                    Offre = OffreViewModel.PopulateById(postulation.OffreId),
                    Employe = EmployeViewModel.PopulateById(postulation.EmployeId)
                });
            }

            return postulationsVm;
        }
    }
}