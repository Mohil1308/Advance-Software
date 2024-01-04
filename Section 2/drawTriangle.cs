using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2
{
    public class drawTriangle : Shape
    {
        private Point[] point;

        public drawTriangle(Point[] point)
        {
            this.point = point;
        }

        public drawTriangle() { }

        public override void setTriangle(int x, int y, Point[] points)
        {
            base.set(x, y);
            this.point = points;
        }

        public override void Draw(Graphics graphic, Pen pen, Brush brush)
        {
            graphic.DrawPolygon(pen, point);
            graphic.FillPolygon(brush, point);
        }
    }
}
