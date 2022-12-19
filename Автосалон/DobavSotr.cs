using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автосалон
{
    public partial class DobavSotr : Form
    {
        public DobavSotr()
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
        private void btnDobavit_Click(object sender, EventArgs e)
        {
            MysqlConnection.Open();
            InsSotr.Parameters["@id_sotr"].Value = Convert.ToInt32(txtId.Text);
            InsSotr.Parameters["@fam"].Value = txtFam.Text;
            InsSotr.Parameters["@imya"].Value = txtImya.Text;
            InsSotr.Parameters["@otchest"].Value = txtOtch.Text;
            InsSotr.Parameters["@dolzh"].Value = cmbDolzh.Text;
            InsSotr.Parameters["@telef"].Value = txtTelef.Text;
            InsSotr.Parameters["@login"].Value = txtLogin.Text;
            InsSotr.ExecuteNonQuery();
            MysqlConnection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DobavSotr_Load(object sender, EventArgs e)
        {
            MysqlConnection.Open();
            txtId.Text = idSotr.ExecuteScalar().ToString();
            SqlDataReader zxc = InsDolzh.ExecuteReader();
            while (zxc.Read())
            {
                cmbDolzh.Items.Add(zxc.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }
    }
}
