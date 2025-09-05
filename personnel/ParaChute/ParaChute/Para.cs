using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaChute
{
    class Para
    {

        private string[] withoutParachute =
{
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
     };

        public string name;
        public int _x;
        public Para(string name)
        {
            this.name = name;
        }

        public void Draw()
        {
            for (int i = 0; i < withoutParachute.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.WriteLine(withoutParachute[i]);
            }
        }
    }
}