﻿namespace ENSC_ProjectManager
{
    partial class ajoutModule
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
            this.codeModule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.libelleModule = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code du module";
            // 
            // codeModule
            // 
            this.codeModule.Location = new System.Drawing.Point(348, 86);
            this.codeModule.MaxLength = 8;
            this.codeModule.Name = "codeModule";
            this.codeModule.Size = new System.Drawing.Size(120, 20);
            this.codeModule.TabIndex = 1;
            this.codeModule.Text = "COCLLLLC";
            this.codeModule.StyleChanged += new System.EventHandler(this.CodeModule_StyleChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libellé du module";
            // 
            // libelleModule
            // 
            this.libelleModule.Location = new System.Drawing.Point(348, 121);
            this.libelleModule.Name = "libelleModule";
            this.libelleModule.Size = new System.Drawing.Size(120, 20);
            this.libelleModule.TabIndex = 3;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(310, 193);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 13;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // ajoutModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.libelleModule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeModule);
            this.Controls.Add(this.label1);
            this.Name = "ajoutModule";
            this.Text = "ajoutModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox libelleModule;
        private System.Windows.Forms.Button Valider;
    }
}