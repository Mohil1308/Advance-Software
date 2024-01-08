using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_section
{
     class shapeFactory
    {
        /// <summary>
        /// Gets an instance of a shape based on the specified shape type.
        /// </summary>
        /// <param name="shapeType">The type of shape to create (e.g., "circle", "rect", "triangle").</param>
        /// <returns>An instance of the specified shape.</returns>
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
