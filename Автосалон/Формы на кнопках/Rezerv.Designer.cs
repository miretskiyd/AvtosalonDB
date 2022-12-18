namespace Автосалон
{
    partial class Rezerv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezerv));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cmbSotr = new System.Windows.Forms.ComboBox();
            this.cmbBoxListProizv = new System.Windows.Forms.ComboBox();
            this.lblSotr = new System.Windows.Forms.Label();
            this.lvlMarka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUdalit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataRezerv = new System.Windows.Forms.DataGridView();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.RezerTable = new System.Data.SqlClient.SqlCommand();
            this.FiltrProizv = new System.Data.SqlClient.SqlCommand();
            this.InsertProizv = new System.Data.SqlClient.SqlCommand();
            this.InsertSotr = new System.Data.SqlClient.SqlCommand();
            this.FiltrSotr = new System.Data.SqlClient.SqlCommand();
            this.FiltrSotrProizv = new System.Data.SqlClient.SqlCommand();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRezerv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblZagolovok);
            this.panel2.Controls.Add(this.btnExecute);
            this.panel2.Controls.Add(this.cmbSotr);
            this.panel2.Controls.Add(this.cmbBoxListProizv);
            this.panel2.Controls.Add(this.lblSotr);
            this.panel2.Controls.Add(this.lvlMarka);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnUdalit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 155);
            this.panel2.TabIndex = 2;
            // 
            // lblZagolovok
            // 
            this.lblZagolovok.AutoSize = true;
            this.lblZagolovok.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZagolovok.Location = new System.Drawing.Point(8, 45);
            this.lblZagolovok.Name = "lblZagolovok";
            this.lblZagolovok.Size = new System.Drawing.Size(231, 32);
            this.lblZagolovok.TabIndex = 20;
            this.lblZagolovok.Text = "Фильтры поиска:";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExecute.Location = new System.Drawing.Point(386, 101);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(97, 29);
            this.btnExecute.TabIndex = 16;
            this.btnExecute.Text = "Применить";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cmbSotr
            // 
            this.cmbSotr.FormattingEnabled = true;
            this.cmbSotr.Location = new System.Drawing.Point(215, 104);
            this.cmbSotr.Name = "cmbSotr";
            this.cmbSotr.Size = new System.Drawing.Size(146, 24);
            this.cmbSotr.TabIndex = 18;
            // 
            // cmbBoxListProizv
            // 
            this.cmbBoxListProizv.FormattingEnabled = true;
            this.cmbBoxListProizv.Location = new System.Drawing.Point(14, 104);
            this.cmbBoxListProizv.Name = "cmbBoxListProizv";
            this.cmbBoxListProizv.Size = new System.Drawing.Size(146, 24);
            this.cmbBoxListProizv.TabIndex = 18;
            // 
            // lblSotr
            // 
            this.lblSotr.AutoSize = true;
            this.lblSotr.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSotr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSotr.Location = new System.Drawing.Point(212, 77);
            this.lblSotr.Name = "lblSotr";
            this.lblSotr.Size = new System.Drawing.Size(102, 18);
            this.lblSotr.TabIndex = 17;
            this.lblSotr.Text = "Сотрудником:";
            // 
            // lvlMarka
            // 
            this.lvlMarka.AutoSize = true;
            this.lvlMarka.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvlMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvlMarka.Location = new System.Drawing.Point(11, 77);
            this.lvlMarka.Name = "lvlMarka";
            this.lvlMarka.Size = new System.Drawing.Size(117, 18);
            this.lvlMarka.TabIndex = 15;
            this.lvlMarka.Text = "Производитель:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(646, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Управление записями:";
            // 
            // btnUdalit
            // 
            this.btnUdalit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnUdalit.FlatAppearance.BorderSize = 0;
            this.btnUdalit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUdalit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUdalit.Location = new System.Drawing.Point(652, 107);
            this.btnUdalit.Name = "btnUdalit";
            this.btnUdalit.Size = new System.Drawing.Size(99, 23);
            this.btnUdalit.TabIndex = 13;
            this.btnUdalit.Text = "Удалить";
            this.btnUdalit.UseVisualStyleBackColor = false;
            this.btnUdalit.Click += new System.EventHandler(this.btnUdalit_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(968, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Зарезервированные автомобили";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataRezerv
            // 
            this.dataRezerv.AllowUserToAddRows = false;
            this.dataRezerv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.dataRezerv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRezerv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRezerv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.dataRezerv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRezerv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataRezerv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRezerv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataRezerv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRezerv.Location = new System.Drawing.Point(0, 155);
            this.dataRezerv.Name = "dataRezerv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRezerv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataRezerv.RowHeadersWidth = 51;
            this.dataRezerv.RowTemplate.Height = 24;
            this.dataRezerv.Size = new System.Drawing.Size(968, 423);
            this.dataRezerv.TabIndex = 3;
            this.dataRezerv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRezerv_CellClick);
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // RezerTable
            // 
            this.RezerTable.CommandText = resources.GetString("RezerTable.CommandText");
            this.RezerTable.Connection = this.MysqlConnection;
            // 
            // FiltrProizv
            // 
            this.FiltrProizv.CommandText = "SELECT * FROM dbo.РезервированиеФильтрПроизводитель(@proizv) ORDER BY ID DESC";
            this.FiltrProizv.Connection = this.MysqlConnection;
            this.FiltrProizv.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@proizv", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // InsertProizv
            // 
            this.InsertProizv.CommandText = "SELECT DISTINCT Производитель FROM Резервирование JOIN Автомобиль ON Резервирован" +
    "ие.ID_Автомобиля = Автомобиль.ID_Автомобиля JOIN Модель ON Автомобиль.ID_Модели " +
    "= Модель.ID_Модели";
            this.InsertProizv.Connection = this.MysqlConnection;
            // 
            // InsertSotr
            // 
            this.InsertSotr.CommandText = "SELECT DISTINCT Фамилия From Резервирование JOIN Сотрудник ON Резервирование.ID_С" +
    "отрудника = Сотрудник.ID_Сотрудника";
            this.InsertSotr.Connection = this.MysqlConnection;
            // 
            // FiltrSotr
            // 
            this.FiltrSotr.CommandText = "SELECT * FROM dbo.РезервированиеФильтрСотрудник(@sotr) ORDER BY ID DESC";
            this.FiltrSotr.Connection = this.MysqlConnection;
            this.FiltrSotr.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@sotr", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // FiltrSotrProizv
            // 
            this.FiltrSotrProizv.CommandText = "SELECT * FROM dbo.РезервированиеФильтрСотрудникПроизв(@sotr, @proizv) ORDER BY ID" +
    " DESC";
            this.FiltrSotrProizv.Connection = this.MysqlConnection;
            this.FiltrSotrProizv.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@sotr", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@proizv", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // Rezerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(968, 578);
            this.Controls.Add(this.dataRezerv);
            this.Controls.Add(this.panel2);
            this.Name = "Rezerv";
            this.Text = "Rezerv";
            this.Load += new System.EventHandler(this.Rezerv_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRezerv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox cmbBoxListProizv;
        private System.Windows.Forms.Label lblSotr;
        private System.Windows.Forms.Label lvlMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUdalit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataRezerv;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand RezerTable;
        private System.Data.SqlClient.SqlCommand FiltrProizv;
        private System.Data.SqlClient.SqlCommand InsertProizv;
        private System.Windows.Forms.ComboBox cmbSotr;
        private System.Data.SqlClient.SqlCommand InsertSotr;
        private System.Data.SqlClient.SqlCommand FiltrSotr;
        private System.Data.SqlClient.SqlCommand FiltrSotrProizv;
    }
}