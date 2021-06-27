using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.Offres
{
    public class OffreViewModel
    {
        public int Id { get; set; }
        public string Intitule { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public double Salaire { get; set; }
        public string Responsable { get; set; }
        public bool HasPostuled { get; set; }

        /// <summary>
        /// Transfer entity from model into a custom entity if "Intitule" contains the search-bar's text
        /// </summary>
        /// <param name="searchBar">The search-bar's text</param>
        /// <returns>List of custom entities (this)</returns>
        public static List<OffreViewModel> PopulatesByContain(string searchBar)
        {
            List<Offre> offres = Manager.Instance.GetOffresByContain((searchBar != null) ? searchBar : "");
            List<OffreViewModel> offresVm = new List<OffreViewModel>();
            foreach (var offre in offres)
            {
                offresVm.Add(new OffreViewModel { Id = offre.Id, Intitule = offre.Intitule, Date = offre.Date });
            }

            return offresVm;
        }

        /// <summary>
        /// Transfer entity from model into a custom entity
        /// </summary>
        /// <param name="offreId">The offer's id</param>
        /// <returns>The custom entity (this)</returns>
        public static OffreViewModel PopulateById(int offreId)
        {
            bool hasPostuled = Manager.Instance.GetPostulationByOffreId(offreId) != null;

            Offre offre = Manager.Instance.GetOffre(offreId);
            OffreViewModel offreVm = new OffreViewModel
            {
                Id = offre.Id,
                Intitule = offre.Intitule,
                Description = offre.Description,
                Date = offre.Date,
                Salaire = offre.Salaire,
                Responsable = offre.Responsable,
                HasPostuled = hasPostuled
            };

            return offreVm;
        }
    }
}