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
            btnSearch.Click += btnSearch_Click;
            btnSaving.Click += btnSaving_Click;
            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*,*)|*,*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*,*)|*,*";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
            
                return;
                string fileName = openFileDialog2.FileName;
                string fileText = System.IO.File.ReadAllText(fileName);
                textBox1.Text = fileText;
                MessageBox.Show("File was found");
            
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)

            return;
            string fileName = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(fileName,textBox1.Text);
            MessageBox.Show("File was saved");
        }
    }
}
