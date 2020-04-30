using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    public class Etudiant : Intervenant
    {
        private bool _redoublant;

        public Promotion Promotion { get; set; }

        public Etudiant(string nom, string prenom, string mail, bool redoublant) : base(nom, prenom, mail)
        {
           
            _redoublant = redoublant;
        }
        public Etudiant()
        {

        }
        
    }
}
