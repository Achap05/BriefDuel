using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Nain : Guerrier
{
    private int _armure;
    public int Armure { get => _armure; set => _armure = value; } 
    public Nain(string nom, int pv, int nbrAttaques, int armure) :
        base(nom, pv, nbrAttaques)
    {
        Armure = armure ;
    }
}
    

