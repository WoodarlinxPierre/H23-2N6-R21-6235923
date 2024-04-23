using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCompteurHydro
{
    public class CompteurHydro : ICompteurHydro
    {
		/// <summary>
        /// stocker la consommation actuelle exprimé en kwh
        /// </summary>
		private int m_consommationActuelle;
        
		
		public int ConsommationActuelle
        {
            get { return m_consommationActuelle;  }
        }


        public CompteurHydro()
        {
            m_consommationActuelle = 0;
        }
		/// <summary>
        /// Mettre à jour la consommation actuelle selon la quantité consommée
        /// </summary>
        /// <param name="pQuantitéKwh"> nombre de kwh a ajouté</param>
		public void Consommer(int pQuantitéKwh)
        {
            m_consommationActuelle += pQuantitéKwh;
        }
    }
}
