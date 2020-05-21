using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    /// <summary>
    /// Formulaire d'ajout des rôles, dernière étape avant l'insertion du projet
    /// </summary>
    public partial class AjoutRoles : Form
    {
        List<Intervenant> Intervenants; // Liste des intervenants ajoutés au projet
        Repertoire Repertoire;
        Dictionary<int, string> indexIntervenantRole; // Récupére l'indice de l'intervenant dans la liste et son rôle associé
        public List<Role> ReturnRoles;
        public AjoutRoles(List<Intervenant> intervenants, Repertoire repertoire)
        {
            InitializeComponent();
            Intervenants = intervenants;
            Repertoire = repertoire;
            indexIntervenantRole = new Dictionary<int, string>();
            descriptionCol2.Hide();
            libelle_role.Hide();
            ajouterRole.Hide();
            retirerRole.Hide();
            RemplirIntervenants();
            RemplirRoles();
            this.CenterToParent();
            this.ControlBox = false;
        }

        /// <summary>
        /// Remplit la liste d'intervenants du projet
        /// </summary>
        private void RemplirIntervenants()
        {
            liste_intervenants.BeginUpdate();
            liste_intervenants.Items.Clear();
            foreach (Intervenant intervenant in Intervenants)
            {
                liste_intervenants.Items.Add(intervenant.Nom + " " + intervenant.Prenom + " " + intervenant.Mail);
            }
            liste_intervenants.EndUpdate();
        }

        /// <summary>
        /// Remplit la liste de suggestions de rôles en fonction des rôles présents dans les autres projets
        /// </summary>
        private void RemplirRoles()
        {
            libelle_role.BeginUpdate();
            libelle_role.Items.Clear();
            foreach (string libRole in Repertoire.GetLibellesRoles())
            {
                libelle_role.Items.Add(libRole);
            }
            libelle_role.EndUpdate();
        }

        /// <summary>
        /// Affiche l'ajout de rôle lorsqu'un intervenant est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void liste_intervenants_SelectedValueChanged(object sender, EventArgs e)
        {
            if (liste_intervenants.SelectedItem != null)
            {
                descriptionCol2.Show();
                libelle_role.Show();
                ajouterRole.Show();
                liste_roles.ClearSelected();
            }
            else
            {
                descriptionCol2.Hide();
                libelle_role.Hide();
                ajouterRole.Hide();
            }
        }

        /// <summary>
        /// Vérifie que l'intervenant choisi n'a pas déjà un rôle attribué puis lui ajoute son rôle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterRole_Click(object sender, EventArgs e)
        {
            if (liste_intervenants.SelectedItem != null && libelle_role.Text.Length > 0)
            {
                if (!indexIntervenantRole.ContainsKey(liste_intervenants.SelectedIndex))
                {
                    liste_roles.BeginUpdate();
                    liste_roles.Items.Add("(" + liste_intervenants.SelectedIndex + ") : " + liste_intervenants.SelectedItem.ToString() + "-" + libelle_role.Text);
                    indexIntervenantRole.Add(liste_intervenants.SelectedIndex, libelle_role.Text);
                    Repertoire.roles.Add(new Role(Intervenants[liste_intervenants.SelectedIndex], libelle_role.Text));
                    RemplirRoles();
                    liste_roles.EndUpdate();
                }
                else
                {
                    MessageBox.Show("Rôle déjà attribué", "Un rôle a déjà été attribué à cet intervenant.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void liste_roles_SelectedValueChanged(object sender, EventArgs e)
        {
            if (liste_roles.SelectedItem != null)
            {
                liste_intervenants.ClearSelected();
                retirerRole.Show();
            }
            else
            {
                retirerRole.Hide();
            }

        }

        /// <summary>
        /// Retire le rôle sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retirerRole_Click(object sender, EventArgs e)
        {
            if (liste_roles.SelectedItem != null)
            {
                int indexIntervenant = int.Parse(liste_roles.SelectedItem.ToString().Substring(1).Split(')')[0]);
                liste_roles.BeginUpdate();
                liste_roles.Items.RemoveAt(liste_roles.SelectedIndex);
                indexIntervenantRole.Remove(indexIntervenant);
                liste_roles.EndUpdate();
            }
        }

        /// <summary>
        /// Vérifie que tous les intervenants ont un rôle puis créer les instances de rôle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValiderRoles_Click(object sender, EventArgs e)
        {
            if (liste_roles.Items.Count == liste_intervenants.Items.Count)
            {
                List<Role> roles = new List<Role>();
                foreach (KeyValuePair<int, string> indexRole in indexIntervenantRole)
                {
                    roles.Add(new Role(Intervenants[indexRole.Key], indexRole.Value));
                }
                ReturnRoles = roles;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Rôles manquants", "Tous les intervenants doivents se voir attribuer un rôle.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Abandonne les modifications et revient à la fenêtre de création de projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetourCreationProjet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
