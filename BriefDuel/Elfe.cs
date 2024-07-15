using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Elfe : Guerrier
{
    public Elfe(string nom, int pv, int nbrAttaques) :
        base(nom, pv, nbrAttaques)
    {
        
    }

    public new void Attaque()
    {
        int DiceRoll = diceRoll.Next(1, 7);
        int dégâts = DiceRoll * NbrAttaques;
        if (dégâts < 6)
        {
            dégâts = 3;
            Console.WriteLine($"{Nom} inflige {dégâts} dégâts");
        }
    }
}


