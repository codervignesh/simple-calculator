namespace simplecalc
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
            this.output = new System.Windows.Forms.TextBox();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.opDiv = new System.Windows.Forms.Button();
            this.opMul = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.opMin = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.opAdd = new System.Windows.Forms.Button();
            this.opEqu = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.opDot = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(334, 26);
            this.output.TabIndex = 0;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(11, 43);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(62, 63);
            this.num7.TabIndex = 1;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.button_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(79, 43);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(62, 63);
            this.num8.TabIndex = 2;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.button_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(147, 43);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(62, 63);
            this.num9.TabIndex = 3;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.button_Click);
            // 
            // opDiv
            // 
            this.opDiv.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opDiv.Location = new System.Drawing.Point(215, 43);
            this.opDiv.Name = "opDiv";
            this.opDiv.Size = new System.Drawing.Size(62, 63);
            this.opDiv.TabIndex = 4;
            this.opDiv.Text = "/";
            this.opDiv.UseVisualStyleBackColor = false;
            this.opDiv.Click += new System.EventHandler(this.op_Prs);
            // 
            // opMul
            // 
            this.opMul.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opMul.Location = new System.Drawing.Point(215, 112);
            this.opMul.Name = "opMul";
            this.opMul.Size = new System.Drawing.Size(62, 63);
            this.opMul.TabIndex = 8;
            this.opMul.Text = "*";
            this.opMul.UseVisualStyleBackColor = false;
            this.opMul.Click += new System.EventHandler(this.op_Prs);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(147, 112);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(62, 63);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.button_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(79, 112);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(62, 63);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.button_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(11, 112);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(62, 63);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.button_Click);
            // 
            // opMin
            // 
            this.opMin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opMin.Location = new System.Drawing.Point(215, 181);
            this.opMin.Name = "opMin";
            this.opMin.Size = new System.Drawing.Size(62, 63);
            this.opMin.TabIndex = 12;
            this.opMin.Text = "-";
            this.opMin.UseVisualStyleBackColor = false;
            this.opMin.Click += new System.EventHandler(this.op_Prs);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(147, 181);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(62, 63);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(80, 181);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(62, 63);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.button_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(11, 181);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(62, 63);
            this.num1.TabIndex = 9;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.button_Click);
            // 
            // opAdd
            // 
            this.opAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opAdd.Location = new System.Drawing.Point(215, 250);
            this.opAdd.Name = "opAdd";
            this.opAdd.Size = new System.Drawing.Size(62, 63);
            this.opAdd.TabIndex = 16;
            this.opAdd.Text = "+";
            this.opAdd.UseVisualStyleBackColor = false;
            this.opAdd.Click += new System.EventHandler(this.op_Prs);
            // 
            // opEqu
            // 
            this.opEqu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opEqu.Location = new System.Drawing.Point(147, 250);
            this.opEqu.Name = "opEqu";
            this.opEqu.Size = new System.Drawing.Size(62, 63);
            this.opEqu.TabIndex = 15;
            this.opEqu.Text = "=";
            this.opEqu.UseVisualStyleBackColor = false;
            this.opEqu.Click += new System.EventHandler(this.op_res);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(79, 250);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(62, 63);
            this.num0.TabIndex = 14;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.button_Click);
            // 
            // opDot
            // 
            this.opDot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.opDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opDot.Location = new System.Drawing.Point(11, 250);
            this.opDot.Name = "opDot";
            this.opDot.Size = new System.Drawing.Size(62, 63);
            this.opDot.TabIndex = 13;
            this.opDot.Text = ".";
            this.opDot.UseVisualStyleBackColor = false;
            this.opDot.Click += new System.EventHandler(this.button_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(283, 112);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(62, 201);
            this.clear.TabIndex = 17;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 63);
            this.button1.TabIndex = 18;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.c_prs);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(354, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.opAdd);
            this.Controls.Add(this.opEqu);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.opDot);
            this.Controls.Add(this.opMin);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.opMul);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.opDiv);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button opDiv;
        private System.Windows.Forms.Button opMul;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button opMin;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button opAdd;
        private System.Windows.Forms.Button opEqu;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button opDot;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button1;
    }
}

