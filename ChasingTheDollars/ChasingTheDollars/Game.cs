using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasingTheDollars
{
    internal class Game
    {
        public void Start()
        {
            string promt = @"
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


            string[] options = { "Play", "Score", "Exit" };
            Menu mainMenu = new(promt, options);
            int selectedIndex = mainMenu.Run();

            Console.ReadKey(true);
        }
    }
}
