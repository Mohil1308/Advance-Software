using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE__ASSINGMENT
{
    public partial class Form1 : Form
    {
        DrawingControl d;
        public Form1()
        {
            // Initialize the drawing control and set the initial position to (0, 0).
            InitializeComponent();
            DrawingShapes.x = DrawingShapes.y = 0;
            d = new DrawingControl();
            d.CurrPoint(false);
            Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flg = false;
            if (richTextBox1.Text.Trim() != string.Empty)
            {
                // Execute drawing commands from the rich text box.
                d.runCommands(richTextBox1.Text.Trim());
                richTextBox1.Focus();
                richTextBox1.Text = string.Empty;
                flg = true;
            }
            if (textBox1.Text.Trim() != string.Empty)
            {
                // Execute drawing commands from the text box.
                d.runCommands(textBox1.Text.Trim());
                textBox1.Focus();
                textBox1.Text = string.Empty;
                flg = true;
            }
            if (!flg)
            {
                d.PrintMessage("Please enter any command!");
                textBox1.Focus();
            }
            // Refresh the drawing area and reset the Fill flag.
            Refresh();
            DrawingShapes.Fill = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the drawing area and reset the drawing control.
            DrawingShapes.nPicture = new Bitmap(640, 480);
            d = new DrawingControl();
            d.CurrPoint(true);
            Refresh();
        }

        public override void Refresh()
        {
            pictureBox1.Image = DrawingShapes.nPicture;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox1.Text.Trim() != string.Empty)
                    d.runCommands(textBox1.Text.Trim());
                else
                    d.PrintMessage("Please enter any command!");

                textBox1.Text = string.Empty;
                Refresh();
                textBox1.Focus();
                DrawingShapes.Fill = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear the drawing area and reset the drawing control.
            DrawingShapes.nPicture = new Bitmap(640, 480);
            d = new DrawingControl();
            d.CurrPoint(false);
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TEXT|*.text";
            save.Title = "Assingmemnt";
            save.ShowDialog();

            if(save.FileName != "" && DrawingShapes.nPicture != null)
            {
                DrawingShapes.nPicture.Save(save.FileName);
            }

        }
    }
}
