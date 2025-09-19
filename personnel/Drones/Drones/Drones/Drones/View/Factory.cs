using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private const int FULLCHARGE = 10000;
        private int _PowerConsumption;
        private int _nombreDecimales = 2;
        private double _resultatArrondi;


        public Factory(int x, int y, Color colorDef, int largeur, int profondeur) : base(x, y, colorDef, largeur, profondeur)
        {
            _PowerConsumption = nbrRandom.rnd.Next(FULLCHARGE);
            _resultatArrondi = Math.Round((double)((double)_PowerConsumption / 1000 * 100.5), _nombreDecimales);

        }


        public new void Render(BufferedGraphics drawingSpace)
        {
            Brush BuildingBrush = new SolidBrush(BuildingColor);
            drawingSpace.Graphics.FillRectangle(BuildingBrush, new Rectangle(X, Y, Largeur, Profondeur));
            Console.WriteLine(_resultatArrondi);
        }
      
    }
}
