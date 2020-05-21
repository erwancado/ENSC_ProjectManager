namespace ENSC_ProjectManager
{
    /// <summary>
    /// Représente une personne prenant part à un projet
    /// </summary>
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

        public bool Equals(Intervenant intervenant)
        {
            return (Nom.Equals(intervenant.Nom) && Prenom.Equals(intervenant.Prenom) && Mail.Equals(intervenant.Mail));
        }
        public bool VerificationMail(string mail)
        {
            return RegexUtilities.IsValidEmail(mail);
        }
    }
}
