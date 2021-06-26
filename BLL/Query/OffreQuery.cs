using BiblioClass;
using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Query
{
    public class OffreQuery
    {
        private MonContexte _contexte;

        public OffreQuery()
        {
            _contexte = new MonContexte();
        }

        public IQueryable<Offre> Offres
        {
            get
            {
                return _contexte.Offres;
            }
        }
    }
}
