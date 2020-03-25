using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class Professeur : Intervenant
    {
        private string _titre;
        public Professeur(string nom, string prenom, string mail, string titre) : base(nom, prenom, mail)
        {
            _titre = titre;
        }

        public string Titre { get => _titre; set => _titre = value; }
    }
}
