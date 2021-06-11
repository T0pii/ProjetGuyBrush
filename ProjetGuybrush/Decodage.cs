using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjetGuybrush
{
    /// <summary>
    /// classe decodage : modélise la partie décodage
    /// </summary>
    public class Decodage
    {

        private List<string> MapChifree = new List<string>();
        private List<char> MapLettre = new List<char>();

        public Decodage(string fichiers)
        {
            MapChifree = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader("../../../cartes/Scabb.chiffre"))
                {
                    string line;




                    while ((line = sr.ReadLine()) != null)

                    {

                        MapChifree.Add(line);


                    }
                    sr.Close();
                }

                Console.WriteLine("carte chiffrée :");
                Console.WriteLine(string.Join(" ", MapChifree));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

           

        }
        /*virtual public void AfficheCodeeLettre()
        {
            Codage de la carte chiffrée
           char lettre= 'a';
           for (int i = 0; i < MapChifree.Count; i++)

           {
               if (MapChifree[i] >= (int) '32')
               {
                   lettre = 'F';
               }
               MapLettre.Add(lettre);



           }
           Console.WriteLine("Carte codée :");
           Console.WriteLine((char)MapLettre.Count);*/

    }

}

                
               
                
               
    

     
              
             

            
           

 