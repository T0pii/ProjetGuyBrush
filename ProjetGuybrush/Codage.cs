using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ProjetGuybrush
{
    /// <summary>
    /// Classe Codage : modélise la partie codage
    /// </summary>
    public class Codage
    {
        protected char[,] MapClair = new char[10, 10];
        protected List<string> MapCode = new List<string>();
        public Codage(string fichier)
        {
            try
            {
                string val;
                int y = 0;
                using StreamReader sr = new StreamReader("../../../cartes/Scabb.clair");
                {
                    Console.WriteLine("Carte claire :");
                    while ((val = sr.ReadLine()) != null)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            MapClair[i, y] = val[i];
                            Console.Write(MapClair[i, y]);
                        }
                        y = y + 1;
                        Console.WriteLine();
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

    


        }

        virtual public void AfficheCouleur()
        {
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Carte colorée :");
            for (int y = 0; y < 10; y++) {
                for (int i = 0; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    if (MapClair[i, y] == 'F')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(MapClair[i, y]);
                    }
                    else if (MapClair[i, y] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(MapClair[i, y]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(MapClair[i, y]);
                    }
                }

                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;


        }
       
        
        virtual public void AfficheCodeeChiffre()
        {
            //Définission des frontières
            int cpt = 0;

            for (int i = 0; i < 10; i++)
            {

                for (int y = 0; y < 10; y++)
                {
                    //Détection des frontières de la carte
                    cpt = 0;
                    //Nord
                    if (i == 0)
                        cpt += 1;
                    //Ouest
                    if (y == 0)
                        cpt += 2;
                    //Sud
                    if (i == 9)
                        cpt += 8;
                    //Est
                    if (y == 9)
                        cpt += 4;

                    //Détection des autres unités
                    //Autre unité à l'Est
                    if ((y < 9) && (MapClair[i, y + 1] != MapClair[i, y]))
                        cpt += 4;
                    //Autre unité à l'Ouest
                    if ((y > 0) && (MapClair[i, y - 1] != MapClair[i, y]))
                        cpt += 2;
                    //Autre unité au Nord
                    if ((i < 9) && (MapClair[i + 1, y] != MapClair[i, y]))
                        cpt += 1;
                    //Autre unité au Sud
                    if ((i > 0) && (MapClair[i - 1, y] != MapClair[i, y]))
                        cpt += 1;
                    // Gestion des unités Mer
                    if (MapClair[i, y] == 'M')
                        cpt += 64;
                    // Gestion des unités Forêt
                    if (MapClair[i, y] == 'F')
                        cpt += 32;
                    MapCode.Add(""+cpt);
                  
                  
                }
            }
     
            //Affichage de la carte codée
            Console.WriteLine("Carte codée :");
            //Console.WriteLine(String.Join(":", MapCode));
            int count = 1;
            foreach (var word in MapCode)
            {
            
                Console.Write(word);
                if (count<=9)
                {
                    Console.Write(":");
                }
                else if (count == 10)
                {
                    Console.Write("|");
                    count = 0;
                }
                count++;
            }
        }
    }

}
