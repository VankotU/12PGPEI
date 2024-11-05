using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                    this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch 
                {
                    MessageBox.Show("Problem with file");
                }
            }
        }
    }
}
