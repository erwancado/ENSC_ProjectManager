using System;
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
    public partial class AjoutRoles : Form
    {
        List<Intervenant> Intervenants;
        Repertoire Repertoire;
        Dictionary<int, string> indexIntervenantRole;
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

        private void RemplirIntervenants()
        {
            liste_intervenants.BeginUpdate();
            liste_intervenants.Items.Clear();
            foreach(Intervenant intervenant in Intervenants)
            {
                liste_intervenants.Items.Add(intervenant.Nom + " " + intervenant.Prenom+" "+intervenant.Mail);
            }
            liste_intervenants.EndUpdate();
        }

        private void RemplirRoles()
        {
            libelle_role.BeginUpdate();
            libelle_role.Items.Clear();
            foreach(string libRole in Repertoire.GetLibellesRoles())
            {
                libelle_role.Items.Add(libRole);
            }
            libelle_role.EndUpdate();
        }

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

        private void ajouterRole_Click(object sender, EventArgs e)
        {
            if(liste_intervenants.SelectedItem!=null && libelle_role.Text.Length > 0)
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

        private void RetourAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
