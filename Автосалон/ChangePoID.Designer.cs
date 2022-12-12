namespace Автосалон
{
    partial class ChangePoID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePoID));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIconteslatopleft = new System.Windows.Forms.Panel();
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmbSost = new System.Windows.Forms.ComboBox();
            this.lblProizv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxGod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxTsvet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxTsena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.ChangeAutoInfo = new System.Data.SqlClient.SqlCommand();
            this.Proizv = new System.Data.SqlClient.SqlCommand();
            this.Model = new System.Data.SqlClient.SqlCommand();
            this.Tsena = new System.Data.SqlClient.SqlCommand();
            this.Sost = new System.Data.SqlClient.SqlCommand();
            this.God = new System.Data.SqlClient.SqlCommand();
            this.tsvet = new System.Data.SqlClient.SqlCommand();
            this.Post = new System.Data.SqlClient.SqlCommand();
            this.txtProizv = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPostavka = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pnlIconteslatopleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(764, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlIconteslatopleft
            // 
            this.pnlIconteslatopleft.BackgroundImage = global::Автосалон.Properties.Resources.icons8_tesla_model_x_100;
            this.pnlIconteslatopleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlIconteslatopleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIconteslatopleft.Location = new System.Drawing.Point(0, 0);
            this.pnlIconteslatopleft.Name = "pnlIconteslatopleft";
            this.pnlIconteslatopleft.Size = new System.Drawing.Size(30, 35);
            this.pnlIconteslatopleft.TabIndex = 1;
            // 
            // lblZagolovok
            // 
            this.lblZagolovok.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZagolovok.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZagolovok.Location = new System.Drawing.Point(0, 35);
            this.lblZagolovok.Name = "lblZagolovok";
            this.lblZagolovok.Size = new System.Drawing.Size(800, 44);
            this.lblZagolovok.TabIndex = 3;
            this.lblZagolovok.Text = "Изменение данных автомобиля с ID: ";
            this.lblZagolovok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id.Location = new System.Drawing.Point(679, 35);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(93, 37);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "id";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSost
            // 
            this.cmbSost.FormattingEnabled = true;
            this.cmbSost.Items.AddRange(new object[] {
            "С пробегом",
            "Новая"});
            this.cmbSost.Location = new System.Drawing.Point(66, 256);
            this.cmbSost.Name = "cmbSost";
            this.cmbSost.Size = new System.Drawing.Size(159, 24);
            this.cmbSost.TabIndex = 6;
            // 
            // lblProizv
            // 
            this.lblProizv.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProizv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProizv.Location = new System.Drawing.Point(15, 134);
            this.lblProizv.Name = "lblProizv";
            this.lblProizv.Size = new System.Drawing.Size(266, 25);
            this.lblProizv.TabIndex = 7;
            this.lblProizv.Text = "Производитель";
            this.lblProizv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Состояние:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxGod
            // 
            this.txtboxGod.Location = new System.Drawing.Point(340, 256);
            this.txtboxGod.Name = "txtboxGod";
            this.txtboxGod.Size = new System.Drawing.Size(120, 22);
            this.txtboxGod.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(269, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Модель:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(266, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Поставка:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(269, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 41);
            this.label5.TabIndex = 12;
            this.label5.Text = "Год выпуска:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxTsvet
            // 
            this.textboxTsvet.Location = new System.Drawing.Point(591, 256);
            this.textboxTsvet.Name = "textboxTsvet";
            this.textboxTsvet.Size = new System.Drawing.Size(120, 22);
            this.textboxTsvet.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(522, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxTsena
            // 
            this.txtboxTsena.Location = new System.Drawing.Point(582, 162);
            this.txtboxTsena.Name = "txtboxTsena";
            this.txtboxTsena.Size = new System.Drawing.Size(152, 22);
            this.txtboxTsena.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(616, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 51);
            this.label2.TabIndex = 16;
            this.label2.Text = "Цвет:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDobavit
            // 
            this.btnDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnDobavit.FlatAppearance.BorderSize = 0;
            this.btnDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavit.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobavit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDobavit.Location = new System.Drawing.Point(323, 390);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(152, 38);
            this.btnDobavit.TabIndex = 19;
            this.btnDobavit.Text = "Изменить";
            this.btnDobavit.UseVisualStyleBackColor = false;
            this.btnDobavit.Click += new System.EventHandler(this.btnDobavit_Click);
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // ChangeAutoInfo
            // 
            this.ChangeAutoInfo.CommandText = "ChangingAutoInfo";
            this.ChangeAutoInfo.CommandType = System.Data.CommandType.StoredProcedure;
            this.ChangeAutoInfo.Connection = this.MysqlConnection;
            this.ChangeAutoInfo.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id_avto", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@proizv", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@marka", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@tsena", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@sost", System.Data.SqlDbType.VarChar, 20),
            new System.Data.SqlClient.SqlParameter("@god", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@tsvet", System.Data.SqlDbType.VarChar, 35),
            new System.Data.SqlClient.SqlParameter("@postavka", System.Data.SqlDbType.Int, 4)});
            // 
            // Proizv
            // 
            this.Proizv.CommandText = "SELECT Производитель From Модель JOIN Автомобиль ON Автомобиль.ID_Модели = Модель" +
    ".ID_Модели WHERE @id_auto = ID_Автомобиля";
            this.Proizv.Connection = this.MysqlConnection;
            this.Proizv.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // Model
            // 
            this.Model.CommandText = "SELECT НаименованиеМодели From Модель JOIN Автомобиль ON Автомобиль.ID_Модели = М" +
    "одель.ID_Модели WHERE @id_auto = ID_Автомобиля";
            this.Model.Connection = this.MysqlConnection;
            this.Model.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // Tsena
            // 
            this.Tsena.CommandText = "select Цена from Автомобиль Where @id_auto = ID_Автомобиля";
            this.Tsena.Connection = this.MysqlConnection;
            this.Tsena.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // Sost
            // 
            this.Sost.CommandText = "select Состояние from Автомобиль Where @id_auto = ID_Автомобиля";
            this.Sost.Connection = this.MysqlConnection;
            this.Sost.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // God
            // 
            this.God.CommandText = "select ГодВыпуска from Автомобиль Where @id_auto = ID_Автомобиля";
            this.God.Connection = this.MysqlConnection;
            this.God.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // tsvet
            // 
            this.tsvet.CommandText = "select Цвет from Автомобиль Where @id_auto = ID_Автомобиля";
            this.tsvet.Connection = this.MysqlConnection;
            this.tsvet.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // Post
            // 
            this.Post.CommandText = "select ID_Поставки from Автомобиль Where @id_auto = ID_Автомобиля";
            this.Post.Connection = this.MysqlConnection;
            this.Post.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // txtProizv
            // 
            this.txtProizv.Location = new System.Drawing.Point(66, 162);
            this.txtProizv.Name = "txtProizv";
            this.txtProizv.Size = new System.Drawing.Size(159, 22);
            this.txtProizv.TabIndex = 20;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(323, 162);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(159, 22);
            this.txtModel.TabIndex = 20;
            // 
            // txtPostavka
            // 
            this.txtPostavka.Location = new System.Drawing.Point(323, 328);
            this.txtPostavka.Name = "txtPostavka";
            this.txtPostavka.Size = new System.Drawing.Size(159, 22);
            this.txtPostavka.TabIndex = 20;
            // 
            // ChangePoID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPostavka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtProizv);
            this.Controls.Add(this.btnDobavit);
            this.Controls.Add(this.textboxTsvet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxTsena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lblZagolovok);
            this.Controls.Add(this.txtboxGod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSost);
            this.Controls.Add(this.lblProizv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePoID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePoID";
            this.Load += new System.EventHandler(this.ChangePoID_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlIconteslatopleft;
        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmbSost;
        private System.Windows.Forms.Label lblProizv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxGod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxTsvet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxTsena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDobavit;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand ChangeAutoInfo;
        private System.Data.SqlClient.SqlCommand Proizv;
        private System.Data.SqlClient.SqlCommand Model;
        private System.Data.SqlClient.SqlCommand Tsena;
        private System.Data.SqlClient.SqlCommand Sost;
        private System.Data.SqlClient.SqlCommand God;
        private System.Data.SqlClient.SqlCommand tsvet;
        private System.Data.SqlClient.SqlCommand Post;
        private System.Windows.Forms.TextBox txtProizv;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPostavka;
    }
}