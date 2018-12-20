using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Menu
    {
        public Menu()
        {
            PrintMenu();
            int Choix = AskChoice(0, 3);
            switch(Choix)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Load();
                    break;
                case 2:
                    APropos();
                    break;
                case 3:
                    QuitGame();
                    break;
            }
        }
        
        public void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                                    KKK     KKK   YYY     YYY   LLL         LLL
                                    KKK    KKK     YYY   YYY    LLL         LLL
                                    KKK  KKKK       YYY YYY     LLL         LLL
                                    KKKKKK           YYYYY      LLL         LLL
                                    KKKKKK            YYY       LLL         LLL
                                    KKK  KKKK         YYY       LLL         LLL
                                    KKK    KKK        YYY       LLLLLLLLL   LLLLLLLLL
                                    KKK     KKK       YYY       LLLLLLLLL   LLLLLLLLL
            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\n\nMAIN MENU : ");
            Console.WriteLine("0 - Start Game");
            Console.WriteLine("1 - Load Game");
            Console.WriteLine("2 - A propos");
            Console.WriteLine("3 - Quit Game");
            Console.WriteLine("Faites un choix :");
        }

        public int AskChoice(int min, int max)
        {
            //TODO Faire le choix du joueur
            int result = int.Parse( Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }

        public static void StartGame()
        {
            //TODO Faire le jeu
            Game g = new  Game();

        }

        public void Load()
        {
            //TODO Faire une sauvegarde de la partie
            Console.WriteLine("FUCK");
        }

        public void APropos()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game create by Anonymous");
            Console.WriteLine("Game Design by Azerty");
            Console.WriteLine("Sound by Qwerty");
            Console.WriteLine("3D by Qwertz");
        }

        public void QuitGame()
        {
            //TODO Quitter le jeu
            Environment.Exit(0);
        }

    }
}