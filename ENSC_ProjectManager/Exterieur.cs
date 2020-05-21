namespace ENSC_ProjectManager
{
    public class Exterieur : Intervenant
    {
        private string _organisation;
        public string Organisation { get => _organisation; set => _organisation = value; }
        public Exterieur(string nom, string prenom, string mail, string organisation) : base(nom, prenom, mail)
        {
            _organisation = organisation;
        }
        public Exterieur()
        {

        }

    }
}
