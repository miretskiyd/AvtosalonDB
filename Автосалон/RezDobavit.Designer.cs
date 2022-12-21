namespace Автосалон
{
    partial class RezDobavit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezDobavit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIconteslatopleft = new System.Windows.Forms.Panel();
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.lblProizv = new System.Windows.Forms.Label();
            this.textboxKol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.InsertPost = new System.Data.SqlClient.SqlCommand();
            this.InsID = new System.Data.SqlClient.SqlCommand();
            this.Sotr = new System.Data.SqlClient.SqlCommand();
            this.IDPostovshika = new System.Data.SqlClient.SqlCommand();
            this.DobPost = new System.Data.SqlClient.SqlCommand();
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
            this.panel1.Size = new System.Drawing.Size(675, 35);
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
            this.btnExit.Location = new System.Drawing.Point(639, 0);
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
            this.lblZagolovok.Size = new System.Drawing.Size(675, 68);
            this.lblZagolovok.TabIndex = 3;
            this.lblZagolovok.Text = "Добавление поставки с ID:  ";
            this.lblZagolovok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtId.Location = new System.Drawing.Point(540, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 36);
            this.txtId.TabIndex = 5;
            this.txtId.Text = "id";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDobavit
            // 
            this.btnDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnDobavit.FlatAppearance.BorderSize = 0;
            this.btnDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavit.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobavit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDobavit.Location = new System.Drawing.Point(261, 240);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(152, 38);
            this.btnDobavit.TabIndex = 8;
            this.btnDobavit.Text = "Добавить";
            this.btnDobavit.UseVisualStyleBackColor = false;
            this.btnDobavit.Click += new System.EventHandler(this.btnDobavit_Click);
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(113, 151);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(121, 24);
            this.cmbPost.TabIndex = 9;
            // 
            // lblProizv
            // 
            this.lblProizv.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProizv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProizv.Location = new System.Drawing.Point(108, 112);
            this.lblProizv.Name = "lblProizv";
            this.lblProizv.Size = new System.Drawing.Size(132, 25);
            this.lblProizv.TabIndex = 10;
            this.lblProizv.Text = "Поставщик";
            this.lblProizv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textboxKol
            // 
            this.textboxKol.Location = new System.Drawing.Point(445, 151);
            this.textboxKol.Name = "textboxKol";
            this.textboxKol.Size = new System.Drawing.Size(120, 22);
            this.textboxKol.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(429, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // InsertPost
            // 
            this.InsertPost.CommandText = "select distinct Наименование from Поставщик";
            this.InsertPost.Connection = this.MysqlConnection;
            // 
            // InsID
            // 
            this.InsID.CommandText = "select MAX(ID_Поставки) + 1 from Поставка";
            this.InsID.Connection = this.MysqlConnection;
            // 
            // Sotr
            // 
            this.Sotr.CommandText = "SELECT dbo.IDСотрВошедшего(@userlogin)";
            this.Sotr.Connection = this.MysqlConnection;
            this.Sotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userlogin", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // IDPostovshika
            // 
            this.IDPostovshika.CommandText = "Select dbo.Postavshik(@naim)";
            this.IDPostovshika.Connection = this.MysqlConnection;
            this.IDPostovshika.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@naim", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // DobPost
            // 
            this.DobPost.CommandText = "ДобавлениеПоставки";
            this.DobPost.CommandType = System.Data.CommandType.StoredProcedure;
            this.DobPost.Connection = this.MysqlConnection;
            this.DobPost.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id_postavka", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@id_postavshika", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@id_sotr", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@kol", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@data", System.Data.SqlDbType.Date, 3)});
            // 
            // RezDobavit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(675, 317);
            this.Controls.Add(this.textboxKol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProizv);
            this.Controls.Add(this.cmbPost);
            this.Controls.Add(this.btnDobavit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblZagolovok);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezDobavit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezDobavit";
            this.Load += new System.EventHandler(this.RezDobavit_Load);
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
        private System.Windows.Forms.Button btnDobavit;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label lblProizv;
        private System.Windows.Forms.TextBox textboxKol;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand InsertPost;
        private System.Data.SqlClient.SqlCommand InsID;
        private System.Data.SqlClient.SqlCommand Sotr;
        private System.Data.SqlClient.SqlCommand IDPostovshika;
        private System.Data.SqlClient.SqlCommand DobPost;
    }
}