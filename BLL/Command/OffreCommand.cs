using BiblioClass;
using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Command
{
    class OffreCommand
    {
        private MonContexte _contexte;

        public OffreCommand()
        {
            _contexte = new MonContexte();
        }

        public void Update(Offre offre)
        {
            var item = _contexte.Offres.Find(offre.Id);
            item.Id = offre.Id;
            item.Date = offre.Date;
            item.Description = offre.Description;
            item.Intitule = offre.Intitule;
            item.Responsable = offre.Responsable;
            item.Salaire = offre.Salaire;
            _contexte.SaveChanges();
        }
    }
}
