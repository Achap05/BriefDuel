// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;


Console.WriteLine("Choisissez:");
Console.WriteLine("---[1] Choisir un personnage---");
Console.WriteLine("---[2] Créer un personnage---");
Console.WriteLine("---[3] Faire un combat---");
Console.WriteLine("---[4] supprimer un personnage---");





Guerrier g1 = new Guerrier("Arthur", 30, 2);
Guerrier g2 = new Guerrier("Renaud", 30, 1);
Nain gNain = new Nain("Durin", 50, 1, 10);
Elfe gElfe = new Elfe("Feanor", 50, 3);



g1.Attaque();
g1.AfficherInfos();

g2.Attaque();
g2.AfficherInfos();

gNain.Attaque();
gNain.AfficherInfos();

gElfe.Attaque();
gElfe.AfficherInfos();

bool End = false;
while (!End)
{
        switch (Console.ReadLine())
        {
            case "1":
            Guerrier CréationPerso()
            {
                string nom;
                int pv;
                int nbrAttaques;
            }
            break;

        case "2":
            
            break;

        case "3":
            
            break;

        default:
            Console.WriteLine("Erreur ce choix n'est pas reconnu");
          
            break;
        }


static void Menu()
{


}