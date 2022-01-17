using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK.CSW.L14
{
    public partial class GreenForm : Form
    {
        public GreenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GreenForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 400), new Point(400, 800), new Point(800, 400), new Point(400, 0) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
