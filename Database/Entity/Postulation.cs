using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass.Entity
{
    public class Postulation
    {
        public string Date { get; set; }

        public string Statut { get; set; }

        public Offre Offre { get; set; }

        public Employe Employe { get; set; }

        public int OffreId { get; set; }

        public int EmployeId { get; set; }

    }
}
