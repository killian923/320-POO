using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaChute
{
    static class Config
    {
        public const int SCREEN_HEIGHT = 40;
        public const int SCREEN_WIDTH = 150;
    }


    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            Plane plane = new Plane();

            while (true)
            {

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();
                plane.update(); 

                Thread.Sleep(100);

            }
        }
    }
    class Plane
    {
        private int _x = 5;
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        public void draw()
        {

            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.WriteLine(view[i]);
            }
        }
        private int Cal(int _x)
        {
            _x += 1;
            return _x;
        }

        public void update()
        {
            _x = Cal(this._x);
        }



    }
}
