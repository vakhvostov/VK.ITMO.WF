using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK.CSW.L30
{
    public partial class WinTimer : Form
    {
        public WinTimer()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                userControlTimer1.TimeEnabled = true;
            else
                userControlTimer1.TimeEnabled = false;
        }
    }
}
