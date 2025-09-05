using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaChute
{
    class Plane
    {
        private int _x;
        private int _altitude;
        public List<Para> parachutists;

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public Plane()
        {
            _x = 0;
            _altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }
        public void draw()
        {

            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.WriteLine(view[i]);
            }
        }


        public void update()
        {
            if (_x >= Config.SCREEN_WIDTH - 5)
            {
                _x = 0;
            }
            else
            {
                _x++;
            }
        }
        public void board(Para para)
        {
            this.parachutists.Add(para);
        }
        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = _x;
            parachutist.altitude = this._altitude;
            return parachutist;
        }
    }
}
