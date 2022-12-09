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
using System.Data.SqlClient;

namespace Автосалон
{

    public partial class Authorization : Form
    {

        public Authorization()
        {
            InitializeComponent();
            
        }

        public void Authorization_Load(object sender, EventArgs e) { }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Фамилия";
                txtLogin.ForeColor = Color.FromArgb(108, 100, 109);
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Фамилия")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Пароль")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Пароль";
                txtPassword.ForeColor = Color.FromArgb(108, 100, 109);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            var loginUser = txtLogin.Text;
            var passwordUser = txtPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select Логин, Пароль from Сотрудник WHERE Логин = '{loginUser}' and Пароль = '{passwordUser}'";
            SqlCommand command = new SqlCommand(queryString, MysqlConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            usersData.User_Surname = loginUser;
            if (table.Rows.Count == 1)
            {
                Dashboard newForm = new Dashboard();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");//можно добавить новую форму стилизованную под messagebox
            }
            
        }
        // Чтобы передвигать по верхней panel все приложение
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
