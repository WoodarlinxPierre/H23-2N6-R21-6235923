using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppCompteurHydro
{
    public partial class FrmPrincipal : Form
    {
        private Random m_objRandom = new Random();
        public const string APP_INFO = "1111111";

        // TODO 01 : Ajouter une classe nommée CompteurHydro qui implémente l'interface ICompteurHydro
        // TODO 02 : Compléter le code de la classe afin qu'elle fonctionne correctement
        // TODO 03 : Retirer les commentaires du formulaire afin de vérifier le fonctionnement du CompteurHydro

        private ICompteurHydro m_objCompteurHydro;
        //==================================================================================================
        // Constructeur du formulaire
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            //m_objCompteurHydro = new CompteurHydro();
        }
        //==================================================================================================
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //==================================================================================================
        private void MnuOpérationConsommer100Kw_Click(object sender, EventArgs e)
        {
            //m_objCompteurHydro.Consommer(100);
            //lblConsommation.Text = m_objCompteurHydro.ConsommationActuelle.ToString("000000");
        }
        //==================================================================================================
        private void MnuOpérationConsommer5000Kw_Click(object sender, EventArgs e)
        {
            //m_objCompteurHydro.Consommer(5000);
            //lblConsommation.Text = m_objCompteurHydro.ConsommationActuelle.ToString("000000");
        }
        //==================================================================================================
        private void MnuOpérationConsommationAléatoire_Click(object sender, EventArgs e)
        {
            //m_objCompteurHydro.Consommer(m_objRandom.Next(200, 2500));
            //lblConsommation.Text = m_objCompteurHydro.ConsommationActuelle.ToString("000000");
        }
    }
}

