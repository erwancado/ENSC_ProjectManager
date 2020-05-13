using System;
using System.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

            try
            {
                using (StreamReader sr = new StreamReader("liste.txt"))
                {
                    string line;
                    Module module = null;
                    string promo = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("+"))
                        {
                            promo = line.Substring(1, 2);
                            if (module != null)
                                repertoire.AddModule(module);
                        }
                        if (line.StartsWith("*"))
                        {
                            if (module != null)
                                repertoire.AddModule(module);
                            string code = line.Substring(1, 8);
                            string[] coupe = line.Split('!');
                            string libelle = coupe[1];
                            Module mod = new Module(code, libelle, promo);
                            module = mod;
                        }
                        else
                        {
                            string code = line.Substring(0, 8);
                            string[] coupe = line.Split('!');
                            string libelle = coupe[1];
                            Matiere mat = new Matiere(code, libelle, promo);
                            module.AjouterMatiere(mat);

                        }
                    }
                    repertoire.AddModule(module);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("le fichier n'a pas pu être lu");
                Console.WriteLine(e.Message);
            }
            String[] typesPromos = { "1A", "2A", "3A", "transpromo" };
            repertoire.typesPromos = typesPromos;
            Type projetProg = new Type(1, 2, typesPromos[0]);
            Type transpromo = new Type(4, 6, typesPromos[3]);
            repertoire.typesProjet.Add(projetProg);
            repertoire.typesProjet.Add(transpromo);
           
            Application.Run(new CreationProjet(repertoire));
        }
        
    }
}
