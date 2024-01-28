using module_2_section;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module_2_section
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;

        //for partition
        private string[] splitw;
        private string[] parm = new string[50];
        private int[] strSplit = new int[50];
        private int[] strError = new int[50];

        //looping 
        private int loopmax;
        private int loopstart;
        private int loopfinish;
        private int loopcount;
        private int errorno = 0;


        //flag bits
        private bool lbit = false;
        private bool ifrslt = false;
        private bool strif = false;
        private bool condn = false;

        //universal colour
        private Color pencolor = Color.Black;
        private Color brushcolor = Color.Cyan;
        private Random rndm = new Random();

        //Shape Factory
        private Shape shape1;
        private shapeFactory factory = new shapeFactory();

        public Form1()
        {
            InitializeComponent();
            display.Image = new Bitmap(Size.Width, Size.Height);
        }
        /// <summary>
        /// Executes the commands specified in the given list of lines.
        /// </summary>
        /// <param name="Currentline">The list of commands to execute.</param>
        /// <param name="lines">The array of all lines in the script.</param>
        /// <param name="linecount">The total number of lines in the script.</param>
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
                                new drawTriangle(pnt1).Draw(g, pen, brush);
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
                                new drawTriangle(pnt1).Draw(g, pen, brush);
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

                    display.Invalidate();
                    display.Update();


                    if (lbit == true)
                    {
                        loopcount++;
                    }
                    display.Refresh();

                }
                catch
                {
                }
                finally
                {
                    g.Dispose();
                    pen.Dispose();
                    brush.Dispose();
                }
                pen.Dispose();
                brush.Dispose();


                counter++;
            }



        }


        private void myMethod()
        {
            // Assuming x, y, radius are available and represent the position and size of the circle
            int x = 100; // replace with your actual x-coordinate
            int y = 100; // replace with your actual y-coordinate
            int radius = 50; // replace with your actual radius

            // Method body
            // Line 1
            // Etc

            // Draw a circle
            Graphics g = Graphics.FromImage(display.Image); // Replace 'display' with your actual PictureBox or control
            Pen pen = new Pen(pencolor, 2); // Replace 'pencolor' with your actual pen color
            Brush brush = new SolidBrush(brushcolor); // Replace 'brushcolor' with your actual brush color

            // Assuming you have a DrawCircle method that draws a circle
            new DrawCircle(x, y, radius).Draw(g, pen, brush);

            // Clean up resources
            g.Dispose();
            pen.Dispose();
            brush.Dispose();

            // For example, let's display a message
            Console.WriteLine("myMethod without parameters has been executed, and a circle has been drawn.");
        }




        private bool ifcheck(int left, string condition, int right) // used to check if sattment 
        {
            switch (condition)
            {

                case "=":
                    if (left == right)
                    {
                        ifrslt = true;
                    }
                    else
                    {
                        ifrslt = false;
                    }
                    break;
                case ">":
                    if (left > right)
                    {
                        ifrslt = true;
                    }
                    else
                    {
                        ifrslt = false;
                    }

                    break;
                case "<":
                    if (left < right)
                    {
                        ifrslt = true;
                    }
                    else
                    {
                        ifrslt = false;
                    }

                    break;
                case "!":
                    if (left != right)
                    {
                        ifrslt = true;
                    }
                    else
                    {
                        ifrslt = false;
                    }

                    break;

                default:
                    MessageBox.Show("condition is not correct please check", "error");

                    break;

            }

            return ifrslt;
        }

        private void VarCheck(string element1, string element2)
        {
            try
            {
                bool variableExists = false;
                int index = 0;

                // Check if the variable already exists
                while (index < parm.Length && parm[index] != null)
                {
                    if (parm[index].Equals(element1))
                    {
                        variableExists = true;
                        break;
                    }
                    index++;
                }

                if (variableExists)
                {
                    MessageBox.Show("Variable already declared", "Error");
                }
                else
                {
                    // Find an empty slot or the first null element
                    index = 0;
                    while (index < parm.Length && parm[index] != null)
                    {
                        index++;
                    }

                    if (index < parm.Length)
                    {
                        parm[index] = element1;
                        int.TryParse(element2, out strSplit[index]);
                    }
                    else
                    {
                        MessageBox.Show("Reached maximum variable limit", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
        private int varCall(string variable)
        {
            int i = 0;
            int number = -1;
            while (49 >= i)
            {
                if (parm[i] == variable)
                {

                    number = strSplit[i];
                    i = 50;
                }
                else
                {
                    i++;
                }

            }
            if (number == 0)
            {
                MessageBox.Show("not a variable", "error");
            }
            return number;

        }

        private void Commandline_KeyDown(object sender, KeyEventArgs e) //used to run the program
        {
            if (e.KeyCode == Keys.Enter)
            {

                String txtdata = commandline.Text;
                if (txtdata.Trim() == "")
                {
                    MessageBox.Show("Kindly enter any command first", "ERROR");

                }
                else
                {
                    String[] line;
                    String[] lines;
                    ArrayList Currentline = new ArrayList();
                    int i = 0;
                    if (txtdata.ToLower().Trim() == "run")
                    {
                        lines = Controlepanel.Lines.ToArray();
                        while (lines.Length != i)
                        {

                            line = lines[i].Split(' ');
                            Currentline.Add(line);
                            i++;
                        }

                    }
                    else
                    {
                        lines = commandline.Lines.ToArray();
                        line = commandline.Text.Split(' ');
                        Currentline.Add(line);


                    }
                    int length = lines.Length;

                    Check(Currentline, lines, length);
                    int L = 0;
                    Array.Clear(parm, 0, parm.Length);//used to cleare the vars array befreo exicution
                    Array.Clear(strSplit, 0, strSplit.Length);
                    string errors = string.Join(", ", strError.Where(x => x != 0));


                    if (condn == false)
                    {

                        MessageBox.Show("Errors on lines :" + errors + ".", "error");
                    }
                    else
                    {

                        excecuteCommand(Currentline, lines, length);
                    }


                }
            }


        }
        /// <summary>
        /// Draws a custom shape composed of a circle, rectangle, and triangle.
        /// </summary>
        /// <param name="g">The Graphics object for drawing.</param>
        /// <param name="pen">The Pen object for outlining the shapes.</param>
        /// <param name="brush">The Brush object for filling the shapes.</param>
        /// <param name="circleSize">The size of the circle.</param>
        /// <param name="rectangleWidth">The width of the rectangle.</param>
        /// <param name="rectangleHeight">The height of the rectangle.</param>
        /// <param name="triangleSize">The size of the triangle.</param>
        private void DrawShape(Graphics g, Pen pen, Brush brush, int circleSize, int rectangleWidth, int rectangleHeight, int triangleSize)
        {
            // Get the center of the display
            int centerX = display.Width / 2;
            int centerY = display.Height / 2;

            // Draw a circle
            DrawCircle circle = new DrawCircle(centerX, centerY, circleSize);
            circle.Draw(g, pen, brush);

            // Draw a rectangle
            DrawRectangle rectangle = new DrawRectangle(centerX + 50, centerY, rectangleWidth, rectangleHeight);
            rectangle.Draw(g, pen, brush);

            // Draw a triangle
            System.Drawing.Point[] trianglePoints = { new Point(centerX + 150, centerY), new Point(centerX + 250, centerY + triangleSize), new Point(centerX + 300, centerY) };
            drawTriangle triangle = new drawTriangle();
            triangle.setTriangle(centerX, centerY, trianglePoints);
            triangle.Draw(g, pen, brush);
        }

        /// <summary>
        /// Draws a kite shape composed of a circle, rectangle, and triangle.
        /// </summary>
        /// <param name="g">The Graphics object for drawing.</param>
        /// <param name="pen">The Pen object for outlining the shapes.</param>
        /// <param name="brush">The Brush object for filling the shapes.</param>
        /// <param name="circleSize">The size of the circle.</param>
        /// <param name="rectangleWidth">The width of the rectangle.</param>
        /// <param name="rectangleHeight">The height of the rectangle.</param>
        /// <param name="triangleSize">The size of the triangle.</param>

        private void DrawKite(Graphics g, Pen pen, Brush brush, int circleSize, int rectangleWidth, int rectangleHeight, int triangleSize)
        {

            int centerX = display.Width / 2;
            int centerY = display.Height / 2;


            DrawCircle topCircle = new DrawCircle(centerX, centerY - circleSize * 2, circleSize);
            topCircle.Draw(g, pen, brush);


            DrawRectangle diamond = new DrawRectangle(centerX - rectangleWidth / 2, centerY, rectangleWidth, rectangleHeight);
            diamond.Draw(g, pen, brush);


            System.Drawing.Point[] trianglePoints = { new Point(centerX, centerY + rectangleHeight / 2),
                                              new Point(centerX - triangleSize, centerY + rectangleHeight / 2 + triangleSize),
                                              new Point(centerX + triangleSize, centerY + rectangleHeight / 2 + triangleSize) };

            drawTriangle tailTriangle = new drawTriangle();
            tailTriangle.setTriangle(centerX, centerY, trianglePoints);
            tailTriangle.Draw(g, pen, brush);
        }


        /// <summary>
        /// Defines a method that draws a specific shape.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen object used for outlining the shape.</param>
        /// <param name="brush">The Brush object used for filling the shape.</param>
        /// <param name="shapeType">The type of shape to draw.</param>
        /// <param name="size">The size of the shape (e.g., radius, side length).</param>
       

        private void Exampl1()
        {
            Graphics g = display.CreateGraphics(); // Assuming "display" is the control where you want to draw

            Pen pen = Pens.Black;
            Brush brush = Brushes.Red;

            int circleSize = 30;
            int rectangleWidth = 60;
            int rectangleHeight = 80;
            int triangleSize = 30;

            DrawKite(g, pen, brush, circleSize, rectangleWidth, rectangleHeight, triangleSize);
        }

        private void Exampl2()
        {
            // Use the existing Graphics object from the display
            Graphics g = Graphics.FromImage(display.Image);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Cyan);

            // Specify the sizes
            int circleSize = 40;
            int rectangleWidth = 50;
            int rectangleHeight = 30;
            int triangleSize = 20;

            // Call the DrawCustomShape method
            DrawShape(g, pen, brush, circleSize, rectangleWidth, rectangleHeight, triangleSize);
            MessageBox.Show("Drawing completed!");


            display.Refresh();
        }

        public void Check(ArrayList currentline, string[] lines, int length)// checks the syntax of the user input
        {
            int count = 0;
            int errors = 0;
            errorno = 0;
            condn = true;
            int k = 0;
            int linenumber = 0;


            while (lines.Length >= count)
            {

                errors = errorno;
                try
                {
                    splitw = (String[])currentline[count];


                    switch (splitw[0].ToLower())
                    {
                        case "circle":
                            if (splitw.Length != 2)
                            {
                                errorno++;
                            }

                            break;

                        case "rect":
                            if (splitw.Length != 3)
                            {
                                errorno++;
                            }

                            break;

                        case "square":
                            if (splitw.Length != 3)
                            {
                                errorno++;
                            }
                            break;

                        case "drawto":
                            if (splitw.Length != 3)
                            {
                                errorno++;
                            }

                            break;
                        case "pen":
                            if (splitw.Length != 2)
                            {
                                errorno++;
                            }
                            break;
                        case "brushcolor":
                            if (splitw.Length != 2)
                            {
                                errorno++;
                            }
                            break;
                        case "triangle":
                            if (splitw.Length != 4)
                            {
                                errorno++;
                            }

                            break;
                        case "clear":


                            break;
                        case "movex":
                            if (splitw.Length != 2)
                            {
                                errorno++;
                            }

                            break;
                        case "movey":
                            if (splitw.Length != 2)
                            {
                                errorno++;
                            }

                            break;
                        case "moveto":
                            if (splitw.Length != 3)
                            {
                                errorno++;
                            }


                            break;

                        case "var":

                            if (splitw.Length != 3)
                            {
                                errorno++;
                            }
                            else
                            {
                                VarCheck(splitw[1], splitw[2]);
                            }

                            break;

                        case "loop":
                            if (splitw.Length != 2)
                            {
                                errorno++;
                            }
                            break;
                        case "end":
                            if (splitw.Length != 1)
                            {
                                errorno++;
                            }
                            break;
                        case "factory":
                            if (splitw.Length != 2)
                            {
                                errorno++;
                            }

                            break;
                        case "if":
                            if (splitw.Length != 4)
                            {
                                errorno++;
                            }

                            break;
                        case "endif":
                            if (splitw.Length != 1)
                            {
                                errorno++;
                            }
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
                                                MessageBox.Show(splitw[0] + "is all ready set to " + splitw[1], "whoop");
                                            }
                                            else
                                            {
                                                int.TryParse(splitw[1], out strSplit[i]);
                                                MessageBox.Show(splitw[0] + " variable is set to " + splitw[1], "whoop");
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
                                    errorno++;
                                }
                            }
                            break;


                    }
                    if (errors != errorno)
                    {
                        linenumber = count;
                        linenumber++;
                        strError[k] = linenumber;
                        k++;
                        errors++;


                    }
                }
                catch
                {

                }
                count++;
                if (errorno != 0)
                {
                    condn = false;
                }
                else
                {
                    condn = true;
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream(Encoding.UTF8.GetBytes(Controlepanel.Text));

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = save.ShowDialog();
            Stream fileStream;

            if (result == DialogResult.OK)
            {

                fileStream = save.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                userInput.Close();

            }
            save.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String input = Controlepanel.Text;
            if (input.Trim() == "")
            {
                MessageBox.Show("Enter a command", "ERROR");

            }
            else
            {
                String[] line;
                String[] lines;
                ArrayList Currentline = new ArrayList();
                int i = 0;
                lines = Controlepanel.Lines.ToArray();
                while (lines.Length != i)
                {

                    line = lines[i].Split(' ');
                    Currentline.Add(line);
                    i++;
                }
                int length = lines.Length;

                Check(Currentline, lines, length);
                int L = 0;
                Array.Clear(parm, 0, parm.Length);//used to cleare the vars array befreo exicution
                Array.Clear(strSplit, 0, strSplit.Length);
                string errors = string.Join(", ", strError.Where(x => x != 0));


                if (condn == false)
                {

                    MessageBox.Show("Error Occur in Line no. :" + errors + ".", "error");
                }
                else
                {

                    excecuteCommand(Currentline, lines, length);
                }

            }
        }

        private void method1_Click(object sender, EventArgs e)
        {
            Exampl2();
        }

        private void method2_Click(object sender, EventArgs e)
        {
            Exampl1();
        }


        private void button4_Click(object sender, EventArgs e)
        {

            Controlepanel.Text = "";
            commandline.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "TXT Files|*.txt";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                Controlepanel.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
            openFile1.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
