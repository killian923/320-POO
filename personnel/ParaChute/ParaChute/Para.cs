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
        public int x;
        public int altitude;

        public Para(string name)
        {
            this.name = name;
        }

        public void Draw()
        {
           
        }
    }
}