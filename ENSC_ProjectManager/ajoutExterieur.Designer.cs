namespace ENSC_ProjectManager
{
    partial class AjoutExterieur
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomExte = new System.Windows.Forms.TextBox();
            this.prenomExte = new System.Windows.Forms.TextBox();
            this.mailExte = new System.Windows.Forms.TextBox();
            this.organisationExte = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Organisation";
            // 
            // nomExte
            // 
            this.nomExte.Location = new System.Drawing.Point(355, 64);
            this.nomExte.Name = "nomExte";
            this.nomExte.Size = new System.Drawing.Size(100, 20);
            this.nomExte.TabIndex = 4;
            // 
            // prenomExte
            // 
            this.prenomExte.Location = new System.Drawing.Point(355, 102);
            this.prenomExte.Name = "prenomExte";
            this.prenomExte.Size = new System.Drawing.Size(100, 20);
            this.prenomExte.TabIndex = 5;
            // 
            // mailExte
            // 
            this.mailExte.Location = new System.Drawing.Point(355, 139);
            this.mailExte.Name = "mailExte";
            this.mailExte.Size = new System.Drawing.Size(100, 20);
            this.mailExte.TabIndex = 6;
            // 
            // organisationExte
            // 
            this.organisationExte.Location = new System.Drawing.Point(355, 173);
            this.organisationExte.Name = "organisationExte";
            this.organisationExte.Size = new System.Drawing.Size(100, 20);
            this.organisationExte.TabIndex = 7;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(338, 253);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 8;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // AjoutExterieur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.organisationExte);
            this.Controls.Add(this.mailExte);
            this.Controls.Add(this.prenomExte);
            this.Controls.Add(this.nomExte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutExterieur";
            this.Text = "ajoutExterieur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomExte;
        private System.Windows.Forms.TextBox prenomExte;
        private System.Windows.Forms.TextBox mailExte;
        private System.Windows.Forms.TextBox organisationExte;
        private System.Windows.Forms.Button Valider;
    }
}