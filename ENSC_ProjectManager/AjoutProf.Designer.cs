﻿namespace ENSC_ProjectManager
{
    partial class AjoutProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutProf));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomProf = new System.Windows.Forms.TextBox();
            this.prenomProf = new System.Windows.Forms.TextBox();
            this.mailProf = new System.Windows.Forms.TextBox();
            this.titreProf = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.label_matieres = new System.Windows.Forms.Label();
            this.liste_matieres = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Titre";
            // 
            // nomProf
            // 
            this.nomProf.Location = new System.Drawing.Point(309, 114);
            this.nomProf.Name = "nomProf";
            this.nomProf.Size = new System.Drawing.Size(100, 20);
            this.nomProf.TabIndex = 4;
            // 
            // prenomProf
            // 
            this.prenomProf.Location = new System.Drawing.Point(309, 148);
            this.prenomProf.Name = "prenomProf";
            this.prenomProf.Size = new System.Drawing.Size(100, 20);
            this.prenomProf.TabIndex = 5;
            // 
            // mailProf
            // 
            this.mailProf.Location = new System.Drawing.Point(309, 182);
            this.mailProf.Name = "mailProf";
            this.mailProf.Size = new System.Drawing.Size(100, 20);
            this.mailProf.TabIndex = 6;
            // 
            // titreProf
            // 
            this.titreProf.Location = new System.Drawing.Point(309, 218);
            this.titreProf.Name = "titreProf";
            this.titreProf.Size = new System.Drawing.Size(100, 20);
            this.titreProf.TabIndex = 7;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(309, 381);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 14;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // label_matieres
            // 
            this.label_matieres.AutoSize = true;
            this.label_matieres.Location = new System.Drawing.Point(163, 260);
            this.label_matieres.Name = "label_matieres";
            this.label_matieres.Size = new System.Drawing.Size(122, 15);
            this.label_matieres.TabIndex = 15;
            this.label_matieres.Text = "Matières enseignées";
            // 
            // liste_matieres
            // 
            this.liste_matieres.CheckOnClick = true;
            this.liste_matieres.FormattingEnabled = true;
            this.liste_matieres.Location = new System.Drawing.Point(309, 260);
            this.liste_matieres.Name = "liste_matieres";
            this.liste_matieres.ScrollAlwaysVisible = true;
            this.liste_matieres.Size = new System.Drawing.Size(330, 94);
            this.liste_matieres.Sorted = true;
            this.liste_matieres.TabIndex = 16;
            this.liste_matieres.ThreeDCheckBoxes = true;
            // 
            // AjoutProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liste_matieres);
            this.Controls.Add(this.label_matieres);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.titreProf);
            this.Controls.Add(this.mailProf);
            this.Controls.Add(this.prenomProf);
            this.Controls.Add(this.nomProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutProf";
            this.Text = "Ajout d\'un professeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomProf;
        private System.Windows.Forms.TextBox prenomProf;
        private System.Windows.Forms.TextBox mailProf;
        private System.Windows.Forms.TextBox titreProf;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label label_matieres;
        private System.Windows.Forms.CheckedListBox liste_matieres;
    }
}