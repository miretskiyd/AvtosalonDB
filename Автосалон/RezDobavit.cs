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
    public partial class RezDobavit : Form
    {
        public RezDobavit()
        {
            InitializeComponent();
        }

        private void btnDobavit_Click(object sender, EventArgs e)
        {
            MysqlConnection.Open();
            Sotr.Parameters["@userlogin"].Value = usersData.User_Surname;
            IDPostovshika.Parameters["@naim"].Value = cmbPost.Text;
            

            DobPost.Parameters["@id_postavka"].Value = Convert.ToInt32(txtId.Text);
            DobPost.Parameters["@id_postavshika"].Value = Convert.ToInt32(IDPostovshika.ExecuteScalar().ToString());
            DobPost.Parameters["@id_sotr"].Value = Convert.ToInt32(Sotr.ExecuteScalar().ToString());
            DobPost.Parameters["@kol"].Value = Convert.ToInt32(textboxKol.Text);
            DobPost.Parameters["@data"].Value = DateTime.Now;
            DobPost.ExecuteNonQuery();
            MysqlConnection.Close();

            CountPos();
            cmbPost.Text = "";
            textboxKol.Text = "";
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

        private void CountPos()
        {
            MysqlConnection.Open();
            txtId.Text = InsID.ExecuteScalar().ToString();
            MysqlConnection.Close();
        }
        private void RezDobavit_Load(object sender, EventArgs e)
        {
            CountPos();
            MysqlConnection.Open();
            SqlDataReader read = InsertPost.ExecuteReader();
            while (read.Read())
            {
                cmbPost.Items.Add(read.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }
    }
}
