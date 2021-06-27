using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WindowApp.ViewModels.Common;

namespace WindowApp.ViewModels
{
    public class DetailOffreVM : BaseViewModel
    {
        #region Variables

        private int _id;
        private DateTime _date;
        private string _intitule;
        private string _responsable;
        private double _salaire;
        private string _description;

        #endregion

        #region Constructeurs

        public DetailOffreVM(Offre o)
        {
            _id = o.Id;
            _date = o.Date;
            _description = o.Description;
            _intitule = o.Intitule;
            _responsable = o.Responsable;
            _salaire = o.Salaire;
        }

        #endregion

        #region Data Bindings

        public int Id
        {
            get { return _id; }
            set 
            { 
                _id = value;
                CallManager("Id");
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set 
            { 
                _date = value;
                CallManager("Date");
            }
        }

        public string Intitule
        {
            get { return _intitule; }
            set
            {
                _intitule = value;
                CallManager("Intitule");
            }
        }

        public string Responsable
        {
            get { return _responsable; }
            set 
            { 
                _responsable = value;
                CallManager("Responsable");
            }
        }

        public double Salaire
        {
            get { return _salaire; }
            set 
            { 
                _salaire = value;
                CallManager("Salaire");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            { 
                _description = value;
                CallManager("Description");
            }
        }

        private void CallManager(String name)
        {
            OnPropertyChanged(name);
            OnPropertyChanged("Offres");

            var offre = new Offre
            {
                Id = _id,
                Date = _date,
                Description = _description,
                Intitule = _intitule,
                Postulations = null,
                Statut = null,
                Responsable = _responsable,
                Salaire = _salaire
            };
            Manager.Instance.UpdateOffre(offre);
        }

        #endregion
    }
}