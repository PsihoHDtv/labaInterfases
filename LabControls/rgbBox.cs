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
        public bool isDec { get; set; } = true;
        public rgbBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (isDec && !char.IsDigit(e.KeyChar) & !char.IsControl((e.KeyChar)) )
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
