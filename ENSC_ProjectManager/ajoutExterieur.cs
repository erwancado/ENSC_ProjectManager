using System;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    public partial class AjoutExterieur : Form
    {
        public Exterieur ReturnIntervenant;
        public AjoutExterieur()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (nomExte.Text.Length > 1 && prenomExte.Text.Length > 0 && mailExte.Text.Length > 7 && organisationExte.Text.Length > 1)
            {
                if (RegexUtilities.IsValidEmail(mailExte.Text))
                {
                    ReturnIntervenant = new Exterieur(nomExte.Text.Replace(' ', '-'), prenomExte.Text.Replace(' ', '-'), mailExte.Text, organisationExte.Text);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("E-mail non valide", "L'e-mail entré est invalide.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Informations manquantes", "Veuillez renseigner tous les champs.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
