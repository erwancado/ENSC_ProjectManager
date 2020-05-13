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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.libelle_role = new System.Windows.Forms.ComboBox();
            this.descriptionCol1 = new System.Windows.Forms.Label();
            this.descriptionCol2 = new System.Windows.Forms.Label();
            this.liste_intervenants = new System.Windows.Forms.ListBox();
            this.liste_roles = new System.Windows.Forms.ListBox();
            this.descriptionCol3 = new System.Windows.Forms.Label();
            this.ajouterRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Insérer le projet";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Retour en arrière";
            this.button5.UseVisualStyleBackColor = true;
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
            this.descriptionCol1.Location = new System.Drawing.Point(147, 80);
            this.descriptionCol1.Name = "descriptionCol1";
            this.descriptionCol1.Size = new System.Drawing.Size(73, 15);
            this.descriptionCol1.TabIndex = 13;
            this.descriptionCol1.Text = "Intervenants";
            // 
            // descriptionCol2
            // 
            this.descriptionCol2.AutoSize = true;
            this.descriptionCol2.Location = new System.Drawing.Point(495, 80);
            this.descriptionCol2.Name = "descriptionCol2";
            this.descriptionCol2.Size = new System.Drawing.Size(33, 15);
            this.descriptionCol2.TabIndex = 14;
            this.descriptionCol2.Text = "Rôle";
            // 
            // liste_intervenants
            // 
            this.liste_intervenants.FormattingEnabled = true;
            this.liste_intervenants.Location = new System.Drawing.Point(81, 117);
            this.liste_intervenants.Name = "liste_intervenants";
            this.liste_intervenants.ScrollAlwaysVisible = true;
            this.liste_intervenants.Size = new System.Drawing.Size(219, 199);
            this.liste_intervenants.TabIndex = 15;
            // 
            // liste_roles
            // 
            this.liste_roles.FormattingEnabled = true;
            this.liste_roles.Location = new System.Drawing.Point(703, 117);
            this.liste_roles.Name = "liste_roles";
            this.liste_roles.ScrollAlwaysVisible = true;
            this.liste_roles.Size = new System.Drawing.Size(219, 199);
            this.liste_roles.TabIndex = 17;
            // 
            // descriptionCol3
            // 
            this.descriptionCol3.AutoSize = true;
            this.descriptionCol3.Location = new System.Drawing.Point(797, 80);
            this.descriptionCol3.Name = "descriptionCol3";
            this.descriptionCol3.Size = new System.Drawing.Size(39, 15);
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
            // 
            // AjoutRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 399);
            this.Controls.Add(this.ajouterRole);
            this.Controls.Add(this.liste_roles);
            this.Controls.Add(this.descriptionCol3);
            this.Controls.Add(this.liste_intervenants);
            this.Controls.Add(this.descriptionCol2);
            this.Controls.Add(this.descriptionCol1);
            this.Controls.Add(this.libelle_role);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Name = "AjoutRoles";
            this.Text = "Ajout des rôles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox libelle_role;
        private System.Windows.Forms.Label descriptionCol1;
        private System.Windows.Forms.Label descriptionCol2;
        private System.Windows.Forms.ListBox liste_intervenants;
        private System.Windows.Forms.ListBox liste_roles;
        private System.Windows.Forms.Label descriptionCol3;
        private System.Windows.Forms.Button ajouterRole;
    }
}