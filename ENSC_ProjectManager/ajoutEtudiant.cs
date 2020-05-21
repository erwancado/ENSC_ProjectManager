﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    public partial class AjoutEtudiant : Form
    {
        public Etudiant ReturnEtudiant;
        public int ReturnAnneePromo;
        public AjoutEtudiant(int minAnneePromo)
        {
            InitializeComponent();
            anneePromo.Maximum = minAnneePromo + 2;
            anneePromo.Value = minAnneePromo;
            anneePromo.Minimum = minAnneePromo;
            this.CenterToParent();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if(nomEtudiant.TextLength!=0 && prenomEtudiant.TextLength != 0)
            {
                if (RegexUtilities.IsValidEmail(email.Text))
                {
                    ReturnAnneePromo = (int)anneePromo.Value;
                    ReturnEtudiant = new Etudiant(nomEtudiant.Text.Replace(' ','-'), prenomEtudiant.Text.Replace(' ', '-'), email.Text, redoublant.Checked,ReturnAnneePromo);
                    this.Visible = false;
                }

                else
                    MessageBox.Show("E-mail non valide", "L'e-mail entré est invalide.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Information manquante", "Tous les champs doivent être remplis pour continuer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
