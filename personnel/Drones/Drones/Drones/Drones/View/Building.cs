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
    
   
}
