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
    public partial class Registraciq : UserControl
    {
        public Registraciq()
        {
            InitializeComponent();
        }

        private void btnEnter1_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "Ivan" && txtBoxPassword1.Text == "123" && txtBoxPasswordR.Text==txtBoxPassword1.Text)
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
