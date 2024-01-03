using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2
{
    class DrawSquare : DrawRectangle
    {
        readonly int size;
        public DrawSquare(int x, int y, int size) : base(x, y, size, size)
        {

            this.size = size;
        }


        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            base.Draw(g, pen, brush);
        }

    }
}
