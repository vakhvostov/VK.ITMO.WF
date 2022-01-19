using System;
using System.Windows.Forms;

namespace VK.CSW.L31
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        public bool TimeEnabled
        {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; }
        }
    }
}
