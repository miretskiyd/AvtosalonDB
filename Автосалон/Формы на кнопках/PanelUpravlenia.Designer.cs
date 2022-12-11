namespace Автосалон
{
    partial class PanelUpravlenia
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.mysqlCommand = new System.Data.SqlClient.SqlCommand();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtosalonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbboxSotr = new System.Windows.Forms.ComboBox();
            this.сотрудникBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avtosalonDataSet = new Автосалон.AvtosalonDataSet();
            this.сотрудникBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowsotr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimeNach = new System.Windows.Forms.DateTimePicker();
            this.dtimeDo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountPrib = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MysqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataAnalyze = new System.Windows.Forms.DataGridView();
            this.сотрудникTableAdapter = new Автосалон.AvtosalonDataSetTableAdapters.СотрудникTableAdapter();
            this.InsertManagers = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtosalonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtosalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnalyze)).BeginInit();
            this.SuspendLayout();
            // 
            // MySqlConnection
            // 
            this.MySqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // mysqlCommand
            // 
            this.mysqlCommand.CommandText = "SELECT * FROM ПродажиСотрудника(@sotr, @dateS, @dateDo)";
            this.mysqlCommand.Connection = this.MySqlConnection;
            this.mysqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@sotr", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@dateS", System.Data.SqlDbType.Date, 1024),
            new System.Data.SqlClient.SqlParameter("@dateDo", System.Data.SqlDbType.Date, 1024)});
            // 
            // cmbboxSotr
            // 
            this.cmbboxSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbboxSotr.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbboxSotr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cmbboxSotr.FormattingEnabled = true;
            this.cmbboxSotr.Location = new System.Drawing.Point(12, 59);
            this.cmbboxSotr.Name = "cmbboxSotr";
            this.cmbboxSotr.Size = new System.Drawing.Size(163, 33);
            this.cmbboxSotr.TabIndex = 2;
            this.cmbboxSotr.SelectedIndexChanged += new System.EventHandler(this.cmbboxSotr_SelectedIndexChanged);
            // 
            // сотрудникBindingSource2
            // 
            this.сотрудникBindingSource2.DataMember = "Сотрудник";
            this.сотрудникBindingSource2.DataSource = this.avtosalonDataSet;
            this.сотрудникBindingSource2.Filter = "";
            // 
            // avtosalonDataSet
            // 
            this.avtosalonDataSet.DataSetName = "AvtosalonDataSet";
            this.avtosalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnShowsotr
            // 
            this.btnShowsotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowsotr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShowsotr.FlatAppearance.BorderSize = 0;
            this.btnShowsotr.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowsotr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowsotr.Location = new System.Drawing.Point(195, 58);
            this.btnShowsotr.Name = "btnShowsotr";
            this.btnShowsotr.Size = new System.Drawing.Size(119, 33);
            this.btnShowsotr.TabIndex = 3;
            this.btnShowsotr.Text = "Показать";
            this.btnShowsotr.UseVisualStyleBackColor = false;
            this.btnShowsotr.Click += new System.EventHandler(this.btnShowsotr_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1268, 114);
            this.label1.TabIndex = 4;
            this.label1.Text = "Анализ продаж менеджеров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtimeNach
            // 
            this.dtimeNach.Location = new System.Drawing.Point(91, 64);
            this.dtimeNach.Name = "dtimeNach";
            this.dtimeNach.Size = new System.Drawing.Size(200, 22);
            this.dtimeNach.TabIndex = 5;
            this.dtimeNach.Value = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            // 
            // dtimeDo
            // 
            this.dtimeDo.Location = new System.Drawing.Point(91, 134);
            this.dtimeDo.Name = "dtimeDo";
            this.dtimeDo.Size = new System.Drawing.Size(200, 22);
            this.dtimeDo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(86, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Начиная с:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(86, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "До:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCountPrib
            // 
            this.txtCountPrib.Location = new System.Drawing.Point(91, 290);
            this.txtCountPrib.Name = "txtCountPrib";
            this.txtCountPrib.ReadOnly = true;
            this.txtCountPrib.Size = new System.Drawing.Size(200, 22);
            this.txtCountPrib.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(86, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Прибыль составила:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // MysqlCommand2
            // 
            this.MysqlCommand2.CommandText = "SELECT dbo.SummPrib(@sotr, @dateS, @dateDo)";
            this.MysqlCommand2.Connection = this.MySqlConnection;
            this.MysqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@sotr", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@dateS", System.Data.SqlDbType.Date, 1024),
            new System.Data.SqlClient.SqlParameter("@dateDo", System.Data.SqlDbType.Date, 1024)});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbboxSotr);
            this.panel1.Controls.Add(this.btnShowsotr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 114);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCountPrib);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtimeNach);
            this.panel2.Controls.Add(this.dtimeDo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(871, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 803);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataAnalyze);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 803);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataAnalyze
            // 
            this.dataAnalyze.AllowUserToAddRows = false;
            this.dataAnalyze.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.dataAnalyze.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataAnalyze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAnalyze.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataAnalyze.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataAnalyze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAnalyze.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAnalyze.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataAnalyze.Location = new System.Drawing.Point(0, 0);
            this.dataAnalyze.Name = "dataAnalyze";
            this.dataAnalyze.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAnalyze.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataAnalyze.RowHeadersWidth = 60;
            this.dataAnalyze.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataAnalyze.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataAnalyze.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataAnalyze.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.dataAnalyze.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataAnalyze.RowTemplate.Height = 24;
            this.dataAnalyze.Size = new System.Drawing.Size(871, 803);
            this.dataAnalyze.TabIndex = 0;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // InsertManagers
            // 
            this.InsertManagers.CommandText = "SELECT Фамилия FROM Сотрудник WHERE Должность = \'Менеджер по продажам\'";
            this.InsertManagers.Connection = this.MySqlConnection;
            // 
            // PanelUpravlenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1268, 917);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PanelUpravlenia";
            this.Text = "PanelUpravlenia";
            this.Load += new System.EventHandler(this.PanelUpravlenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtosalonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtosalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAnalyze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection MySqlConnection;
        private System.Data.SqlClient.SqlCommand mysqlCommand;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;

        private System.Windows.Forms.BindingSource avtosalonDataSetBindingSource;
        private System.Windows.Forms.BindingSource продажаBindingSource;
        private System.Windows.Forms.ComboBox cmbboxSotr;
        private System.Windows.Forms.Button btnShowsotr;
        private System.Windows.Forms.BindingSource сотрудникBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimeNach;
        private System.Windows.Forms.DateTimePicker dtimeDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountPrib;
        private System.Windows.Forms.Label label4;
        private System.Data.SqlClient.SqlCommand MysqlCommand2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataAnalyze;
        private AvtosalonDataSet avtosalonDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource2;
        private AvtosalonDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Data.SqlClient.SqlCommand InsertManagers;
    }
}