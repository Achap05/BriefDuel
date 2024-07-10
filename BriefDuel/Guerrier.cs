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

        // Méthodes

        public Guerrier(string nom,int pv,int nbrAttaques)
        {
            Nom = nom; 
            PV = 100;
            NbrAttaques = 1;
        }
}


