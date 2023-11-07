using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE__ASSINGMENT
{
    public class DrawingPaper
    {
        //Graphics variable for graphic funcation
        Graphics gra;
        //Pen variable
        Pen pe;
        //Two integer variable x and y which show live position 
        int x, y;
        //decalre live position to show current pointer
        Rectangle livePos;
        //declare live shape to get live shape
        Rectangle liveShape;

        public DrawingPaper()
        {
            //Graphics instance and asign value to bitmap
            this.gra = Graphics.FromImage(DrawingShapes.nPicture);
            //Set pen as black
            pe = new Pen(Color.Black, 1);
            //Give value to x and y from get set method
            x = DrawingShapes.x;
            y = DrawingShapes.y;
        }

        public void DrawLine(int xpos, int ypos)
        {
            try
            {
                //Make condition to check line has color or not
                if (DrawingShapes.Fill)
                {
                    //Give pen with new color and draw line
                    pe = new Pen(DrawingShapes.pColor, 1);
                    this.gra.DrawLine(pe, x, y, xpos, ypos);
                }
                else
                    //Black Line
                    this.gra.DrawLine(pe, x, y, xpos, ypos);
                //Give pen color default as black
                pe = new Pen(Color.Black, 1);
                //Give value if function run successfully for unit testing
                DrawingShapes.isUnitValid = true;
            }
            catch (Exception ex)
            {
                //Give print message if any time error occure
                PrintMessage(ex.Message);
                DrawingShapes.isUnitValid = false;
            }

        }

        public void DrawSquare(int width)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (width / 2);
                liveShape = new Rectangle(xpos, ypos, width, width);
                if (DrawingShapes.Fill)
                    this.gra.FillRectangle(DrawingShapes.drawColor, liveShape);
                this.gra.DrawRectangle(pe, liveShape);
                DrawingShapes.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawingShapes.isUnitValid = false;
            }
        }

        public void DrawRect(int width, int height)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (height / 2);
                liveShape = new Rectangle(xpos, ypos, width, height);
                if (DrawingShapes.Fill)
                    this.gra.FillRectangle(DrawingShapes.drawColor, liveShape);
                this.gra.DrawRectangle(pe, liveShape);
                DrawingShapes.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawingShapes.isUnitValid = false;
            }
        }

        public void DrawCircle(int width)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (width / 2);
                liveShape = new Rectangle(xpos, ypos, width, width);
                if (DrawingShapes.Fill)
                    this.gra.FillEllipse(DrawingShapes.drawColor, liveShape);
                this.gra.DrawEllipse(pe, xpos, ypos, width, width);
                DrawingShapes.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawingShapes.isUnitValid = false;
            }
        }

        public void MovePoint(int xpos, int ypos)
        {
            try
            {
                pe = new Pen(SystemColors.ActiveBorder, 2);
                this.gra.DrawRectangle(pe, livePos);
                pe = new Pen(Color.Red, 2);
                livePos = GetRectangle(xpos, ypos, 2, 2);
                this.gra.DrawRectangle(pe, livePos);
                x = DrawingShapes.x = xpos;
                y = DrawingShapes.y = ypos;
                pe = new Pen(Color.Black, 1);
                DrawingShapes.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawingShapes.isUnitValid = false;
            }
        }

        public void DrawTriangle(int xpos, int ypos, int zpos)
        {
            try
            {
                int tx, ty, cx, cy;
                cx = Convert.ToInt32(x - (xpos / 3));
                cy = Convert.ToInt32(y - (ypos / 3));
                tx = Convert.ToInt32(cx + xpos);
                ty = Convert.ToInt32(cy + ypos);

                Point[] points = new Point[3];
                points[0] = new Point(cx, cy);
                points[1] = new Point(tx, cy);
                points[2] = new Point(cx, ty);
                if (DrawingShapes.Fill)
                    this.gra.FillPolygon(DrawingShapes.drawColor, points);
                this.gra.DrawPolygon(pe, points);
                DrawingShapes.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawingShapes.isUnitValid = false;
            }
        }

        public void CurrPoint(Boolean flg)
        {
            pe = new Pen(Color.Red, 2);
            if (flg)
            {
                livePos = GetRectangle(DrawingShapes.x, DrawingShapes.y, 2, 2);
                this.gra.DrawRectangle(pe, livePos);
            }
            else
            {
                x = y = 0;
                DrawingShapes.x = DrawingShapes.y = 0;
                livePos = GetRectangle(x, y, 2, 2);
                this.gra.DrawRectangle(pe, livePos);
            }
            pe = new Pen(Color.Black, 1);
        }

        public void PrintMessage(String ErrMsg)
        {
            using (Font myFont = new Font("Arial", 8))
            {
                gra.DrawString(ErrMsg, myFont, Brushes.Black, new Point(5, 5));
            }
        }

        private Rectangle GetRectangle(int rx, int ry, int rwidth, int rheight)
        {
            return new Rectangle(rx, ry, rwidth, rheight);
        }
    }
}
