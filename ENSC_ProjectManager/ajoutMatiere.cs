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
    public partial class ajoutMatiere : Form
    {
        public ajoutMatiere()
        {
            InitializeComponent();
            anneeEnseignement.Items.Add("1 ère année");
            anneeEnseignement.Items.Add("2 ème année");
            anneeEnseignement.Items.Add("3 ème année");
            listeProf.Items.Add(Professeur anidaznpizn);

            Valider.Enabled = false;

            if (code.Text.Length > 0 && nomMatiere.Text.Length > 0 && anneeEnseignement.SelectedItem.ToString().Length > 0 && listeProf.CheckedItems.Count > 0)
                Valider.Enabled = true;

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            foreach (var item in this.listeProf.Items)
            { var value = item.ToString(); }
            List<Professeur> listProf = new List<Professeur>(listeProf.CheckedItems.);
            Matiere Mat = new Matiere(code.Text, nomMatiere.Text, anneeEnseignement.SelectedItem.ToString());
        }

        private void AnneeEnseignement_Click(object sender, EventArgs e)
        {
            if (code.Text.Length > 0 && nomMatiere.Text.Length > 0 && listeProf.CheckedItems.Count > 0)
                Valider.Enabled = true;
        }

        private void ListeProf_Click(object sender, EventArgs e)
        {

        }
    }
}
