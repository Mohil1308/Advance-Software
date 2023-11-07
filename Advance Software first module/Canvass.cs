using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;
using System.Runtime.Versioning;

namespace Advance_Software_first_module
{
    public class Canvass
    {
        Graphics gra;
        Pen pe;
        int a, b;
        Rectangle LivePos;
        Rectangle LiveSha;
        public Canvass()
        {
            this.gra = Graphics.FromImage(DrawShape.NPicture);
            pe = new Pen(Color.Black, 1);
            a = DrawShape.a;
            b = DrawShape.b;
        }
        public void DrLine(int apos, int bpos)
        {
            try
            {
                if (DrawShape.isFill)
                {
                    pe = new Pen(DrawShape.penColor, 1);
                    this.gra.DrawLine(pe, a, b, apos, bpos);
                }
                else
                    this.gra.DrawLine(pe, a, b, apos, bpos);
                pe = new Pen(Color.Black, 1);
                DrawShape.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawShape.isUnitValid = false;

            }
        }
        public void DrTriangle(int apos, int bpos, int cmdC)
        {
            try
            {
                int ma, mb, na, nb;
                na = Convert.ToInt32(a - (apos / 3));
                nb = Convert.ToInt32(b - (bpos / 3));
                ma = Convert.ToInt32(na + apos);
                mb = Convert.ToInt32(nb + bpos);
                Point[] points = new Point[3];
                points[0] = new Point(na, nb);
                points[1] = new Point(ma, mb);
                points[2] = new Point(na, mb);
                if (DrawShape.isFill)
                    this.gra.FillPolygon(DrawShape.FillColor, points);
                this.gra.DrawPolygon(pe, points);
                DrawShape.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawShape.isUnitValid = false;
            }
        }
        public void DrSquare(int wid)
        {
            try
            {
                int apos = a - (wid / 2);
                int bpos = b - (wid / 2);
                LiveSha = new Rectangle(apos, bpos, wid, wid);
                if (DrawShape.isFill)
                    this.gra.FillRectangle(DrawShape.FillColor, LiveSha);
                this.gra.DrawRectangle(pe, LiveSha);
                DrawShape.isUnitValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DrawShape.isUnitValid = false;
            }
        }
        public void DrRect(int wid, int hei)
        {
            try
            {
                int apos = a - (wid / 2);
                int bpos = b - (hei / 2);
                LiveSha = new Rectangle(apos, bpos, wid, hei);
                if (DrawShape.isFill)
                    this.gra.FillRectangle(DrawShape.FillColor, LiveSha);
                this.gra.DrawRectangle(pe, LiveSha);
                DrawShape.isUnitValid = true;

            }
            catch (Exception ex)
            {

                PrintMessage(ex.Message);
                DrawShape.isUnitValid = false;
            }
        }
        public void DrCircle(int wid)
        {
            try
            {
                int apos = a - (wid / 2);
                int bpos = b - (wid / 2);
                LiveSha = new Rectangle(apos, bpos, wid, wid);
                if (DrawShape.isFill)
                    this.gra.FillEllipse(DrawShape.FillColor, LiveSha);
                this.gra.DrawEllipse(pe, apos, bpos, wid, wid);
                DrawShape.isUnitValid = true;

            }
            catch (Exception ex)
            {

                PrintMessage(ex.Message);
                DrawShape.isUnitValid = false;
            }
        }
        public void LivePointer(Boolean flg)
        {
            pe = new Pen(Color.Red, 2);
            if (flg)
            {
                LivePos = GetRect(DrawShape.a, DrawShape.b, 2, 2);
                this.gra.DrawRectangle(pe, LivePos);
            }
            else
            {
                a = b = 0;
                DrawShape.a = DrawShape.b = 0;
                LivePos = GetRect(a, b, 2, 2);
                this.gra.DrawRectangle(pe, LivePos);
            }
            pe = new Pen(Color.Black, 1);
        }
        public void MoPoint(int apos, int bpos)
        {
            try
            {
                pe = new Pen(SystemColors.ActiveBorder, 2);
                this.gra.DrawRectangle(pe, LivePos);
                pe = new Pen(Color.Red, 2);
                LivePos = GetRect(apos, bpos, 2, 2);
                this.gra.DrawRectangle(pe, LivePos);
                a = DrawShape.a = apos;
                b = DrawShape.b = bpos;
                pe = new Pen(Color.Black, 1);
                DrawShape.isUnitValid = true;

            }
            catch (Exception ex)
            {

                PrintMessage(ex.Message);
                DrawShape.isUnitValid = false;
            }
        }


        private Rectangle GetRect(int xa, int xb, int xwid, int xhei)
        {
            return new Rectangle(xa, xb, xwid, xhei);
        }

        public void PrintMessage(String ErrMsg)
        {
            using (Font myFont = new Font("Calibri", 8))
            {
                gra.DrawString(ErrMsg, myFont, Brushes.Black, new Point(5, 5));
            }
        }
    }
}
