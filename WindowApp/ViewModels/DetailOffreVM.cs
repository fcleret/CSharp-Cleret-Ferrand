using BiblioClass.Entity;
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
                OnPropertyChanged("Id");
                OnPropertyChanged("Offres");
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set 
            { 
                _date = value;
                OnPropertyChanged("Date");
                OnPropertyChanged("Offres");
            }
        }

        public string Intitule
        {
            get { return _intitule; }
            set
            {
                _intitule = value;
                OnPropertyChanged("Intitule");
                OnPropertyChanged("Offres");
            }
        }

        public string Responsable
        {
            get { return _responsable; }
            set 
            { 
                _responsable = value;
                OnPropertyChanged("Responsable");
                OnPropertyChanged("Offres");
            }
        }

        public double Salaire
        {
            get { return _salaire; }
            set 
            { 
                _salaire = value;
                OnPropertyChanged("Salaire");
                OnPropertyChanged("Offres");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            { 
                _description = value;
                OnPropertyChanged("Description");
                OnPropertyChanged("Offres");
            }
        }

        #endregion
    }
}