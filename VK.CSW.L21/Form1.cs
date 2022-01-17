using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK.CSW.L21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
                memberList.Items.Add(peopleList.Text);
            else
                MessageBox.Show("Choose enement from list or enter a new one");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }
    }
}
