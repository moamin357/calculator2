namespace calculator_by_mo_amin
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
            this.textfirstnumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkbox2 = new System.Windows.Forms.CheckBox();
            this.textsecondnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textfirstnumber
            // 
            this.textfirstnumber.Location = new System.Drawing.Point(613, 96);
            this.textfirstnumber.Multiline = true;
            this.textfirstnumber.Name = "textfirstnumber";
            this.textfirstnumber.Size = new System.Drawing.Size(182, 35);
            this.textfirstnumber.TabIndex = 0;
            this.textfirstnumber.TextChanged += new System.EventHandler(this.textfirstnumber_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "addtion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "substruction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "divide";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "multipy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(414, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "enter first number";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSize = true;
            this.checkbox2.Location = new System.Drawing.Point(414, 160);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(162, 21);
            this.checkbox2.TabIndex = 7;
            this.checkbox2.Text = "enter second number";
            this.checkbox2.UseVisualStyleBackColor = true;
            this.checkbox2.CheckedChanged += new System.EventHandler(this.jj_CheckedChanged);
            // 
            // textsecondnumber
            // 
            this.textsecondnumber.Location = new System.Drawing.Point(613, 146);
            this.textsecondnumber.Multiline = true;
            this.textsecondnumber.Name = "textsecondnumber";
            this.textsecondnumber.Size = new System.Drawing.Size(182, 35);
            this.textsecondnumber.TabIndex = 8;
            this.textsecondnumber.TextChanged += new System.EventHandler(this.textsecondnumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 310);
            this.Controls.Add(this.textsecondnumber);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkbox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textfirstnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textfirstnumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkbox2;
        private System.Windows.Forms.TextBox textsecondnumber;
    }
}

