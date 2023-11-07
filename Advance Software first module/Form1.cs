using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advance_Software_first_module
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        DrawControl drawControl1;
        public Form1()
        {
            InitializeComponent();
            DrawShape.a = DrawShape.b = 0;
            drawControl1 = new DrawControl();
            drawControl1.LivePointer(false);
            Refresh();      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DrawShape.NPicture = new Bitmap(640, 480);
            drawControl1 = new DrawControl();
            drawControl1.LivePointer(true);
            Refresh();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Boolean flg = false;
            if (richTextBox1.Text.Trim() != string.Empty)
            {
                drawControl1.runCommands(richTextBox1.Text.Trim());
                richTextBox1.Focus();
                richTextBox1.Text = string.Empty;
                flg = true;
            }
            if (textBox1.Text.Trim() != string.Empty)
            {
                drawControl1.runCommands(textBox1.Text.Trim());
                textBox1.Focus();
                textBox1.Text = string.Empty;
                flg = true;
            }
            if (!flg)
            {
                drawControl1.PrintMessage("Please enter any command!");
                textBox1.Focus();
            }
            Refresh();
            DrawShape.isFill = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DrawShape.NPicture = new Bitmap(640, 480);
            drawControl1 = new DrawControl();
            drawControl1.LivePointer(false);
            Refresh();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox1.Text.Trim() != string.Empty)
                    drawControl1.runCommands(textBox1.Text.Trim());
                else
                    drawControl1.PrintMessage("Please enter any command!");

                textBox1.Text = string.Empty;
                Refresh();
                textBox1.Focus();
                DrawShape.isFill = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
