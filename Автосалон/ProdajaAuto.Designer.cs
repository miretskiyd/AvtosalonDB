namespace Автосалон
{
    partial class ProdajaAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdajaAuto));
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIconteslatopleft = new System.Windows.Forms.Panel();
            this.lblProizv = new System.Windows.Forms.Label();
            this.txtFIOPokup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSummaProd = new System.Windows.Forms.TextBox();
            this.dateProd = new System.Windows.Forms.DateTimePicker();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.Label();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.InsertSummaProd = new System.Data.SqlClient.SqlCommand();
            this.Prodaja = new System.Data.SqlClient.SqlCommand();
            this.ID_Sotr = new System.Data.SqlClient.SqlCommand();
            this.CountProd = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZagolovok
            // 
            this.lblZagolovok.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZagolovok.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZagolovok.Location = new System.Drawing.Point(0, 35);
            this.lblZagolovok.Name = "lblZagolovok";
            this.lblZagolovok.Size = new System.Drawing.Size(884, 68);
            this.lblZagolovok.TabIndex = 2;
            this.lblZagolovok.Text = "Продажа автомобиля с ID:";
            this.lblZagolovok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pnlIconteslatopleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 35);
            this.panel1.TabIndex = 3;
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
            this.btnExit.Location = new System.Drawing.Point(848, 0);
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
            // lblProizv
            // 
            this.lblProizv.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProizv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProizv.Location = new System.Drawing.Point(12, 123);
            this.lblProizv.Name = "lblProizv";
            this.lblProizv.Size = new System.Drawing.Size(266, 25);
            this.lblProizv.TabIndex = 5;
            this.lblProizv.Text = "ФИО Покупателя:";
            this.lblProizv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFIOPokup
            // 
            this.txtFIOPokup.Location = new System.Drawing.Point(41, 170);
            this.txtFIOPokup.Name = "txtFIOPokup";
            this.txtFIOPokup.Size = new System.Drawing.Size(206, 22);
            this.txtFIOPokup.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(306, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(597, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата продажи:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSummaProd
            // 
            this.txtSummaProd.Location = new System.Drawing.Point(368, 170);
            this.txtSummaProd.Name = "txtSummaProd";
            this.txtSummaProd.Size = new System.Drawing.Size(151, 22);
            this.txtSummaProd.TabIndex = 6;
            // 
            // dateProd
            // 
            this.dateProd.Location = new System.Drawing.Point(634, 170);
            this.dateProd.Name = "dateProd";
            this.dateProd.Size = new System.Drawing.Size(200, 22);
            this.dateProd.TabIndex = 7;
            // 
            // btnDobavit
            // 
            this.btnDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnDobavit.FlatAppearance.BorderSize = 0;
            this.btnDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavit.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobavit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDobavit.Location = new System.Drawing.Point(368, 263);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(152, 38);
            this.btnDobavit.TabIndex = 9;
            this.btnDobavit.Text = "Продать";
            this.btnDobavit.UseVisualStyleBackColor = false;
            this.btnDobavit.Click += new System.EventHandler(this.btnDobavit_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtId.Location = new System.Drawing.Point(652, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 37);
            this.txtId.TabIndex = 10;
            this.txtId.Text = "id";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // InsertSummaProd
            // 
            this.InsertSummaProd.CommandText = "select Цена from Автомобиль Where @id_auto = ID_Автомобиля";
            this.InsertSummaProd.Connection = this.MysqlConnection;
            this.InsertSummaProd.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4, "ID_Автомобиля")});
            // 
            // Prodaja
            // 
            this.Prodaja.CommandText = "ДобавлениеПродажиАвтомобиля";
            this.Prodaja.CommandType = System.Data.CommandType.StoredProcedure;
            this.Prodaja.Connection = this.MysqlConnection;
            this.Prodaja.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id_prod", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@id_avto", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@id_sotr", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@fio_pok", System.Data.SqlDbType.VarChar, 40),
            new System.Data.SqlClient.SqlParameter("@data_pok", System.Data.SqlDbType.Date, 3),
            new System.Data.SqlClient.SqlParameter("@tsena", System.Data.SqlDbType.Int, 4)});
            // 
            // ID_Sotr
            // 
            this.ID_Sotr.CommandText = "SELECT dbo.IDСотрВошедшего(@userlogin)";
            this.ID_Sotr.Connection = this.MysqlConnection;
            this.ID_Sotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userlogin", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // CountProd
            // 
            this.CountProd.CommandText = "SELECT Max(ID_Продажи)+1 from Продажа";
            this.CountProd.Connection = this.MysqlConnection;
            // 
            // ProdajaAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(884, 328);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDobavit);
            this.Controls.Add(this.dateProd);
            this.Controls.Add(this.txtSummaProd);
            this.Controls.Add(this.txtFIOPokup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProizv);
            this.Controls.Add(this.lblZagolovok);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProdajaAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdajaAuto";
            this.Load += new System.EventHandler(this.ProdajaAuto_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlIconteslatopleft;
        private System.Windows.Forms.Label lblProizv;
        private System.Windows.Forms.TextBox txtFIOPokup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSummaProd;
        private System.Windows.Forms.DateTimePicker dateProd;
        private System.Windows.Forms.Button btnDobavit;
        private System.Windows.Forms.Label txtId;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand InsertSummaProd;
        private System.Data.SqlClient.SqlCommand Prodaja;
        private System.Data.SqlClient.SqlCommand ID_Sotr;
        private System.Data.SqlClient.SqlCommand CountProd;
    }
}