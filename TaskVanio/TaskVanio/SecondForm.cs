﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskVanio
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        public SecondForm(string labelText) : this()

        {
            lblGreetingText.Text = labelText;
        }

        private void lblGreetingText_Click(object sender, EventArgs e)
        {

        }
    }
}