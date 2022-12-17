using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Автосалон
{
    public partial class DobavlenieAvto : Form
    {
        public DobavlenieAvto()
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

        private void DobavlenieAvto_Load(object sender, EventArgs e)
        {
            InsertDataMarks();
            F_countAutos();
            InsertPostavk();
        }
        private void InsertPostavk()
        {
            MysqlConnection.Open();
            SqlDataReader zxc = commandCountPost.ExecuteReader();
            while (zxc.Read())
            {
                cmbPostavka.Items.Add(zxc.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }
        private void F_countAutos()
        {
            MysqlConnection.Open();
            txtId.Text = countAutos.ExecuteScalar().ToString();
            MysqlConnection.Close();
        }
        private void InsertDataMarks()
        {
            MysqlConnection.Open();
            SqlDataReader read = commandInsertModels.ExecuteReader();
            while (read.Read())
            {
                cmbModel.Items.Add(read.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }

        private void Pokinul4at()
        {
            int god = 0;
            Int32.TryParse(txtboxGod.Text, out god);
            if (god < 1980 || god > DateTime.Now.Year)
            {
                txtboxGod.Text = "";
                MessageBox.Show("Введите корректное значение года выпуска автомобиля!");
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModels.Items.Clear();
            commandInsertModelsAfter.Parameters["@proizv"].Value = cmbModel.Text;
            MysqlConnection.Open();
            SqlDataReader qwe = commandInsertModelsAfter.ExecuteReader();
            while (qwe.Read())
            {
                cmbModels.Items.Add(qwe.GetValue(0).ToString());
            }
            MysqlConnection.Close();
        }
        private void DobavlenieAuto()
        {
            InsertAvto.Parameters["@id_avto"].Value = Convert.ToInt32(txtId.Text);
            InsertAvto.Parameters["@proizv"].Value = cmbModel.Text;
            InsertAvto.Parameters["@marka"].Value = cmbModels.Text;
            InsertAvto.Parameters["@tsena"].Value = Convert.ToInt32(txtboxTsena.Text);
            InsertAvto.Parameters["@sost"].Value = cmbSost.Text;
            InsertAvto.Parameters["@god"].Value = Convert.ToInt32(txtboxGod.Text);
            InsertAvto.Parameters["@tsvet"].Value = textboxTsvet.Text;
            InsertAvto.Parameters["@postavka"].Value = Convert.ToInt32(cmbPostavka.Text);
            MysqlConnection.Open();
            InsertAvto.ExecuteNonQuery();
            MysqlConnection.Close();
            MessageBox.Show("Вы добавили новый автомобиль");
            ObnulenieValues();
            F_countAutos();
        }
        private void ObnulenieValues()
        {
            cmbModel.Text = "";
            cmbModels.Text = "";
            cmbSost.Text = "";
            txtboxGod.Text = "";
            textboxTsvet.Text = "";
            cmbPostavka.Text = "";
            txtboxTsena.Text = "";
        }
        private void btnDobavit_Click(object sender, EventArgs e)
        {
            DobavlenieAuto();
            this.Close();
            
        }

        private void txtboxGod_Leave(object sender, EventArgs e)
        {
            Pokinul4at();
        }

        private void textboxTsvet_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
