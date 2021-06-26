using BiblioClass;
using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Query
{
    public class EmployeQuery
    {
        private MonContexte _contexte;

        public EmployeQuery()
        {
            _contexte = new MonContexte();
        }

        public IQueryable<Employe> Employes
        {
            get
            {
                return _contexte.Employes;
            }
        }
    }
}
