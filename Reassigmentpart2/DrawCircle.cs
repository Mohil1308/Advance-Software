using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Reassigmentpart2
{
    public class CustomCircle : IShape
    {
        // Additional properties unique to CustomCircle
        private int diameter;
        private int x;
        private int y;

        // Constructor with additional parameters for CustomCircle
        public CustomCircle(int x, int y, int diameter) : base(x, y)
        {
            this.x = x;
            this.diameter = diameter;   
        }

        // Implementing methods from the IShape interface
        public void SetParameters(params int[] parameters)
        {
            if (parameters.Length >= 3)
            {
                object value = base.Set(parameters[0], parameters[1]); // Set x and y coordinates
                this.diameter = parameters[2] * 2; // Set diameter (radius * 2)
            }
            else
            {
                throw new ArgumentException("Invalid number of parameters for setting circle properties.");
            }
        }

        // Additional method for setting diameter directly
        public void SetDiameter(int diameter)
        {
            this.diameter = diameter;
        }

        // Overridden Draw method to draw the circle
        public override void DrawShape(Graphics graphics, Pen pen, Brush brush)
        {
            // Drawing the circle
            graphics.FillEllipse(brush, x, y, diameter, diameter);
            graphics.DrawEllipse(pen, x, y, diameter, diameter);   
        }

        // Override ToString method for CustomCircle
        public override string ToString()
        {
            return base.ToString() + "  " + this.diameter;
        }
    }

}
