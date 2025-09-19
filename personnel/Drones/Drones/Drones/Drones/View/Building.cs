using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    public partial class Building
    {
        public void Render(BufferedGraphics drawingSpace)
        {
            Brush BuildingBrush = new SolidBrush(BuildingColor);
            drawingSpace.Graphics.FillRectangle(BuildingBrush, new Rectangle(X,Y, Largeur, Profondeur));
        }
    }
    public partial class Factory : Building
    {
        private const int FULLCHARGE = 10000;
        private int _PowerConsumption;
        private int nombreDecimales = 2;

        public Factory(int x, int y, Color colorDef, int largeur, int profondeur) : base(x, y, colorDef, largeur, profondeur)
        {
            _PowerConsumption = nbrRandom.rnd.Next(FULLCHARGE);
        }
        public new void Render(BufferedGraphics drawingSpace)
        {
            Brush BuildingBrush = new SolidBrush(BuildingColor);
            drawingSpace.Graphics.FillRectangle(BuildingBrush, new Rectangle(X, Y, Largeur, Profondeur));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X + 10, Y - 20);
        }
        public override string ToString()
        {
            double resultatArrondi = Math.Round((double)((double)_PowerConsumption / 1000 * 100.5), nombreDecimales);
            return $" KwH ({resultatArrondi.ToString()}%)";
        }
    }
}
