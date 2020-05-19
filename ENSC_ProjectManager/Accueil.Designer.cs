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
            this.titreFiltreParAnneeDePromo = new System.Windows.Forms.Label();
            this.titreFiltreParMatiere = new System.Windows.Forms.Label();
            this.listeMatieres = new System.Windows.Forms.CheckedListBox();
            this.titreFiltreParEleve = new System.Windows.Forms.Label();
            this.listeEleves = new System.Windows.Forms.CheckedListBox();
            this.boutonNouveauProjet = new System.Windows.Forms.Button();
            this.titreDate = new System.Windows.Forms.Label();
            this.matiere = new System.Windows.Forms.TextBox();
            this.titreRechercheMatiere = new System.Windows.Forms.Label();
            this.titreRechercherQuelqun = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.nom = new System.Windows.Forms.TextBox();
            this.titreDateDebut = new System.Windows.Forms.Label();
            this.titreDateFin = new System.Windows.Forms.Label();
            this.listeProfs = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titreListeModules = new System.Windows.Forms.Label();
            this.listeModules = new System.Windows.Forms.CheckedListBox();
            this.titreRechercherModule = new System.Windows.Forms.Label();
            this.module = new System.Windows.Forms.TextBox();
            this.titreRechercheIntervenant = new System.Windows.Forms.Label();
            this.listeIntervenants = new System.Windows.Forms.CheckedListBox();
            this.rechercher = new System.Windows.Forms.Button();
            this.titreListeNiveaux = new System.Windows.Forms.Label();
            this.niveaux = new System.Windows.Forms.CheckedListBox();
            this.listeAnneePromo = new System.Windows.Forms.CheckedListBox();
            this.nomDeProjet = new System.Windows.Forms.TextBox();
            this.titreRechercheParNomDeProjet = new System.Windows.Forms.Label();
            this.rechercherMatiere = new System.Windows.Forms.Button();
            this.rechercherModule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listeProjets
            // 
            this.listeProjets.FormattingEnabled = true;
            this.listeProjets.Location = new System.Drawing.Point(15, 127);
            this.listeProjets.Name = "listeProjets";
            this.listeProjets.Size = new System.Drawing.Size(593, 563);
            this.listeProjets.TabIndex = 0;
            // 
            // titreListe
            // 
            this.titreListe.AutoSize = true;
            this.titreListe.Location = new System.Drawing.Point(12, 62);
            this.titreListe.Name = "titreListe";
            this.titreListe.Size = new System.Drawing.Size(127, 13);
            this.titreListe.TabIndex = 1;
            this.titreListe.Text = "Liste des projets existants";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(733, 9);
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
            this.titreFiltre.Location = new System.Drawing.Point(631, 62);
            this.titreFiltre.Name = "titreFiltre";
            this.titreFiltre.Size = new System.Drawing.Size(34, 13);
            this.titreFiltre.TabIndex = 3;
            this.titreFiltre.Text = "Filtres";
            this.titreFiltre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreFiltreParAnneeDePromo
            // 
            this.titreFiltreParAnneeDePromo.AutoSize = true;
            this.titreFiltreParAnneeDePromo.Location = new System.Drawing.Point(631, 102);
            this.titreFiltreParAnneeDePromo.Name = "titreFiltreParAnneeDePromo";
            this.titreFiltreParAnneeDePromo.Size = new System.Drawing.Size(120, 13);
            this.titreFiltreParAnneeDePromo.TabIndex = 5;
            this.titreFiltreParAnneeDePromo.Text = "Par année de promotion";
            this.titreFiltreParAnneeDePromo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreFiltreParMatiere
            // 
            this.titreFiltreParMatiere.AutoSize = true;
            this.titreFiltreParMatiere.Location = new System.Drawing.Point(836, 102);
            this.titreFiltreParMatiere.Name = "titreFiltreParMatiere";
            this.titreFiltreParMatiere.Size = new System.Drawing.Size(65, 13);
            this.titreFiltreParMatiere.TabIndex = 6;
            this.titreFiltreParMatiere.Text = "Par matières";
            this.titreFiltreParMatiere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeMatieres
            // 
            this.listeMatieres.FormattingEnabled = true;
            this.listeMatieres.Location = new System.Drawing.Point(839, 127);
            this.listeMatieres.Name = "listeMatieres";
            this.listeMatieres.Size = new System.Drawing.Size(199, 139);
            this.listeMatieres.TabIndex = 7;
            // 
            // titreFiltreParEleve
            // 
            this.titreFiltreParEleve.AutoSize = true;
            this.titreFiltreParEleve.Location = new System.Drawing.Point(1066, 102);
            this.titreFiltreParEleve.Name = "titreFiltreParEleve";
            this.titreFiltreParEleve.Size = new System.Drawing.Size(57, 13);
            this.titreFiltreParEleve.TabIndex = 8;
            this.titreFiltreParEleve.Text = "Par élèves";
            this.titreFiltreParEleve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeEleves
            // 
            this.listeEleves.FormattingEnabled = true;
            this.listeEleves.Location = new System.Drawing.Point(1069, 127);
            this.listeEleves.Name = "listeEleves";
            this.listeEleves.Size = new System.Drawing.Size(267, 154);
            this.listeEleves.TabIndex = 9;
            // 
            // boutonNouveauProjet
            // 
            this.boutonNouveauProjet.Location = new System.Drawing.Point(12, 12);
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
            this.titreDate.Location = new System.Drawing.Point(631, 396);
            this.titreDate.Name = "titreDate";
            this.titreDate.Size = new System.Drawing.Size(47, 13);
            this.titreDate.TabIndex = 11;
            this.titreDate.Text = "Par date";
            this.titreDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // matiere
            // 
            this.matiere.Location = new System.Drawing.Point(839, 306);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(127, 20);
            this.matiere.TabIndex = 13;
            this.matiere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Matiere_KeyPress);
            // 
            // titreRechercheMatiere
            // 
            this.titreRechercheMatiere.AutoSize = true;
            this.titreRechercheMatiere.Location = new System.Drawing.Point(836, 290);
            this.titreRechercheMatiere.Name = "titreRechercheMatiere";
            this.titreRechercheMatiere.Size = new System.Drawing.Size(121, 13);
            this.titreRechercheMatiere.TabIndex = 14;
            this.titreRechercheMatiere.Text = "Rechercher une matière";
            this.titreRechercheMatiere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreRechercherQuelqun
            // 
            this.titreRechercherQuelqun.AutoSize = true;
            this.titreRechercherQuelqun.Location = new System.Drawing.Point(1066, 587);
            this.titreRechercherQuelqun.Name = "titreRechercherQuelqun";
            this.titreRechercherQuelqun.Size = new System.Drawing.Size(112, 13);
            this.titreRechercherQuelqun.TabIndex = 15;
            this.titreRechercherQuelqun.Text = "Rechercher quelqu\'un";
            this.titreRechercherQuelqun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(1115, 624);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(120, 20);
            this.Prenom.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1066, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prenom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1066, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(634, 442);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(174, 20);
            this.dateDebut.TabIndex = 19;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(634, 496);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(174, 20);
            this.dateFin.TabIndex = 20;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(1115, 650);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(120, 20);
            this.nom.TabIndex = 21;
            // 
            // titreDateDebut
            // 
            this.titreDateDebut.AutoSize = true;
            this.titreDateDebut.Location = new System.Drawing.Point(631, 426);
            this.titreDateDebut.Name = "titreDateDebut";
            this.titreDateDebut.Size = new System.Drawing.Size(73, 13);
            this.titreDateDebut.TabIndex = 22;
            this.titreDateDebut.Text = "date de début";
            this.titreDateDebut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreDateFin
            // 
            this.titreDateFin.AutoSize = true;
            this.titreDateFin.Location = new System.Drawing.Point(631, 478);
            this.titreDateFin.Name = "titreDateFin";
            this.titreDateFin.Size = new System.Drawing.Size(57, 13);
            this.titreDateFin.TabIndex = 23;
            this.titreDateFin.Text = "date de fin";
            this.titreDateFin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeProfs
            // 
            this.listeProfs.FormattingEnabled = true;
            this.listeProfs.Location = new System.Drawing.Point(1069, 306);
            this.listeProfs.Name = "listeProfs";
            this.listeProfs.Size = new System.Drawing.Size(267, 139);
            this.listeProfs.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1066, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Par Professeurs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreListeModules
            // 
            this.titreListeModules.AutoSize = true;
            this.titreListeModules.Location = new System.Drawing.Point(836, 352);
            this.titreListeModules.Name = "titreListeModules";
            this.titreListeModules.Size = new System.Drawing.Size(65, 13);
            this.titreListeModules.TabIndex = 26;
            this.titreListeModules.Text = "Par modules";
            this.titreListeModules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeModules
            // 
            this.listeModules.FormattingEnabled = true;
            this.listeModules.Location = new System.Drawing.Point(839, 381);
            this.listeModules.Name = "listeModules";
            this.listeModules.Size = new System.Drawing.Size(199, 154);
            this.listeModules.TabIndex = 27;
            // 
            // titreRechercherModule
            // 
            this.titreRechercherModule.AutoSize = true;
            this.titreRechercherModule.Location = new System.Drawing.Point(836, 557);
            this.titreRechercherModule.Name = "titreRechercherModule";
            this.titreRechercherModule.Size = new System.Drawing.Size(115, 13);
            this.titreRechercherModule.TabIndex = 28;
            this.titreRechercherModule.Text = "Rechercher un module";
            this.titreRechercherModule.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // module
            // 
            this.module.Location = new System.Drawing.Point(839, 577);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(127, 20);
            this.module.TabIndex = 29;
            this.module.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module_KeyPress);
            // 
            // titreRechercheIntervenant
            // 
            this.titreRechercheIntervenant.AutoSize = true;
            this.titreRechercheIntervenant.Location = new System.Drawing.Point(1066, 460);
            this.titreRechercheIntervenant.Name = "titreRechercheIntervenant";
            this.titreRechercheIntervenant.Size = new System.Drawing.Size(85, 13);
            this.titreRechercheIntervenant.TabIndex = 30;
            this.titreRechercheIntervenant.Text = "Par Intervenants";
            this.titreRechercheIntervenant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeIntervenants
            // 
            this.listeIntervenants.FormattingEnabled = true;
            this.listeIntervenants.Location = new System.Drawing.Point(1069, 476);
            this.listeIntervenants.Name = "listeIntervenants";
            this.listeIntervenants.Size = new System.Drawing.Size(267, 94);
            this.listeIntervenants.TabIndex = 31;
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(1261, 633);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(75, 23);
            this.rechercher.TabIndex = 32;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = true;
            // 
            // titreListeNiveaux
            // 
            this.titreListeNiveaux.AutoSize = true;
            this.titreListeNiveaux.Location = new System.Drawing.Point(631, 236);
            this.titreListeNiveaux.Name = "titreListeNiveaux";
            this.titreListeNiveaux.Size = new System.Drawing.Size(63, 13);
            this.titreListeNiveaux.TabIndex = 33;
            this.titreListeNiveaux.Text = "Par niveaux";
            this.titreListeNiveaux.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // niveaux
            // 
            this.niveaux.FormattingEnabled = true;
            this.niveaux.Location = new System.Drawing.Point(634, 271);
            this.niveaux.Name = "niveaux";
            this.niveaux.Size = new System.Drawing.Size(174, 94);
            this.niveaux.TabIndex = 34;
            // 
            // listeAnneePromo
            // 
            this.listeAnneePromo.FormattingEnabled = true;
            this.listeAnneePromo.Location = new System.Drawing.Point(634, 127);
            this.listeAnneePromo.Name = "listeAnneePromo";
            this.listeAnneePromo.Size = new System.Drawing.Size(174, 94);
            this.listeAnneePromo.TabIndex = 4;
            // 
            // nomDeProjet
            // 
            this.nomDeProjet.Location = new System.Drawing.Point(160, 95);
            this.nomDeProjet.Name = "nomDeProjet";
            this.nomDeProjet.Size = new System.Drawing.Size(199, 20);
            this.nomDeProjet.TabIndex = 35;
            // 
            // titreRechercheParNomDeProjet
            // 
            this.titreRechercheParNomDeProjet.AutoSize = true;
            this.titreRechercheParNomDeProjet.Location = new System.Drawing.Point(9, 102);
            this.titreRechercheParNomDeProjet.Name = "titreRechercheParNomDeProjet";
            this.titreRechercheParNomDeProjet.Size = new System.Drawing.Size(145, 13);
            this.titreRechercheParNomDeProjet.TabIndex = 36;
            this.titreRechercheParNomDeProjet.Text = "Recherche par nom de projet";
            // 
            // rechercherMatiere
            // 
            this.rechercherMatiere.Location = new System.Drawing.Point(972, 304);
            this.rechercherMatiere.Name = "rechercherMatiere";
            this.rechercherMatiere.Size = new System.Drawing.Size(75, 23);
            this.rechercherMatiere.TabIndex = 37;
            this.rechercherMatiere.Text = "Rechercher";
            this.rechercherMatiere.UseVisualStyleBackColor = true;
            this.rechercherMatiere.Click += new System.EventHandler(this.RechercherMatiere_Click);
            // 
            // rechercherModule
            // 
            this.rechercherModule.Location = new System.Drawing.Point(972, 575);
            this.rechercherModule.Name = "rechercherModule";
            this.rechercherModule.Size = new System.Drawing.Size(75, 23);
            this.rechercherModule.TabIndex = 38;
            this.rechercherModule.Text = "Rechercher";
            this.rechercherModule.UseVisualStyleBackColor = true;
            this.rechercherModule.Click += new System.EventHandler(this.RechercherModule_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.rechercherModule);
            this.Controls.Add(this.rechercherMatiere);
            this.Controls.Add(this.titreRechercheParNomDeProjet);
            this.Controls.Add(this.nomDeProjet);
            this.Controls.Add(this.niveaux);
            this.Controls.Add(this.titreListeNiveaux);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.listeIntervenants);
            this.Controls.Add(this.titreRechercheIntervenant);
            this.Controls.Add(this.module);
            this.Controls.Add(this.titreRechercherModule);
            this.Controls.Add(this.listeModules);
            this.Controls.Add(this.titreListeModules);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeProfs);
            this.Controls.Add(this.titreDateFin);
            this.Controls.Add(this.titreDateDebut);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.titreRechercherQuelqun);
            this.Controls.Add(this.titreRechercheMatiere);
            this.Controls.Add(this.matiere);
            this.Controls.Add(this.titreDate);
            this.Controls.Add(this.boutonNouveauProjet);
            this.Controls.Add(this.listeEleves);
            this.Controls.Add(this.titreFiltreParEleve);
            this.Controls.Add(this.listeMatieres);
            this.Controls.Add(this.titreFiltreParMatiere);
            this.Controls.Add(this.titreFiltreParAnneeDePromo);
            this.Controls.Add(this.listeAnneePromo);
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
        private System.Windows.Forms.Label titreFiltreParAnneeDePromo;
        private System.Windows.Forms.Label titreFiltreParMatiere;
        private System.Windows.Forms.CheckedListBox listeMatieres;
        private System.Windows.Forms.Label titreFiltreParEleve;
        private System.Windows.Forms.CheckedListBox listeEleves;
        private System.Windows.Forms.Button boutonNouveauProjet;
        private System.Windows.Forms.Label titreDate;
        private System.Windows.Forms.TextBox matiere;
        private System.Windows.Forms.Label titreRechercheMatiere;
        private System.Windows.Forms.Label titreRechercherQuelqun;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label titreDateDebut;
        private System.Windows.Forms.Label titreDateFin;
        private System.Windows.Forms.CheckedListBox listeProfs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titreListeModules;
        private System.Windows.Forms.CheckedListBox listeModules;
        private System.Windows.Forms.Label titreRechercherModule;
        private System.Windows.Forms.TextBox module;
        private System.Windows.Forms.Label titreRechercheIntervenant;
        private System.Windows.Forms.CheckedListBox listeIntervenants;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.Label titreListeNiveaux;
        private System.Windows.Forms.CheckedListBox niveaux;
        private System.Windows.Forms.CheckedListBox listeAnneePromo;
        private System.Windows.Forms.TextBox nomDeProjet;
        private System.Windows.Forms.Label titreRechercheParNomDeProjet;
        private System.Windows.Forms.Button rechercherMatiere;
        private System.Windows.Forms.Button rechercherModule;
    }
}