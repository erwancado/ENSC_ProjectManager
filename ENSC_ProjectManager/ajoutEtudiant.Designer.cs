namespace ENSC_ProjectManager
{
    partial class ajoutEtudiant
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
            this.nomEtudiant = new System.Windows.Forms.TextBox();
            this.prenomEtudiant = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.groupeTD = new System.Windows.Forms.Label();
            this.redoublant = new System.Windows.Forms.RadioButton();
            this.nonRedoublant = new System.Windows.Forms.RadioButton();
            this.email = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.Location = new System.Drawing.Point(284, 67);
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.Size = new System.Drawing.Size(100, 20);
            this.nomEtudiant.TabIndex = 0;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.Location = new System.Drawing.Point(284, 107);
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.Size = new System.Drawing.Size(100, 20);
            this.prenomEtudiant.TabIndex = 1;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(189, 70);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(89, 13);
            this.nom.TabIndex = 2;
            this.nom.Text = "Nom de l\'étudiant";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(175, 110);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(103, 13);
            this.prenom.TabIndex = 3;
            this.prenom.Text = "Prénom de l\'étudiant";
            // 
            // groupeTD
            // 
            this.groupeTD.AutoSize = true;
            this.groupeTD.Location = new System.Drawing.Point(216, 184);
            this.groupeTD.Name = "groupeTD";
            this.groupeTD.Size = new System.Drawing.Size(62, 13);
            this.groupeTD.TabIndex = 4;
            this.groupeTD.Text = "Redoublant";
            // 
            // redoublant
            // 
            this.redoublant.AutoSize = true;
            this.redoublant.Location = new System.Drawing.Point(284, 182);
            this.redoublant.Name = "redoublant";
            this.redoublant.Size = new System.Drawing.Size(39, 17);
            this.redoublant.TabIndex = 5;
            this.redoublant.TabStop = true;
            this.redoublant.Text = "oui";
            this.redoublant.UseVisualStyleBackColor = true;
            // 
            // nonRedoublant
            // 
            this.nonRedoublant.AutoSize = true;
            this.nonRedoublant.Checked = true;
            this.nonRedoublant.Location = new System.Drawing.Point(341, 182);
            this.nonRedoublant.Name = "nonRedoublant";
            this.nonRedoublant.Size = new System.Drawing.Size(43, 17);
            this.nonRedoublant.TabIndex = 6;
            this.nonRedoublant.TabStop = true;
            this.nonRedoublant.Text = "non";
            this.nonRedoublant.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(284, 144);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 7;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Enabled = false;
            this.mail.Location = new System.Drawing.Point(195, 147);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(83, 13);
            this.mail.TabIndex = 8;
            this.mail.Text = "Email de l\'ENSC";
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(295, 245);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 9;
            this.Valider.Text = "Valider l\'étudiant";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // ajoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nonRedoublant);
            this.Controls.Add(this.redoublant);
            this.Controls.Add(this.groupeTD);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenomEtudiant);
            this.Controls.Add(this.nomEtudiant);
            this.Name = "ajoutEtudiant";
            this.Text = "ajoutEtudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomEtudiant;
        private System.Windows.Forms.TextBox prenomEtudiant;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label groupeTD;
        private System.Windows.Forms.RadioButton redoublant;
        private System.Windows.Forms.RadioButton nonRedoublant;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Button Valider;
    }
}