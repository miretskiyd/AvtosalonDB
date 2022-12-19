namespace Автосалон
{
    partial class Sotrudniki
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSotrudniki = new System.Windows.Forms.DataGridView();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.FormLoadData = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSotrudniki)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btnDobavit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 119);
            this.panel1.TabIndex = 3;
            // 
            // btnDobavit
            // 
            this.btnDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnDobavit.FlatAppearance.BorderSize = 0;
            this.btnDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDobavit.Location = new System.Drawing.Point(18, 80);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(99, 26);
            this.btnDobavit.TabIndex = 14;
            this.btnDobavit.Text = "Добавить";
            this.btnDobavit.UseVisualStyleBackColor = false;
            this.btnDobavit.Click += new System.EventHandler(this.btnDobavit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Управление записями:";
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
            this.label1.Text = "Сотрудники";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataSotrudniki
            // 
            this.dataSotrudniki.AllowUserToAddRows = false;
            this.dataSotrudniki.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.dataSotrudniki.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataSotrudniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSotrudniki.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.dataSotrudniki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSotrudniki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataSotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSotrudniki.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataSotrudniki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSotrudniki.Location = new System.Drawing.Point(0, 119);
            this.dataSotrudniki.Name = "dataSotrudniki";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSotrudniki.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataSotrudniki.RowHeadersWidth = 51;
            this.dataSotrudniki.RowTemplate.Height = 24;
            this.dataSotrudniki.Size = new System.Drawing.Size(1029, 424);
            this.dataSotrudniki.TabIndex = 4;
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // FormLoadData
            // 
            this.FormLoadData.CommandText = "select ID_Сотрудника as ID, Фамилия, Имя, Отчество, Должность, Телефон, Логин fro" +
    "m Сотрудник";
            this.FormLoadData.Connection = this.MysqlConnection;
            // 
            // Sotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1029, 543);
            this.Controls.Add(this.dataSotrudniki);
            this.Controls.Add(this.panel1);
            this.Name = "Sotrudniki";
            this.Text = "Sotrudniki";
            this.Load += new System.EventHandler(this.Sotrudniki_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSotrudniki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDobavit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSotrudniki;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand FormLoadData;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}