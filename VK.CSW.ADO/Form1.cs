using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VK.CSW.ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dgvResult_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ExamDB;Data Source=LAPTOP-DHBMFRC4\\SQLEXPRESS"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT  nPokazatelId, vPeriodType, dtStartDate, dtEndDate, vTerritoryId, nValue FROM[ExamDB].[Istochnik].[TableSource]", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dgvResult.Columns.Add("nPId", "nPId");
                        dgvResult.Columns.Add("pType", "pType");
                        dgvResult.Columns.Add("StartDate", "StartDate");
                        dgvResult.Columns.Add("EndDate", "EndDate");
                        dgvResult.Columns.Add("TId", "TId");
                        dgvResult.Columns.Add("nValue", "nValue");

                        while (reader.Read())
                        {
                            int idx = dgvResult.Rows.Add();
                            for(int i = 0; i < reader.FieldCount; ++i)
                            {
                                dgvResult.Rows[idx].Cells[i].Value = reader[i].ToString();
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
