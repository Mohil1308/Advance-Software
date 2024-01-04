using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2
{
    interface  shapeInterface
    {
        void set(params int[] list);
        void setTriangle(int x, int y, Point[] points);
        void Draw(Graphics g, Pen pen, Brush brush);

    }
}

