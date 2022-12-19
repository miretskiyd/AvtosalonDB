namespace Автосалон
{
    partial class DobavlenieAvto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobavlenieAvto));
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIconteslatopleft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblProizv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxTsvet = new System.Windows.Forms.TextBox();
            this.txtboxTsena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSost = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxGod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPostavka = new System.Windows.Forms.ComboBox();
            this.cmbModels = new System.Windows.Forms.ComboBox();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.commandInsertModels = new System.Data.SqlClient.SqlCommand();
            this.commandInsertModelsAfter = new System.Data.SqlClient.SqlCommand();
            this.countAutos = new System.Data.SqlClient.SqlCommand();
            this.InsertAvto = new System.Data.SqlClient.SqlCommand();
            this.commandCountPost = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZagolovok
            // 
            this.lblZagolovok.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblZagolovok.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZagolovok.Location = new System.Drawing.Point(0, 0);
            this.lblZagolovok.Name = "lblZagolovok";
            this.lblZagolovok.Size = new System.Drawing.Size(800, 68);
            this.lblZagolovok.TabIndex = 0;
            this.lblZagolovok.Text = "Добавление автомобиля с ID:  ";
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
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.lblZagolovok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtId.Location = new System.Drawing.Point(624, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 36);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "id";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownWidth = 160;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(54, 88);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(159, 24);
            this.cmbModel.TabIndex = 3;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // lblProizv
            // 
            this.lblProizv.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProizv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProizv.Location = new System.Drawing.Point(3, 60);
            this.lblProizv.Name = "lblProizv";
            this.lblProizv.Size = new System.Drawing.Size(266, 25);
            this.lblProizv.TabIndex = 4;
            this.lblProizv.Text = "Производитель";
            this.lblProizv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(103, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цвет:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxTsvet
            // 
            this.textboxTsvet.Location = new System.Drawing.Point(76, 188);
            this.textboxTsvet.Name = "textboxTsvet";
            this.textboxTsvet.Size = new System.Drawing.Size(120, 22);
            this.textboxTsvet.TabIndex = 5;
            this.textboxTsvet.TextChanged += new System.EventHandler(this.textboxTsvet_TextChanged);
            // 
            // txtboxTsena
            // 
            this.txtboxTsena.Location = new System.Drawing.Point(64, 90);
            this.txtboxTsena.Name = "txtboxTsena";
            this.txtboxTsena.Size = new System.Drawing.Size(152, 22);
            this.txtboxTsena.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(0, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbSost
            // 
            this.cmbSost.FormattingEnabled = true;
            this.cmbSost.Items.AddRange(new object[] {
            "С пробегом",
            "Новая"});
            this.cmbSost.Location = new System.Drawing.Point(54, 188);
            this.cmbSost.Name = "cmbSost";
            this.cmbSost.Size = new System.Drawing.Size(159, 24);
            this.cmbSost.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Состояние:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxGod
            // 
            this.txtboxGod.Location = new System.Drawing.Point(74, 188);
            this.txtboxGod.Name = "txtboxGod";
            this.txtboxGod.Size = new System.Drawing.Size(120, 22);
            this.txtboxGod.TabIndex = 7;
            this.txtboxGod.Leave += new System.EventHandler(this.txtboxGod_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, -22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 353);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год выпуска:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbPostavka);
            this.panel3.Controls.Add(this.cmbModels);
            this.panel3.Controls.Add(this.btnDobavit);
            this.panel3.Controls.Add(this.txtboxGod);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(266, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 353);
            this.panel3.TabIndex = 8;
            // 
            // cmbPostavka
            // 
            this.cmbPostavka.FormattingEnabled = true;
            this.cmbPostavka.Location = new System.Drawing.Point(73, 250);
            this.cmbPostavka.Name = "cmbPostavka";
            this.cmbPostavka.Size = new System.Drawing.Size(121, 24);
            this.cmbPostavka.TabIndex = 8;
            // 
            // cmbModels
            // 
            this.cmbModels.DropDownWidth = 160;
            this.cmbModels.FormattingEnabled = true;
            this.cmbModels.Location = new System.Drawing.Point(57, 88);
            this.cmbModels.Name = "cmbModels";
            this.cmbModels.Size = new System.Drawing.Size(159, 24);
            this.cmbModels.TabIndex = 3;
            // 
            // btnDobavit
            // 
            this.btnDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(113)))));
            this.btnDobavit.FlatAppearance.BorderSize = 0;
            this.btnDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobavit.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobavit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDobavit.Location = new System.Drawing.Point(57, 303);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(152, 38);
            this.btnDobavit.TabIndex = 7;
            this.btnDobavit.Text = "Добавить";
            this.btnDobavit.UseVisualStyleBackColor = false;
            this.btnDobavit.Click += new System.EventHandler(this.btnDobavit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Модель:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Поставка:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbModel);
            this.panel4.Controls.Add(this.cmbSost);
            this.panel4.Controls.Add(this.lblProizv);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 353);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textboxTsvet);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtboxTsena);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(532, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 353);
            this.panel5.TabIndex = 8;
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // commandInsertModels
            // 
            this.commandInsertModels.CommandText = "SELECT DISTINCT Производитель FROM Модель";
            this.commandInsertModels.Connection = this.MysqlConnection;
            // 
            // commandInsertModelsAfter
            // 
            this.commandInsertModelsAfter.CommandText = "SELECT * FROM dbo.ВставкаМоделейПослеПроизводителей(@proizv)";
            this.commandInsertModelsAfter.Connection = this.MysqlConnection;
            this.commandInsertModelsAfter.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@proizv", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // countAutos
            // 
            this.countAutos.CommandText = "SELECT Max(ID_Автомобиля)+1 from Автомобиль";
            this.countAutos.Connection = this.MysqlConnection;
            // 
            // InsertAvto
            // 
            this.InsertAvto.CommandText = "ДобавлениеАвтомобиля";
            this.InsertAvto.CommandType = System.Data.CommandType.StoredProcedure;
            this.InsertAvto.Connection = this.MysqlConnection;
            this.InsertAvto.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id_avto", System.Data.SqlDbType.Int, 25),
            new System.Data.SqlClient.SqlParameter("@proizv", System.Data.SqlDbType.VarChar, 35),
            new System.Data.SqlClient.SqlParameter("@marka", System.Data.SqlDbType.VarChar, 35),
            new System.Data.SqlClient.SqlParameter("@tsena", System.Data.SqlDbType.Int, 25),
            new System.Data.SqlClient.SqlParameter("@sost", System.Data.SqlDbType.VarChar, 40),
            new System.Data.SqlClient.SqlParameter("@god", System.Data.SqlDbType.Int, 40),
            new System.Data.SqlClient.SqlParameter("@tsvet", System.Data.SqlDbType.VarChar, 40),
            new System.Data.SqlClient.SqlParameter("@postavka", System.Data.SqlDbType.Int, 5)});
            // 
            // commandCountPost
            // 
            this.commandCountPost.CommandText = "SELECT DISTINCT ID_Поставки From Поставка";
            this.commandCountPost.Connection = this.MysqlConnection;
            // 
            // DobavlenieAvto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DobavlenieAvto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DobavlenieAvto";
            this.Load += new System.EventHandler(this.DobavlenieAvto_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlIconteslatopleft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblProizv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxTsvet;
        private System.Windows.Forms.TextBox txtboxTsena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxGod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDobavit;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand commandInsertModels;
        private System.Windows.Forms.ComboBox cmbModels;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlCommand commandInsertModelsAfter;
        private System.Data.SqlClient.SqlCommand countAutos;
        private System.Data.SqlClient.SqlCommand InsertAvto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPostavka;
        private System.Data.SqlClient.SqlCommand commandCountPost;
        private System.Windows.Forms.Label txtId;
    }
}