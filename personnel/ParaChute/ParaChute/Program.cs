using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaChute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            ConsoleKeyInfo keyPressed;


            Plane plane = new Plane();

            for (int z = 0; z < 8; z++)
            {
                plane.board(new Para("Bob " + z.ToString()));
            }

            while (true)
            {
                plane.update();

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();



                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;

                        case ConsoleKey.Spacebar:

                            break;
                    }
                }

                Thread.Sleep(100);

            }
        }
    }
}