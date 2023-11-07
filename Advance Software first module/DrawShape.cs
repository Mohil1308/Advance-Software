using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Advance_Software_first_module
{
    public class DrawShape
    {
        private static int _a, _b;
        static private Bitmap _NPicture = new Bitmap(640, 480);
        static SolidBrush _FillColor;
        static Boolean _isFill;
        static Boolean _isUnitValid;
        static Color _penColor;
        public static Boolean isFill
        {
            get
            {
                return _isFill;
            }
            set { _isFill = value; }
        }
        public static SolidBrush FillColor
        {
            get
            {
                return _FillColor;
            }
            set { _FillColor = value; }
        }
        public static Bitmap NPicture
        {
            get
            {
                return _NPicture;
            }
            set { _NPicture = value; }
        }
        public static int a
        {
            get
            {
                return _a;
            }
            set { _a = value; }
        }
        public static int b
        {
            get
            {
                return _b;
            }
            set { _b = value; }
        }
        public static Color penColor
        {
            get
            {
                return _penColor;
            }
            set { _penColor = value; }
        }
        public static Boolean isUnitValid
        {
            get
            {
                return _isUnitValid;
            }
            set { _isUnitValid = value; }
        }
    }
}
