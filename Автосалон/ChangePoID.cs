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
    public partial class ChangePoID : Form
    {
        public ChangePoID()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void ChangePoID_Load(object sender, EventArgs e)
        {
            lbl_id.Text = usersData.id_cell;
            VstavkaZnacheniyPoId();
        }

        

        private void VstavkaZnacheniyPoId()
        {
            Proizv.Parameters["@id_auto"].Value = Convert.ToInt32(lbl_id.Text);
            Model.Parameters["@id_auto"].Value = Convert.ToInt32(lbl_id.Text);
            Tsena.Parameters["@id_auto"].Value = Convert.ToInt32(lbl_id.Text);
            Sost.Parameters["@id_auto"].Value = Convert.ToInt32(lbl_id.Text);
            God.Parameters["@id_auto"].Value = Convert.ToInt32(lbl_id.Text);
            tsvet.Parameters["@id_auto"].Value = Convert.ToInt32(lbl_id.Text);
            Post.Parameters["@id_auto"].Value = Convert.ToInt32(lbl_id.Text);
            MysqlConnection.Open();
            txtProizv.Text = Proizv.ExecuteScalar().ToString();
            txtModel.Text = Model.ExecuteScalar().ToString();
            txtboxTsena.Text = Tsena.ExecuteScalar().ToString();
            txtboxGod.Text = God.ExecuteScalar().ToString();
            textboxTsvet.Text = tsvet.ExecuteScalar().ToString();
            txtPostavka.Text = Post.ExecuteScalar().ToString();
            SqlDataReader zxc = Sost.ExecuteReader();
            while (zxc.Read())
            {
                cmbSost.Text = zxc.GetValue(0).ToString();
            }
            MysqlConnection.Close();
        }
        private void btnDobavit_Click(object sender, EventArgs e)
        {
            ChangeAutoInfo.Parameters["@id_avto"].Value = Convert.ToInt32(lbl_id.Text);
            ChangeAutoInfo.Parameters["@proizv"].Value = txtProizv.Text;
            ChangeAutoInfo.Parameters["@marka"].Value = txtModel.Text;
            ChangeAutoInfo.Parameters["@tsena"].Value = Convert.ToInt32(txtboxTsena.Text);
            ChangeAutoInfo.Parameters["@sost"].Value = cmbSost.Text;
            ChangeAutoInfo.Parameters["@god"].Value = Convert.ToInt32(txtboxGod.Text);
            ChangeAutoInfo.Parameters["@tsvet"].Value = textboxTsvet.Text;
            ChangeAutoInfo.Parameters["@postavka"].Value = Convert.ToInt32(txtPostavka.Text);
            MysqlConnection.Open();
            ChangeAutoInfo.ExecuteNonQuery();
            MysqlConnection.Close();
            MessageBox.Show("Вы изменили данные автомобиля");
        }
    }
}
