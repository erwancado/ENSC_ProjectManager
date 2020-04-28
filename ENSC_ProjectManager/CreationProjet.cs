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
    public partial class CreationProjet : Form
    {
        public CreationProjet(Repertoire repertoire)
        {
            InitializeComponent();
            dateDebutProjet.Enabled = false;
            dateFinProjet.Enabled = false;
            listeMatiere.Enabled = false;
        }

    }
}
