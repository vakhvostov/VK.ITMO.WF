using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VK.CSW.WPFADO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbResult_Initialized(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ExamDB;Data Source=LAPTOP-DHBMFRC4\\SQLEXPRESS"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT  nPokazatelId, vPeriodType, dtStartDate, dtEndDate, vTerritoryId, nValue FROM[ExamDB].[Istochnik].[TableSource]", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for(int i=0; i < reader.FieldCount; ++i)
                                lbResult.Items.Add(reader[i].ToString());
                        }
                    }
                }
            }
        }
    }
}
