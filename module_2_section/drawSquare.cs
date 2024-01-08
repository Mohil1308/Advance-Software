using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_section
{
    class DrawSquare : DrawRectangle
    {
        readonly int size;
        public DrawSquare(int x, int y, int size) : base(x, y, size, size)
        {

            this.size = size;
        }

        /// <summary>
        /// Draws the square using the specified Graphics object, Pen, and Brush.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen object used for outlining the square.</param>
        /// <param name="brush">The Brush object used for filling the square.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            base.Draw(g, pen, brush);
        }

    }
}
