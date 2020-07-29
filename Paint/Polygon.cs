using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Polygon
    {
        public Polygon(){}
        public void ToListPoints(List<System.Drawing.Point> pnt, int x0, int y0, int radius, int amount, float angle = 0)
        {
            if (amount == 1) return;
            pnt.Clear();
            pnt.Add(new System.Drawing.Point((int)(x0 + radius * Math.Cos(angle * Math.PI / 180)), (int)(y0 + radius * Math.Sin(angle * Math.PI / 180))));
            for (int i = 0; i <= amount; i++)
            {
                pnt.Add(new System.Drawing.Point((int)(x0 + radius * Math.Cos(angle * Math.PI / 180)), (int)(y0 + radius * Math.Sin(angle * Math.PI / 180))));
                angle += (int)(360 / amount);
            }
        }
    }
}
