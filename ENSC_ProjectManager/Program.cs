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
            /*
            try
            {
                using (StreamReader sr = new StreamReader("liste.txt"))
                {
                    string line;
                    Module module = null;
                    string promo = null;
                    while (sr.Peek()>=0)
                    {
                        line = sr.ReadLine();
                        if (line.StartsWith("+"))
                        {
                            promo = line.Substring(1, 2);
                            if (module != null)
                                repertoire.AddModule(module);
                        }
                        else if (line.StartsWith("*"))
                        {
                            if (module != null)
                                repertoire.AddModule(module);
                            string[] coupe = line.Split('!');
                            string code = coupe[0].Substring(1);
                            string libelle = coupe[1];
                            Module mod = new Module(code, libelle, promo);
                            module = mod;
                        }
                        else
                        {
                            
                            string[] coupe = line.Split('!');
                            string code = coupe[0];
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
            repertoire.saveFile = "repertoire.xml";*/
            repertoire = Repertoire.LoadData("repertoire.xml");
            Application.Run(new Accueil(repertoire));
        }

    }
}
