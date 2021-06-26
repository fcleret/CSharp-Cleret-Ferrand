using BiblioClass;
using BiblioClass.Entity;
using BLL.Command;
using BLL.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Manager
    {
        private static Manager _instance;

        private Manager() {}

        public static Manager Instance
        {
            get {
                if (_instance == null) { _instance = new Manager(); }
                return _instance;
            }
        }

        public List<Postulation> GetPostulationByEmployeId(int id)
        {
            return new PostulationQuery().Postulations.Where(e => e.EmployeId == id).ToList();
        }

        public Postulation GetPostulationByOffreId(int id)
        {
            return new PostulationQuery().Postulations.Where(e => e.OffreId == id).FirstOrDefault();
        }

        public void InsertPostulation(int offreId)
        {
            new PostulationCommand().Add(new Postulation {
                Date = DateTime.Now.ToString(),
                Statut = "En cours",
                OffreId = offreId,
                EmployeId = 5
            });
        }

        public void RemovePostulation(int offreId)
        {
            new PostulationCommand().Remove(offreId);
        }

        public List<Offre> GetOffresByContain(string searchQuery)
        {
            return new OffreQuery().Offres.Where(e => e.Intitule.Contains(searchQuery)).ToList();
        }

        public Offre getOffre(int id)
        {
            return new OffreQuery().Offres.Where(e => e.Id == id).FirstOrDefault();
        }

        public Employe getEmploye(int id)
        {
            return new EmployeQuery().Employes.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Offre> GetAllOffres()
        {
            return new OffreQuery().Offres.ToList();
        }

        public void AddOffre(Offre o)
        {
            MonContexte _contexte = new MonContexte();
            _contexte.Offres.Add(o);
            _contexte.SaveChanges();
        }

        public void AddStatut(Statut s)
        {
            MonContexte _contexte = new MonContexte();
            _contexte.Statuts.Add(s);
            _contexte.SaveChanges();
        }
    }
}
