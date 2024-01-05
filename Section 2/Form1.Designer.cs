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
            display = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ControlePanel = new RichTextBox();
            commandline = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)display).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(31, 938);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 0;
            button3.Text = "Run";
            button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            button4.Location = new Point(296, 938);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 1;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // 
            // button2
            // 
            button2.Location = new Point(559, 938);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ControlePanel);
            groupBox1.Location = new Point(21, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 691);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Multi Command";
            // 
            // display
            // 
            display.Location = new Point(21, 42);
            display.Name = "display";
            display.Size = new Size(900, 849);
            display.TabIndex = 5;
            display.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(display);
            groupBox2.Location = new Point(754, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(927, 907);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Drawing Area";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(commandline);
            groupBox3.Location = new Point(754, 938);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(927, 124);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Single Command";
            // 
            // ControlePanel
            // 
            ControlePanel.Location = new Point(41, 38);
            ControlePanel.Name = "ControlePanel";
            ControlePanel.Size = new Size(647, 631);
            ControlePanel.TabIndex = 0;
            ControlePanel.Text = "";
            // 
            // commandline
            // 
            commandline.Location = new Point(26, 56);
            commandline.Name = "commandline";
            commandline.Size = new Size(869, 39);
            commandline.TabIndex = 0;
            this.commandline.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Commandline_KeyDown);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1693, 1090);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
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
