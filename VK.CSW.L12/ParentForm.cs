using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK.CSW.L12
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowsTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Text = newChild.Text + " " + ++openDocs;
            newChild.Show();

        }

        private int openDocs = 0;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocs;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows are horizontal";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows are cascade";
        }
    }
}
