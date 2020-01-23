using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class rgbBox : TextBox
    {
        public rgbBox()
        {
            InitializeComponent();
            this.MaxLength = 3;
        }
        private bool dec = true;
        public bool isDec { get { return dec; } set { dec = value; RecalcValue(); } }
        public int value { get; set; } = 0;
        public rgbBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        
        //protected override void OnKeyPress(KeyPressEventArgs e)
        //{
        //    if ( !char.IsDigit(e.KeyChar) & !char.IsControl((e.KeyChar)))
        //        e.Handled = true;
        //    base.OnKeyPress(e);
            
        //}

        private void rgbBox_TextChanged(object sender, EventArgs e)
        {
            RecalcValue();
        }
        private void RecalcValue()
        {
            try
            {
                if (this.Text != "")
                {
                    try
                    {
                        value = Convert.ToInt32(this.Text);
                    }
                    catch
                    {
                        value = Int32.Parse(this.Text, System.Globalization.NumberStyles.HexNumber);
                    }
                }
                if (value > 255)
                    value = 255;
                if (value < 0)
                    value = 0;

                if (dec)
                    this.Text = value.ToString();
                else
                    this.Text = value.ToString("X");
            }
            catch { }
        }
    }
}
