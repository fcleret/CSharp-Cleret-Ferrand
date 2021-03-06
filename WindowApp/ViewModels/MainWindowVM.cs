using BiblioClass.Entity;
using BLL;
using Cours2_ExempleMVVM.Mock;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WindowApp.ViewModels;
using WindowApp.ViewModels.Common;

namespace WindowApp
{
    public class MainWindowVM : BaseViewModel
    {
        #region Variables

        private DetailOffreVM _selectedOffre;
        private ObservableCollection<DetailOffreVM> _offres = null;
        private string _textSearch;
        private RelayCommand _addOffre;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public MainWindowVM()
        {
            // On appelle le mock pour initialiser une liste de produits
            Refresh();
        }

        private void Refresh()
        {
            _offres = new ObservableCollection<DetailOffreVM>();
            foreach (Offre o in Manager.Instance.GetAllOffres())
            {
                _offres.Add(new DetailOffreVM(o));
            }

            if (_offres != null && _offres.Count > 0)
                _selectedOffre = _offres.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailOffreVM> Offres
        {
            get { return _offres; }
            set
            {
                _offres = value;
                OnPropertyChanged("Offres");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public DetailOffreVM SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }

        public string TextSearch
        {
            get { return _textSearch; }
            set
            {
                _textSearch = value;
                OnPropertyChanged("TextSearch");

                Refresh();

                ObservableCollection<DetailOffreVM> obsList = new ObservableCollection<DetailOffreVM>();
                _offres.Where(o => o.Intitule.ToLower().Contains(value.ToLower())).ToList().ForEach(o => obsList.Add(o));
                Offres = obsList;
            }
        }

        #endregion

        #region Command

        public ICommand AddOffre
        {
            get
            {
                if (_addOffre == null)
                {
                    _addOffre = new RelayCommand(() => AjouterOffre());
                }
                return _addOffre;
            }
        }

        public void AjouterOffre()
        {
            Manager.Instance.AddOffre(new Offre
            {
                Date = DateTime.Now,
                Description = "",
                Intitule = "(empty)",
                Responsable = "",
                Salaire = 0,
                StatutId = 1
            });

            Refresh();
            OnPropertyChanged("Offres");
        }

        #endregion
    }
}
