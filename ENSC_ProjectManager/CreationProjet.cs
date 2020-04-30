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
    public partial class CreationProjet : Form
    {
        Repertoire repertoire;
        public CreationProjet(Repertoire repertoire)
        {
            InitializeComponent();
            this.repertoire = repertoire;
            dateDebutProjet.Enabled = false;
            dateFinProjet.Enabled = false;
            listeMatiere.Enabled = false;
            listePromotion.Enabled = false;
            listeEtudiants.Enabled = false;
            listeProfesseurs.Enabled = false;
            listeExtes.Enabled = false;
            insertExte.Hide();
            insertProfesseur.Hide();
            insertEtudiant.Hide();
            retirerEtudiant.Hide();
            retirerProfesseur.Hide();
            retirerExte.Hide();
            retirerLivrable.Hide();
            ajouterLivrable.Enabled = false;
            RemplirTypesProjet();
        }
        private void RemplirTypesProjet()
        {
            listeTypeProjet.BeginUpdate();
            listeTypeProjet.Items.Clear();
            foreach (Type type in repertoire.typesProjet)
            {
                listeTypeProjet.Items.Add("Projet " + type.TypePromotion.ToUpper() + " de " + type.NbMinEtudiants + " à " + type.NbMaxEtudiants + " étudiants");
            }
            listeTypeProjet.EndUpdate();
        }
        private void RemplirEtudiants(int[] anneePromos)
        {
            listeEtudiants.BeginUpdate();
            listeEtudiants.Items.Clear();
            foreach (int annee in anneePromos)
            {
                Promotion promotion = repertoire.GetPromotion(annee);
                if (promotion != null)
                {
                    foreach (Etudiant etudiant in promotion.Etudiants)
                    {
                        listeEtudiants.Items.Add(etudiant.Nom + " " + etudiant.Prenom+" - promotion "+etudiant.Promotion.Annee);
                    }
                }
            }
            listeEtudiants.EndUpdate();
        }
        private void RemplirPromos(string[] promotions)
        {
            listePromotion.BeginUpdate();
            listePromotion.Items.Clear();
            foreach (string promotion in promotions)
            {
                listePromotion.Items.Add(promotion);
            }
            listePromotion.EndUpdate();
        }
        private void RemplirMatieres(string[] promotion)
        {
            listeMatiere.BeginUpdate();
            listeMatiere.Items.Clear();
            foreach (Matiere matiere in repertoire.matieres)
            {
                if (promotion.Contains(matiere.Promo))
                {
                    listeMatiere.Items.Add(matiere.Code + "-" + matiere.Libelle);
                }
            }
            listeMatiere.EndUpdate();
        }
        private void RemplirProfesseurs(Matiere[] matieres)
        {
            listeProfesseurs.BeginUpdate();
            listeProfesseurs.Items.Clear();
            foreach (Matiere matiere in matieres)
            {
                foreach (Professeur professeur in matiere.ListeProfesseurs)
                {
                    listeProfesseurs.Items.Add(professeur.Nom + " " + professeur.Prenom);
                }
            }
            listeProfesseurs.EndUpdate();
        }
        private void RemplirExtes()
        {
            listeExtes.BeginUpdate();
            listeExtes.Items.Clear();
            foreach (Exterieur exterieur in repertoire.intervenantsExte)
            {
                listeExtes.Items.Add(exterieur.Nom + " " + exterieur.Prenom + " - " + exterieur.Organisation);
            }
        }
        private int AnneePromo(string promotion)
        {
            int result = -1;
            if (promotion.Equals("1A"))
            {
                result = dateDebutProjet.Value.Month > 8 ? dateDebutProjet.Value.Year + 3 : dateDebutProjet.Value.Year + 2;
            }
            else if (promotion.Equals("2A"))
            {
                result = dateDebutProjet.Value.Month > 8 ? dateDebutProjet.Value.Year + 2 : dateDebutProjet.Value.Year + 1;
            }
            else
            {
                result = dateDebutProjet.Value.Month > 8 ? dateDebutProjet.Value.Year + 1 : dateDebutProjet.Value.Year;
            }
            return result;
        }

        private void DateDebutProjet_Validating(object sender, CancelEventArgs e)
        {
            DatesValidation();
            ajouterLivrable.Enabled = true;
        }
        private void DateFinProjet_Validating(object sender, CancelEventArgs e)
        {
            DatesValidation();
            ajouterLivrable.Enabled = true;
        }

        private void ListeTypeProjet_SelectedValueChanged(object sender, EventArgs e)
        {
            dateDebutProjet.Enabled = true;
            dateFinProjet.Enabled = true;
            listePromotion.Enabled = true;
            listeMatiere.Enabled = true;
            string libPromo = listeTypeProjet.SelectedItem.ToString().Split(' ')[1];
            string[] promotions = GetPromotions(libPromo);
            RemplirPromos(promotions);
            RemplirMatieres(promotions);
        }

        private string[] GetPromotions(string libPromo)
        {
            if (libPromo.Equals("TRANSPROMO") || libPromo.Equals("TRANSPROMOTION"))
            {
                return new string[] { "1A", "2A" };
            }
            else if (libPromo.Equals("1A") || libPromo.Equals("2A") || libPromo.Equals("3A"))
            {
                return new string[] { libPromo };
            }
            else
            {
                return new string[] { "1A", "2A", "3A" };
            }
        }

        private void ListePromotion_SelectedValueChanged(object sender, EventArgs e)
        {
            List<string> promotions = new List<string>();
            List<int> anneesPromos = new List<int>();
            for (int i = 0; i < listePromotion.CheckedItems.Count; i++)
            {
                string promo = listePromotion.CheckedItems[i].ToString();
                promotions.Add(promo);
                anneesPromos.Add(AnneePromo(promo));
            }
            RemplirMatieres(promotions.ToArray());
            listeEtudiants.Enabled = true;
            RemplirEtudiants(anneesPromos.ToArray());
        }

        private void ListeMatiere_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Matiere> matieres = new List<Matiere>();
            for (int i = 0; i < listeMatiere.CheckedItems.Count; i++)
            {
                string code = listeMatiere.CheckedItems[i].ToString().Split('-')[0];
                Matiere matiere = repertoire.GetMatiere(code);
                if (matiere != null)
                    matieres.Add(matiere);
            }
            listeProfesseurs.Enabled = true;
            listeExtes.Enabled = true;
            RemplirProfesseurs(matieres.ToArray());
            RemplirExtes();
        }

       
        private void DatesValidation()
        {
            if (dateDebutProjet.Value > dateFinProjet.Value)
            {
                dateFinProjet.Value = dateDebutProjet.Value.AddDays(1);
            }
            else if (dateDebutProjet.Value.Month > 8)
            {
                if (DateTimeSpan.CompareDates(dateDebutProjet.Value, dateFinProjet.Value).Months > (18 - dateDebutProjet.Value.Month))
                {
                    dateFinProjet.Value = dateDebutProjet.Value.AddMonths(18 - dateDebutProjet.Value.Month);
                }
            }
            else if (dateDebutProjet.Value.Month < 7)
            {
                if (DateTimeSpan.CompareDates(dateDebutProjet.Value, dateFinProjet.Value).Months > (7 - dateDebutProjet.Value.Month))
                {
                    dateFinProjet.Value = dateDebutProjet.Value.AddMonths(7 - dateDebutProjet.Value.Month);
                }
            }
        }

        private void insertEtudiant_Click(object sender, EventArgs e)
        {
            affichageEtudiants.BeginUpdate();
            if(listeEtudiants.SelectedItem!=null)
                affichageEtudiants.Items.Add(listeEtudiants.SelectedItem);
            affichageEtudiants.EndUpdate();
        }

        private void retirerEtudiant_Click(object sender, EventArgs e)
        {
            if (affichageEtudiants.SelectedItem != null)
            {
                affichageEtudiants.BeginUpdate();
                affichageEtudiants.Items.RemoveAt(affichageEtudiants.SelectedIndex);
                affichageEtudiants.EndUpdate();
            }
        }

        private void insertProfesseur_Click(object sender, EventArgs e)
        {
            affichageProfesseurs.BeginUpdate();
            if (listeProfesseurs.SelectedItem != null)
                affichageProfesseurs.Items.Add(listeProfesseurs.SelectedItem);
            affichageProfesseurs.EndUpdate();
        }

        private void listeEtudiants_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listeEtudiants.SelectedItem == null)
                insertEtudiant.Hide();
            else
            {
                insertEtudiant.Show();
            }
        }

        private void affichageEtudiants_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageEtudiants.SelectedItem == null)
                retirerEtudiant.Hide();
            else
                retirerEtudiant.Show();
        }

        private void listeProfesseurs_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listeProfesseurs.SelectedItem == null)
                insertProfesseur.Hide();
            else
            {
                insertProfesseur.Show();
            }
        }

        private void affichageProfesseurs_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageProfesseurs.SelectedItem == null)
                retirerProfesseur.Hide();
            else
                retirerProfesseur.Show();
        }

        private void listeExtes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listeExtes.SelectedItem == null)
                insertExte.Hide();
            else
                insertExte.Show();
        }

        private void affichageExtes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageExtes.SelectedItem == null)
                retirerExte.Hide();
            else
                retirerExte.Show();
        }

        private void affichageLivrables_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageLivrables.SelectedItem == null)
                retirerLivrable.Hide();
            else
                retirerLivrable.Show();
        }

        private void retirerProfesseur_Click(object sender, EventArgs e)
        {
            if (affichageProfesseurs.SelectedItem != null)
            {
                affichageProfesseurs.BeginUpdate();
                affichageProfesseurs.Items.RemoveAt(affichageProfesseurs.SelectedIndex);
                affichageProfesseurs.EndUpdate();
            }
        }

        private void retirerExte_Click(object sender, EventArgs e)
        {
            if (affichageExtes.SelectedItem != null)
            {
                affichageExtes.BeginUpdate();
                affichageExtes.Items.RemoveAt(affichageEtudiants.SelectedIndex);
                affichageExtes.EndUpdate();
            }
        }

        private void retirerLivrable_Click(object sender, EventArgs e)
        {
            if (affichageLivrables.SelectedItem != null)
            {
                affichageLivrables.BeginUpdate();
                affichageLivrables.Items.RemoveAt(affichageEtudiants.SelectedIndex);
                affichageLivrables.EndUpdate();
            }
        }

        private void insertExte_Click(object sender, EventArgs e)
        {
            affichageExtes.BeginUpdate();
            if (listeExtes.SelectedItem != null)
                affichageExtes.Items.Add(listeProfesseurs.SelectedItem);
            affichageExtes.EndUpdate();
        }
    }
}