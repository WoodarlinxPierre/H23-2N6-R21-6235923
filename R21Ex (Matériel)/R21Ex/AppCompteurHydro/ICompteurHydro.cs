namespace AppCompteurHydro
{
    // Définit les éléments pour modéliser un compteur hydro-électrique
    public interface ICompteurHydro
    {
        /// ---------------------------------------------------------------------------------
        /// <summary>
        ///    Obtient la consommation totale actuelle 
        /// </summary>
        int ConsommationActuelle { get; }
        ///==================================================================================
        /// <summary>
        /// Augmente la quantité d'électricité consommée.
        /// </summary>
        /// <param name="pQuantitéKwh">Quantité d'électricité à ajouter au compteur</param>
        void Consommer(int pQuantitéKwh);
    }
}