namespace ENSC_ProjectManager
{
    partial class AjoutMatiere
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
            this.label1 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.nomMatiere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anneeEnseignement = new System.Windows.Forms.ListBox();
            this.Valider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listeProf = new System.Windows.Forms.CheckedListBox();
            this.label_module = new System.Windows.Forms.Label();
            this.liste_modules = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code de la matière";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(333, 52);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(100, 20);
            this.code.TabIndex = 1;
            // 
            // nomMatiere
            // 
            this.nomMatiere.Location = new System.Drawing.Point(333, 90);
            this.nomMatiere.Name = "nomMatiere";
            this.nomMatiere.Size = new System.Drawing.Size(100, 20);
            this.nomMatiere.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom de la matière";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Année d\'enseignement";
            // 
            // anneeEnseignement
            // 
            this.anneeEnseignement.FormattingEnabled = true;
            this.anneeEnseignement.Location = new System.Drawing.Point(333, 233);
            this.anneeEnseignement.Name = "anneeEnseignement";
            this.anneeEnseignement.Size = new System.Drawing.Size(152, 56);
            this.anneeEnseignement.TabIndex = 6;
            this.anneeEnseignement.Click += new System.EventHandler(this.AnneeEnseignement_Click);
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(333, 415);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 7;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom du/des professeurs";
            // 
            // listeProf
            // 
            this.listeProf.CheckOnClick = true;
            this.listeProf.FormattingEnabled = true;
            this.listeProf.Location = new System.Drawing.Point(333, 133);
            this.listeProf.Name = "listeProf";
            this.listeProf.ScrollAlwaysVisible = true;
            this.listeProf.Size = new System.Drawing.Size(152, 94);
            this.listeProf.Sorted = true;
            this.listeProf.TabIndex = 9;
            this.listeProf.ThreeDCheckBoxes = true;
            // 
            // label_module
            // 
            this.label_module.AutoSize = true;
            this.label_module.Location = new System.Drawing.Point(274, 304);
            this.label_module.Name = "label_module";
            this.label_module.Size = new System.Drawing.Size(49, 15);
            this.label_module.TabIndex = 10;
            this.label_module.Text = "Module";
            // 
            // liste_modules
            // 
            this.liste_modules.FormattingEnabled = true;
            this.liste_modules.Location = new System.Drawing.Point(333, 304);
            this.liste_modules.Name = "liste_modules";
            this.liste_modules.ScrollAlwaysVisible = true;
            this.liste_modules.Size = new System.Drawing.Size(152, 95);
            this.liste_modules.TabIndex = 11;
            // 
            // AjoutMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liste_modules);
            this.Controls.Add(this.label_module);
            this.Controls.Add(this.listeProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.anneeEnseignement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomMatiere);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label1);
            this.Name = "AjoutMatiere";
            this.Text = "ajoutMatiere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox nomMatiere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox anneeEnseignement;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox listeProf;
        private System.Windows.Forms.Label label_module;
        private System.Windows.Forms.ListBox liste_modules;
    }
}