using System;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    /// <summary>
    /// Formulaire d'ajout d'un type de projet
    /// </summary>
    public partial class AjoutType : Form
    {
        public Type ReturnType;
        public AjoutType()
        {
            InitializeComponent();
            listeTypePromo.Items.Add("1A");
            listeTypePromo.Items.Add("2A");
            listeTypePromo.Items.Add("3A");
            listeTypePromo.Items.Add("Transpromo");
            validerType.Enabled = false;
            this.CenterToParent();
        }

        private void NbMinEleve_ValueChanged(object sender, EventArgs e)
        {
            if (nbMaxEleve.Value < nbMinEleve.Value)
                nbMaxEleve.Value = nbMinEleve.Value;
            nbMaxEleve.Minimum = nbMinEleve.Value;
        }

        private void ValiderType_Click(object sender, EventArgs e)
        {
            ReturnType = new Type((int)nbMinEleve.Value, (int)nbMaxEleve.Value, listeTypePromo.SelectedItem.ToString());
            this.Visible = false;
        }

        private void ListeTypePromo_Click(object sender, EventArgs e)
        {
            validerType.Enabled = true;
        }
    }
}
