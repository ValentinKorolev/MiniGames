﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChasingTheDollars
{
    internal class Field
    {
        string[,] field;
        int rows;
        int cols;
        public void ShowField()
        {
            field = new[,] 
            {//1  2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18  19  20
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},//1
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//2
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//3
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//4
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//5
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//6
            {"#"," "," "," "," "," "," "," "," "," "," ","$"," "," "," "," "," "," "," ","#"},//7
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//8
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//9
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//10
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//11
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//12
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//13
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//14
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//15
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//16
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//17
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//18
            {"#"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","#"},//19
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},//20
            };
            rows = field.GetLength(0);
            cols = field.GetLength(1);

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    string element = field[x, y];
                    Console.SetCursorPosition(x, y);
                    Console.Write(element);
                }
            }
        }
        public bool IsBorderField(int posX, int posY)
        {
            if(posX < 0 || posY < 0 || posX >= cols || posY >= rows)
            {
                return false;
            }

            return field[posY, posX] == " " || field[posY,posX] == "$";
        }

    }
}
