using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr.View
{
    public partial class Vhod : UserControl
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxPassword.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "Ivan" && txtBoxPassword.Text == "123")
            {
                this.Hide();
                var Admin = new Admin();
                Admin.Closed += (s, args) => this.Hide();
                Admin.Show();
            }
            else 
            {
                MessageBox.Show("Problem4e");
            }
        }
    }
}
