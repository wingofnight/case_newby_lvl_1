using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace case_newby_lvl_1
{
    public class ColorProfile
    {
        public ConsoleColor BackGround { get; set; }
        public ConsoleColor ForeGround { get; set; }
    }
    public class SectorPaint
    {
        //int lastLenght = 0;
        string symbol = "";//нужно сделать конструктор класса, который задавал бы значение symbol и запускал функцию ClassesCreate()
        private void ClassesCreate()
        {
            //нужно сделать все цвета которые есть в ConsoleColor.блаблабла. 
            ColorProfile Red = new ColorProfile();
            Red.ForeGround = ConsoleColor.Red;
            Red.BackGround = ConsoleColor.Black;

            ColorProfile DarckRed = new ColorProfile();
            DarckRed.ForeGround = ConsoleColor.DarkRed;
            DarckRed.BackGround = ConsoleColor.Black;

        }

        public void Point(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
    }
