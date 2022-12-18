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
    }
}
