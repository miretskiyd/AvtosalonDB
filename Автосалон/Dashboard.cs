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
    public partial class Dashboard : Form
    {
        private Form currentChildForm;

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlWorkspace.Controls.Add(childForm);
            pnlWorkspace.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public Dashboard()
        {
            InitializeComponent();
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
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
            Application.Exit();
        }

        private void btnExitAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization newForm = new Authorization();
            newForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timerDash.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            ReturningSurname();
            pnlUprOnlyDirec();
        }
        private void ReturningSurname()
        {
            string userLogin = usersData.User_Surname;
            MysqlCommand.Parameters["@userlogin"].Value = userLogin;
            MsqlCommand2.Parameters["@userlogin"].Value = userLogin;
            MysqlConnection.Open();
            lblSurname.Text = MysqlCommand.ExecuteScalar().ToString();
            lblDolzh.Text = MsqlCommand2.ExecuteScalar().ToString();
            MysqlConnection.Close();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new PanelUpravlenia());
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAutos.Height;
            pnlNav.Top = btnAutos.Top;
            pnlNav.Left = btnAutos.Left;
            btnAutos.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Autos());
        }

        private void btnRezerv_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRezerv.Height;
            pnlNav.Top = btnRezerv.Top;
            pnlNav.Left = btnRezerv.Left;
            btnRezerv.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Rezerv());
        }

        private void btnProdaji_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProdaji.Height;
            pnlNav.Top = btnProdaji.Top;
            pnlNav.Left = btnProdaji.Left;
            btnProdaji.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Prodaji());
        }
        private void pnlUprOnlyDirec()
        {
            if (lblDolzh.Text == "Директор" || lblDolzh.Text == "Администратор")
                btnDashboard.Visible = true;
            else
                btnDashboard.Visible = false;
        }
        private void timerDash_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timerDash.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
