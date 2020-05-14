namespace ENSC_ProjectManager
{
    partial class CreationProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationProjet));
            this.listeTypeProjet = new System.Windows.Forms.ListBox();
            this.ajouterType = new System.Windows.Forms.Button();
            this.listeMatiere = new System.Windows.Forms.CheckedListBox();
            this.dateDebutProjet = new System.Windows.Forms.DateTimePicker();
            this.dateFinProjet = new System.Windows.Forms.DateTimePicker();
            this.listeEtudiants = new System.Windows.Forms.ListBox();
            this.label_etu = new System.Windows.Forms.Label();
            this.listePromotion = new System.Windows.Forms.CheckedListBox();
            this.label_profs = new System.Windows.Forms.Label();
            this.insertEtudiant = new System.Windows.Forms.Button();
            this.insertProfesseur = new System.Windows.Forms.Button();
            this.listeProfesseurs = new System.Windows.Forms.ListBox();
            this.insertExte = new System.Windows.Forms.Button();
            this.listeExtes = new System.Windows.Forms.ListBox();
            this.label_exte = new System.Windows.Forms.Label();
            this.ajouterLivrable = new System.Windows.Forms.Button();
            this.label_livrables = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.nomProjet = new System.Windows.Forms.TextBox();
            this.label_nom_projet = new System.Windows.Forms.Label();
            this.descriptionProjet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.retirerEtudiant = new System.Windows.Forms.Button();
            this.retirerProfesseur = new System.Windows.Forms.Button();
            this.affichageEtudiants = new System.Windows.Forms.ListBox();
            this.affichageProfesseurs = new System.Windows.Forms.ListBox();
            this.affichageExtes = new System.Windows.Forms.ListBox();
            this.affichageLivrables = new System.Windows.Forms.ListBox();
            this.ajouterEtudiant = new System.Windows.Forms.Button();
            this.ajouterProfesseur = new System.Windows.Forms.Button();
            this.ajouterExte = new System.Windows.Forms.Button();
            this.retirerExte = new System.Windows.Forms.Button();
            this.retirerLivrable = new System.Windows.Forms.Button();
            this.ajoutMatiere = new System.Windows.Forms.Button();
            this.logoENSC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoENSC)).BeginInit();
            this.SuspendLayout();
            // 
            // listeTypeProjet
            // 
            this.listeTypeProjet.FormattingEnabled = true;
            this.listeTypeProjet.Location = new System.Drawing.Point(12, 44);
            this.listeTypeProjet.Name = "listeTypeProjet";
            this.listeTypeProjet.ScrollAlwaysVisible = true;
            this.listeTypeProjet.Size = new System.Drawing.Size(224, 56);
            this.listeTypeProjet.TabIndex = 0;
            this.listeTypeProjet.SelectedValueChanged += new System.EventHandler(this.ListeTypeProjet_SelectedValueChanged);
            // 
            // ajouterType
            // 
            this.ajouterType.Location = new System.Drawing.Point(243, 57);
            this.ajouterType.Name = "ajouterType";
            this.ajouterType.Size = new System.Drawing.Size(121, 23);
            this.ajouterType.TabIndex = 1;
            this.ajouterType.Text = "Ajouter un type";
            this.ajouterType.UseVisualStyleBackColor = true;
            this.ajouterType.Click += new System.EventHandler(this.ajouterType_Click);
            // 
            // listeMatiere
            // 
            this.listeMatiere.FormattingEnabled = true;
            this.listeMatiere.Location = new System.Drawing.Point(732, 92);
            this.listeMatiere.Name = "listeMatiere";
            this.listeMatiere.ScrollAlwaysVisible = true;
            this.listeMatiere.Size = new System.Drawing.Size(372, 109);
            this.listeMatiere.TabIndex = 3;
            this.listeMatiere.SelectedValueChanged += new System.EventHandler(this.ListeMatiere_SelectedValueChanged);
            // 
            // dateDebutProjet
            // 
            this.dateDebutProjet.Location = new System.Drawing.Point(12, 136);
            this.dateDebutProjet.Name = "dateDebutProjet";
            this.dateDebutProjet.Size = new System.Drawing.Size(168, 20);
            this.dateDebutProjet.TabIndex = 4;
            this.dateDebutProjet.Validating += new System.ComponentModel.CancelEventHandler(this.DateDebutProjet_Validating);
            // 
            // dateFinProjet
            // 
            this.dateFinProjet.Location = new System.Drawing.Point(200, 136);
            this.dateFinProjet.Name = "dateFinProjet";
            this.dateFinProjet.Size = new System.Drawing.Size(200, 20);
            this.dateFinProjet.TabIndex = 5;
            this.dateFinProjet.Validating += new System.ComponentModel.CancelEventHandler(this.DateFinProjet_Validating);
            // 
            // listeEtudiants
            // 
            this.listeEtudiants.FormattingEnabled = true;
            this.listeEtudiants.Location = new System.Drawing.Point(32, 258);
            this.listeEtudiants.Name = "listeEtudiants";
            this.listeEtudiants.ScrollAlwaysVisible = true;
            this.listeEtudiants.Size = new System.Drawing.Size(171, 30);
            this.listeEtudiants.TabIndex = 6;
            this.listeEtudiants.SelectedValueChanged += new System.EventHandler(this.listeEtudiants_SelectedValueChanged);
            // 
            // label_etu
            // 
            this.label_etu.AutoSize = true;
            this.label_etu.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_etu.Location = new System.Drawing.Point(78, 237);
            this.label_etu.Name = "label_etu";
            this.label_etu.Size = new System.Drawing.Size(68, 17);
            this.label_etu.TabIndex = 7;
            this.label_etu.Text = "Etudiants";
            // 
            // listePromotion
            // 
            this.listePromotion.CheckOnClick = true;
            this.listePromotion.FormattingEnabled = true;
            this.listePromotion.Location = new System.Drawing.Point(476, 122);
            this.listePromotion.Name = "listePromotion";
            this.listePromotion.ScrollAlwaysVisible = true;
            this.listePromotion.Size = new System.Drawing.Size(120, 34);
            this.listePromotion.TabIndex = 8;
            this.listePromotion.SelectedValueChanged += new System.EventHandler(this.ListePromotion_SelectedValueChanged);
            // 
            // label_profs
            // 
            this.label_profs.AutoSize = true;
            this.label_profs.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profs.Location = new System.Drawing.Point(334, 237);
            this.label_profs.Name = "label_profs";
            this.label_profs.Size = new System.Drawing.Size(83, 17);
            this.label_profs.TabIndex = 9;
            this.label_profs.Text = "Professeurs";
            // 
            // insertEtudiant
            // 
            this.insertEtudiant.Location = new System.Drawing.Point(52, 294);
            this.insertEtudiant.Name = "insertEtudiant";
            this.insertEtudiant.Size = new System.Drawing.Size(117, 23);
            this.insertEtudiant.TabIndex = 11;
            this.insertEtudiant.Text = "Inserer etudiant";
            this.insertEtudiant.UseVisualStyleBackColor = true;
            this.insertEtudiant.Click += new System.EventHandler(this.insertEtudiant_Click);
            // 
            // insertProfesseur
            // 
            this.insertProfesseur.Location = new System.Drawing.Point(302, 294);
            this.insertProfesseur.Name = "insertProfesseur";
            this.insertProfesseur.Size = new System.Drawing.Size(141, 23);
            this.insertProfesseur.TabIndex = 14;
            this.insertProfesseur.Text = "Inserer professeur";
            this.insertProfesseur.UseVisualStyleBackColor = true;
            this.insertProfesseur.Click += new System.EventHandler(this.insertProfesseur_Click);
            // 
            // listeProfesseurs
            // 
            this.listeProfesseurs.FormattingEnabled = true;
            this.listeProfesseurs.Location = new System.Drawing.Point(287, 258);
            this.listeProfesseurs.Name = "listeProfesseurs";
            this.listeProfesseurs.ScrollAlwaysVisible = true;
            this.listeProfesseurs.Size = new System.Drawing.Size(171, 30);
            this.listeProfesseurs.TabIndex = 13;
            this.listeProfesseurs.SelectedValueChanged += new System.EventHandler(this.listeProfesseurs_SelectedValueChanged);
            // 
            // insertExte
            // 
            this.insertExte.Location = new System.Drawing.Point(517, 294);
            this.insertExte.Name = "insertExte";
            this.insertExte.Size = new System.Drawing.Size(141, 23);
            this.insertExte.TabIndex = 18;
            this.insertExte.Text = "Inserer intervenant";
            this.insertExte.UseVisualStyleBackColor = true;
            this.insertExte.Click += new System.EventHandler(this.insertExte_Click);
            // 
            // listeExtes
            // 
            this.listeExtes.FormattingEnabled = true;
            this.listeExtes.Location = new System.Drawing.Point(503, 258);
            this.listeExtes.Name = "listeExtes";
            this.listeExtes.ScrollAlwaysVisible = true;
            this.listeExtes.Size = new System.Drawing.Size(171, 30);
            this.listeExtes.TabIndex = 17;
            this.listeExtes.SelectedValueChanged += new System.EventHandler(this.listeExtes_SelectedValueChanged);
            // 
            // label_exte
            // 
            this.label_exte.AutoSize = true;
            this.label_exte.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exte.Location = new System.Drawing.Point(514, 237);
            this.label_exte.Name = "label_exte";
            this.label_exte.Size = new System.Drawing.Size(151, 17);
            this.label_exte.TabIndex = 16;
            this.label_exte.Text = "Intervenants extérieurs";
            // 
            // ajouterLivrable
            // 
            this.ajouterLivrable.Location = new System.Drawing.Point(833, 286);
            this.ajouterLivrable.Name = "ajouterLivrable";
            this.ajouterLivrable.Size = new System.Drawing.Size(105, 23);
            this.ajouterLivrable.TabIndex = 20;
            this.ajouterLivrable.Text = "Ajouter livrable";
            this.ajouterLivrable.UseVisualStyleBackColor = true;
            this.ajouterLivrable.Click += new System.EventHandler(this.ajouterLivrable_Click);
            // 
            // label_livrables
            // 
            this.label_livrables.AutoSize = true;
            this.label_livrables.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_livrables.Location = new System.Drawing.Point(858, 330);
            this.label_livrables.Name = "label_livrables";
            this.label_livrables.Size = new System.Drawing.Size(64, 17);
            this.label_livrables.TabIndex = 21;
            this.label_livrables.Text = "Livrables";
            // 
            // valider
            // 
            this.valider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.valider.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Location = new System.Drawing.Point(531, 689);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(197, 37);
            this.valider.TabIndex = 23;
            this.valider.Text = "Valider et passer aux rôles";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // nomProjet
            // 
            this.nomProjet.Location = new System.Drawing.Point(575, 15);
            this.nomProjet.Name = "nomProjet";
            this.nomProjet.Size = new System.Drawing.Size(241, 20);
            this.nomProjet.TabIndex = 24;
            // 
            // label_nom_projet
            // 
            this.label_nom_projet.AutoSize = true;
            this.label_nom_projet.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom_projet.Location = new System.Drawing.Point(473, 18);
            this.label_nom_projet.Name = "label_nom_projet";
            this.label_nom_projet.Size = new System.Drawing.Size(96, 17);
            this.label_nom_projet.TabIndex = 25;
            this.label_nom_projet.Text = "Nom du projet";
            // 
            // descriptionProjet
            // 
            this.descriptionProjet.Location = new System.Drawing.Point(1062, 242);
            this.descriptionProjet.Name = "descriptionProjet";
            this.descriptionProjet.Size = new System.Drawing.Size(368, 397);
            this.descriptionProjet.TabIndex = 26;
            this.descriptionProjet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1191, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Description du projet";
            // 
            // retirerEtudiant
            // 
            this.retirerEtudiant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.retirerEtudiant.Location = new System.Drawing.Point(52, 645);
            this.retirerEtudiant.Name = "retirerEtudiant";
            this.retirerEtudiant.Size = new System.Drawing.Size(117, 23);
            this.retirerEtudiant.TabIndex = 29;
            this.retirerEtudiant.Text = "Retirer";
            this.retirerEtudiant.UseVisualStyleBackColor = true;
            this.retirerEtudiant.Click += new System.EventHandler(this.retirerEtudiant_Click);
            // 
            // retirerProfesseur
            // 
            this.retirerProfesseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.retirerProfesseur.Location = new System.Drawing.Point(315, 645);
            this.retirerProfesseur.Name = "retirerProfesseur";
            this.retirerProfesseur.Size = new System.Drawing.Size(117, 23);
            this.retirerProfesseur.TabIndex = 30;
            this.retirerProfesseur.Text = "Retirer";
            this.retirerProfesseur.UseVisualStyleBackColor = true;
            this.retirerProfesseur.Click += new System.EventHandler(this.retirerProfesseur_Click);
            // 
            // affichageEtudiants
            // 
            this.affichageEtudiants.FormattingEnabled = true;
            this.affichageEtudiants.Location = new System.Drawing.Point(32, 362);
            this.affichageEtudiants.Name = "affichageEtudiants";
            this.affichageEtudiants.Size = new System.Drawing.Size(171, 277);
            this.affichageEtudiants.TabIndex = 31;
            this.affichageEtudiants.SelectedValueChanged += new System.EventHandler(this.affichageEtudiants_SelectedValueChanged);
            // 
            // affichageProfesseurs
            // 
            this.affichageProfesseurs.FormattingEnabled = true;
            this.affichageProfesseurs.Location = new System.Drawing.Point(287, 362);
            this.affichageProfesseurs.Name = "affichageProfesseurs";
            this.affichageProfesseurs.Size = new System.Drawing.Size(171, 277);
            this.affichageProfesseurs.TabIndex = 32;
            this.affichageProfesseurs.SelectedValueChanged += new System.EventHandler(this.affichageProfesseurs_SelectedValueChanged);
            // 
            // affichageExtes
            // 
            this.affichageExtes.FormattingEnabled = true;
            this.affichageExtes.Location = new System.Drawing.Point(503, 362);
            this.affichageExtes.Name = "affichageExtes";
            this.affichageExtes.Size = new System.Drawing.Size(171, 277);
            this.affichageExtes.TabIndex = 33;
            this.affichageExtes.SelectedValueChanged += new System.EventHandler(this.affichageExtes_SelectedValueChanged);
            // 
            // affichageLivrables
            // 
            this.affichageLivrables.FormattingEnabled = true;
            this.affichageLivrables.Location = new System.Drawing.Point(755, 362);
            this.affichageLivrables.Name = "affichageLivrables";
            this.affichageLivrables.Size = new System.Drawing.Size(265, 277);
            this.affichageLivrables.TabIndex = 34;
            this.affichageLivrables.SelectedValueChanged += new System.EventHandler(this.affichageLivrables_SelectedValueChanged);
            // 
            // ajouterEtudiant
            // 
            this.ajouterEtudiant.Location = new System.Drawing.Point(52, 324);
            this.ajouterEtudiant.Name = "ajouterEtudiant";
            this.ajouterEtudiant.Size = new System.Drawing.Size(117, 23);
            this.ajouterEtudiant.TabIndex = 35;
            this.ajouterEtudiant.Text = "Ajouter un étudiant";
            this.ajouterEtudiant.UseVisualStyleBackColor = true;
            this.ajouterEtudiant.Click += new System.EventHandler(this.ajouterEtudiant_Click);
            // 
            // ajouterProfesseur
            // 
            this.ajouterProfesseur.Location = new System.Drawing.Point(302, 326);
            this.ajouterProfesseur.Name = "ajouterProfesseur";
            this.ajouterProfesseur.Size = new System.Drawing.Size(141, 23);
            this.ajouterProfesseur.TabIndex = 36;
            this.ajouterProfesseur.Text = "Ajouter un professeur";
            this.ajouterProfesseur.UseVisualStyleBackColor = true;
            this.ajouterProfesseur.Click += new System.EventHandler(this.ajouterProfesseur_Click);
            // 
            // ajouterExte
            // 
            this.ajouterExte.Location = new System.Drawing.Point(517, 326);
            this.ajouterExte.Name = "ajouterExte";
            this.ajouterExte.Size = new System.Drawing.Size(141, 23);
            this.ajouterExte.TabIndex = 37;
            this.ajouterExte.Text = "Ajouter un intervenant";
            this.ajouterExte.UseVisualStyleBackColor = true;
            this.ajouterExte.Click += new System.EventHandler(this.ajouterExte_Click);
            // 
            // retirerExte
            // 
            this.retirerExte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.retirerExte.Location = new System.Drawing.Point(531, 645);
            this.retirerExte.Name = "retirerExte";
            this.retirerExte.Size = new System.Drawing.Size(117, 23);
            this.retirerExte.TabIndex = 38;
            this.retirerExte.Text = "Retirer";
            this.retirerExte.UseVisualStyleBackColor = true;
            this.retirerExte.Click += new System.EventHandler(this.retirerExte_Click);
            // 
            // retirerLivrable
            // 
            this.retirerLivrable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.retirerLivrable.Location = new System.Drawing.Point(833, 645);
            this.retirerLivrable.Name = "retirerLivrable";
            this.retirerLivrable.Size = new System.Drawing.Size(117, 23);
            this.retirerLivrable.TabIndex = 39;
            this.retirerLivrable.Text = "Retirer";
            this.retirerLivrable.UseVisualStyleBackColor = true;
            this.retirerLivrable.Click += new System.EventHandler(this.retirerLivrable_Click);
            // 
            // ajoutMatiere
            // 
            this.ajoutMatiere.Location = new System.Drawing.Point(1124, 132);
            this.ajoutMatiere.Name = "ajoutMatiere";
            this.ajoutMatiere.Size = new System.Drawing.Size(130, 23);
            this.ajoutMatiere.TabIndex = 40;
            this.ajoutMatiere.Text = "Ajouter une matière";
            this.ajoutMatiere.UseVisualStyleBackColor = true;
            this.ajoutMatiere.Click += new System.EventHandler(this.ajoutMatiere_Click);
            // 
            // logoENSC
            // 
            this.logoENSC.Image = global::ENSC_ProjectManager.Properties.Resources.logo_ensc;
            this.logoENSC.InitialImage = global::ENSC_ProjectManager.Properties.Resources.logo_ensc;
            this.logoENSC.Location = new System.Drawing.Point(1272, 3);
            this.logoENSC.Name = "logoENSC";
            this.logoENSC.Size = new System.Drawing.Size(184, 114);
            this.logoENSC.TabIndex = 41;
            this.logoENSC.TabStop = false;
            // 
            // CreationProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 727);
            this.Controls.Add(this.logoENSC);
            this.Controls.Add(this.ajoutMatiere);
            this.Controls.Add(this.retirerLivrable);
            this.Controls.Add(this.retirerExte);
            this.Controls.Add(this.ajouterExte);
            this.Controls.Add(this.ajouterProfesseur);
            this.Controls.Add(this.ajouterEtudiant);
            this.Controls.Add(this.affichageLivrables);
            this.Controls.Add(this.affichageExtes);
            this.Controls.Add(this.affichageProfesseurs);
            this.Controls.Add(this.affichageEtudiants);
            this.Controls.Add(this.retirerProfesseur);
            this.Controls.Add(this.retirerEtudiant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionProjet);
            this.Controls.Add(this.label_nom_projet);
            this.Controls.Add(this.nomProjet);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.label_livrables);
            this.Controls.Add(this.ajouterLivrable);
            this.Controls.Add(this.insertExte);
            this.Controls.Add(this.listeExtes);
            this.Controls.Add(this.label_exte);
            this.Controls.Add(this.insertProfesseur);
            this.Controls.Add(this.listeProfesseurs);
            this.Controls.Add(this.insertEtudiant);
            this.Controls.Add(this.label_profs);
            this.Controls.Add(this.listePromotion);
            this.Controls.Add(this.label_etu);
            this.Controls.Add(this.listeEtudiants);
            this.Controls.Add(this.dateFinProjet);
            this.Controls.Add(this.dateDebutProjet);
            this.Controls.Add(this.listeMatiere);
            this.Controls.Add(this.ajouterType);
            this.Controls.Add(this.listeTypeProjet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreationProjet";
            this.Text = "Insérer un projet";
            ((System.ComponentModel.ISupportInitialize)(this.logoENSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listeTypeProjet;
        private System.Windows.Forms.Button ajouterType;
        private System.Windows.Forms.CheckedListBox listeMatiere;
        private System.Windows.Forms.DateTimePicker dateDebutProjet;
        private System.Windows.Forms.DateTimePicker dateFinProjet;
        private System.Windows.Forms.ListBox listeEtudiants;
        private System.Windows.Forms.Label label_etu;
        private System.Windows.Forms.CheckedListBox listePromotion;
        private System.Windows.Forms.Label label_profs;
        private System.Windows.Forms.Button insertEtudiant;
        private System.Windows.Forms.Button insertProfesseur;
        private System.Windows.Forms.ListBox listeProfesseurs;
        private System.Windows.Forms.Button insertExte;
        private System.Windows.Forms.ListBox listeExtes;
        private System.Windows.Forms.Label label_exte;
        private System.Windows.Forms.Button ajouterLivrable;
        private System.Windows.Forms.Label label_livrables;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox nomProjet;
        private System.Windows.Forms.Label label_nom_projet;
        private System.Windows.Forms.RichTextBox descriptionProjet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button retirerEtudiant;
        private System.Windows.Forms.Button retirerProfesseur;
        private System.Windows.Forms.ListBox affichageEtudiants;
        private System.Windows.Forms.ListBox affichageProfesseurs;
        private System.Windows.Forms.ListBox affichageExtes;
        private System.Windows.Forms.ListBox affichageLivrables;
        private System.Windows.Forms.Button ajouterEtudiant;
        private System.Windows.Forms.Button ajouterProfesseur;
        private System.Windows.Forms.Button ajouterExte;
        private System.Windows.Forms.Button retirerExte;
        private System.Windows.Forms.Button retirerLivrable;
        private System.Windows.Forms.Button ajoutMatiere;
        private System.Windows.Forms.PictureBox logoENSC;
    }
}

