using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ClassDefinitions
{
    internal class ConsoleGame
    {
        static int top = 0;
        static int left = 0;
        static char symbol = '#';
        public static void Run()
        {
            Console.Write(symbol);
            while (true)
            {
                var key = GetPressedKey();
                
                if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                {
                    MoveRight();
                }
                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    MoveDown();
                }
                else if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                {
                    MoveUp();
                }
                else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                {
                    MoveLeft();
                }
                else if (key == ConsoleKey.Q)
                {
                    break;
                }
                else
                {
                    PrintSymbolOnScreen();
                }
            }
            Console.Clear();
            Console.WriteLine("Oyun Bitti");
        }
        static ConsoleKey GetPressedKey()
        {
            var nextMove = Console.ReadKey();
            var key = nextMove.Key;
            return key;
        }
        static void PrintSymbolOnScreen()
        {
            Console.Clear();
            #region Manuel Olarak Boşluk Ekleme
            for (var i = 0; i < top; i++)
            {
                Console.WriteLine();
            }

            for (var i = 0; i < left; i++)
            {
                Console.Write(" ");
            }
            #endregion

            #region Kolay Çözüm :D
            //Console.SetCursorPosition(left, top); 
            #endregion

            Console.Write(symbol);
        }
        static void MoveLeft()
        {
            if (left > 0)
            {
                left--;
            }
            PrintSymbolOnScreen();
        }
        static void MoveRight()
        {
            left++;
            PrintSymbolOnScreen();
        }
        static void MoveUp()
        {
            if (top > 0)
            {
                top--;
            }
            PrintSymbolOnScreen();
        }
        static void MoveDown()
        {
            top++;
            PrintSymbolOnScreen();
        }
    }
}
