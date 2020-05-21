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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
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
            this.PrenomRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.NomRecherche = new System.Windows.Forms.TextBox();
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
            this.RechercherPersonne = new System.Windows.Forms.Button();
            this.titreListeNiveaux = new System.Windows.Forms.Label();
            this.niveaux = new System.Windows.Forms.CheckedListBox();
            this.listeAnneePromo = new System.Windows.Forms.CheckedListBox();
            this.nomDeProjet = new System.Windows.Forms.TextBox();
            this.titreRechercheParNomDeProjet = new System.Windows.Forms.Label();
            this.resultatsRecherchePersonne = new System.Windows.Forms.CheckedListBox();
            this.logoENSC = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppliquerFiltres = new System.Windows.Forms.Button();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.rechercherMatiere = new System.Windows.Forms.Button();
            this.rechercherModule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoENSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listeProjets
            // 
            this.listeProjets.FormattingEnabled = true;
            this.listeProjets.Location = new System.Drawing.Point(15, 127);
            this.listeProjets.Name = "listeProjets";
            this.listeProjets.Size = new System.Drawing.Size(593, 563);
            this.listeProjets.TabIndex = 0;
            this.listeProjets.DoubleClick += new System.EventHandler(this.listeProjets_DoubleClick);
            // 
            // titreListe
            // 
            this.titreListe.AutoSize = true;
            this.titreListe.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreListe.ForeColor = System.Drawing.Color.DarkOrange;
            this.titreListe.Location = new System.Drawing.Point(201, 62);
            this.titreListe.Name = "titreListe";
            this.titreListe.Size = new System.Drawing.Size(180, 19);
            this.titreListe.TabIndex = 1;
            this.titreListe.Text = "Liste des projets existants";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Roboto Condensed", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titre.Location = new System.Drawing.Point(646, 3);
            this.titre.MaximumSize = new System.Drawing.Size(0, 30);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(109, 30);
            this.titre.TabIndex = 2;
            this.titre.Text = "ACCUEIL";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreFiltre
            // 
            this.titreFiltre.AutoSize = true;
            this.titreFiltre.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreFiltre.ForeColor = System.Drawing.Color.DarkOrange;
            this.titreFiltre.Location = new System.Drawing.Point(919, 62);
            this.titreFiltre.Name = "titreFiltre";
            this.titreFiltre.Size = new System.Drawing.Size(50, 19);
            this.titreFiltre.TabIndex = 3;
            this.titreFiltre.Text = "Filtres";
            this.titreFiltre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreFiltreParAnneeDePromo
            // 
            this.titreFiltreParAnneeDePromo.AutoSize = true;
            this.titreFiltreParAnneeDePromo.Location = new System.Drawing.Point(631, 102);
            this.titreFiltreParAnneeDePromo.Name = "titreFiltreParAnneeDePromo";
            this.titreFiltreParAnneeDePromo.Size = new System.Drawing.Size(140, 15);
            this.titreFiltreParAnneeDePromo.TabIndex = 5;
            this.titreFiltreParAnneeDePromo.Text = "Par année de promotion";
            this.titreFiltreParAnneeDePromo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreFiltreParMatiere
            // 
            this.titreFiltreParMatiere.AutoSize = true;
            this.titreFiltreParMatiere.Location = new System.Drawing.Point(836, 102);
            this.titreFiltreParMatiere.Name = "titreFiltreParMatiere";
            this.titreFiltreParMatiere.Size = new System.Drawing.Size(77, 15);
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
            this.titreFiltreParEleve.Size = new System.Drawing.Size(64, 15);
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
            this.boutonNouveauProjet.Font = new System.Drawing.Font("Roboto Condensed", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonNouveauProjet.ForeColor = System.Drawing.Color.DarkOrange;
            this.boutonNouveauProjet.Location = new System.Drawing.Point(12, 12);
            this.boutonNouveauProjet.Name = "boutonNouveauProjet";
            this.boutonNouveauProjet.Size = new System.Drawing.Size(234, 23);
            this.boutonNouveauProjet.TabIndex = 10;
            this.boutonNouveauProjet.Text = "NOUVEAU PROJET";
            this.boutonNouveauProjet.UseMnemonic = false;
            this.boutonNouveauProjet.UseVisualStyleBackColor = true;
            this.boutonNouveauProjet.Click += new System.EventHandler(this.BoutonNouveauProjet_Click);
            // 
            // titreDate
            // 
            this.titreDate.AutoSize = true;
            this.titreDate.Location = new System.Drawing.Point(631, 396);
            this.titreDate.Name = "titreDate";
            this.titreDate.Size = new System.Drawing.Size(53, 15);
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
            this.titreRechercheMatiere.Size = new System.Drawing.Size(140, 15);
            this.titreRechercheMatiere.TabIndex = 14;
            this.titreRechercheMatiere.Text = "Rechercher une matière";
            this.titreRechercheMatiere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreRechercherQuelqun
            // 
            this.titreRechercherQuelqun.AutoSize = true;
            this.titreRechercherQuelqun.Location = new System.Drawing.Point(1066, 587);
            this.titreRechercherQuelqun.Name = "titreRechercherQuelqun";
            this.titreRechercherQuelqun.Size = new System.Drawing.Size(129, 15);
            this.titreRechercherQuelqun.TabIndex = 15;
            this.titreRechercherQuelqun.Text = "Rechercher quelqu\'un";
            this.titreRechercherQuelqun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrenomRecherche
            // 
            this.PrenomRecherche.Location = new System.Drawing.Point(1115, 621);
            this.PrenomRecherche.Name = "PrenomRecherche";
            this.PrenomRecherche.Size = new System.Drawing.Size(120, 20);
            this.PrenomRecherche.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1058, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prenom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1066, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
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
            this.dateDebut.ValueChanged += new System.EventHandler(this.dateDebut_ValueChanged);
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(634, 496);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(174, 20);
            this.dateFin.TabIndex = 20;
            // 
            // NomRecherche
            // 
            this.NomRecherche.Location = new System.Drawing.Point(1115, 650);
            this.NomRecherche.Name = "NomRecherche";
            this.NomRecherche.Size = new System.Drawing.Size(120, 20);
            this.NomRecherche.TabIndex = 21;
            // 
            // titreDateDebut
            // 
            this.titreDateDebut.AutoSize = true;
            this.titreDateDebut.Location = new System.Drawing.Point(631, 426);
            this.titreDateDebut.Name = "titreDateDebut";
            this.titreDateDebut.Size = new System.Drawing.Size(82, 15);
            this.titreDateDebut.TabIndex = 22;
            this.titreDateDebut.Text = "date de début";
            this.titreDateDebut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreDateFin
            // 
            this.titreDateFin.AutoSize = true;
            this.titreDateFin.Location = new System.Drawing.Point(631, 478);
            this.titreDateFin.Name = "titreDateFin";
            this.titreDateFin.Size = new System.Drawing.Size(64, 15);
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
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Par Professeurs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titreListeModules
            // 
            this.titreListeModules.AutoSize = true;
            this.titreListeModules.Location = new System.Drawing.Point(836, 352);
            this.titreListeModules.Name = "titreListeModules";
            this.titreListeModules.Size = new System.Drawing.Size(77, 15);
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
            this.titreRechercherModule.Size = new System.Drawing.Size(133, 15);
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
            this.titreRechercheIntervenant.Size = new System.Drawing.Size(95, 15);
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
            // RechercherPersonne
            // 
            this.RechercherPersonne.Location = new System.Drawing.Point(1261, 634);
            this.RechercherPersonne.Name = "RechercherPersonne";
            this.RechercherPersonne.Size = new System.Drawing.Size(75, 23);
            this.RechercherPersonne.TabIndex = 32;
            this.RechercherPersonne.Text = "Rechercher";
            this.RechercherPersonne.UseVisualStyleBackColor = true;
            this.RechercherPersonne.Click += new System.EventHandler(this.RechercherPersonne_Click);
            // 
            // titreListeNiveaux
            // 
            this.titreListeNiveaux.AutoSize = true;
            this.titreListeNiveaux.Location = new System.Drawing.Point(631, 236);
            this.titreListeNiveaux.Name = "titreListeNiveaux";
            this.titreListeNiveaux.Size = new System.Drawing.Size(71, 15);
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
            this.nomDeProjet.Location = new System.Drawing.Point(182, 102);
            this.nomDeProjet.Name = "nomDeProjet";
            this.nomDeProjet.Size = new System.Drawing.Size(199, 20);
            this.nomDeProjet.TabIndex = 35;
            this.nomDeProjet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomDeProjet_KeyDown);
            // 
            // titreRechercheParNomDeProjet
            // 
            this.titreRechercheParNomDeProjet.AutoSize = true;
            this.titreRechercheParNomDeProjet.Location = new System.Drawing.Point(9, 102);
            this.titreRechercheParNomDeProjet.Name = "titreRechercheParNomDeProjet";
            this.titreRechercheParNomDeProjet.Size = new System.Drawing.Size(167, 15);
            this.titreRechercheParNomDeProjet.TabIndex = 36;
            this.titreRechercheParNomDeProjet.Text = "Recherche par nom de projet";
            // 
            // resultatsRecherchePersonne
            // 
            this.resultatsRecherchePersonne.FormattingEnabled = true;
            this.resultatsRecherchePersonne.Location = new System.Drawing.Point(1069, 695);
            this.resultatsRecherchePersonne.Name = "resultatsRecherchePersonne";
            this.resultatsRecherchePersonne.Size = new System.Drawing.Size(267, 94);
            this.resultatsRecherchePersonne.TabIndex = 37;
            this.resultatsRecherchePersonne.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.resultatsRecherchePersonne_ItemCheck);
            // 
            // logoENSC
            // 
            this.logoENSC.Image = global::ENSC_ProjectManager.Properties.Resources.logo_ensc;
            this.logoENSC.InitialImage = global::ENSC_ProjectManager.Properties.Resources.logo_ensc;
            this.logoENSC.Location = new System.Drawing.Point(1184, 3);
            this.logoENSC.Name = "logoENSC";
            this.logoENSC.Size = new System.Drawing.Size(184, 114);
            this.logoENSC.TabIndex = 42;
            this.logoENSC.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ENSC_ProjectManager.Properties.Resources.logo_home1;
            this.pictureBox1.Location = new System.Drawing.Point(604, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // AppliquerFiltres
            // 
            this.AppliquerFiltres.Font = new System.Drawing.Font("Roboto Condensed", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppliquerFiltres.ForeColor = System.Drawing.Color.DarkOrange;
            this.AppliquerFiltres.Location = new System.Drawing.Point(604, 729);
            this.AppliquerFiltres.Name = "AppliquerFiltres";
            this.AppliquerFiltres.Size = new System.Drawing.Size(109, 39);
            this.AppliquerFiltres.TabIndex = 44;
            this.AppliquerFiltres.Text = "FILTRER";
            this.AppliquerFiltres.UseVisualStyleBackColor = true;
            this.AppliquerFiltres.Click += new System.EventHandler(this.AppliquerFiltres_Click);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.BackColor = System.Drawing.Color.Coral;
            this.checkBoxDate.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxDate.Location = new System.Drawing.Point(698, 397);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDate.TabIndex = 45;
            this.checkBoxDate.UseVisualStyleBackColor = false;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 801);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.AppliquerFiltres);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoENSC);
            this.Controls.Add(this.resultatsRecherchePersonne);
            this.Controls.Add(this.rechercherModule);
            this.Controls.Add(this.rechercherMatiere);
            this.Controls.Add(this.titreRechercheParNomDeProjet);
            this.Controls.Add(this.nomDeProjet);
            this.Controls.Add(this.niveaux);
            this.Controls.Add(this.titreListeNiveaux);
            this.Controls.Add(this.RechercherPersonne);
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
            this.Controls.Add(this.NomRecherche);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrenomRecherche);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.Text = "ENSC Project Manager";
            ((System.ComponentModel.ISupportInitialize)(this.logoENSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox PrenomRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.TextBox NomRecherche;
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
        private System.Windows.Forms.Button RechercherPersonne;
        private System.Windows.Forms.Label titreListeNiveaux;
        private System.Windows.Forms.CheckedListBox niveaux;
        private System.Windows.Forms.CheckedListBox listeAnneePromo;
        private System.Windows.Forms.TextBox nomDeProjet;
        private System.Windows.Forms.Label titreRechercheParNomDeProjet;
        private System.Windows.Forms.CheckedListBox resultatsRecherchePersonne;
        private System.Windows.Forms.PictureBox logoENSC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AppliquerFiltres;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.Button rechercherMatiere;
        private System.Windows.Forms.Button rechercherModule;
    }
}