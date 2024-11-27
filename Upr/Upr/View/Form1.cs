using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Upr.View;

namespace Upr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vhod1.Hide();
            vhod2.Hide();
            zaNas1.Hide();
            registraciq1.Hide();
        }

        private void галерияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gallery = new Galeriq();
            gallery.Closed += (s, args) => this.Close();
            gallery.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uslugi = new Uslugi();
            uslugi.Closed += (s, args) => this.Close();
            uslugi.Show();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Hide();
            registraciq1.Hide();
            zaNas1.Show();
            zaNas1.BringToFront();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Hide();
            vhod2.Hide();
            zaNas1.Hide();
            registraciq1.Hide();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Show();
            vhod1.BringToFront();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registraciq1.Show();
            registraciq1.BringToFront();
        }
    }
}
