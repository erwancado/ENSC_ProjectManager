namespace ENSC_ProjectManager
{
    public class Etudiant : Intervenant
    {
        public bool Redoublant;
        public int AnneePromotion;

        public Etudiant(string nom, string prenom, string mail, bool redoublant, int anneePromotion) : base(nom, prenom, mail)
        {

            Redoublant = redoublant;
            AnneePromotion = anneePromotion;
        }
        public Etudiant()
        {

        }

    }
}
