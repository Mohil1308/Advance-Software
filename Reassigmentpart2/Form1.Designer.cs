namespace Reassigmentpart2
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
            this.display = new System.Windows.Forms.PictureBox();
            this.Controlepanel = new System.Windows.Forms.RichTextBox();
            this.commandline = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.method2 = new System.Windows.Forms.Button();
            this.method1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Silver;
            this.display.Location = new System.Drawing.Point(922, 85);
            this.display.Margin = new System.Windows.Forms.Padding(4);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(790, 827);
            this.display.TabIndex = 5;
            this.display.TabStop = false;
            // 
            // Controlepanel
            // 
            this.Controlepanel.Location = new System.Drawing.Point(93, 85);
            this.Controlepanel.Margin = new System.Windows.Forms.Padding(4);
            this.Controlepanel.Name = "Controlepanel";
            this.Controlepanel.Size = new System.Drawing.Size(599, 532);
            this.Controlepanel.TabIndex = 6;
            this.Controlepanel.Text = "";
            // 
            // commandline
            // 
            this.commandline.Location = new System.Drawing.Point(922, 973);
            this.commandline.Margin = new System.Windows.Forms.Padding(4);
            this.commandline.Name = "commandline";
            this.commandline.Size = new System.Drawing.Size(790, 31);
            this.commandline.TabIndex = 7;
            this.commandline.TextChanged += new System.EventHandler(this.commandline_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(93, 837);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 75);
            this.button3.TabIndex = 8;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(466, 837);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 75);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(93, 952);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 73);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(466, 952);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 73);
            this.button4.TabIndex = 11;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // method2
            // 
            this.method2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.method2.Location = new System.Drawing.Point(466, 736);
            this.method2.Margin = new System.Windows.Forms.Padding(4);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(226, 75);
            this.method2.TabIndex = 12;
            this.method2.Text = "Method 2 ";
            this.method2.UseVisualStyleBackColor = false;
            // 
            // method1
            // 
            this.method1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.method1.Location = new System.Drawing.Point(93, 736);
            this.method1.Margin = new System.Windows.Forms.Padding(4);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(244, 75);
            this.method1.TabIndex = 13;
            this.method1.Text = "Method 1";
            this.method1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1794, 1071);
            this.Controls.Add(this.method1);
            this.Controls.Add(this.method2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.commandline);
            this.Controls.Add(this.Controlepanel);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.RichTextBox Controlepanel;
        private System.Windows.Forms.TextBox commandline;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button method2;
        private System.Windows.Forms.Button method1;
    }
}

