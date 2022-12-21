using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автосалон
{
    public partial class SostavPost : Form
    {
        public SostavPost()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SostavPost_Load(object sender, EventArgs e)
        {
            lblid.Text = usersData.id_cell;
            SostavCom.Parameters["@id_post"].Value = Convert.ToInt32(lblid.Text);
            CountAuto.Parameters["@id_post"].Value = Convert.ToInt32(lblid.Text);
            MysqlConnection.Open();
            var temp = new DataTable();
            temp.Load(SostavCom.ExecuteReader());
            txtKolvo.Text = CountAuto.ExecuteScalar().ToString();
            dataSostPostavki.DataSource = temp;

            MysqlConnection.Close();
        }
    }
}
