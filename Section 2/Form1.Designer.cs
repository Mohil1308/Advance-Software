namespace Section_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            ControlePanel = new RichTextBox();
            display = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            commandline = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)display).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(17, 440);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(81, 22);
            button3.TabIndex = 0;
            button3.Text = "Run";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(159, 440);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(81, 22);
            button4.TabIndex = 1;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 440);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(81, 22);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ControlePanel);
            groupBox1.Location = new Point(11, 45);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(383, 324);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Multi Command";
            // 
            // ControlePanel
            // 
            ControlePanel.Location = new Point(22, 18);
            ControlePanel.Margin = new Padding(2, 1, 2, 1);
            ControlePanel.Name = "ControlePanel";
            ControlePanel.Size = new Size(350, 298);
            ControlePanel.TabIndex = 0;
            ControlePanel.Text = "";
            // 
            // display
            // 
            display.Location = new Point(11, 20);
            display.Margin = new Padding(2, 1, 2, 1);
            display.Name = "display";
            display.Size = new Size(485, 398);
            display.TabIndex = 5;
            display.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(display);
            groupBox2.Location = new Point(406, 6);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(499, 425);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Drawing Area";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(commandline);
            groupBox3.Location = new Point(406, 440);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(499, 58);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Single Command";
            // 
            // commandline
            // 
            commandline.Location = new Point(14, 26);
            commandline.Margin = new Padding(2, 1, 2, 1);
            commandline.Name = "commandline";
            commandline.Size = new Size(470, 23);
            commandline.TabIndex = 0;
            commandline.KeyDown += Commandline_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(918, 513);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)display).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button4;
        private Button button2;
        private GroupBox groupBox1;
        private PictureBox display;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox ControlePanel;
        private TextBox commandline;
    }
}
