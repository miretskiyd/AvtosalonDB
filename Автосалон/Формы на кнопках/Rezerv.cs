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

namespace Автосалон
{
    public partial class Rezerv : Form
    {
        public Rezerv()
        {
            InitializeComponent();
        }

        private void Rezerv_Load(object sender, EventArgs e)
        {
            MysqlConnection.Open();
            var temp = new DataTable();
            temp.Load(RezerTable.ExecuteReader());
            dataRezerv.DataSource = temp;
            SqlDataReader read = InsertProizv.ExecuteReader();
            while (read.Read())
            {
                cmbBoxListProizv.Items.Add(read.GetValue(0).ToString());
            }
            MysqlConnection.Close();
            InsertSotrCmb();
        }
        private void InsertSotrCmb()
        { 
            MysqlConnection.Open();
            SqlDataReader read = InsertSotr.ExecuteReader();
            while (read.Read())
            {
                cmbSotr.Items.Add(read.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            FiltrProizv.Parameters["@proizv"].Value = cmbBoxListProizv.Text;
            FiltrSotr.Parameters["@sotr"].Value = cmbSotr.Text;
            FiltrSotrProizv.Parameters["@proizv"].Value = cmbBoxListProizv.Text;
            FiltrSotrProizv.Parameters["@sotr"].Value = cmbSotr.Text;
            var temp = new DataTable();
            MysqlConnection.Open();
            if (cmbBoxListProizv.Text == "" && cmbSotr.Text == "")
            {
                temp.Load(RezerTable.ExecuteReader());
                dataRezerv.DataSource = temp;
            }

            if (cmbBoxListProizv.Text != "" && cmbSotr.Text == "")
            {
                temp.Load(FiltrProizv.ExecuteReader());
                dataRezerv.DataSource = temp;
            }

            if (cmbBoxListProizv.Text == "" && cmbSotr.Text != "")
            {
                temp.Load(FiltrSotr.ExecuteReader());
                dataRezerv.DataSource = temp;
            }
            if (cmbBoxListProizv.Text != "" && cmbSotr.Text != "")
            {
                temp.Load(FiltrSotrProizv.ExecuteReader());
                dataRezerv.DataSource = temp;
            }
                MysqlConnection.Close();
        }
    }
}
