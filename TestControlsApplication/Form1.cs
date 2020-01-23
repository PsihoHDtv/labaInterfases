//using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControlsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //void CreatePluginsMenu()
        //{
        //    foreach (string name in plugins.Keys)
        //    {
        //        ToolStripMenuItem item = new ToolStripMenuItem(name);
        //        item.Click += OnPluginClick;
        //        filterToolStripMenuItem.DropDownItems.Add(item);
        //    }
        //}
        //private void OnPluginClick(object sender, EventArgs args)
        //{
        //    IPlugin plugin =
        //    (IPlugin)plugins[((ToolStripMenuItem)sender).Text];
        //    plugin.Transform(this);
        //}
    }
}
