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
    public partial class RezervAuto : Form
    {
        public RezervAuto()
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

        private void RezervAuto_Load(object sender, EventArgs e)
        {
            lbl_id.Text = usersData.id_cell;
        }

        private void btnRezerv_Click(object sender, EventArgs e)
        {
            RezervirovanieAutoF();
        }
        private void RezervirovanieAutoF()
        {
            MysqlConnection.Open();
            string NomerProd = ID_rez.ExecuteScalar().ToString();
            MysqlConnection.Close();
        }
    }
}
