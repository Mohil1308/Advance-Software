using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2
{
     class shapeFactory
    {
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToLower().Trim();
            if (shapeType.Equals("circle"))
            {
                return new DrawCircle();

            }
            else if (shapeType.Equals("rect"))
            {
                return new DrawRectangle();

            }
            else if (shapeType.Equals("triangle"))
            {
                return new drawTriangle();
            }
            else
            {
                System.ArgumentException argEx = new System.ArgumentException("Factory Exception occur : " + shapeType + " is not available");
                throw argEx;
            }


        }
    }
}
