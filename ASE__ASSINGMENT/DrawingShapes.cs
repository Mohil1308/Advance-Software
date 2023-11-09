using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE__ASSINGMENT
{
    /// <summary>
    /// This class represents a container for various drawing-related properties and settings.
    /// </summary>
    // This class represents a container for various drawing-related properties and settings.
    public class DrawingShapes
    {
        // Private fields to store drawing-related information.
        private static int _x, _y;
        static private Bitmap _nPicture = new Bitmap(640, 480);
        static SolidBrush _drawColor;
        static Boolean _Fill;
        static Boolean _isUnitValid;
        static Color _pColor;

        /// <summary>
        /// Gets or sets a value indicating whether to fill shapes during drawing.
        /// </summary>
        // Public property for Fill setting.
        public static Boolean Fill
        {
            get
            {
                return _Fill;
            }
            set { _Fill = value; }
        }

        /// <summary>
        /// Gets or sets the brush used for drawing.
        /// </summary>
        // Public property for the brush used for drawing.
        public static SolidBrush drawColor
        {
            get
            {
                return _drawColor;
            }
            set { _drawColor = value; }
        }

        /// <summary>
        /// Gets or sets the bitmap that holds the drawing.
        /// </summary>
        // Public property for the bitmap that holds the drawing.
        public static Bitmap nPicture
        {
            get
            {
                return _nPicture;
            }
            set { _nPicture = value; }
        }

        /// <summary>
        /// Gets or sets the X-coordinate of the drawing.
        /// </summary>
        // Public properties for X and Y coordinates.
        public static int x
        {
            get
            { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Gets or sets the Y-coordinate of the drawing.
        /// </summary>
        public static int y
        {
            get
            { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Gets or sets the current pen color.
        /// </summary>
        // Public property for the current pen color.
        public static Color pColor
        {
            get { return _pColor; }
            set { _pColor = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a unit is valid.
        /// </summary>
        // Public property to determine if a unit is valid.
        public static Boolean isUnitValid
        {
            get { return _isUnitValid; }
            set { _isUnitValid = value; }
        }
    }
}
