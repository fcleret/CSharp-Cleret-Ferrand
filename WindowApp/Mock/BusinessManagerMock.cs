using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowApp.Mock;

namespace Cours2_ExempleMVVM.Mock
{
    /// <summary>
    /// Business MOCK
    /// </summary>
    public class BusinessManagerMock
    {
        private static BusinessManagerMock _businessManager = null;

        /// <summary>
        /// Constructeur
        /// </summary>
        private BusinessManagerMock()
        {
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessManagerMock Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManagerMock();
                return _businessManager;
            }
        }

        /// <summary>
        /// Méthode pour simuler un appel au contexte pour renvoyer une liste de produits
        /// </summary>
        /// <returns></returns>
        public List<Offre> GetAllProduit()
        {
            List<Offre> produits = new List<Offre>();
            produits.Add(new Offre { Date = "02-06-2020", Intitule = "Technicien de surface (H/F)" });
            produits.Add(new Offre { Date = "05-07-2020", Intitule = "Développeur DevOps / Fullstack (H/F)" });
            produits.Add(new Offre { Date = "22-09-2020", Intitule = "Secrétaire (F)" });
            produits.Add(new Offre { Date = "22-09-2020", Intitule = "Maçon (P)" });
            produits.Add(new Offre { Date = "22-09-2020", Intitule = "Président Fullstack (H/F)" });
            return produits;
        }
    }
}
