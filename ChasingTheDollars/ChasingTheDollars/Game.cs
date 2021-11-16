using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasingTheDollars
{
    internal class Game
    {
        public void ShowMenu()
        {
            Menu mainMenu = new();
            int selectedIndex = mainMenu.Run();
            Field fieldGame = new();
            Player Player = new(10, 18);

            switch (selectedIndex)
            {
                case 0:
                    RunGameLoop();
                    break;
                case 1:
                    DisplayScore();
                    break;
                case 2:
                    ExitGame();
                    break;
            }

            void StartGame()
            {
                Console.Clear();
                
                fieldGame.ShowField();
                
                Player.Draw();
            }

            void DisplayScore()
            {

            }

            void ExitGame()
            {

            }

            void PlayerController()
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                ConsoleKey key = keyInfo.Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (fieldGame.IsBorderField(Player.posX, Player.posY - 1))
                        {
                            Player.posY -= 1;
                        }                        
                        break;                        
                    case ConsoleKey.DownArrow:
                        if (fieldGame.IsBorderField(Player.posX, Player.posY + 1))
                        {
                            Player.posY += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (fieldGame.IsBorderField(Player.posX - 1, Player.posY))
                        {
                            Player.posX -= 1;
                        }                        
                        break;
                    case ConsoleKey.RightArrow:
                        if (fieldGame.IsBorderField(Player.posX + 1, Player.posY))
                        {
                            Player.posX += 1;
                        }                        
                        break;
                    default:
                        break;
                }      
            }

            void RunGameLoop()
            {
                while (true)
                {
                    StartGame();

                    PlayerController();

                    Thread.Sleep(20);
                }
            }

            Console.ReadKey(true);
        }
    }
}
