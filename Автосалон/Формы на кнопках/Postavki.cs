using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автосалон
{
    public partial class Postavki : Form
    {
        public Postavki()
        {
            InitializeComponent();
        }

        private void Postavki_Load(object sender, EventArgs e)
        {
            MysqlConnection.Open();
            var temp = new DataTable();
            temp.Load(PostavkiCom.ExecuteReader());
            dataPostavki.DataSource = temp;
            MysqlConnection.Close();
        }

        private void btnDobavit_Click(object sender, EventArgs e)
        {
            Form frm = new RezDobavit();
            frm.Show();
        }

        private void btnSostav_Click(object sender, EventArgs e)
        {
            Form frm = new SostavPost();
            frm.Show();
        }

        private void dataPostavki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usersData.id_cell = dataPostavki.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataPostavki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
