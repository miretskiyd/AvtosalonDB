namespace Автосалон
{
    partial class Prodaji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prodaji));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTsena = new System.Windows.Forms.TextBox();
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.cmbBoxListProizv = new System.Windows.Forms.ComboBox();
            this.lblKuzov = new System.Windows.Forms.Label();
            this.lvlMarka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUdalit = new System.Windows.Forms.Button();
            this.btnIzmenit = new System.Windows.Forms.Button();
            this.PoslednieProdaji = new System.Data.SqlClient.SqlCommand();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataProdaji = new System.Windows.Forms.DataGridView();
            this.InsertProizv = new System.Data.SqlClient.SqlCommand();
            this.FiltrProizv = new System.Data.SqlClient.SqlCommand();
            this.FiltrTsena = new System.Data.SqlClient.SqlCommand();
            this.FiltrTsenaProizv = new System.Data.SqlClient.SqlCommand();
            this.NalichieCom = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProdaji)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продажа автомобиля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTsena);
            this.panel1.Controls.Add(this.lblZagolovok);
            this.panel1.Controls.Add(this.btnExecute);
            this.panel1.Controls.Add(this.cmbBoxListProizv);
            this.panel1.Controls.Add(this.lblKuzov);
            this.panel1.Controls.Add(this.lvlMarka);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUdalit);
            this.panel1.Controls.Add(this.btnIzmenit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 155);
            this.panel1.TabIndex = 1;
            // 
            // txtTsena
            // 
            this.txtTsena.Location = new System.Drawing.Point(216, 105);
            this.txtTsena.Name = "txtTsena";
            this.txtTsena.Size = new System.Drawing.Size(100, 22);
            this.txtTsena.TabIndex = 21;
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
            this.btnExecute.Location = new System.Drawing.Point(359, 102);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(97, 29);
            this.btnExecute.TabIndex = 16;
            this.btnExecute.Text = "Применить";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cmbBoxListProizv
            // 
            this.cmbBoxListProizv.FormattingEnabled = true;
            this.cmbBoxListProizv.Location = new System.Drawing.Point(14, 104);
            this.cmbBoxListProizv.Name = "cmbBoxListProizv";
            this.cmbBoxListProizv.Size = new System.Drawing.Size(146, 24);
            this.cmbBoxListProizv.TabIndex = 18;
            // 
            // lblKuzov
            // 
            this.lblKuzov.AutoSize = true;
            this.lblKuzov.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKuzov.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKuzov.Location = new System.Drawing.Point(212, 77);
            this.lblKuzov.Name = "lblKuzov";
            this.lblKuzov.Size = new System.Drawing.Size(103, 18);
            this.lblKuzov.TabIndex = 17;
            this.lblKuzov.Text = "Сумма свыше:";
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
            this.label2.Location = new System.Drawing.Point(680, 57);
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
            this.btnUdalit.Location = new System.Drawing.Point(791, 101);
            this.btnUdalit.Name = "btnUdalit";
            this.btnUdalit.Size = new System.Drawing.Size(99, 23);
            this.btnUdalit.TabIndex = 13;
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
            this.btnIzmenit.Location = new System.Drawing.Point(686, 101);
            this.btnIzmenit.Name = "btnIzmenit";
            this.btnIzmenit.Size = new System.Drawing.Size(99, 23);
            this.btnIzmenit.TabIndex = 14;
            this.btnIzmenit.Text = "Изменить";
            this.btnIzmenit.UseVisualStyleBackColor = false;
            // 
            // PoslednieProdaji
            // 
            this.PoslednieProdaji.CommandText = resources.GetString("PoslednieProdaji.CommandText");
            this.PoslednieProdaji.Connection = this.MysqlConnection;
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataProdaji);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 388);
            this.panel2.TabIndex = 2;
            // 
            // dataProdaji
            // 
            this.dataProdaji.AllowUserToAddRows = false;
            this.dataProdaji.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.dataProdaji.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataProdaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProdaji.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.dataProdaji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProdaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataProdaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProdaji.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataProdaji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataProdaji.Location = new System.Drawing.Point(0, 0);
            this.dataProdaji.Name = "dataProdaji";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProdaji.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataProdaji.RowHeadersWidth = 51;
            this.dataProdaji.RowTemplate.Height = 24;
            this.dataProdaji.Size = new System.Drawing.Size(1029, 388);
            this.dataProdaji.TabIndex = 1;
            // 
            // InsertProizv
            // 
            this.InsertProizv.CommandText = "SELECT DISTINCT Производитель FROM Продажа JOIN Автомобиль ON Продажа.ID_Автомоби" +
    "ля = Автомобиль.ID_Автомобиля JOIN Модель ON Автомобиль.ID_Модели = Модель.ID_Мо" +
    "дели";
            this.InsertProizv.Connection = this.MysqlConnection;
            // 
            // FiltrProizv
            // 
            this.FiltrProizv.CommandText = "SELECT * FROM dbo.ПродажаФильтрПроизводитель(@proizv)";
            this.FiltrProizv.Connection = this.MysqlConnection;
            this.FiltrProizv.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@proizv", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // FiltrTsena
            // 
            this.FiltrTsena.CommandText = "SELECT * FROM ПродажаФильтрЦена(@tsena)";
            this.FiltrTsena.Connection = this.MysqlConnection;
            this.FiltrTsena.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@tsena", System.Data.SqlDbType.Int, 4)});
            // 
            // FiltrTsenaProizv
            // 
            this.FiltrTsenaProizv.CommandText = "SELECT * FROM ПродажаФильтрЦенаПроизв(@proizv, @tsena)";
            this.FiltrTsenaProizv.Connection = this.MysqlConnection;
            this.FiltrTsenaProizv.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@proizv", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@tsena", System.Data.SqlDbType.Int, 4)});
            // 
            // Prodaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1029, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Prodaji";
            this.Text = "Prodaji";
            this.Load += new System.EventHandler(this.Prodaji_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProdaji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Data.SqlClient.SqlCommand PoslednieProdaji;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataProdaji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUdalit;
        private System.Windows.Forms.Button btnIzmenit;
        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox cmbBoxListProizv;
        private System.Windows.Forms.Label lblKuzov;
        private System.Windows.Forms.Label lvlMarka;
        private System.Windows.Forms.TextBox txtTsena;
        private System.Data.SqlClient.SqlCommand InsertProizv;
        private System.Data.SqlClient.SqlCommand FiltrProizv;
        private System.Data.SqlClient.SqlCommand FiltrTsena;
        private System.Data.SqlClient.SqlCommand FiltrTsenaProizv;
        private System.Data.SqlClient.SqlCommand NalichieCom;
    }
}