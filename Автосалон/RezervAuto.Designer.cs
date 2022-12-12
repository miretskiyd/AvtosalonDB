namespace Автосалон
{
    partial class RezervAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervAuto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIconteslatopleft = new System.Windows.Forms.Panel();
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtFIOPokup = new System.Windows.Forms.TextBox();
            this.lblProizv = new System.Windows.Forms.Label();
            this.dateRezerv = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRezerv = new System.Windows.Forms.Button();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.RezervCom = new System.Data.SqlClient.SqlCommand();
            this.ID_sotr = new System.Data.SqlClient.SqlCommand();
            this.ID_rez = new System.Data.SqlClient.SqlCommand();
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
            this.panel1.Size = new System.Drawing.Size(858, 35);
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
            this.btnExit.Location = new System.Drawing.Point(822, 0);
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
            this.lblZagolovok.Size = new System.Drawing.Size(858, 44);
            this.lblZagolovok.TabIndex = 4;
            this.lblZagolovok.Text = "Зарезервировать автомобиль с ID: ";
            this.lblZagolovok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id.Location = new System.Drawing.Point(695, 35);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(93, 39);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "id";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFIOPokup
            // 
            this.txtFIOPokup.Location = new System.Drawing.Point(70, 192);
            this.txtFIOPokup.Name = "txtFIOPokup";
            this.txtFIOPokup.Size = new System.Drawing.Size(206, 22);
            this.txtFIOPokup.TabIndex = 8;
            // 
            // lblProizv
            // 
            this.lblProizv.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProizv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProizv.Location = new System.Drawing.Point(41, 145);
            this.lblProizv.Name = "lblProizv";
            this.lblProizv.Size = new System.Drawing.Size(266, 25);
            this.lblProizv.TabIndex = 7;
            this.lblProizv.Text = "ФИО Резервирующего:";
            this.lblProizv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateRezerv
            // 
            this.dateRezerv.Location = new System.Drawing.Point(571, 192);
            this.dateRezerv.Name = "dateRezerv";
            this.dateRezerv.Size = new System.Drawing.Size(200, 22);
            this.dateRezerv.TabIndex = 9;
            this.dateRezerv.Value = new System.DateTime(2022, 12, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(532, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Резервирование до:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRezerv
            // 
            this.btnRezerv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnRezerv.FlatAppearance.BorderSize = 0;
            this.btnRezerv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerv.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRezerv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRezerv.Location = new System.Drawing.Point(338, 341);
            this.btnRezerv.Name = "btnRezerv";
            this.btnRezerv.Size = new System.Drawing.Size(194, 38);
            this.btnRezerv.TabIndex = 10;
            this.btnRezerv.Text = "Зарезервировать";
            this.btnRezerv.UseVisualStyleBackColor = false;
            this.btnRezerv.Click += new System.EventHandler(this.btnRezerv_Click);
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // RezervCom
            // 
            this.RezervCom.CommandText = "НовоеРезервирование";
            this.RezervCom.CommandType = System.Data.CommandType.StoredProcedure;
            this.RezervCom.Connection = this.MysqlConnection;
            this.RezervCom.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id_rezerv", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@id_sotr", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@fio_pok", System.Data.SqlDbType.VarChar, 40),
            new System.Data.SqlClient.SqlParameter("@dateNowRez", System.Data.SqlDbType.Date, 3),
            new System.Data.SqlClient.SqlParameter("@dateDoRez", System.Data.SqlDbType.Date, 3)});
            // 
            // ID_sotr
            // 
            this.ID_sotr.CommandText = "SELECT dbo.IDСотрВошедшего(@userlogin)";
            this.ID_sotr.Connection = this.MysqlConnection;
            this.ID_sotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userlogin", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // ID_rez
            // 
            this.ID_rez.CommandText = "SELECT Max(ID_Резервирования)+1 from Резервирование";
            this.ID_rez.Connection = this.MysqlConnection;
            // 
            // RezervAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(858, 434);
            this.Controls.Add(this.btnRezerv);
            this.Controls.Add(this.dateRezerv);
            this.Controls.Add(this.txtFIOPokup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProizv);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lblZagolovok);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervAuto";
            this.Load += new System.EventHandler(this.RezervAuto_Load);
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
        private System.Windows.Forms.TextBox txtFIOPokup;
        private System.Windows.Forms.Label lblProizv;
        private System.Windows.Forms.DateTimePicker dateRezerv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRezerv;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand RezervCom;
        private System.Data.SqlClient.SqlCommand ID_sotr;
        private System.Data.SqlClient.SqlCommand ID_rez;
    }
}