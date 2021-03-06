﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    /// <summary>
    /// Formulaire d'ajout d'une matière
    /// </summary>
    public partial class AjoutMatiere : Form
    {
        public Matiere ReturnMatiere;
        public Module ReturnModule; // Module auquel la matière sera associée
        private Repertoire Repertoire;

        public AjoutMatiere(Repertoire repertoire)
        {
            InitializeComponent();
            Repertoire = repertoire;
            anneeEnseignement.Items.Add("1A");
            anneeEnseignement.Items.Add("2A");
            anneeEnseignement.Items.Add("3A");
            RemplirProfesseurs();
            RemplirModules("");
            this.CenterToParent();
        }

        /// <summary>
        /// Vérifie que tous les champs sont remplis correctement avant de créer la matière
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, EventArgs e)
        {
            if (code.TextLength == 8)
            {
                if (nomMatiere.TextLength != 0)
                {
                    if (liste_modules.SelectedItem != null)
                    {
                        if (anneeEnseignement.SelectedItem != null)
                        {
                            List<Professeur> enseignants = new List<Professeur>();
                            for (int i = 0; i < listeProf.CheckedItems.Count; i++)
                            {
                                string nom = listeProf.CheckedItems[i].ToString().Split(' ')[0];
                                string prenom = listeProf.CheckedItems[i].ToString().Split(' ')[1];
                                Professeur professeur = Repertoire.GetProfesseur(nom, prenom);
                                if (professeur != null)
                                    enseignants.Add(professeur);
                            }
                            ReturnModule = Repertoire.GetModule(liste_modules.SelectedItem.ToString().Split('-')[0]);
                            ReturnMatiere = new Matiere(code.Text, nomMatiere.Text, anneeEnseignement.SelectedItem.ToString());
                            ReturnMatiere.AjouterProfesseur(enseignants.ToArray());
                            ReturnModule.AjouterMatiere(ReturnMatiere);
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Année d'enseignement manquante", "Veuillez sélectionner une année d'enseignement.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Module manquant", "Veuillez sélectionner le module de la matière.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Nom de la matière manquant", "Veuilez renseigner le nom de la matière.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Code invalide", "Le code saisi pour la matière est invalide.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AnneeEnseignement_Click(object sender, EventArgs e)
        {
            if (code.Text.Length > 0 && nomMatiere.Text.Length > 0 && listeProf.SelectedItems.Count > 0)
                Valider.Enabled = true;
        }
        private void RemplirProfesseurs()
        {
            listeProf.BeginUpdate();
            listeProf.Items.Clear();
            foreach (Professeur professeur in Repertoire.professeurs)
            {
                listeProf.Items.Add(professeur.Nom + " " + professeur.Prenom);
            }
            listeProf.EndUpdate();
        }

        /// <summary>
        /// Remplit la liste des modules correspondant au type de promotion choisi
        /// </summary>
        /// <param name="promo">type de promotion</param>
        private void RemplirModules(string promo)
        {
            liste_modules.BeginUpdate();
            liste_modules.Items.Clear();
            if (promo.Equals(""))
            {
                foreach (Module module in Repertoire.modules)
                {
                    liste_modules.Items.Add(module.Code + "-" + module.Libelle);
                }
            }
            else
            {
                foreach (Module module in Repertoire.modules)
                {
                    if (module.Promo.Equals(promo))
                        liste_modules.Items.Add(module.Code + "-" + module.Libelle);
                }
            }
            liste_modules.EndUpdate();
        }

        private void anneeEnseignement_SelectedValueChanged(object sender, EventArgs e)
        {
            RemplirModules(anneeEnseignement.SelectedItem.ToString());
        }
    }
}
