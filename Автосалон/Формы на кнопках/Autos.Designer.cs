namespace Автосалон
{
    partial class Autos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lvlMarka = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKuzov = new System.Windows.Forms.Label();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.MysqlCommand = new System.Data.SqlClient.SqlCommand();
            this.dataAutos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBoxListMarks = new System.Windows.Forms.ComboBox();
            this.MysqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandInsertMarks = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandInsertKuzov = new System.Data.SqlClient.SqlCommand();
            this.cmboxListKuzov = new System.Windows.Forms.ComboBox();
            this.mysqlcomOnlyMark = new System.Data.SqlClient.SqlCommand();
            this.mysqlcomOnlyKuzov = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDobavlenie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUdalit = new System.Windows.Forms.Button();
            this.btnIzmenit = new System.Windows.Forms.Button();
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.DeletingCommand = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataAutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlMarka
            // 
            this.lvlMarka.AutoSize = true;
            this.lvlMarka.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvlMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvlMarka.Location = new System.Drawing.Point(27, 31);
            this.lvlMarka.Name = "lvlMarka";
            this.lvlMarka.Size = new System.Drawing.Size(126, 18);
            this.lvlMarka.TabIndex = 2;
            this.lvlMarka.Text = "Название марки:";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExecute.Location = new System.Drawing.Point(385, 50);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(97, 29);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Применить";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            // 
            // lblKuzov
            // 
            this.lblKuzov.AutoSize = true;
            this.lblKuzov.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKuzov.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKuzov.Location = new System.Drawing.Point(228, 31);
            this.lblKuzov.Name = "lblKuzov";
            this.lblKuzov.Size = new System.Drawing.Size(50, 18);
            this.lblKuzov.TabIndex = 4;
            this.lblKuzov.Text = "Кузов:";
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // MysqlCommand
            // 
            this.MysqlCommand.CommandText = resources.GetString("MysqlCommand.CommandText");
            this.MysqlCommand.Connection = this.MysqlConnection;
            // 
            // dataAutos
            // 
            this.dataAutos.AllowUserToAddRows = false;
            this.dataAutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.dataAutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dataAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.dataAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAutos.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAutos.Location = new System.Drawing.Point(0, 0);
            this.dataAutos.Name = "dataAutos";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataAutos.RowHeadersWidth = 51;
            this.dataAutos.RowTemplate.Height = 24;
            this.dataAutos.Size = new System.Drawing.Size(800, 350);
            this.dataAutos.TabIndex = 0;
            this.dataAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAutos_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataAutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 350);
            this.panel1.TabIndex = 5;
            // 
            // cmbBoxListMarks
            // 
            this.cmbBoxListMarks.FormattingEnabled = true;
            this.cmbBoxListMarks.Location = new System.Drawing.Point(30, 58);
            this.cmbBoxListMarks.Name = "cmbBoxListMarks";
            this.cmbBoxListMarks.Size = new System.Drawing.Size(146, 24);
            this.cmbBoxListMarks.TabIndex = 7;
            // 
            // MysqlCommand2
            // 
            this.MysqlCommand2.CommandText = "SELECT * FROM dbo.АвтомобилиФорма(@marka, @kuzov)";
            this.MysqlCommand2.Connection = this.MysqlConnection;
            this.MysqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@marka", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@kuzov", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlCommandInsertMarks
            // 
            this.sqlCommandInsertMarks.CommandText = "SELECT DISTINCT Производитель\r\nFROM     Модель\r\nORDER BY Производитель";
            this.sqlCommandInsertMarks.Connection = this.MysqlConnection;
            // 
            // sqlCommandInsertKuzov
            // 
            this.sqlCommandInsertKuzov.CommandText = "SELECT Distinct Кузов From Модель Order by Кузов asc";
            this.sqlCommandInsertKuzov.Connection = this.MysqlConnection;
            // 
            // cmboxListKuzov
            // 
            this.cmboxListKuzov.FormattingEnabled = true;
            this.cmboxListKuzov.Location = new System.Drawing.Point(231, 58);
            this.cmboxListKuzov.Name = "cmboxListKuzov";
            this.cmboxListKuzov.Size = new System.Drawing.Size(121, 24);
            this.cmboxListKuzov.TabIndex = 8;
            this.cmboxListKuzov.SelectedIndexChanged += new System.EventHandler(this.cmboxListKuzov_SelectedIndexChanged);
            // 
            // mysqlcomOnlyMark
            // 
            this.mysqlcomOnlyMark.CommandText = "SELECT * FROM dbo.АвтомобилиФормаМарка(@marka)";
            this.mysqlcomOnlyMark.Connection = this.MysqlConnection;
            this.mysqlcomOnlyMark.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@marka", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // mysqlcomOnlyKuzov
            // 
            this.mysqlcomOnlyKuzov.CommandText = "SELECT * FROM dbo.АвтомобилиФормаКузов(@kuzov)";
            this.mysqlcomOnlyKuzov.Connection = this.MysqlConnection;
            this.mysqlcomOnlyKuzov.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@kuzov", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblZagolovok);
            this.panel2.Controls.Add(this.btnExecute);
            this.panel2.Controls.Add(this.cmbBoxListMarks);
            this.panel2.Controls.Add(this.cmboxListKuzov);
            this.panel2.Controls.Add(this.lblKuzov);
            this.panel2.Controls.Add(this.lvlMarka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDobavlenie);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnUdalit);
            this.panel3.Controls.Add(this.btnIzmenit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(409, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 100);
            this.panel3.TabIndex = 11;
            // 
            // btnDobavlenie
            // 
            this.btnDobavlenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnDobavlenie.FlatAppearance.BorderSize = 0;
            this.btnDobavlenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavlenie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDobavlenie.Location = new System.Drawing.Point(6, 53);
            this.btnDobavlenie.Name = "btnDobavlenie";
            this.btnDobavlenie.Size = new System.Drawing.Size(99, 23);
            this.btnDobavlenie.TabIndex = 10;
            this.btnDobavlenie.Text = "Добавить";
            this.btnDobavlenie.UseVisualStyleBackColor = false;
            this.btnDobavlenie.Click += new System.EventHandler(this.btnDobavlenie_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Управление записями:";
            // 
            // btnUdalit
            // 
            this.btnUdalit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnUdalit.FlatAppearance.BorderSize = 0;
            this.btnUdalit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUdalit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUdalit.Location = new System.Drawing.Point(216, 53);
            this.btnUdalit.Name = "btnUdalit";
            this.btnUdalit.Size = new System.Drawing.Size(99, 23);
            this.btnUdalit.TabIndex = 10;
            this.btnUdalit.Text = "Удалить";
            this.btnUdalit.UseVisualStyleBackColor = false;
            this.btnUdalit.Click += new System.EventHandler(this.btnUdalit_Click);
            // 
            // btnIzmenit
            // 
            this.btnIzmenit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnIzmenit.FlatAppearance.BorderSize = 0;
            this.btnIzmenit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmenit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzmenit.Location = new System.Drawing.Point(111, 53);
            this.btnIzmenit.Name = "btnIzmenit";
            this.btnIzmenit.Size = new System.Drawing.Size(99, 23);
            this.btnIzmenit.TabIndex = 10;
            this.btnIzmenit.Text = "Изменить";
            this.btnIzmenit.UseVisualStyleBackColor = false;
            this.btnIzmenit.Click += new System.EventHandler(this.btnIzmenit_Click);
            // 
            // lblZagolovok
            // 
            this.lblZagolovok.AutoSize = true;
            this.lblZagolovok.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZagolovok.Location = new System.Drawing.Point(75, 0);
            this.lblZagolovok.Name = "lblZagolovok";
            this.lblZagolovok.Size = new System.Drawing.Size(231, 32);
            this.lblZagolovok.TabIndex = 9;
            this.lblZagolovok.Text = "Фильтры поиска:";
            // 
            // DeletingCommand
            // 
            this.DeletingCommand.CommandText = "DeletingAuto";
            this.DeletingCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.DeletingCommand.Connection = this.MysqlConnection;
            this.DeletingCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id_auto", System.Data.SqlDbType.Int, 4)});
            // 
            // Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "Autos";
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.Autos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lvlMarka;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKuzov;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand MysqlCommand;
        private System.Windows.Forms.DataGridView dataAutos;
        private System.Windows.Forms.Panel panel1;
        private System.Data.SqlClient.SqlCommand MysqlCommand2;
        private System.Windows.Forms.ComboBox cmbBoxListMarks;
        private System.Data.SqlClient.SqlCommand sqlCommandInsertMarks;
        private System.Data.SqlClient.SqlCommand sqlCommandInsertKuzov;
        private System.Windows.Forms.ComboBox cmboxListKuzov;
        private System.Data.SqlClient.SqlCommand mysqlcomOnlyMark;
        private System.Data.SqlClient.SqlCommand mysqlcomOnlyKuzov;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUdalit;
        private System.Windows.Forms.Button btnIzmenit;
        private System.Windows.Forms.Button btnDobavlenie;
        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlCommand DeletingCommand;
    }
}