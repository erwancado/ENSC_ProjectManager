namespace ENSC_ProjectManager
{
    public class Professeur : Intervenant
    {
        private string _titre;
        public string Titre { get => _titre; set => _titre = value; }
        public Professeur(string nom, string prenom, string mail, string titre) : base(nom, prenom, mail)
        {
            _titre = titre;
        }
        public Professeur() : base()
        {

        }
    }
}
