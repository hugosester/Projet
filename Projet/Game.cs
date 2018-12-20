using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Game
    {

        public Game()
        {
            //TODO Faire le début du jeu
            Console.WriteLine("Choisir un nom ?");
            string nom = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("C'est l'histoire de " + nom + " qui c'est perdu dans un monde soutterrain.");
            Console.WriteLine("Il doit survivre pour rester en vie");
            Console.ReadLine();

            /*Player p = new Player();*/
            /* Map m = new Map();*/


            PrintChoix();
            int Choix2 = AskChoice2(0, 3);
            switch (Choix2)
            {
                case 0:
                    Console.WriteLine("Aller vers le nord");
                    break;
                case 1:
                    Console.WriteLine("Aller vers l'ouest");
                    break;
                case 2:
                    Console.WriteLine("Aller vers le sud");
                    break;
                case 3:
                    Console.WriteLine("Aller vers l'est");
                    break;

            }
            Console.WriteLine("Choisir ou ce deplacer");

            //TODO Récupérer la case
            void PrintChoix()
            {
                Console.WriteLine("0 - Vers le nord");
                Console.WriteLine("1 - Vers l'ouest");
                Console.WriteLine("2 - Vers le sud");
                Console.WriteLine("3 - Vers l'est");
                Console.WriteLine("Faites un choix :");
            }
        }
            public int AskChoice2(int min2, int max2)
            {
                //TODO Faire le choix du joueur
                int result2 = int.Parse(Console.ReadLine());
                while (result2 > max2 || result2 < min2)
                {
                    result2 = int.Parse(Console.ReadLine());
                }
                return result2;

            }
        //TODO Tester le contenu de la case
        //TODO Peut etre lancer un combat ...
    }
}
