namespace module_2_section
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.PictureBox();
            this.Controlepanel = new System.Windows.Forms.RichTextBox();
            this.commandline = new System.Windows.Forms.TextBox();
            this.method1 = new System.Windows.Forms.Button();
            this.method2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(11, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(183, 349);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(11, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(183, 403);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Silver;
            this.display.Location = new System.Drawing.Point(316, 11);
            this.display.Margin = new System.Windows.Forms.Padding(2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(395, 430);
            this.display.TabIndex = 4;
            this.display.TabStop = false;
            // 
            // Controlepanel
            // 
            this.Controlepanel.Location = new System.Drawing.Point(11, 11);
            this.Controlepanel.Margin = new System.Windows.Forms.Padding(2);
            this.Controlepanel.Name = "Controlepanel";
            this.Controlepanel.Size = new System.Drawing.Size(285, 217);
            this.Controlepanel.TabIndex = 5;
            this.Controlepanel.Text = "";
            this.Controlepanel.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // commandline
            // 
            this.commandline.Location = new System.Drawing.Point(11, 244);
            this.commandline.Margin = new System.Windows.Forms.Padding(2);
            this.commandline.Name = "commandline";
            this.commandline.Size = new System.Drawing.Size(285, 20);
            this.commandline.TabIndex = 6;
            this.commandline.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Commandline_KeyDown);
            // 
            // method1
            // 
            this.method1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.method1.Location = new System.Drawing.Point(11, 291);
            this.method1.Margin = new System.Windows.Forms.Padding(2);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(122, 38);
            this.method1.TabIndex = 7;
            this.method1.Text = "Method 1";
            this.method1.UseVisualStyleBackColor = false;
            this.method1.Click += new System.EventHandler(this.method1_Click);
            // 
            // method2
            // 
            this.method2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.method2.Location = new System.Drawing.Point(183, 291);
            this.method2.Margin = new System.Windows.Forms.Padding(2);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(113, 38);
            this.method2.TabIndex = 8;
            this.method2.Text = "Method 2 ";
            this.method2.UseVisualStyleBackColor = false;
            this.method2.Click += new System.EventHandler(this.method2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(722, 458);
            this.Controls.Add(this.method2);
            this.Controls.Add(this.method1);
            this.Controls.Add(this.commandline);
            this.Controls.Add(this.Controlepanel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.RichTextBox Controlepanel;
        private System.Windows.Forms.TextBox commandline;
        private System.Windows.Forms.Button method1;
        private System.Windows.Forms.Button method2;
    }
}

