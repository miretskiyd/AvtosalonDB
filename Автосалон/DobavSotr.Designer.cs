namespace Автосалон
{
    partial class DobavSotr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobavSotr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIconteslatopleft = new System.Windows.Forms.Panel();
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.lblProizv = new System.Windows.Forms.Label();
            this.txtOtch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDolzh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.idSotr = new System.Data.SqlClient.SqlCommand();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.InsDolzh = new System.Data.SqlClient.SqlCommand();
            this.InsSotr = new System.Data.SqlClient.SqlCommand();
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
            this.lblZagolovok.Size = new System.Drawing.Size(800, 68);
            this.lblZagolovok.TabIndex = 3;
            this.lblZagolovok.Text = "Добавление сотрудника с ID:  ";
            this.lblZagolovok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtId.Location = new System.Drawing.Point(617, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 36);
            this.txtId.TabIndex = 5;
            this.txtId.Text = "id";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFam
            // 
            this.txtFam.Location = new System.Drawing.Point(88, 161);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(128, 22);
            this.txtFam.TabIndex = 6;
            // 
            // lblProizv
            // 
            this.lblProizv.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProizv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProizv.Location = new System.Drawing.Point(22, 133);
            this.lblProizv.Name = "lblProizv";
            this.lblProizv.Size = new System.Drawing.Size(266, 25);
            this.lblProizv.TabIndex = 7;
            this.lblProizv.Text = "Фамилия";
            this.lblProizv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOtch
            // 
            this.txtOtch.Location = new System.Drawing.Point(560, 161);
            this.txtOtch.Name = "txtOtch";
            this.txtOtch.Size = new System.Drawing.Size(128, 22);
            this.txtOtch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(494, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Отчество";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtImya
            // 
            this.txtImya.Location = new System.Drawing.Point(317, 161);
            this.txtImya.Name = "txtImya";
            this.txtImya.Size = new System.Drawing.Size(128, 22);
            this.txtImya.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(248, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbDolzh
            // 
            this.cmbDolzh.FormattingEnabled = true;
            this.cmbDolzh.Location = new System.Drawing.Point(88, 284);
            this.cmbDolzh.Name = "cmbDolzh";
            this.cmbDolzh.Size = new System.Drawing.Size(128, 24);
            this.cmbDolzh.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Должность";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(317, 286);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(128, 22);
            this.txtTelef.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(248, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефон";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(560, 284);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(128, 22);
            this.txtLogin.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(491, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Логин";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDobavit
            // 
            this.btnDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnDobavit.FlatAppearance.BorderSize = 0;
            this.btnDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavit.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobavit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDobavit.Location = new System.Drawing.Point(303, 351);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(152, 38);
            this.btnDobavit.TabIndex = 9;
            this.btnDobavit.Text = "Добавить";
            this.btnDobavit.UseVisualStyleBackColor = false;
            this.btnDobavit.Click += new System.EventHandler(this.btnDobavit_Click);
            // 
            // idSotr
            // 
            this.idSotr.CommandText = "select MAX(ID_Сотрудника) + 1 from Сотрудник";
            this.idSotr.Connection = this.MysqlConnection;
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // InsDolzh
            // 
            this.InsDolzh.CommandText = "select distinct Должность from Сотрудник";
            this.InsDolzh.Connection = this.MysqlConnection;
            // 
            // InsSotr
            // 
            this.InsSotr.CommandText = "ДобавлениеСотрудника";
            this.InsSotr.CommandType = System.Data.CommandType.StoredProcedure;
            this.InsSotr.Connection = this.MysqlConnection;
            this.InsSotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id_sotr", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@fam", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@imya", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@otchest", System.Data.SqlDbType.VarChar, 35),
            new System.Data.SqlClient.SqlParameter("@dolzh", System.Data.SqlDbType.VarChar, 40),
            new System.Data.SqlClient.SqlParameter("@telef", System.Data.SqlDbType.VarChar, 13),
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar, 20)});
            // 
            // DobavSotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.btnDobavit);
            this.Controls.Add(this.cmbDolzh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProizv);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.txtImya);
            this.Controls.Add(this.txtOtch);
            this.Controls.Add(this.txtFam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblZagolovok);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DobavSotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sq";
            this.Load += new System.EventHandler(this.DobavSotr_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlIconteslatopleft;
        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.Label lblProizv;
        private System.Windows.Forms.TextBox txtOtch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDolzh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDobavit;
        private System.Data.SqlClient.SqlCommand idSotr;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand InsDolzh;
        private System.Data.SqlClient.SqlCommand InsSotr;
    }
}