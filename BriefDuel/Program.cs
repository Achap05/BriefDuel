// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");


Console.WriteLine("Choisissez:");
Console.WriteLine("---[1] Choisir un personnage---");
Console.WriteLine("---[2] Choisir un adversaire---");
Console.WriteLine("---[3] Refaire un combat---");


static void Menu() 
{

}

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

