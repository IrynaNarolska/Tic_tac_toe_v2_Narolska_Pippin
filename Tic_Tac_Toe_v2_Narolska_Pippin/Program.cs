using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_v2_Narolska_Pippin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.SetCursorPosition(5, 1);
            Console.WriteLine("\t\t---LEVEL 1---   ---LEVEL 2---   ---LEVEL 3---");

            //Console.SetCursorPosition(5, 2);
            //Console.Write("\t\t|---+---+---|   |---+---+---|   |---+---+---|");

            Console.SetCursorPosition(0, 3);

            Console.Write("\t\t|---+-- -+---|\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\t        | ");

                for (int j = 0; j < 3; j++)
                {
                    //if (_gameboard.PositionState[i, j] == Gameboard.PlayerPiece.None)
                    //{
                    //    Console.Write(" " + " | ");
                    //}
                    //else
                    //{
                    //    Console.Write(_gameboard.PositionState[i, j] + " | ");
                    //}

                }

                Console.Write("\n\t\t|---+---+---|\n");
                Console.ReadKey();
            }
        }
    }
}
