using System;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Repertoire repertoire = new Repertoire();
            repertoire = Repertoire.LoadData("repertoire.xml"); // Charge les donnée du répertoire depuis le fichier de sauvegarde
            Application.Run(new Accueil(repertoire)); // Affiche la page d'accueil du logiciel
        }

    }
}
