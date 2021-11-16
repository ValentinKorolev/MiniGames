using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasingTheDollars
{
    internal class Menu
    {
        private int _selectedIndex;
        private string[] _options;
        private string _bannerGame;


        public Menu()
        {
            _bannerGame = @"
 _______ _                _                _______ _              ______       _ _                  
(_______) |              (_)              (_______) |            (______)     | | |                 
 _      | |__  _____  ___ _ ____   ____       _   | |__  _____    _     _ ___ | | | _____  ____ ___ 
| |     |  _ \(____ |/___) |  _ \ / _  |     | |  |  _ \| ___ |  | |   | / _ \| | |(____ |/ ___)___)
| |_____| | | / ___ |___ | | | | ( (_| |     | |  | | | | ____|  | |__/ / |_| | | |/ ___ | |  |___ |
 \______)_| |_\_____(___/|_|_| |_|\___ |     |_|  |_| |_|_____)  |_____/ \___/ \_)_)_____|_|  (___/ 
                                 (_____|                                                            


Welcome to Chasing The Dollars!!!

Press enter to select option:
";
            _options = new string []{ "Play", "Score", "Exit" }; 
            _selectedIndex = 0;
        }

        private void DisplayOptions()
        {
            Console.WriteLine(_bannerGame);
            
            for (int i = 0; i < _options.Length; i++)
            {
                string currentOption = _options[i];
                string prefix;

                if (i == _selectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefix}<<{currentOption}>>");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _selectedIndex--;
                    if(_selectedIndex == -1)
                    {
                        _selectedIndex = _options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    _selectedIndex++;
                    if (_selectedIndex == _options.Length)
                    {
                        _selectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return _selectedIndex;
        }
    }
}
