using BiblioClass;
using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Query
{
    public class PostulationQuery
    {
        private MonContexte _contexte;

        public PostulationQuery()
        {
            _contexte = new MonContexte();
        }

        public IQueryable<Postulation> Postulations
        {
            get
            {
                return _contexte.Postulations;
            }
        }
    }
}
