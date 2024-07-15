using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Guerrier
    {
        #region "Attributs"
        private string _nom;
        private int _pv;
        private int _nbrAttaques;
        #endregion

        #region "Propriétés"
        public string Nom { get => _nom; set => _nom = value; }
        public int PV { get => _pv; set => _pv = value; }
        public int NbrAttaques { get => _nbrAttaques; set => _nbrAttaques = value; }
        #endregion

    public Guerrier(string nom, int pv, int nbrAttaques)
    {
        Nom = nom;
        PV = pv;
        NbrAttaques = nbrAttaques;
    }


    // Méthodes
    public static Random diceRoll = new Random();
        int valDiceRoll = diceRoll.Next(1,7);
        int dégâts = 0;
        public void Attaque()
        { 
            int DiceRoll = diceRoll.Next(1, 7);
            int dégâts = DiceRoll * NbrAttaques;
            if (DiceRoll >= 1)
        {
            Console.WriteLine($"{Nom} inflige {dégâts} dégâts");
        }
        }

        public void AfficherInfos()
    {
        Console.WriteLine($"{Nom} PV: {PV}");
    }

        public void SubirDégâts()
    {
        if ( dégâts > 0)
        {
            
        }
    }

        
}


