using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasingTheDollars
{
    internal class Player
    {
        private string _markerPlayer;
        private ConsoleColor _colorPlayer;
        public int posX { get; set; }
        public int posY { get; set; }

        public Player(int initialX, int initialY)
        {
            posX = initialX;
            posY = initialY;
            _markerPlayer = "O";
            _colorPlayer = ConsoleColor.Red;
        }

        public void Draw()
        {
            Console.ForegroundColor = _colorPlayer;
            Console.SetCursorPosition(posX, posY);
            Console.Write(_markerPlayer);
            Console.ResetColor();
        }
    }
}
