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
    public partial class AjoutProf : Form
    {
        public Professeur ReturnProfesseur;
        public List<Matiere> ReturnMatieresEnseignees;
        private Repertoire Repertoire;
        public AjoutProf(Repertoire repertoire)
        {
            InitializeComponent();
            Repertoire = repertoire;
            RemplirMatieres(repertoire.matieres);
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if(nomProf.TextLength!=0 && prenomProf.TextLength!=0 && mailProf.TextLength != 0)
            {
                if (RegexUtilities.IsValidEmail(mailProf.Text))
                {
                    List<Matiere> matieresEnseignees = new List<Matiere>();
                    if (liste_matieres.CheckedItems.Count != 0)
                    {
                        for(int i=0; i<liste_matieres.CheckedItems.Count; i++)
                        {
                            string strCode = liste_matieres.CheckedItems[i].ToString().Split('-')[0];
                            Matiere matiere = Repertoire.GetMatiere(strCode);
                            if (matiere != null)
                                matieresEnseignees.Add(matiere);
                        }
                    }
                    ReturnMatieresEnseignees = matieresEnseignees;
                    ReturnProfesseur = new Professeur(nomProf.Text.Replace(' ', '-'), prenomProf.Text.Replace(' ', '-'), mailProf.Text, titreProf.Text);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("E-mail non valide", "L'e-mail entré est invalide.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Information manquante", "Tous les champs doivent être remplis pour continuer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void RemplirMatieres(List<Matiere> matieres)
        {
            liste_matieres.BeginUpdate();
            liste_matieres.Items.Clear();
            foreach(Matiere matiere in matieres)
            {
                liste_matieres.Items.Add(matiere.Code + "-" + matiere.Libelle);
            }
            liste_matieres.EndUpdate();
        }
    }
}
