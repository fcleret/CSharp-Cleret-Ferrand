using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.Employes
{
    public class EmployeViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        /// <summary>
        /// Transfer entity from model into a custom entity
        /// </summary>
        /// <param name="employeId">The employe's id</param>
        /// <returns>The custom entity (this)</returns>
        public static EmployeViewModel PopulateById(int employeId)
        {
            Employe employe = Manager.Instance.GetEmploye(employeId);
            EmployeViewModel employeVm = new EmployeViewModel
            {
                Id = employe.Id,
                Nom = employe.Nom,
                Prenom = employe.Prenom
            };

            return employeVm;
        }
    }
}