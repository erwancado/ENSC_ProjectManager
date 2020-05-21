namespace ENSC_ProjectManager
{
    /// <summary>
    /// Représente un professeur de l'ENSC
    /// </summary>
    public class Professeur : Intervenant
    {
        private string _titre;
        public string Titre { get => _titre; set => _titre = value; } // (Ex : Enseignant-chercheur, ingénieur, docteur...)
        public Professeur(string nom, string prenom, string mail, string titre) : base(nom, prenom, mail)
        {
            _titre = titre;
        }
        public Professeur() : base()
        {

        }
    }
}
