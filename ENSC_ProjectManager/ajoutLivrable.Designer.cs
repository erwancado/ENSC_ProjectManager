namespace ENSC_ProjectManager
{
    partial class AjoutLivrable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutLivrable));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateRenduLivrable = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.listeTypeFichier = new System.Windows.Forms.ListBox();
            this.nomDuLivrable = new System.Windows.Forms.TextBox();
            this.rendu = new System.Windows.Forms.RadioButton();
            this.nonRendu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nom du livrable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Type de fichier";
            // 
            // dateRenduLivrable
            // 
            this.dateRenduLivrable.Location = new System.Drawing.Point(392, 281);
            this.dateRenduLivrable.MinDate = new System.DateTime(2020, 4, 30, 0, 0, 0, 0);
            this.dateRenduLivrable.Name = "dateRenduLivrable";
            this.dateRenduLivrable.Size = new System.Drawing.Size(200, 20);
            this.dateRenduLivrable.TabIndex = 32;
            this.dateRenduLivrable.ValueChanged += new System.EventHandler(this.DateRenduLivrable_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date de rendu";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(303, 360);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(177, 23);
            this.valider.TabIndex = 34;
            this.valider.Text = "Ajouter ce livrable";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // listeTypeFichier
            // 
            this.listeTypeFichier.FormattingEnabled = true;
            this.listeTypeFichier.Location = new System.Drawing.Point(392, 150);
            this.listeTypeFichier.Name = "listeTypeFichier";
            this.listeTypeFichier.Size = new System.Drawing.Size(120, 95);
            this.listeTypeFichier.TabIndex = 35;
            // 
            // nomDuLivrable
            // 
            this.nomDuLivrable.Location = new System.Drawing.Point(392, 97);
            this.nomDuLivrable.Name = "nomDuLivrable";
            this.nomDuLivrable.Size = new System.Drawing.Size(120, 20);
            this.nomDuLivrable.TabIndex = 36;
            this.nomDuLivrable.TextChanged += new System.EventHandler(this.NomDuLivrable_TextChanged);
            // 
            // rendu
            // 
            this.rendu.AutoSize = true;
            this.rendu.Location = new System.Drawing.Point(328, 323);
            this.rendu.Name = "rendu";
            this.rendu.Size = new System.Drawing.Size(62, 19);
            this.rendu.TabIndex = 37;
            this.rendu.TabStop = true;
            this.rendu.Text = "Rendu";
            this.rendu.UseVisualStyleBackColor = true;
            // 
            // nonRendu
            // 
            this.nonRendu.AutoSize = true;
            this.nonRendu.Location = new System.Drawing.Point(412, 323);
            this.nonRendu.Name = "nonRendu";
            this.nonRendu.Size = new System.Drawing.Size(83, 19);
            this.nonRendu.TabIndex = 38;
            this.nonRendu.TabStop = true;
            this.nonRendu.Text = "Non rendu";
            this.nonRendu.UseVisualStyleBackColor = true;
            // 
            // AjoutLivrable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nonRendu);
            this.Controls.Add(this.rendu);
            this.Controls.Add(this.nomDuLivrable);
            this.Controls.Add(this.listeTypeFichier);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateRenduLivrable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutLivrable";
            this.Text = "Ajout d\'un livrable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateRenduLivrable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.ListBox listeTypeFichier;
        private System.Windows.Forms.TextBox nomDuLivrable;
        private System.Windows.Forms.RadioButton rendu;
        private System.Windows.Forms.RadioButton nonRendu;
    }
}