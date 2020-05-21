namespace ENSC_ProjectManager
{
    partial class AjoutType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutType));
            this.label_nb_min = new System.Windows.Forms.Label();
            this.label_nb_max = new System.Windows.Forms.Label();
            this.nbMinEleve = new System.Windows.Forms.NumericUpDown();
            this.nbMaxEleve = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.validerType = new System.Windows.Forms.Button();
            this.listeTypePromo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbMinEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMaxEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nb_min
            // 
            this.label_nb_min.AutoSize = true;
            this.label_nb_min.Location = new System.Drawing.Point(167, 106);
            this.label_nb_min.Name = "label_nb_min";
            this.label_nb_min.Size = new System.Drawing.Size(171, 15);
            this.label_nb_min.TabIndex = 0;
            this.label_nb_min.Text = "Nombre minimum d\'étudiants";
            // 
            // label_nb_max
            // 
            this.label_nb_max.AutoSize = true;
            this.label_nb_max.Location = new System.Drawing.Point(164, 153);
            this.label_nb_max.Name = "label_nb_max";
            this.label_nb_max.Size = new System.Drawing.Size(174, 15);
            this.label_nb_max.TabIndex = 1;
            this.label_nb_max.Text = "Nombre maximum d\'étudiants";
            // 
            // nbMinEleve
            // 
            this.nbMinEleve.Location = new System.Drawing.Point(358, 104);
            this.nbMinEleve.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbMinEleve.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbMinEleve.Name = "nbMinEleve";
            this.nbMinEleve.Size = new System.Drawing.Size(60, 20);
            this.nbMinEleve.TabIndex = 2;
            this.nbMinEleve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbMinEleve.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbMinEleve.ValueChanged += new System.EventHandler(this.NbMinEleve_ValueChanged);
            // 
            // nbMaxEleve
            // 
            this.nbMaxEleve.Location = new System.Drawing.Point(358, 153);
            this.nbMaxEleve.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbMaxEleve.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbMaxEleve.Name = "nbMaxEleve";
            this.nbMaxEleve.Size = new System.Drawing.Size(60, 20);
            this.nbMaxEleve.TabIndex = 3;
            this.nbMaxEleve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbMaxEleve.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Selectionnez un type de promotion";
            // 
            // validerType
            // 
            this.validerType.Location = new System.Drawing.Point(264, 328);
            this.validerType.Name = "validerType";
            this.validerType.Size = new System.Drawing.Size(131, 23);
            this.validerType.TabIndex = 6;
            this.validerType.Text = "Ajouter";
            this.validerType.UseVisualStyleBackColor = true;
            this.validerType.Click += new System.EventHandler(this.ValiderType_Click);
            // 
            // listeTypePromo
            // 
            this.listeTypePromo.FormattingEnabled = true;
            this.listeTypePromo.Location = new System.Drawing.Point(358, 198);
            this.listeTypePromo.Name = "listeTypePromo";
            this.listeTypePromo.Size = new System.Drawing.Size(120, 95);
            this.listeTypePromo.TabIndex = 7;
            this.listeTypePromo.Click += new System.EventHandler(this.ListeTypePromo_Click);
            // 
            // AjoutType
            // 
            this.ClientSize = new System.Drawing.Size(685, 455);
            this.Controls.Add(this.listeTypePromo);
            this.Controls.Add(this.validerType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbMaxEleve);
            this.Controls.Add(this.nbMinEleve);
            this.Controls.Add(this.label_nb_max);
            this.Controls.Add(this.label_nb_min);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutType";
            this.Text = "Ajout d\'un type de projet";
            ((System.ComponentModel.ISupportInitialize)(this.nbMinEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMaxEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_nb_min;
        private System.Windows.Forms.Label label_nb_max;
        private System.Windows.Forms.NumericUpDown nbMinEleve;
        private System.Windows.Forms.NumericUpDown nbMaxEleve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button validerType;
        private System.Windows.Forms.ListBox listeTypePromo;
    }
}