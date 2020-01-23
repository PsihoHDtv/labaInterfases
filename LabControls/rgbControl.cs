using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class rgbControl : UserControl
    {
        public rgbControl()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rgbBoxBlue.isDec = true;
            rgbBoxGreen.isDec = true;
            rgbBoxRed.isDec = true;
            FillButton();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            rgbBoxBlue.isDec = false;
            rgbBoxGreen.isDec = false;
            rgbBoxRed.isDec = false;
            FillButton();
        }

        private void rgbBoxRed_TextChanged(object sender, EventArgs e)
        {

            FillButton();
        }

        private void rgbBoxGreen_TextChanged(object sender, EventArgs e)
        {
            FillButton();

        }

        private void rgbBoxBlue_TextChanged(object sender, EventArgs e)
        {
            FillButton();
        }

        private void FillButton()
        {
            textBox1.Text= rgbBoxRed.Text.ToString()+rgbBoxGreen.Text.ToString() + rgbBoxBlue.Text.ToString();
            button1.BackColor = Color.FromArgb(rgbBoxRed.value, rgbBoxGreen.value, rgbBoxBlue.value);
        }
    }
}
