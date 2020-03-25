using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class Etudiant : Intervenant
    {
        private bool _redoublant;
        private int _groupeTD;

        public Promotion Promotion { get; set; }

        public Etudiant(string nom, string prenom, string mail, int groupeTD, bool redoublant) : base(nom, prenom, mail)
        {
            _groupeTD = groupeTD;
            _redoublant = redoublant;
        }

        public int GroupeTD { get => _groupeTD; set => _groupeTD = value; }
    }
}
