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
    public partial class ProdajaAuto : Form
    {
        public ProdajaAuto()
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

        private void ProdajaAuto_Load(object sender, EventArgs e)
        {
            txtId.Text = usersData.id_cell;
            InsertSummaProd.Parameters["@id_auto"].Value = Convert.ToInt32(txtId.Text);

            MysqlConnection.Open();
            txtSummaProd.Text = InsertSummaProd.ExecuteScalar().ToString();
            string NomerProd = CountProd.ExecuteScalar().ToString();
            MysqlConnection.Close();

            
        }

        private void OformlenieProd()
        {
            MysqlConnection.Open();
            string NomerProd = CountProd.ExecuteScalar().ToString();

            MysqlConnection.Close();
            MysqlConnection.Open();
            Prodaja.Parameters["@id_prod"].Value = NomerProd;
            ID_Sotr.Parameters["@userlogin"].Value = usersData.User_Surname;
            string id_sotr = ID_Sotr.ExecuteScalar().ToString();
            Prodaja.Parameters["@id_sotr"].Value = id_sotr;
            Prodaja.Parameters["@id_avto"].Value = Convert.ToInt32(txtId.Text);
            Prodaja.Parameters["@fio_pok"].Value = txtFIOPokup.Text;
            Prodaja.Parameters["@data_pok"].Value = dateProd.Value;
            Prodaja.Parameters["@tsena"].Value = Convert.ToInt32(txtSummaProd.Text);
            Prodaja.ExecuteNonQuery();
            MysqlConnection.Close();
            MessageBox.Show("Вы оформили продажу автомобиля!");
            this.Close();
        }
        // @id_prod, @id_avto, @id_sotr, @fio_pok, @data_pok, @tsena
        private void btnDobavit_Click(object sender, EventArgs e)
        {
            OformlenieProd();
        }
    }
}
