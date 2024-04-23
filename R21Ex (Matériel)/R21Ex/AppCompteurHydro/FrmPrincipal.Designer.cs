namespace AppCompteurHydro
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpération = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpérationConsommer100Kw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpérationConsommer5250Kw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpérationConsommationAléatoire = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConsommation = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuOpération});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(510, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // mnuOpération
            // 
            this.mnuOpération.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpérationConsommer100Kw,
            this.mnuOpérationConsommer5250Kw,
            this.mnuOpérationConsommationAléatoire});
            this.mnuOpération.Name = "mnuOpération";
            this.mnuOpération.Size = new System.Drawing.Size(72, 20);
            this.mnuOpération.Text = "&Opération";
            // 
            // mnuOpérationConsommer100Kw
            // 
            this.mnuOpérationConsommer100Kw.Name = "mnuOpérationConsommer100Kw";
            this.mnuOpérationConsommer100Kw.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuOpérationConsommer100Kw.Size = new System.Drawing.Size(245, 22);
            this.mnuOpérationConsommer100Kw.Text = "Consommer 100 Kw";
            this.mnuOpérationConsommer100Kw.Click += new System.EventHandler(this.MnuOpérationConsommer100Kw_Click);
            // 
            // mnuOpérationConsommer5250Kw
            // 
            this.mnuOpérationConsommer5250Kw.Name = "mnuOpérationConsommer5250Kw";
            this.mnuOpérationConsommer5250Kw.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuOpérationConsommer5250Kw.Size = new System.Drawing.Size(245, 22);
            this.mnuOpérationConsommer5250Kw.Text = "Consommer 5250 Kw";
            this.mnuOpérationConsommer5250Kw.Click += new System.EventHandler(this.MnuOpérationConsommer5000Kw_Click);
            // 
            // mnuOpérationConsommationAléatoire
            // 
            this.mnuOpérationConsommationAléatoire.Name = "mnuOpérationConsommationAléatoire";
            this.mnuOpérationConsommationAléatoire.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mnuOpérationConsommationAléatoire.Size = new System.Drawing.Size(245, 22);
            this.mnuOpérationConsommationAléatoire.Text = "Consommation aléatoire";
            this.mnuOpérationConsommationAléatoire.Click += new System.EventHandler(this.MnuOpérationConsommationAléatoire_Click);
            // 
            // lblConsommation
            // 
            this.lblConsommation.BackColor = System.Drawing.Color.Transparent;
            this.lblConsommation.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsommation.Location = new System.Drawing.Point(146, 184);
            this.lblConsommation.Name = "lblConsommation";
            this.lblConsommation.Size = new System.Drawing.Size(218, 54);
            this.lblConsommation.TabIndex = 2;
            this.lblConsommation.Text = "000000";
            this.lblConsommation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppCompteurHydro.Properties.Resources.Compteur;
            this.ClientSize = new System.Drawing.Size(510, 557);
            this.Controls.Add(this.lblConsommation);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICompteurHydro ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuOpération;
        private System.Windows.Forms.ToolStripMenuItem mnuOpérationConsommer100Kw;
        private System.Windows.Forms.ToolStripMenuItem mnuOpérationConsommer5250Kw;
        private System.Windows.Forms.Label lblConsommation;
        private System.Windows.Forms.ToolStripMenuItem mnuOpérationConsommationAléatoire;
    }
}

