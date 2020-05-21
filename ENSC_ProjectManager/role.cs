namespace ENSC_ProjectManager
{
    /// <summary>
    /// Associe un rôle à un intervenant dans un projet
    /// </summary>
    public class Role
    {
        public string Libelle { get; set; }
        public Intervenant Intervenant { get; set; }

        public Role(Intervenant intervenant, string libelle)
        {
            this.Libelle = libelle;
            this.Intervenant = intervenant;
        }
        public Role()
        {

        }
    }
}
