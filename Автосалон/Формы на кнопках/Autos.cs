using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автосалон
{
    public partial class Autos : Form
    {
        public Autos()
        {
            InitializeComponent();
        }

        private void Autos_Load(object sender, EventArgs e)
        {

            prevTable();
            MysqlConnection.Open();
            SqlDataReader qwe = sqlCommandInsertKuzov.ExecuteReader();
            while (qwe.Read())
            {
                cmboxListKuzov.Items.Add(qwe.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }


        private void prevTable()
        {
            MysqlConnection.Open();
            var temp = new DataTable();
            temp.Load(MysqlCommand.ExecuteReader());
            dataAutos.DataSource = temp;
            SqlDataReader read = sqlCommandInsertMarks.ExecuteReader();
            while (read.Read())
            { 
                cmbBoxListMarks.Items.Add(read.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            MarkaKuzovOnly();
        }


        private void MarkaKuzovOnly()
        {
            MysqlCommand2.Parameters["@marka"].Value = cmbBoxListMarks.Text;
            mysqlcomOnlyMark.Parameters["@marka"].Value = cmbBoxListMarks.Text;
            MysqlCommand2.Parameters["@kuzov"].Value = cmboxListKuzov.Text;
            mysqlcomOnlyKuzov.Parameters["@kuzov"].Value = cmboxListKuzov.Text;
            NMarkKuz.Parameters["@marka"].Value = cmbBoxListMarks.Text;
            NMarkKuz.Parameters["@kuzov"].Value = cmboxListKuzov.Text;
            NKuz.Parameters["@kuzov"].Value = cmboxListKuzov.Text;
            NMark.Parameters["@marka"].Value = cmbBoxListMarks.Text;
            MysqlConnection.Open();           
            var temp = new DataTable();
            if (checkNalich.Checked == false)
            {
                if (cmbBoxListMarks.Text != "" && cmboxListKuzov.Text != "")
                {
                    temp.Load(MysqlCommand2.ExecuteReader());
                    dataAutos.DataSource = temp;
                }
                else if (cmbBoxListMarks.Text != "" && cmboxListKuzov.Text == "")
                {
                    temp.Load(mysqlcomOnlyMark.ExecuteReader());
                    dataAutos.DataSource = temp;
                }
                else if (cmbBoxListMarks.Text == "" && cmboxListKuzov.Text != "")
                {
                    temp.Load(mysqlcomOnlyKuzov.ExecuteReader());
                    dataAutos.DataSource = temp;
                }
                else if (cmbBoxListMarks.Text == "" && cmboxListKuzov.Text == "")
                {
                    temp.Load(MysqlCommand.ExecuteReader());
                    dataAutos.DataSource = temp;
                }
            }
            if (checkNalich.Checked == true)
            {
                if (cmbBoxListMarks.Text != "" && cmboxListKuzov.Text != "")
                {
                    temp.Load(NMarkKuz.ExecuteReader());
                    dataAutos.DataSource = temp;
                }
                else if (cmbBoxListMarks.Text != "" && cmboxListKuzov.Text == "")
                {
                    temp.Load(NMark.ExecuteReader());
                    dataAutos.DataSource = temp;
                }
                else if (cmbBoxListMarks.Text == "" && cmboxListKuzov.Text != "")
                {
                    temp.Load(NKuz.ExecuteReader());
                    dataAutos.DataSource = temp;
                }
                else if (cmbBoxListMarks.Text == "" && cmboxListKuzov.Text == "")
                {
                    temp.Load(NAutos.ExecuteReader());
                    dataAutos.DataSource = temp;

                }
            }
            MysqlConnection.Close();
        }

        private void cmboxListKuzov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDobavlenie_Click(object sender, EventArgs e)
        {
            Form frm = new DobavlenieAvto();
            frm.Show();
        }

        private void dataAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usersData.id_cell = dataAutos.Rows[e.RowIndex].Cells[0].Value.ToString();
                
        }

        private void btnIzmenit_Click(object sender, EventArgs e)
        {
            Form frm = new ChangePoID();
            frm.Show();
        }

        private void btnUdalit_Click(object sender, EventArgs e)
        {
            Form frm = new Udalenie();
            frm.Show();
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            Form frm = new ProdajaAuto();
            frm.Show();
        }

        private void btnRezerv_Click(object sender, EventArgs e)
        {
            Form frm = new RezervAuto();
            frm.Show();
        }
    }
}
