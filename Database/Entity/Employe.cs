﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass.Entity
{
    public class Employe
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Anciennete { get; set; }

        public string Biographie { get; set; }

        public ICollection<Postulation> Postulations { get; set; }

        public ICollection<Formation> Formations { get; set; }

        public ICollection<Experience> Experiences { get; set; }
    }
}
