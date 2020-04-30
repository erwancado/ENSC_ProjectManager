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
    public partial class AjoutType : Form
    {
        public AjoutType()
        {
            InitializeComponent();
            listeTypePromo.Items.Add("1A");
            listeTypePromo.Items.Add("2A");
            listeTypePromo.Items.Add("3A");
            listeTypePromo.Items.Add("Transpromo");
            validerType.Enabled = false;
        }

        private void NbMinEleve_ValueChanged(object sender, EventArgs e)
        {
            if(nbMaxEleve.Value<nbMinEleve.Value)
                nbMaxEleve.Value = nbMinEleve.Value;
            nbMaxEleve.Minimum = nbMinEleve.Value;
        }

        private void ValiderType_Click(object sender, EventArgs e)
        {
            Type unType = new Type((int)nbMinEleve.Value, (int)nbMaxEleve.Value, listeTypePromo.SelectedItem.ToString());
        }

        private void ListeTypePromo_Click(object sender, EventArgs e)
        {
            validerType.Enabled = true;
        }
    }
}
