using System.Collections;

namespace Section_2
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;

        private string[] splitw;
        private string[] parm = new string[50];
        private int[] strSplit = new int[50];
        private int[] strError = new int[50];


        private int loopmax;
        private int loopstart;
        private int loopfinish;
        private int loopcount;
        private int errorno = 0;


        private bool lbit = false;
        private bool ifrslt = false;
        private bool strif = false;
        private bool condn = false;


        private Color pencolor = Color.Black;
        private Color brushcolor = Color.Cyan;
        private Random rndm = new Random();


        private Shape shape1;
        private shapeFactory factory = new shapeFactory();

        public Form1()
        {
            InitializeComponent();
            display.Image = new Bitmap(Size.Width, Size.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        public void excecuteCommand(ArrayList Currentline, string[] lines, int linecount)
        {


            int counter = 0;
            int jump = 0;


            while (lines.Length >= counter)
            {
                Graphics g = Graphics.FromImage(display.Image);
                Pen pen = new Pen(pencolor, 2);
                Brush brush = new SolidBrush(brushcolor);

                try
                {
                    if (jump != 0)
                    {
                        if (jump == counter)
                        {
                            counter++;
                            jump = 0;
                        }
                    }

                    splitw = (String[])Currentline[counter];


                    switch (splitw[0].ToLower())
                    {
                        case "circle":

                            int radius;
                            if (!int.TryParse(splitw[1], out radius))
                            {

                                radius = varCall((string)splitw[1]);
                                new DrawCircle(x, y, radius).Draw(g, pen, brush);
                            }
                            else if (int.TryParse(splitw[1], out radius))
                            {
                                int.TryParse(splitw[1], out radius);
                                new DrawCircle(x, y, radius).Draw(g, pen, brush);
                            }
                            else
                            {
                                MessageBox.Show("enter a radius or use a variable", "error");
                            }
                            break;
                        case "rect":

                            int width;

                            int height;
                            if (!int.TryParse(splitw[1], out width) || !int.TryParse(splitw[2], out height))
                            {
                                width = varCall(splitw[1]);
                                height = varCall(splitw[2]);
                                new DrawRectangle(x, y, width, height).Draw(g, pen, brush);

                            }
                            else
                            {
                                int.TryParse(splitw[1], out width);
                                int.TryParse(splitw[2], out height);
                                new DrawRectangle(x, y, width, height).Draw(g, pen, brush);
                            }
                            break;
                        case "square":
                            int side;
                            if (!int.TryParse(splitw[1], out side))
                            {
                                side = varCall(splitw[1]);
                                new DrawSquare(x, y, side).Draw(g, pen, brush);
                            }
                            else
                            {
                                int.TryParse(splitw[1], out side);
                                new DrawSquare(x, y, side).Draw(g, pen, brush);
                            }

                            break;
                        case "drawto":
                            int point1, point2;
                            if (!int.TryParse(splitw[1], out point1) || !int.TryParse(splitw[2], out point2))
                            {
                                point1 = varCall(splitw[1]);
                                point2 = varCall(splitw[2]);
                                g.DrawLine(pen, x, y, point1, point1);

                            }
                            else
                            {
                                int.TryParse(splitw[1], out point1);
                                int.TryParse(splitw[2], out point2);
                                g.DrawLine(pen, x, y, point1, point2);

                            }
                            break;
                        case "pen":
                            try
                            {
                                if (splitw[1] != "rand")
                                {
                                    pencolor = Color.FromName(splitw[1]);
                                }
                                else
                                {
                                    pencolor = Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256));
                                }
                            }
                            catch
                            {
                                pencolor = Color.Black;
                            }
                            break;
                        case "brush":
                            try
                            {
                                if (splitw[1] != "rand")
                                {
                                    brushcolor = Color.FromName(splitw[1]);
                                }
                                else
                                {
                                    brushcolor = Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256));

                                }

                            }
                            catch
                            {
                                brushcolor = Color.Black;
                            }
                            break;
                        case "triangle":
                            int p1, p2, p3;

                            if (!int.TryParse(splitw[1], out p1) || !int.TryParse(splitw[2], out p2) || !int.TryParse(splitw[3], out p3))
                            {
                                p1 = varCall(splitw[1]);
                                p2 = varCall(splitw[2]);
                                p3 = varCall(splitw[3]);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new DrawTriangle(pnt1).Draw(g, pen, brush);
                            }
                            else
                            {
                                int.TryParse(splitw[1], out p1);
                                int.TryParse(splitw[2], out p2);
                                int.TryParse(splitw[3], out p3);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new DrawTriangle(pnt1).Draw(g, pen, brush);
                            }
                            break;
                        case "clear":
                            g.Clear(Color.Transparent);
                            g.Dispose();
                            break;

                        case "moveto":

                            if (int.TryParse(splitw[1], out x) && int.TryParse(splitw[2], out y))
                            {
                                int.TryParse(splitw[1], out x);
                                int.TryParse(splitw[2], out y);
                            }
                            else
                            {
                                x = varCall(splitw[1]);
                                y = varCall(splitw[2]);
                            }

                            break;

                        case "var":
                            VarCheck(splitw[1], splitw[2]);
                            break;

                        case "loop":
                            lbit = true;
                            loopmax = 0;
                            loopcount = 0;
                            loopstart = counter;

                            if (int.TryParse(splitw[1], out loopmax))
                            {
                                int.TryParse(splitw[1], out loopmax);
                            }
                            else
                            {
                                loopmax = varCall(splitw[1]);
                            }

                            if (lines[counter] == "end" && loopcount != loopmax)
                            {
                                counter = loopfinish;
                                lbit = false;
                                break;
                            }
                            else if (lines[counter] == "end" && loopcount != loopmax)
                            {
                                loopcount++;
                                loopfinish = counter++;
                                counter = loopstart;
                                counter++;
                                break;

                            }
                            else
                            {
                                loopcount++;
                                break;
                            }
                        case "end":
                            if (loopcount == loopmax || loopcount > loopmax)
                            {

                            }
                            else
                            {
                                counter = loopstart;
                            }


                            break;
                        case "num":

                            x = rndm.Next(display.Width);
                            y = rndm.Next(display.Height);


                            brushcolor = Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256));
                            pencolor = Color.Black;

                            shape1 = factory.getShape(splitw[1]);
                            if (splitw[1].ToLower().Trim() == "circle")
                            {
                                radius = rndm.Next(Size.Width / 4);
                                shape1.set(x, y, radius);
                            }
                            else if (splitw[1].ToLower().Trim() == "rectangle")
                            {
                                width = rndm.Next(display.Width);
                                height = rndm.Next(display.Height);
                                shape1.set(x, y, width, height);
                            }
                            else if (splitw[1].ToLower().Trim() == "triangle")
                            {
                                p1 = rndm.Next(display.Width);
                                p2 = rndm.Next(display.Width);
                                p3 = rndm.Next(display.Width);
                                System.Drawing.Point pointa = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc = new System.Drawing.Point(p3, p1);
                                System.Drawing.Point[] pnt = { pointa, pointb, pointc };
                                shape1.setTriangle(x, y, pnt);
                            }
                            shape1.Draw(g, pen, brush);
                            display.Refresh();
                            break;
                        case "if":
                            int left;
                            int right;
                            string condition;
                            if (splitw.Length > 4)
                            {
                                MessageBox.Show("need more input", "Error");
                            }
                            else
                            {
                                if (!int.TryParse(splitw[1], out left))
                                {
                                    left = varCall(splitw[1]);
                                }
                                else
                                {
                                    int.TryParse(splitw[1], out left);
                                }

                                if (!int.TryParse(splitw[3], out right))
                                {
                                    right = varCall(splitw[3]);
                                }
                                else
                                {
                                    int.TryParse(splitw[3], out right);
                                }
                                condition = splitw[2];
                                ifcheck(left, condition, right);
                                if (ifrslt == true)
                                {

                                    jump = counter;
                                    jump++;
                                    jump++;



                                    break;
                                }
                                else
                                {

                                    counter++;

                                }




                            }

                            break;
                        case "endif":
                            jump = 0;
                            strif = false;
                            break;


                        default:
                            if (splitw[0].Trim() == null)
                            {

                            }
                            else
                            {
                                int i = 0;
                                if (parm[0] != null)
                                {
                                    while (49 >= i)
                                    {
                                        if (parm[i] == splitw[0])
                                        {
                                            //  MessageBox.Show(element[0] + " called", "whoop");
                                            if (!int.TryParse(splitw[1], out strSplit[i]))
                                            {
                                                MessageBox.Show(splitw[0] + "is all ready set to " + splitw[1], "info");
                                            }
                                            else
                                            {
                                                int.TryParse(splitw[1], out strSplit[i]);
                                                MessageBox.Show(splitw[0] + " variable is set to " + splitw[1], "info");
                                            }
                                            i = 50;
                                        }
                                        else if (i != parm.Length)
                                        {
                                            i++;
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show(splitw[0] + " not a Command", "Messgae");
                                }
                            }
                            break;

                    }
                    if (lbit == true)
                    {
                        loopcount++;
                    }
                    display.Refresh();

                }
                catch
                {
                }
                pen.Dispose();
                brush.Dispose();


                counter++;
            }



        }




    }
}
