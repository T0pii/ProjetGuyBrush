using System;

namespace ProjetGuybrush
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
          
            //Decodage chaine1 = new Decodage("../../../cartes/Scabb.chiffre");
            Codage chaine2 = new Codage("../../../cartes/Scabb.clair");
            chaine2.AfficheCodeeChiffre();
            //chaine2.AfficheCouleur();
            //IleClasse chaine3 = new IleClasse("../../../cartes/Phatt.clair");
            //chaine3.ListeParcelle();
            //chaine3.MoyenneParcelle();
            //chaine3.DemandeListeParcelle();
            //chaine3.AffichageParcelleBornee();




        }
           
    }
}
