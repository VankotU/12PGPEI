using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Perimeter_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            double a=double.Parse(txtBox_A.Text);
            double b= double.Parse(txtBox_B.Text);
            double c= double.Parse(txtBox_C.Text);
            double area;
            double perimeter;
            if (rb_Square.Checked)
            {
                area = a * a;
                perimeter = 2*a + b + c;
                lbl_Area.Text = area.ToString();
                lbl_Perimeter.Text = perimeter.ToString();
            }
            if (rb_Triangle.Checked)
            {
                area = (a * b)/2;
                perimeter = a + b + c;
                lbl_Area.Text = area.ToString();
                lbl_Perimeter.Text = perimeter.ToString();
            }
            if (rb_Rectangle.Checked)
            {
                area = a * b;
                perimeter = 2*(a + b);
                lbl_Area.Text = area.ToString();
                lbl_Perimeter.Text = perimeter.ToString();
            }
        }
    }
}
