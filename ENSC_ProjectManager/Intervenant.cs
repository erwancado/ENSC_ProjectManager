using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    public class Intervenant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public Intervenant(string nom, string prenom, string mail)
        {
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
        }
        public Intervenant()
        {

        }

        public bool VerificationMail(string mail)
        {
            return RegexUtilities.IsValidEmail(mail);
        }
    }
}
