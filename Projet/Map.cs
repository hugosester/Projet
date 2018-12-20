using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Map : Case
    {
        public int Largeur;
        public int Longueur;
        public Case[,] Carte;
        private int x;

        public Map()
        {
            Largeur = 10;
            Longueur = 10;
            Carte = new Case[10, 10];

            for (int i = 0; i < Largeur; i++)
            {
                for (int j = 0; j < Longueur; j++)
                {
                    Carte[i, j] = new Case();
                    Console.WriteLine("-");
                }
            }
        }

        public string GetDescription(int x, int y)
        {
            string s = Carte[x, y].Description;
            return s;
        }
    }
}
