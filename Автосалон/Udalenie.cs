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
    public partial class Udalenie : Form
    {
        public Udalenie()
        {
            InitializeComponent();
        }

        public void btnYes_Click(object sender, EventArgs e)
        {
            DeletingAutos.Parameters["@id_auto"].Value = Convert.ToInt32(usersData.id_cell);
            MysqlConnection.Open();
            DeletingAutos.ExecuteNonQuery();
            MysqlConnection.Close();
            this.Close();
        }

        public void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
