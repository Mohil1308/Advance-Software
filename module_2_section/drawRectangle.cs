using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_section
{
    public class DrawRectangle : Shape
    {

        private int width;
        private int height;
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawRectangle"/> class with specified coordinates, width, and height.
        /// </summary>
        /// <param name="x">The x-coordinate of the top-left corner of the rectangle.</param>
        /// <param name="y">The y-coordinate of the top-left corner of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public DrawRectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width;
            this.height = height;
        }
        public DrawRectangle() { }
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            g.FillRectangle(brush, x, y, width, height);
            g.DrawRectangle(pen, x, y, width, height);
        }
    }

}
