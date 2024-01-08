using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_section
{
    /// <summary>
    /// Represents an interface for shapes that can be drawn.
    /// </summary>
    interface shapeInterface
    {
        /// <summary>
        /// Sets the position or dimensions of the shape.
        /// </summary>
        /// <param name="list">An array of integers representing position or dimensions.</param>
        void set(params int[] list);
        void setTriangle(int x, int y, Point[] points);
        void Draw(Graphics g, Pen pen, Brush brush);
    }
}

