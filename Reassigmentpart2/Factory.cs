using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reassigmentpart2
{
    public class ShapeFactory
    {

        public void GetShape(string shapeType)
        {

            shapeType = shapeType.ToLower().Trim();
            if (shapeType.Equals("circle"))
            {
                return new CustomCircle();

            }
            else if (shapeType.Equals("rectangle"))
            {
                return new DrawRectangel();

            }
            else if (shapeType.Equals("triangle"))
            {
                return new DrawTriangle();
            }
            else if (shapeType.Equals("square"))
            {
                return new DrawSquare();
            }
            else
            {
                throw new ArgumentException("Factory Exception: " + shapeType + " is not available");
            }
        }
    }


}
