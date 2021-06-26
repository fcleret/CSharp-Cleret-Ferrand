using BiblioClass;
using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Command
{

    public class PostulationCommand
    {
        private MonContexte _contexte;

        public PostulationCommand()
        {
            _contexte = new MonContexte();
        }

        public void Add(Postulation postulation)
        {
            _contexte.Postulations.Add(postulation);
            _contexte.SaveChanges();
        }

        public void Remove(int id)
        {
            _contexte.Postulations.Remove(_contexte.Postulations.Where(e => e.OffreId == id).FirstOrDefault());
            _contexte.SaveChanges();
        }
    }
}
