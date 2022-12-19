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
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            MysqlConnection.Open();
            var temp = new DataTable();
            temp.Load(FormLoadData.ExecuteReader());
            dataSotrudniki.DataSource = temp;
            MysqlConnection.Close();
        }

        private void btnDobavit_Click(object sender, EventArgs e)
        {
            Form frm = new DobavSotr();
            frm.Show();
        }
    }
}
