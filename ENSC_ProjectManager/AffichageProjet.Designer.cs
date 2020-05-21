namespace ENSC_ProjectManager
{
    partial class AffichageProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageProjet));
            this.NomProjet = new System.Windows.Forms.Label();
            this.Dates = new System.Windows.Forms.Label();
            this.label_participants = new System.Windows.Forms.Label();
            this.label_roles = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_matieres = new System.Windows.Forms.Label();
            this.label_livrables = new System.Windows.Forms.Label();
            this.TypeProjet = new System.Windows.Forms.Label();
            this.participantsTextBox = new System.Windows.Forms.RichTextBox();
            this.rolesTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.matieresTextBox = new System.Windows.Forms.RichTextBox();
            this.livrablesTextBox = new System.Windows.Forms.RichTextBox();
            this.RetourAccueil = new System.Windows.Forms.Button();
            this.logoENSC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoENSC)).BeginInit();
            this.SuspendLayout();
            // 
            // NomProjet
            // 
            this.NomProjet.AutoSize = true;
            this.NomProjet.Font = new System.Drawing.Font("Roboto Condensed", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomProjet.ForeColor = System.Drawing.Color.DarkOrange;
            this.NomProjet.Location = new System.Drawing.Point(575, 21);
            this.NomProjet.Name = "NomProjet";
            this.NomProjet.Size = new System.Drawing.Size(179, 33);
            this.NomProjet.TabIndex = 0;
            this.NomProjet.Text = "Nom du projet";
            // 
            // Dates
            // 
            this.Dates.AutoSize = true;
            this.Dates.Font = new System.Drawing.Font("Roboto Condensed", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dates.ForeColor = System.Drawing.Color.Orange;
            this.Dates.Location = new System.Drawing.Point(230, 74);
            this.Dates.Name = "Dates";
            this.Dates.Size = new System.Drawing.Size(59, 23);
            this.Dates.TabIndex = 1;
            this.Dates.Text = "Dates";
            // 
            // label_participants
            // 
            this.label_participants.AutoSize = true;
            this.label_participants.Font = new System.Drawing.Font("Roboto Condensed", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_participants.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_participants.Location = new System.Drawing.Point(230, 170);
            this.label_participants.Name = "label_participants";
            this.label_participants.Size = new System.Drawing.Size(101, 20);
            this.label_participants.TabIndex = 2;
            this.label_participants.Text = "Participants";
            // 
            // label_roles
            // 
            this.label_roles.AutoSize = true;
            this.label_roles.Font = new System.Drawing.Font("Roboto Condensed", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roles.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_roles.Location = new System.Drawing.Point(702, 170);
            this.label_roles.Name = "label_roles";
            this.label_roles.Size = new System.Drawing.Size(52, 20);
            this.label_roles.TabIndex = 3;
            this.label_roles.Text = "Rôles";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Roboto Condensed", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_description.Location = new System.Drawing.Point(1051, 170);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(170, 20);
            this.label_description.TabIndex = 4;
            this.label_description.Text = "Description du projet";
            // 
            // label_matieres
            // 
            this.label_matieres.AutoSize = true;
            this.label_matieres.Font = new System.Drawing.Font("Roboto Condensed", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matieres.ForeColor = System.Drawing.Color.Orange;
            this.label_matieres.Location = new System.Drawing.Point(1064, 479);
            this.label_matieres.Name = "label_matieres";
            this.label_matieres.Size = new System.Drawing.Size(169, 20);
            this.label_matieres.TabIndex = 5;
            this.label_matieres.Text = "Matières concernées";
            // 
            // label_livrables
            // 
            this.label_livrables.AutoSize = true;
            this.label_livrables.Font = new System.Drawing.Font("Roboto Condensed", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_livrables.ForeColor = System.Drawing.Color.Orange;
            this.label_livrables.Location = new System.Drawing.Point(243, 479);
            this.label_livrables.Name = "label_livrables";
            this.label_livrables.Size = new System.Drawing.Size(151, 20);
            this.label_livrables.TabIndex = 6;
            this.label_livrables.Text = "Livrables du projet";
            // 
            // TypeProjet
            // 
            this.TypeProjet.AutoSize = true;
            this.TypeProjet.Font = new System.Drawing.Font("Roboto Condensed", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeProjet.ForeColor = System.Drawing.Color.Orange;
            this.TypeProjet.Location = new System.Drawing.Point(752, 74);
            this.TypeProjet.Name = "TypeProjet";
            this.TypeProjet.Size = new System.Drawing.Size(129, 23);
            this.TypeProjet.TabIndex = 7;
            this.TypeProjet.Text = "Type de projet";
            // 
            // participantsTextBox
            // 
            this.participantsTextBox.BackColor = System.Drawing.Color.White;
            this.participantsTextBox.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantsTextBox.Location = new System.Drawing.Point(24, 193);
            this.participantsTextBox.Name = "participantsTextBox";
            this.participantsTextBox.ReadOnly = true;
            this.participantsTextBox.Size = new System.Drawing.Size(520, 269);
            this.participantsTextBox.TabIndex = 8;
            this.participantsTextBox.Text = "";
            // 
            // rolesTextBox
            // 
            this.rolesTextBox.BackColor = System.Drawing.Color.White;
            this.rolesTextBox.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesTextBox.Location = new System.Drawing.Point(642, 193);
            this.rolesTextBox.Name = "rolesTextBox";
            this.rolesTextBox.ReadOnly = true;
            this.rolesTextBox.Size = new System.Drawing.Size(172, 269);
            this.rolesTextBox.TabIndex = 9;
            this.rolesTextBox.Text = "";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(910, 193);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(433, 269);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.Text = "";
            // 
            // matieresTextBox
            // 
            this.matieresTextBox.BackColor = System.Drawing.Color.White;
            this.matieresTextBox.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matieresTextBox.Location = new System.Drawing.Point(910, 502);
            this.matieresTextBox.Name = "matieresTextBox";
            this.matieresTextBox.ReadOnly = true;
            this.matieresTextBox.Size = new System.Drawing.Size(433, 233);
            this.matieresTextBox.TabIndex = 11;
            this.matieresTextBox.Text = "";
            // 
            // livrablesTextBox
            // 
            this.livrablesTextBox.BackColor = System.Drawing.Color.White;
            this.livrablesTextBox.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrablesTextBox.Location = new System.Drawing.Point(121, 502);
            this.livrablesTextBox.Name = "livrablesTextBox";
            this.livrablesTextBox.ReadOnly = true;
            this.livrablesTextBox.Size = new System.Drawing.Size(423, 233);
            this.livrablesTextBox.TabIndex = 12;
            this.livrablesTextBox.Text = "";
            // 
            // RetourAccueil
            // 
            this.RetourAccueil.BackColor = System.Drawing.Color.Transparent;
            this.RetourAccueil.Image = global::ENSC_ProjectManager.Properties.Resources.logo_back1;
            this.RetourAccueil.Location = new System.Drawing.Point(24, 14);
            this.RetourAccueil.Name = "RetourAccueil";
            this.RetourAccueil.Size = new System.Drawing.Size(59, 57);
            this.RetourAccueil.TabIndex = 13;
            this.RetourAccueil.UseVisualStyleBackColor = false;
            this.RetourAccueil.Click += new System.EventHandler(this.RetourAccueil_Click);
            // 
            // logoENSC
            // 
            this.logoENSC.Image = global::ENSC_ProjectManager.Properties.Resources.logo_ensc;
            this.logoENSC.InitialImage = global::ENSC_ProjectManager.Properties.Resources.logo_ensc;
            this.logoENSC.Location = new System.Drawing.Point(1168, 12);
            this.logoENSC.Name = "logoENSC";
            this.logoENSC.Size = new System.Drawing.Size(184, 114);
            this.logoENSC.TabIndex = 43;
            this.logoENSC.TabStop = false;
            // 
            // AffichageProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1364, 799);
            this.Controls.Add(this.logoENSC);
            this.Controls.Add(this.RetourAccueil);
            this.Controls.Add(this.livrablesTextBox);
            this.Controls.Add(this.matieresTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.rolesTextBox);
            this.Controls.Add(this.participantsTextBox);
            this.Controls.Add(this.TypeProjet);
            this.Controls.Add(this.label_livrables);
            this.Controls.Add(this.label_matieres);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_roles);
            this.Controls.Add(this.label_participants);
            this.Controls.Add(this.Dates);
            this.Controls.Add(this.NomProjet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AffichageProjet";
            this.Text = "Détails du projet";
            ((System.ComponentModel.ISupportInitialize)(this.logoENSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomProjet;
        private System.Windows.Forms.Label Dates;
        private System.Windows.Forms.Label label_participants;
        private System.Windows.Forms.Label label_roles;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_matieres;
        private System.Windows.Forms.Label label_livrables;
        private System.Windows.Forms.Label TypeProjet;
        private System.Windows.Forms.RichTextBox participantsTextBox;
        private System.Windows.Forms.RichTextBox rolesTextBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.RichTextBox matieresTextBox;
        private System.Windows.Forms.RichTextBox livrablesTextBox;
        private System.Windows.Forms.Button RetourAccueil;
        private System.Windows.Forms.PictureBox logoENSC;
    }
}