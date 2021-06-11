using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGuybrush
{
    class IleClasse : Codage
    {
        public IleClasse(string fichier) : base(fichier)
        {
        }
        public void ListeParcelle()
        {
            Console.WriteLine("Affichage de la liste des parcelles : ");

            int nbUnit = 0;
            int valCoords = 0;
            int ascii = 'a';
            List<int> CoordsParcelle = new List<int>();
            bool resteParcelle = true;
            while (resteParcelle)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (MapClair[i, y] == Convert.ToChar(ascii))
                        {
                            nbUnit++;
                            CoordsParcelle.Add(i);
                            CoordsParcelle.Add(y);
                        }
                    }
                }
                if (nbUnit == 0)
                {
                    resteParcelle = false;
                }
                else
                {
                    Console.WriteLine("\nPARCELLE {0} - {1} unites", Convert.ToChar(ascii), nbUnit);
                    foreach (var coords in CoordsParcelle)
                    {
                        if (valCoords == 0)
                        {
                            Console.Write("({0},", coords);
                            valCoords++;
                        }
                        else
                        {
                            Console.Write("{0}) ", coords);
                            valCoords = 0;
                        }
                    }
                    Console.WriteLine();
                    ascii++;
                }
                CoordsParcelle.Clear();
                nbUnit = 0;
            }
        }
        public void DemandeListeParcelle()
        {
            char parcelleChoisie;
            Console.WriteLine("\nEntrez la parcelle dont vous voulez connaître la taille :");
            parcelleChoisie = Convert.ToChar(Console.ReadLine());
            if ((parcelleChoisie == 'M') || (parcelleChoisie == 'F'))
            {
                if (parcelleChoisie == 'M')
                    Console.WriteLine("\nCe n'est pas une parcelle, c'est un bloc d'unité Mer");
                else
                    Console.WriteLine("\nCe n'est pas une parcelle, c'est un bloc d'unité Forêt");
            }
            else
            {
                int nbUnite = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (MapClair[i, y] == parcelleChoisie)
                        {
                            nbUnite++;
                        }
                    }
                }
                if (nbUnite == 0)
                {
                    Console.WriteLine("\nParcelle {0} : inexistante", parcelleChoisie);
                }
                Console.WriteLine("Taille de la parcelle {0} : {1} unites", parcelleChoisie, nbUnite);
            }
        }

        public void AffichageParcelleBornee()
        {
            int borneParcelle;
            Console.WriteLine("\nQuelle est la taille de parcelle minimum recherchée ?");
            borneParcelle = Convert.ToInt32(Console.ReadLine());
            int nbUnit = 0;
            int nbAffichages = 0;
            int ascii = 'a';
            bool resteParcelle = true;
            Console.WriteLine("\nParcelles de taille supérieure à {0} :", borneParcelle);
           
            while (resteParcelle)
            {
                

                for (int i = 0; i < 10; i++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (MapClair[i, y] == Convert.ToChar(ascii))
                        {
                            nbUnit++;
                           
                        }
                    }
                }
               
               
                if (nbUnit >= borneParcelle)
                {
                    Console.WriteLine("\nParcelle {0}: {1} unites", Convert.ToChar(ascii), nbUnit);
                    ascii++;
                    nbAffichages++;

                }
                else if (nbUnit <= borneParcelle)
                {
                    ascii++;
                }

                if (nbAffichages == 0)
                {
                    Console.WriteLine("\nAucune parcelle");
                    resteParcelle = false;
                }
                

                if (nbUnit == 0)
                {
                    resteParcelle = false;
                }

                //Console.WriteLine("a");
                nbUnit = 0;
            }
              
           }
        

        public void MoyenneParcelle()
        {
            Console.WriteLine("Affichage de la liste des parcelles : ");

            double nbUnit = 0;
            double moyenneParcelle = 0;
            int ascii = 'a';
            int nbParcelle = 0;
            
            
            bool resteParcelle = true;
            while (resteParcelle)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (MapClair[i, y] == Convert.ToChar(ascii))
                        {
                            nbUnit++;
                            

                        }
                    }
                }
                moyenneParcelle = moyenneParcelle + nbUnit;
                if (nbUnit == 0)
                {
                    resteParcelle = false;
                }
                 else
                {
                    ascii++;
                    nbParcelle++; 
                }
                 nbUnit = 0;
            }
            moyenneParcelle = moyenneParcelle / nbParcelle;
            Console.WriteLine("\nAire moyenne : {0} ", Math.Round(moyenneParcelle, 2));
               
         }


    }
}