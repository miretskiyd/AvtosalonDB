using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Автосалон
{
    public partial class PanelUpravlenia : Form
    {
        public PanelUpravlenia()
        {
            InitializeComponent();
        }

        private void PanelUpravlenia_Load(object sender, EventArgs e)
        {
            

            ShowOnlyManagers();
        }
        private void ShowOnlyManagers()
        {
            MySqlConnection.Open();
            SqlDataReader qwe = InsertManagers.ExecuteReader();
            while (qwe.Read())
            {
                cmbboxSotr.Items.Add(qwe.GetValue(0).ToString());
            }
            MySqlConnection.Close();
        }

        private void btnShowsotr_Click(object sender, EventArgs e)
        {
            mysqlCommand.Parameters["@sotr"].Value = cmbboxSotr.Text;
            mysqlCommand.Parameters["@dateS"].Value = dtimeNach.Value;
            mysqlCommand.Parameters["@dateDo"].Value = dtimeDo.Value;
            MysqlCommand2.Parameters["@sotr"].Value = cmbboxSotr.Text;
            MysqlCommand2.Parameters["@dateS"].Value = dtimeNach.Value;
            MysqlCommand2.Parameters["@dateDo"].Value = dtimeDo.Value;
            MySqlConnection.Open();
            txtCountPrib.Text = MysqlCommand2.ExecuteScalar().ToString();
            var temp = new DataTable();
            temp.Load(mysqlCommand.ExecuteReader());
            dataAnalyze.DataSource = temp;
            MySqlConnection.Close();
        }

        private void cmbboxSotr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }
    }
}
