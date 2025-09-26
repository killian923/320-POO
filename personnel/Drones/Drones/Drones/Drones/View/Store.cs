using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Store : Building
    {
        private string[] _openingHours;
        private static bool alreadyDisplayed = false;

        public string[] OpeningHours { get => _openingHours; set => _openingHours = value; }

        public Store(int x, int y, Color colorDef, int largeur, int profondeur, string[] openingHours) : base(x, y, colorDef, largeur, profondeur)
        {
            _openingHours = openingHours;
        }
        public new void Render(BufferedGraphics drawingSpace)
        {
            Brush BuildingBrush = new SolidBrush(BuildingColor);
            drawingSpace.Graphics.FillEllipse(BuildingBrush, new Rectangle(X, Y, Largeur, Profondeur));

            if (!alreadyDisplayed)
            {
                Console.Write("Store : ");
                Console.WriteLine(string.Join(" ", _openingHours));
                alreadyDisplayed = true;
            }

        }
}
}
