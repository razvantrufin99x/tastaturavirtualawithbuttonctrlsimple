using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tastaturavirtualawithbuttonctrl
{
    public partial class vkkb : UserControl
    {
        public vkkb()
        {
            InitializeComponent();
        }
        public Form1 f = null;

        public void setText(string i)
        {
           
                button1.Text = i.ToString();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.setValue(button1.Text);
        }

        private void vkkb_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }
    }
}
