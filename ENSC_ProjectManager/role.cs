using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class Role
    {
        public string Libelle { get; set; }
        internal Intervenant Intervenant { get; set; }

        public Role(Intervenant intervenant,string libelle)
        {
            this.Libelle = libelle;
            this.Intervenant = intervenant;
        }
    }
}
