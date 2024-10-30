using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравей " + txtName.Text + "!!! \nТова е голямото ти постижение!");
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)

            {

                pbAvatar.ImageLocation = openPictureDialog.FileName;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*.rtf";

            saveFileDialog.Filter = "RTF Files|*.rtf";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && (saveFileDialog.FileName.Length > 0))
            { 
                    try

                    {
                        // Save the contents of the RichTextBox into the file.
                        richTxtComment.SaveFile(saveFileDialog.FileName);
                    }

                    catch (Exception)
                    {
                    }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //SecondForm secondForm = new SecondForm();
            //secondForm.Show();
            string str = "Hello " + txtName.Text.Trim();
            SecondForm secondForm = new SecondForm(str);
            secondForm.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            string str = "Hello" + txtName.Text.Trim();
            SecondForm secondForm = new SecondForm(str);
            secondForm.ShowDialog();

            if (DialogResult.Yes == secondForm.ShowDialog())
            {
                MessageBox.Show("Вие натиснахте бутона Yes");
            }

            else MessageBox.Show("Вие затворихте прозореца без да натиснете бутона Yes");
        }
        private void ClearTheGroupBox()

        {

            foreach (var item in gbUser.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();

                if (item is RichTextBox) ((RichTextBox)item).Clear();

                if (item is Label) ((Label)item).Text = "...";

                if (item is Button) ((Button)item).BackColor = Color.Aqua;
            }

        }
    }
}
