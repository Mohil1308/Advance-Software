using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_section
{
    public class drawTriangle : Shape
    {
        private Point[] point;

        public drawTriangle(Point[] point)
        {
            this.point = point;
        }

        public drawTriangle() { }

        /// <summary>
        /// Sets the coordinates and points for the triangle.
        /// </summary>
        /// <param name="x">The x-coordinate of the triangle.</param>
        /// <param name="y">The y-coordinate of the triangle.</param>
        /// <param name="points">An array of points representing the vertices of the triangle.</param>
        public override void setTriangle(int x, int y, Point[] points)
        {
            base.set(x, y);
            this.point = points;
        }
        /// <summary>
        /// Draws the triangle using the specified Graphics object, Pen, and Brush.
        /// </summary>
        /// <param name="graphic">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen object used for outlining the triangle.</param>
        /// <param name="brush">The Brush object used for filling the triangle.</param>
        public override void Draw(Graphics graphic, Pen pen, Brush brush)
        {
            graphic.DrawPolygon(pen, point);
            graphic.FillPolygon(brush, point);
        }
    }
}
