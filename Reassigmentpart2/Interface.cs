using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reassigmentpart2
{
    public interface IShape
    {
        // Define methods for setting shape parameters
        void SetParameters(params int[] parameters);

        // Define method for drawing the shape
        void DrawShape(Graphics graphics, Pen pen, Brush brush);
    }
}
