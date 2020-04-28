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
            this.listeTypeProjet = new System.Windows.Forms.ListBox();
            this.ajouterType = new System.Windows.Forms.Button();
            this.listeMatiere = new System.Windows.Forms.CheckedListBox();
            this.dateDebutProjet = new System.Windows.Forms.DateTimePicker();
            this.dateFinProjet = new System.Windows.Forms.DateTimePicker();
            this.listeEtudiants = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listePromotion = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insertEtudiant = new System.Windows.Forms.Button();
            this.affichageEtudiants = new System.Windows.Forms.RichTextBox();
            this.affichageProfesseurs = new System.Windows.Forms.RichTextBox();
            this.insertProfesseur = new System.Windows.Forms.Button();
            this.listeProfesseurs = new System.Windows.Forms.ListBox();
            this.affichageExtes = new System.Windows.Forms.RichTextBox();
            this.insertExte = new System.Windows.Forms.Button();
            this.listeExtes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ajouterLivrable = new System.Windows.Forms.Button();
            this.livrables = new System.Windows.Forms.Label();
            this.affichageLivrable = new System.Windows.Forms.RichTextBox();
            this.valider = new System.Windows.Forms.Button();
            this.nomProjet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionProjet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listeTypeProjet
            // 
            this.listeTypeProjet.FormattingEnabled = true;
            this.listeTypeProjet.Location = new System.Drawing.Point(116, 57);
            this.listeTypeProjet.Name = "listeTypeProjet";
            this.listeTypeProjet.Size = new System.Drawing.Size(120, 30);
            this.listeTypeProjet.TabIndex = 0;
            // 
            // ajouterType
            // 
            this.ajouterType.Location = new System.Drawing.Point(243, 57);
            this.ajouterType.Name = "ajouterType";
            this.ajouterType.Size = new System.Drawing.Size(121, 23);
            this.ajouterType.TabIndex = 1;
            this.ajouterType.Text = "Ajouter un type";
            this.ajouterType.UseVisualStyleBackColor = true;
            // 
            // listeMatiere
            // 
            this.listeMatiere.FormattingEnabled = true;
            this.listeMatiere.Location = new System.Drawing.Point(487, 122);
            this.listeMatiere.Name = "listeMatiere";
            this.listeMatiere.Size = new System.Drawing.Size(152, 34);
            this.listeMatiere.TabIndex = 3;
            // 
            // dateDebutProjet
            // 
            this.dateDebutProjet.Location = new System.Drawing.Point(12, 136);
            this.dateDebutProjet.Name = "dateDebutProjet";
            this.dateDebutProjet.Size = new System.Drawing.Size(168, 20);
            this.dateDebutProjet.TabIndex = 4;
            // 
            // dateFinProjet
            // 
            this.dateFinProjet.Location = new System.Drawing.Point(200, 136);
            this.dateFinProjet.Name = "dateFinProjet";
            this.dateFinProjet.Size = new System.Drawing.Size(200, 20);
            this.dateFinProjet.TabIndex = 5;
            // 
            // listeEtudiants
            // 
            this.listeEtudiants.FormattingEnabled = true;
            this.listeEtudiants.Location = new System.Drawing.Point(32, 258);
            this.listeEtudiants.Name = "listeEtudiants";
            this.listeEtudiants.Size = new System.Drawing.Size(171, 30);
            this.listeEtudiants.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Etudiants";
            // 
            // listePromotion
            // 
            this.listePromotion.FormattingEnabled = true;
            this.listePromotion.Location = new System.Drawing.Point(695, 122);
            this.listePromotion.Name = "listePromotion";
            this.listePromotion.Size = new System.Drawing.Size(120, 34);
            this.listePromotion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Professeurs";
            // 
            // insertEtudiant
            // 
            this.insertEtudiant.Location = new System.Drawing.Point(86, 295);
            this.insertEtudiant.Name = "insertEtudiant";
            this.insertEtudiant.Size = new System.Drawing.Size(117, 23);
            this.insertEtudiant.TabIndex = 11;
            this.insertEtudiant.Text = "Insertion etudiant";
            this.insertEtudiant.UseVisualStyleBackColor = true;
            // 
            // affichageEtudiants
            // 
            this.affichageEtudiants.Location = new System.Drawing.Point(32, 352);
            this.affichageEtudiants.Name = "affichageEtudiants";
            this.affichageEtudiants.ReadOnly = true;
            this.affichageEtudiants.Size = new System.Drawing.Size(171, 285);
            this.affichageEtudiants.TabIndex = 12;
            this.affichageEtudiants.Text = "";
            // 
            // affichageProfesseurs
            // 
            this.affichageProfesseurs.Location = new System.Drawing.Point(287, 352);
            this.affichageProfesseurs.Name = "affichageProfesseurs";
            this.affichageProfesseurs.ReadOnly = true;
            this.affichageProfesseurs.Size = new System.Drawing.Size(171, 285);
            this.affichageProfesseurs.TabIndex = 15;
            this.affichageProfesseurs.Text = "";
            // 
            // insertProfesseur
            // 
            this.insertProfesseur.Location = new System.Drawing.Point(317, 294);
            this.insertProfesseur.Name = "insertProfesseur";
            this.insertProfesseur.Size = new System.Drawing.Size(141, 23);
            this.insertProfesseur.TabIndex = 14;
            this.insertProfesseur.Text = "Insertion professeur";
            this.insertProfesseur.UseVisualStyleBackColor = true;
            // 
            // listeProfesseurs
            // 
            this.listeProfesseurs.FormattingEnabled = true;
            this.listeProfesseurs.Location = new System.Drawing.Point(287, 258);
            this.listeProfesseurs.Name = "listeProfesseurs";
            this.listeProfesseurs.Size = new System.Drawing.Size(171, 30);
            this.listeProfesseurs.TabIndex = 13;
            // 
            // affichageExtes
            // 
            this.affichageExtes.Location = new System.Drawing.Point(503, 352);
            this.affichageExtes.Name = "affichageExtes";
            this.affichageExtes.ReadOnly = true;
            this.affichageExtes.Size = new System.Drawing.Size(171, 285);
            this.affichageExtes.TabIndex = 19;
            this.affichageExtes.Text = "";
            // 
            // insertExte
            // 
            this.insertExte.Location = new System.Drawing.Point(533, 294);
            this.insertExte.Name = "insertExte";
            this.insertExte.Size = new System.Drawing.Size(141, 23);
            this.insertExte.TabIndex = 18;
            this.insertExte.Text = "Insertion exté";
            this.insertExte.UseVisualStyleBackColor = true;
            // 
            // listeExtes
            // 
            this.listeExtes.FormattingEnabled = true;
            this.listeExtes.Location = new System.Drawing.Point(503, 258);
            this.listeExtes.Name = "listeExtes";
            this.listeExtes.Size = new System.Drawing.Size(171, 30);
            this.listeExtes.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Intervenants extérieurs";
            // 
            // ajouterLivrable
            // 
            this.ajouterLivrable.Location = new System.Drawing.Point(773, 286);
            this.ajouterLivrable.Name = "ajouterLivrable";
            this.ajouterLivrable.Size = new System.Drawing.Size(105, 23);
            this.ajouterLivrable.TabIndex = 20;
            this.ajouterLivrable.Text = "Ajouter livrable";
            this.ajouterLivrable.UseVisualStyleBackColor = true;
            // 
            // livrables
            // 
            this.livrables.AutoSize = true;
            this.livrables.Location = new System.Drawing.Point(799, 331);
            this.livrables.Name = "livrables";
            this.livrables.Size = new System.Drawing.Size(56, 15);
            this.livrables.TabIndex = 21;
            this.livrables.Text = "Livrables";
            // 
            // affichageLivrable
            // 
            this.affichageLivrable.Location = new System.Drawing.Point(732, 352);
            this.affichageLivrable.Name = "affichageLivrable";
            this.affichageLivrable.ReadOnly = true;
            this.affichageLivrable.Size = new System.Drawing.Size(171, 285);
            this.affichageLivrable.TabIndex = 22;
            this.affichageLivrable.Text = "";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(531, 692);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(177, 23);
            this.valider.TabIndex = 23;
            this.valider.Text = "Valider et passer aux rôles";
            this.valider.UseVisualStyleBackColor = true;
            // 
            // nomProjet
            // 
            this.nomProjet.Location = new System.Drawing.Point(574, 12);
            this.nomProjet.Name = "nomProjet";
            this.nomProjet.Size = new System.Drawing.Size(100, 20);
            this.nomProjet.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nom du projet";
            // 
            // descriptionProjet
            // 
            this.descriptionProjet.Location = new System.Drawing.Point(952, 240);
            this.descriptionProjet.Name = "descriptionProjet";
            this.descriptionProjet.Size = new System.Drawing.Size(368, 397);
            this.descriptionProjet.TabIndex = 26;
            this.descriptionProjet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1080, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Description du projet";
            // 
            // CreationProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 727);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionProjet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomProjet);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.affichageLivrable);
            this.Controls.Add(this.livrables);
            this.Controls.Add(this.ajouterLivrable);
            this.Controls.Add(this.affichageExtes);
            this.Controls.Add(this.insertExte);
            this.Controls.Add(this.listeExtes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.affichageProfesseurs);
            this.Controls.Add(this.insertProfesseur);
            this.Controls.Add(this.listeProfesseurs);
            this.Controls.Add(this.affichageEtudiants);
            this.Controls.Add(this.insertEtudiant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listePromotion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeEtudiants);
            this.Controls.Add(this.dateFinProjet);
            this.Controls.Add(this.dateDebutProjet);
            this.Controls.Add(this.listeMatiere);
            this.Controls.Add(this.ajouterType);
            this.Controls.Add(this.listeTypeProjet);
            this.Name = "CreationProjet";
            this.Text = "Insérer un projet";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listePromotion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insertEtudiant;
        private System.Windows.Forms.RichTextBox affichageEtudiants;
        private System.Windows.Forms.RichTextBox affichageProfesseurs;
        private System.Windows.Forms.Button insertProfesseur;
        private System.Windows.Forms.ListBox listeProfesseurs;
        private System.Windows.Forms.RichTextBox affichageExtes;
        private System.Windows.Forms.Button insertExte;
        private System.Windows.Forms.ListBox listeExtes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ajouterLivrable;
        private System.Windows.Forms.Label livrables;
        private System.Windows.Forms.RichTextBox affichageLivrable;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox nomProjet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descriptionProjet;
        private System.Windows.Forms.Label label6;
    }
}

