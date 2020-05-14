namespace ENSC_ProjectManager
{
    partial class AjoutEtudiant
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
            this.label1 = new System.Windows.Forms.Label();
            this.anneePromo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.anneePromo)).BeginInit();
            this.SuspendLayout();
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.Location = new System.Drawing.Point(299, 67);
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.Size = new System.Drawing.Size(100, 20);
            this.nomEtudiant.TabIndex = 0;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.Location = new System.Drawing.Point(299, 107);
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.Size = new System.Drawing.Size(100, 20);
            this.prenomEtudiant.TabIndex = 1;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(189, 70);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(104, 15);
            this.nom.TabIndex = 2;
            this.nom.Text = "Nom de l\'étudiant";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(175, 110);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(121, 15);
            this.prenom.TabIndex = 3;
            this.prenom.Text = "Prénom de l\'étudiant";
            // 
            // groupeTD
            // 
            this.groupeTD.AutoSize = true;
            this.groupeTD.Location = new System.Drawing.Point(216, 184);
            this.groupeTD.Name = "groupeTD";
            this.groupeTD.Size = new System.Drawing.Size(71, 15);
            this.groupeTD.TabIndex = 4;
            this.groupeTD.Text = "Redoublant";
            // 
            // redoublant
            // 
            this.redoublant.AutoSize = true;
            this.redoublant.Location = new System.Drawing.Point(296, 181);
            this.redoublant.Name = "redoublant";
            this.redoublant.Size = new System.Drawing.Size(42, 19);
            this.redoublant.TabIndex = 5;
            this.redoublant.TabStop = true;
            this.redoublant.Text = "oui";
            this.redoublant.UseVisualStyleBackColor = true;
            // 
            // nonRedoublant
            // 
            this.nonRedoublant.AutoSize = true;
            this.nonRedoublant.Checked = true;
            this.nonRedoublant.Location = new System.Drawing.Point(353, 181);
            this.nonRedoublant.Name = "nonRedoublant";
            this.nonRedoublant.Size = new System.Drawing.Size(46, 19);
            this.nonRedoublant.TabIndex = 6;
            this.nonRedoublant.TabStop = true;
            this.nonRedoublant.Text = "non";
            this.nonRedoublant.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(299, 144);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 7;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(195, 147);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(98, 15);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Promotion";
            // 
            // anneePromo
            // 
            this.anneePromo.Location = new System.Drawing.Point(300, 216);
            this.anneePromo.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.anneePromo.Minimum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.anneePromo.Name = "anneePromo";
            this.anneePromo.Size = new System.Drawing.Size(99, 20);
            this.anneePromo.TabIndex = 11;
            this.anneePromo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anneePromo.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // AjoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anneePromo);
            this.Controls.Add(this.label1);
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
            this.Name = "AjoutEtudiant";
            this.Text = "ajoutEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.anneePromo)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown anneePromo;
    }
}