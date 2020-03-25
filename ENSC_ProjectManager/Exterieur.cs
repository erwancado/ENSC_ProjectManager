using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class Exterieur : Intervenant
    {
        private string _organisation;
        public Exterieur(string nom, string prenom, string mail, string organisation) : base(nom, prenom, mail)
        {
            _organisation = organisation;
        }

        public string Organisation { get => _organisation; set => _organisation = value; }
    }
}
