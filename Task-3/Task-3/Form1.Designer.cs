namespace Task_3
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
            this.rb_Square = new System.Windows.Forms.RadioButton();
            this.rb_Triangle = new System.Windows.Forms.RadioButton();
            this.rb_Rectangle = new System.Windows.Forms.RadioButton();
            this.txtBox_A = new System.Windows.Forms.TextBox();
            this.txtBox_B = new System.Windows.Forms.TextBox();
            this.txtBox_C = new System.Windows.Forms.TextBox();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.lbl_Perimeter = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_Square
            // 
            this.rb_Square.AutoSize = true;
            this.rb_Square.Location = new System.Drawing.Point(12, 12);
            this.rb_Square.Name = "rb_Square";
            this.rb_Square.Size = new System.Drawing.Size(59, 17);
            this.rb_Square.TabIndex = 0;
            this.rb_Square.TabStop = true;
            this.rb_Square.Text = "Square";
            this.rb_Square.UseVisualStyleBackColor = true;
            // 
            // rb_Triangle
            // 
            this.rb_Triangle.AutoSize = true;
            this.rb_Triangle.Location = new System.Drawing.Point(100, 12);
            this.rb_Triangle.Name = "rb_Triangle";
            this.rb_Triangle.Size = new System.Drawing.Size(63, 17);
            this.rb_Triangle.TabIndex = 1;
            this.rb_Triangle.TabStop = true;
            this.rb_Triangle.Text = "Triangle";
            this.rb_Triangle.UseVisualStyleBackColor = true;
            // 
            // rb_Rectangle
            // 
            this.rb_Rectangle.AutoSize = true;
            this.rb_Rectangle.Location = new System.Drawing.Point(190, 12);
            this.rb_Rectangle.Name = "rb_Rectangle";
            this.rb_Rectangle.Size = new System.Drawing.Size(74, 17);
            this.rb_Rectangle.TabIndex = 2;
            this.rb_Rectangle.TabStop = true;
            this.rb_Rectangle.Text = "Rectangle";
            this.rb_Rectangle.UseVisualStyleBackColor = true;
            // 
            // txtBox_A
            // 
            this.txtBox_A.Location = new System.Drawing.Point(32, 50);
            this.txtBox_A.Name = "txtBox_A";
            this.txtBox_A.Size = new System.Drawing.Size(100, 20);
            this.txtBox_A.TabIndex = 3;
            // 
            // txtBox_B
            // 
            this.txtBox_B.Location = new System.Drawing.Point(32, 77);
            this.txtBox_B.Name = "txtBox_B";
            this.txtBox_B.Size = new System.Drawing.Size(100, 20);
            this.txtBox_B.TabIndex = 4;
            // 
            // txtBox_C
            // 
            this.txtBox_C.Location = new System.Drawing.Point(32, 103);
            this.txtBox_C.Name = "txtBox_C";
            this.txtBox_C.Size = new System.Drawing.Size(100, 20);
            this.txtBox_C.TabIndex = 5;
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Area.Location = new System.Drawing.Point(190, 53);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(29, 13);
            this.lbl_Area.TabIndex = 6;
            this.lbl_Area.Text = "Area";
            // 
            // lbl_Perimeter
            // 
            this.lbl_Perimeter.AutoSize = true;
            this.lbl_Perimeter.ForeColor = System.Drawing.Color.Red;
            this.lbl_Perimeter.Location = new System.Drawing.Point(190, 84);
            this.lbl_Perimeter.Name = "lbl_Perimeter";
            this.lbl_Perimeter.Size = new System.Drawing.Size(51, 13);
            this.lbl_Perimeter.TabIndex = 7;
            this.lbl_Perimeter.Text = "Perimeter";
            this.lbl_Perimeter.Click += new System.EventHandler(this.lbl_Perimeter_Click);
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(171, 103);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 8;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(152, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(138, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Perimeter:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.lbl_Perimeter);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.txtBox_C);
            this.Controls.Add(this.txtBox_B);
            this.Controls.Add(this.txtBox_A);
            this.Controls.Add(this.rb_Rectangle);
            this.Controls.Add(this.rb_Triangle);
            this.Controls.Add(this.rb_Square);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Square;
        private System.Windows.Forms.RadioButton rb_Triangle;
        private System.Windows.Forms.RadioButton rb_Rectangle;
        private System.Windows.Forms.TextBox txtBox_A;
        private System.Windows.Forms.TextBox txtBox_B;
        private System.Windows.Forms.TextBox txtBox_C;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Label lbl_Perimeter;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

