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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nbMinEleve = new System.Windows.Forms.NumericUpDown();
            this.nbMaxEleve = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.validerType = new System.Windows.Forms.Button();
            this.listeTypePromo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbMinEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMaxEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "nombre minimum d\'eleve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "nombre maximum d\'eleve";
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
            this.nbMinEleve.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbMinEleve.ValueChanged += new System.EventHandler(this.NbMinEleve_ValueChanged);
            // 
            // nbMaxEleve
            // 
            this.nbMaxEleve.Location = new System.Drawing.Point(358, 151);
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
            this.nbMaxEleve.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Selectionnez un type de promotion";
            // 
            // validerType
            // 
            this.validerType.Location = new System.Drawing.Point(264, 328);
            this.validerType.Name = "validerType";
            this.validerType.Size = new System.Drawing.Size(131, 23);
            this.validerType.TabIndex = 6;
            this.validerType.Text = "ajouter ce type de projet";
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "AjoutType";
            ((System.ComponentModel.ISupportInitialize)(this.nbMinEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMaxEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox listeTypePromotion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbMinEleve;
        private System.Windows.Forms.NumericUpDown nbMaxEleve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button validerType;
        private System.Windows.Forms.ListBox listeTypePromo;
    }
}