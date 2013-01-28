using System.Windows.Forms;
namespace gsb_application
{
    partial class MainWindows
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesPrêtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauPrêtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesPrêtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueDesMateriauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerDeMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelDutilisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.lesPrêtsToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.statistiqueToolStripMenuItem,
            this.profilToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(688, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.fichierToolStripMenuItem.Text = "Connexion";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.seConnecterToolStripMenuItem.Text = "Se connecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.seDeconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // lesPrêtsToolStripMenuItem
            // 
            this.lesPrêtsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauPrêtToolStripMenuItem1,
            this.consulterLesPrêtsToolStripMenuItem});
            this.lesPrêtsToolStripMenuItem.Name = "lesPrêtsToolStripMenuItem";
            this.lesPrêtsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.lesPrêtsToolStripMenuItem.Text = "Prêts";
            // 
            // nouveauPrêtToolStripMenuItem1
            // 
            this.nouveauPrêtToolStripMenuItem1.Name = "nouveauPrêtToolStripMenuItem1";
            this.nouveauPrêtToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+N";
            this.nouveauPrêtToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.nouveauPrêtToolStripMenuItem1.Text = "Nouveau prêt";
            this.nouveauPrêtToolStripMenuItem1.Click += new System.EventHandler(this.nouveauPrêtToolStripMenuItem1_Click);
            // 
            // consulterLesPrêtsToolStripMenuItem
            // 
            this.consulterLesPrêtsToolStripMenuItem.Name = "consulterLesPrêtsToolStripMenuItem";
            this.consulterLesPrêtsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+K";
            this.consulterLesPrêtsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.consulterLesPrêtsToolStripMenuItem.Text = "Consulter les prêts";
            this.consulterLesPrêtsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesPrêtsToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnUtilisateurToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // créerUnUtilisateurToolStripMenuItem
            // 
            this.créerUnUtilisateurToolStripMenuItem.Name = "créerUnUtilisateurToolStripMenuItem";
            this.créerUnUtilisateurToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+U";
            this.créerUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.créerUnUtilisateurToolStripMenuItem.Text = "Créer un utilisateur";
            this.créerUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.créerUnUtilisateurToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affToolStripMenuItem,
            this.statistiqueDesMateriauxToolStripMenuItem});
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            // 
            // affToolStripMenuItem
            // 
            this.affToolStripMenuItem.Name = "affToolStripMenuItem";
            this.affToolStripMenuItem.ShortcutKeyDisplayString = "Alt+S";
            this.affToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.affToolStripMenuItem.Text = "Statistique de l\'application";
            this.affToolStripMenuItem.Click += new System.EventHandler(this.affToolStripMenuItem_Click);
            // 
            // statistiqueDesMateriauxToolStripMenuItem
            // 
            this.statistiqueDesMateriauxToolStripMenuItem.Name = "statistiqueDesMateriauxToolStripMenuItem";
            this.statistiqueDesMateriauxToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.statistiqueDesMateriauxToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.statistiqueDesMateriauxToolStripMenuItem.Text = "Statistique des materiels";
            this.statistiqueDesMateriauxToolStripMenuItem.Click += new System.EventHandler(this.statistiqueDesMateriauxToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerDeMotDePasseToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // changerDeMotDePasseToolStripMenuItem
            // 
            this.changerDeMotDePasseToolStripMenuItem.Name = "changerDeMotDePasseToolStripMenuItem";
            this.changerDeMotDePasseToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.changerDeMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.changerDeMotDePasseToolStripMenuItem.Text = "Changer de mot de passe ";
            this.changerDeMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerDeMotDePasseToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelDutilisationToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // manuelDutilisationToolStripMenuItem
            // 
            this.manuelDutilisationToolStripMenuItem.Name = "manuelDutilisationToolStripMenuItem";
            this.manuelDutilisationToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.manuelDutilisationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.manuelDutilisationToolStripMenuItem.Text = "Manuel d\'utilisation";
            this.manuelDutilisationToolStripMenuItem.Click += new System.EventHandler(this.manuelDutilisationToolStripMenuItem_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 411);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MainWindows";
            this.Text = "Application de gestion des prêts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.evenementClavier_KeyPress);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesPrêtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauPrêtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterLesPrêtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerDeMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelDutilisationToolStripMenuItem;
        private ToolStripMenuItem seConnecterToolStripMenuItem;
        private ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private ToolStripMenuItem statistiqueToolStripMenuItem;
        private ToolStripMenuItem affToolStripMenuItem;
        private ToolStripMenuItem statistiqueDesMateriauxToolStripMenuItem;
    }
}

