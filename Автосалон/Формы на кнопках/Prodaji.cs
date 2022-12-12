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
    public partial class Prodaji : Form
    {
        public Prodaji()
        {
            InitializeComponent();
        }

        private void Prodaji_Load(object sender, EventArgs e)
        {
            LoadProdaji();
        }
        private void LoadProdaji()
        {
            MysqlConnection.Open();
            var temp = new DataTable();
            temp.Load(PoslednieProdaji.ExecuteReader());
            dataProdaji.DataSource = temp;
            SqlDataReader read = InsertProizv.ExecuteReader();
            while (read.Read())
            {
                cmbBoxListProizv.Items.Add(read.GetValue(0).ToString());
            }
            MysqlConnection.Close();

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            FiltrProizv.Parameters["@proizv"].Value = cmbBoxListProizv.Text;
            FiltrTsena.Parameters["@tsena"].Value = txtTsena.Text;
            FiltrTsenaProizv.Parameters["@tsena"].Value = txtTsena.Text;
            FiltrTsenaProizv.Parameters["@proizv"].Value = cmbBoxListProizv.Text;
            MysqlConnection.Open();
            var temp = new DataTable();
            if (txtTsena.Text == "" && cmbBoxListProizv.Text != "")
            {
                temp.Load(FiltrProizv.ExecuteReader());
                dataProdaji.DataSource = temp;
            }
            else if (txtTsena.Text == "" && cmbBoxListProizv.Text == "")
            {
                temp.Load(PoslednieProdaji.ExecuteReader());
                dataProdaji.DataSource = temp;
            }
            else if (txtTsena.Text != "" && cmbBoxListProizv.Text == "")
            {
                temp.Load(FiltrTsena.ExecuteReader());
                dataProdaji.DataSource = temp;
            }
            else if (txtTsena.Text != "" && cmbBoxListProizv.Text != "")
            {
                temp.Load(FiltrTsenaProizv.ExecuteReader());
                dataProdaji.DataSource = temp;
            }
            MysqlConnection.Close();
        }

        private void btnDobavlenie_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUdalit_Click(object sender, EventArgs e)
        {
            Form udal = new UdalProd();
            udal.Show();

        }
    }
}
