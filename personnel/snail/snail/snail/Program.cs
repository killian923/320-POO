using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(i,0);
                Snail();
                Console.SetCursorPosition(i, 0);
                Console.Write(" ");


                Thread.Sleep(150);
            }
            Console.Write(" ____");
            
            Console.Read();

        }
        static void Snail()
        {
            Console.Write("  _@_ö");
        }
    }
}
