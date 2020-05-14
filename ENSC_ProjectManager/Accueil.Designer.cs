namespace ENSC_ProjectManager
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listeProjets = new System.Windows.Forms.ListBox();
            this.titreListe = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.titreFiltre = new System.Windows.Forms.Label();
            this.listeAnnee = new System.Windows.Forms.CheckedListBox();
            this.titreFiltreParAnnee = new System.Windows.Forms.Label();
            this.titreFiltreParMatiere = new System.Windows.Forms.Label();
            this.listeMatieres = new System.Windows.Forms.CheckedListBox();
            this.titreFiltreParEleve = new System.Windows.Forms.Label();
            this.listeEleves = new System.Windows.Forms.CheckedListBox();
            this.boutonNouveauProjet = new System.Windows.Forms.Button();
            this.titreDate = new System.Windows.Forms.Label();
            this.listeDates = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // listeProjets
            // 
            this.listeProjets.FormattingEnabled = true;
            this.listeProjets.Location = new System.Drawing.Point(12, 102);
            this.listeProjets.Name = "listeProjets";
            this.listeProjets.Size = new System.Drawing.Size(355, 303);
            this.listeProjets.TabIndex = 0;
            // 
            // titreListe
            // 
            this.titreListe.AutoSize = true;
            this.titreListe.Location = new System.Drawing.Point(12, 72);
            this.titreListe.Name = "titreListe";
            this.titreListe.Size = new System.Drawing.Size(127, 13);
            this.titreListe.TabIndex = 1;
            this.titreListe.Text = "Liste des projets existants";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(357, 21);
            this.titre.MaximumSize = new System.Drawing.Size(0, 30);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(45, 13);
            this.titre.TabIndex = 2;
            this.titre.Text = "Accueil ";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreFiltre
            // 
            this.titreFiltre.AutoSize = true;
            this.titreFiltre.Location = new System.Drawing.Point(403, 72);
            this.titreFiltre.Name = "titreFiltre";
            this.titreFiltre.Size = new System.Drawing.Size(29, 13);
            this.titreFiltre.TabIndex = 3;
            this.titreFiltre.Text = "Filtre";
            this.titreFiltre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeAnnee
            // 
            this.listeAnnee.FormattingEnabled = true;
            this.listeAnnee.Location = new System.Drawing.Point(379, 127);
            this.listeAnnee.Name = "listeAnnee";
            this.listeAnnee.Size = new System.Drawing.Size(120, 94);
            this.listeAnnee.TabIndex = 4;
            // 
            // titreFiltreParAnnee
            // 
            this.titreFiltreParAnnee.AutoSize = true;
            this.titreFiltreParAnnee.Location = new System.Drawing.Point(376, 102);
            this.titreFiltreParAnnee.Name = "titreFiltreParAnnee";
            this.titreFiltreParAnnee.Size = new System.Drawing.Size(56, 13);
            this.titreFiltreParAnnee.TabIndex = 5;
            this.titreFiltreParAnnee.Text = "Par année";
            this.titreFiltreParAnnee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreFiltreParMatiere
            // 
            this.titreFiltreParMatiere.AutoSize = true;
            this.titreFiltreParMatiere.Location = new System.Drawing.Point(516, 102);
            this.titreFiltreParMatiere.Name = "titreFiltreParMatiere";
            this.titreFiltreParMatiere.Size = new System.Drawing.Size(65, 13);
            this.titreFiltreParMatiere.TabIndex = 6;
            this.titreFiltreParMatiere.Text = "Par matières";
            this.titreFiltreParMatiere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeMatieres
            // 
            this.listeMatieres.FormattingEnabled = true;
            this.listeMatieres.Location = new System.Drawing.Point(519, 127);
            this.listeMatieres.Name = "listeMatieres";
            this.listeMatieres.Size = new System.Drawing.Size(120, 94);
            this.listeMatieres.TabIndex = 7;
            // 
            // titreFiltreParEleve
            // 
            this.titreFiltreParEleve.AutoSize = true;
            this.titreFiltreParEleve.Location = new System.Drawing.Point(655, 102);
            this.titreFiltreParEleve.Name = "titreFiltreParEleve";
            this.titreFiltreParEleve.Size = new System.Drawing.Size(57, 13);
            this.titreFiltreParEleve.TabIndex = 8;
            this.titreFiltreParEleve.Text = "Par élèves";
            this.titreFiltreParEleve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeEleves
            // 
            this.listeEleves.FormattingEnabled = true;
            this.listeEleves.Location = new System.Drawing.Point(658, 127);
            this.listeEleves.Name = "listeEleves";
            this.listeEleves.Size = new System.Drawing.Size(120, 94);
            this.listeEleves.TabIndex = 9;
            // 
            // boutonNouveauProjet
            // 
            this.boutonNouveauProjet.Location = new System.Drawing.Point(468, 382);
            this.boutonNouveauProjet.Name = "boutonNouveauProjet";
            this.boutonNouveauProjet.Size = new System.Drawing.Size(234, 23);
            this.boutonNouveauProjet.TabIndex = 10;
            this.boutonNouveauProjet.Text = "Nouveau Projet";
            this.boutonNouveauProjet.UseMnemonic = false;
            this.boutonNouveauProjet.UseVisualStyleBackColor = true;
            this.boutonNouveauProjet.Click += new System.EventHandler(this.BoutonNouveauProjet_Click);
            // 
            // titreDate
            // 
            this.titreDate.AutoSize = true;
            this.titreDate.Location = new System.Drawing.Point(376, 240);
            this.titreDate.Name = "titreDate";
            this.titreDate.Size = new System.Drawing.Size(47, 13);
            this.titreDate.TabIndex = 11;
            this.titreDate.Text = "Par date";
            this.titreDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeDates
            // 
            this.listeDates.FormattingEnabled = true;
            this.listeDates.Location = new System.Drawing.Point(379, 256);
            this.listeDates.Name = "listeDates";
            this.listeDates.Size = new System.Drawing.Size(120, 94);
            this.listeDates.TabIndex = 12;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeDates);
            this.Controls.Add(this.titreDate);
            this.Controls.Add(this.boutonNouveauProjet);
            this.Controls.Add(this.listeEleves);
            this.Controls.Add(this.titreFiltreParEleve);
            this.Controls.Add(this.listeMatieres);
            this.Controls.Add(this.titreFiltreParMatiere);
            this.Controls.Add(this.titreFiltreParAnnee);
            this.Controls.Add(this.listeAnnee);
            this.Controls.Add(this.titreFiltre);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.titreListe);
            this.Controls.Add(this.listeProjets);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listeProjets;
        private System.Windows.Forms.Label titreListe;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label titreFiltre;
        private System.Windows.Forms.CheckedListBox listeAnnee;
        private System.Windows.Forms.Label titreFiltreParAnnee;
        private System.Windows.Forms.Label titreFiltreParMatiere;
        private System.Windows.Forms.CheckedListBox listeMatieres;
        private System.Windows.Forms.Label titreFiltreParEleve;
        private System.Windows.Forms.CheckedListBox listeEleves;
        private System.Windows.Forms.Button boutonNouveauProjet;
        private System.Windows.Forms.Label titreDate;
        private System.Windows.Forms.CheckedListBox listeDates;
    }
}