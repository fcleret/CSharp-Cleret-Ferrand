﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass.Entity
{
    public class Formation
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        public DateTime Date { get; set; }

        public Employe Employe { get; set; }

        public int EmployeId { get; set; }

    }
}
