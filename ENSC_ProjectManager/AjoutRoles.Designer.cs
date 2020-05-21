namespace ENSC_ProjectManager
{
    partial class AjoutRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutRoles));
            this.ValiderRoles = new System.Windows.Forms.Button();
            this.libelle_role = new System.Windows.Forms.ComboBox();
            this.descriptionCol1 = new System.Windows.Forms.Label();
            this.descriptionCol2 = new System.Windows.Forms.Label();
            this.liste_intervenants = new System.Windows.Forms.ListBox();
            this.liste_roles = new System.Windows.Forms.ListBox();
            this.descriptionCol3 = new System.Windows.Forms.Label();
            this.ajouterRole = new System.Windows.Forms.Button();
            this.retirerRole = new System.Windows.Forms.Button();
            this.RetourAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValiderRoles
            // 
            this.ValiderRoles.Font = new System.Drawing.Font("Roboto Condensed", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderRoles.ForeColor = System.Drawing.Color.DarkOrange;
            this.ValiderRoles.Location = new System.Drawing.Point(440, 348);
            this.ValiderRoles.Name = "ValiderRoles";
            this.ValiderRoles.Size = new System.Drawing.Size(154, 39);
            this.ValiderRoles.TabIndex = 9;
            this.ValiderRoles.Text = "Insérer le projet";
            this.ValiderRoles.UseVisualStyleBackColor = true;
            this.ValiderRoles.Click += new System.EventHandler(this.ValiderRoles_Click);
            // 
            // libelle_role
            // 
            this.libelle_role.FormattingEnabled = true;
            this.libelle_role.Location = new System.Drawing.Point(413, 117);
            this.libelle_role.Name = "libelle_role";
            this.libelle_role.Size = new System.Drawing.Size(198, 21);
            this.libelle_role.TabIndex = 12;
            // 
            // descriptionCol1
            // 
            this.descriptionCol1.AutoSize = true;
            this.descriptionCol1.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionCol1.ForeColor = System.Drawing.Color.DarkOrange;
            this.descriptionCol1.Location = new System.Drawing.Point(120, 80);
            this.descriptionCol1.Name = "descriptionCol1";
            this.descriptionCol1.Size = new System.Drawing.Size(90, 19);
            this.descriptionCol1.TabIndex = 13;
            this.descriptionCol1.Text = "Intervenants";
            // 
            // descriptionCol2
            // 
            this.descriptionCol2.AutoSize = true;
            this.descriptionCol2.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionCol2.ForeColor = System.Drawing.Color.Orange;
            this.descriptionCol2.Location = new System.Drawing.Point(495, 80);
            this.descriptionCol2.Name = "descriptionCol2";
            this.descriptionCol2.Size = new System.Drawing.Size(38, 19);
            this.descriptionCol2.TabIndex = 14;
            this.descriptionCol2.Text = "Rôle";
            // 
            // liste_intervenants
            // 
            this.liste_intervenants.FormattingEnabled = true;
            this.liste_intervenants.Location = new System.Drawing.Point(39, 117);
            this.liste_intervenants.Name = "liste_intervenants";
            this.liste_intervenants.ScrollAlwaysVisible = true;
            this.liste_intervenants.Size = new System.Drawing.Size(261, 199);
            this.liste_intervenants.TabIndex = 15;
            this.liste_intervenants.SelectedValueChanged += new System.EventHandler(this.liste_intervenants_SelectedValueChanged);
            // 
            // liste_roles
            // 
            this.liste_roles.FormattingEnabled = true;
            this.liste_roles.Location = new System.Drawing.Point(703, 117);
            this.liste_roles.Name = "liste_roles";
            this.liste_roles.ScrollAlwaysVisible = true;
            this.liste_roles.Size = new System.Drawing.Size(317, 199);
            this.liste_roles.TabIndex = 17;
            this.liste_roles.SelectedValueChanged += new System.EventHandler(this.liste_roles_SelectedValueChanged);
            // 
            // descriptionCol3
            // 
            this.descriptionCol3.AutoSize = true;
            this.descriptionCol3.Font = new System.Drawing.Font("Roboto Condensed", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionCol3.ForeColor = System.Drawing.Color.DarkOrange;
            this.descriptionCol3.Location = new System.Drawing.Point(832, 80);
            this.descriptionCol3.Name = "descriptionCol3";
            this.descriptionCol3.Size = new System.Drawing.Size(45, 19);
            this.descriptionCol3.TabIndex = 16;
            this.descriptionCol3.Text = "Rôles";
            // 
            // ajouterRole
            // 
            this.ajouterRole.Location = new System.Drawing.Point(452, 156);
            this.ajouterRole.Name = "ajouterRole";
            this.ajouterRole.Size = new System.Drawing.Size(131, 23);
            this.ajouterRole.TabIndex = 18;
            this.ajouterRole.Text = "Ajouter le rôle";
            this.ajouterRole.UseVisualStyleBackColor = true;
            this.ajouterRole.Click += new System.EventHandler(this.ajouterRole_Click);
            // 
            // retirerRole
            // 
            this.retirerRole.Location = new System.Drawing.Point(803, 331);
            this.retirerRole.Name = "retirerRole";
            this.retirerRole.Size = new System.Drawing.Size(108, 23);
            this.retirerRole.TabIndex = 19;
            this.retirerRole.Text = "Retirer le rôle";
            this.retirerRole.UseVisualStyleBackColor = true;
            this.retirerRole.Click += new System.EventHandler(this.retirerRole_Click);
            // 
            // RetourAccueil
            // 
            this.RetourAccueil.BackColor = System.Drawing.Color.Transparent;
            this.RetourAccueil.Image = global::ENSC_ProjectManager.Properties.Resources.logo_back1;
            this.RetourAccueil.Location = new System.Drawing.Point(12, 12);
            this.RetourAccueil.Name = "RetourAccueil";
            this.RetourAccueil.Size = new System.Drawing.Size(59, 57);
            this.RetourAccueil.TabIndex = 42;
            this.RetourAccueil.UseVisualStyleBackColor = false;
            this.RetourAccueil.Click += new System.EventHandler(this.RetourCreationProjet_Click);
            // 
            // AjoutRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 399);
            this.Controls.Add(this.RetourAccueil);
            this.Controls.Add(this.retirerRole);
            this.Controls.Add(this.ajouterRole);
            this.Controls.Add(this.liste_roles);
            this.Controls.Add(this.descriptionCol3);
            this.Controls.Add(this.liste_intervenants);
            this.Controls.Add(this.descriptionCol2);
            this.Controls.Add(this.descriptionCol1);
            this.Controls.Add(this.libelle_role);
            this.Controls.Add(this.ValiderRoles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutRoles";
            this.Text = "Ajout des rôles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ValiderRoles;
        private System.Windows.Forms.ComboBox libelle_role;
        private System.Windows.Forms.Label descriptionCol1;
        private System.Windows.Forms.Label descriptionCol2;
        private System.Windows.Forms.ListBox liste_intervenants;
        private System.Windows.Forms.ListBox liste_roles;
        private System.Windows.Forms.Label descriptionCol3;
        private System.Windows.Forms.Button ajouterRole;
        private System.Windows.Forms.Button retirerRole;
        private System.Windows.Forms.Button RetourAccueil;
    }
}