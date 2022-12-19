namespace Автосалон
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlIconteslatopleft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnExitAcc = new System.Windows.Forms.Button();
            this.btnSotr = new System.Windows.Forms.Button();
            this.btnPostavki = new System.Windows.Forms.Button();
            this.btnProdaji = new System.Windows.Forms.Button();
            this.btnRezerv = new System.Windows.Forms.Button();
            this.btnAutos = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDolzh = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlWorkspace = new System.Windows.Forms.Panel();
            this.timerDash = new System.Windows.Forms.Timer(this.components);
            this.MysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.MysqlCommand = new System.Data.SqlClient.SqlCommand();
            this.MsqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1127, 35);
            this.panel1.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(1091, 0);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.btnExitAcc);
            this.panel2.Controls.Add(this.btnSotr);
            this.panel2.Controls.Add(this.btnPostavki);
            this.panel2.Controls.Add(this.btnProdaji);
            this.panel2.Controls.Add(this.btnRezerv);
            this.panel2.Controls.Add(this.btnAutos);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 618);
            this.panel2.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 6;
            // 
            // btnExitAcc
            // 
            this.btnExitAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnExitAcc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExitAcc.FlatAppearance.BorderSize = 0;
            this.btnExitAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAcc.Font = new System.Drawing.Font("Montserrat Medium", 9.4F);
            this.btnExitAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExitAcc.Image = global::Автосалон.Properties.Resources.icons8_выход_50;
            this.btnExitAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitAcc.Location = new System.Drawing.Point(0, 547);
            this.btnExitAcc.Name = "btnExitAcc";
            this.btnExitAcc.Size = new System.Drawing.Size(239, 71);
            this.btnExitAcc.TabIndex = 5;
            this.btnExitAcc.Text = "Выйти";
            this.btnExitAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExitAcc.UseVisualStyleBackColor = false;
            this.btnExitAcc.Click += new System.EventHandler(this.btnExitAcc_Click);
            // 
            // btnSotr
            // 
            this.btnSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSotr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSotr.FlatAppearance.BorderSize = 0;
            this.btnSotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSotr.Font = new System.Drawing.Font("Montserrat Medium", 9.4F);
            this.btnSotr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSotr.Image = global::Автосалон.Properties.Resources.icons8_группа_пользователей_50;
            this.btnSotr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSotr.Location = new System.Drawing.Point(0, 455);
            this.btnSotr.Name = "btnSotr";
            this.btnSotr.Size = new System.Drawing.Size(239, 71);
            this.btnSotr.TabIndex = 4;
            this.btnSotr.Text = "Сотрудники";
            this.btnSotr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSotr.UseVisualStyleBackColor = false;
            this.btnSotr.Click += new System.EventHandler(this.btnSotr_Click);
            // 
            // btnPostavki
            // 
            this.btnPostavki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnPostavki.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostavki.FlatAppearance.BorderSize = 0;
            this.btnPostavki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostavki.Font = new System.Drawing.Font("Montserrat Medium", 9.4F);
            this.btnPostavki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPostavki.Image = global::Автосалон.Properties.Resources.icons8_фура_50;
            this.btnPostavki.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPostavki.Location = new System.Drawing.Point(0, 384);
            this.btnPostavki.Name = "btnPostavki";
            this.btnPostavki.Size = new System.Drawing.Size(239, 71);
            this.btnPostavki.TabIndex = 4;
            this.btnPostavki.Text = "Поставки";
            this.btnPostavki.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPostavki.UseVisualStyleBackColor = false;
            this.btnPostavki.Click += new System.EventHandler(this.btnPostavki_Click);
            // 
            // btnProdaji
            // 
            this.btnProdaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnProdaji.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdaji.FlatAppearance.BorderSize = 0;
            this.btnProdaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdaji.Font = new System.Drawing.Font("Montserrat Medium", 9.4F);
            this.btnProdaji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProdaji.Image = global::Автосалон.Properties.Resources.icons8_продажа_машины_50__1_;
            this.btnProdaji.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProdaji.Location = new System.Drawing.Point(0, 313);
            this.btnProdaji.Name = "btnProdaji";
            this.btnProdaji.Size = new System.Drawing.Size(239, 71);
            this.btnProdaji.TabIndex = 4;
            this.btnProdaji.Text = "Продажи";
            this.btnProdaji.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProdaji.UseVisualStyleBackColor = false;
            this.btnProdaji.Click += new System.EventHandler(this.btnProdaji_Click);
            // 
            // btnRezerv
            // 
            this.btnRezerv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnRezerv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRezerv.FlatAppearance.BorderSize = 0;
            this.btnRezerv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerv.Font = new System.Drawing.Font("Montserrat Medium", 9.4F);
            this.btnRezerv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRezerv.Image = global::Автосалон.Properties.Resources.icons8_доставка_50;
            this.btnRezerv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRezerv.Location = new System.Drawing.Point(0, 242);
            this.btnRezerv.Name = "btnRezerv";
            this.btnRezerv.Size = new System.Drawing.Size(239, 71);
            this.btnRezerv.TabIndex = 3;
            this.btnRezerv.Text = "Резервирование";
            this.btnRezerv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRezerv.UseVisualStyleBackColor = false;
            this.btnRezerv.Click += new System.EventHandler(this.btnRezerv_Click);
            // 
            // btnAutos
            // 
            this.btnAutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutos.FlatAppearance.BorderSize = 0;
            this.btnAutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutos.Font = new System.Drawing.Font("Montserrat Medium", 9.4F);
            this.btnAutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAutos.Image = global::Автосалон.Properties.Resources.icons8_пробка_50;
            this.btnAutos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutos.Location = new System.Drawing.Point(0, 171);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(239, 71);
            this.btnAutos.TabIndex = 2;
            this.btnAutos.Text = "Автомобили";
            this.btnAutos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAutos.UseVisualStyleBackColor = false;
            this.btnAutos.Click += new System.EventHandler(this.btnAutos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Montserrat Medium", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDashboard.Image = global::Автосалон.Properties.Resources.icons8_веб_аналитика_50;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(239, 71);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Панель управления";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDolzh);
            this.panel4.Controls.Add(this.lblSurname);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(107, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 100);
            this.panel4.TabIndex = 5;
            // 
            // lblDolzh
            // 
            this.lblDolzh.AutoEllipsis = true;
            this.lblDolzh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDolzh.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolzh.Location = new System.Drawing.Point(0, 63);
            this.lblDolzh.Name = "lblDolzh";
            this.lblDolzh.Size = new System.Drawing.Size(132, 37);
            this.lblDolzh.TabIndex = 4;
            this.lblDolzh.Text = "label2";
            this.lblDolzh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSurname
            // 
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurname.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSurname.Location = new System.Drawing.Point(0, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(132, 77);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "label2";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(12, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label2";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Автосалон.Properties.Resources.icons8_бизнесмен_100;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlWorkspace
            // 
            this.pnlWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.pnlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkspace.Location = new System.Drawing.Point(239, 35);
            this.pnlWorkspace.Name = "pnlWorkspace";
            this.pnlWorkspace.Size = new System.Drawing.Size(888, 618);
            this.pnlWorkspace.TabIndex = 2;
            this.pnlWorkspace.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWorkspace_Paint);
            // 
            // timerDash
            // 
            this.timerDash.Tick += new System.EventHandler(this.timerDash_Tick);
            // 
            // MysqlConnection
            // 
            this.MysqlConnection.ConnectionString = "Data Source=LAPTOP-6VLIU4NF\\SQLEXPRESS;Initial Catalog=Avtosalon;Integrated Secur" +
    "ity=True";
            this.MysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // MysqlCommand
            // 
            this.MysqlCommand.CommandText = "SELECT dbo.ReturningSurname(@userlogin)";
            this.MysqlCommand.Connection = this.MysqlConnection;
            this.MysqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userlogin", System.Data.SqlDbType.VarChar, 50)});
            // 
            // MsqlCommand2
            // 
            this.MsqlCommand2.CommandText = "SELECT dbo.ReturningDolzh(@userlogin)";
            this.MsqlCommand2.Connection = this.MysqlConnection;
            this.MsqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userlogin", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1127, 653);
            this.Controls.Add(this.pnlWorkspace);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIconteslatopleft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAutos;
        private System.Windows.Forms.Button btnExitAcc;
        private System.Windows.Forms.Button btnProdaji;
        private System.Windows.Forms.Button btnRezerv;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlWorkspace;
        private System.Windows.Forms.Timer timerDash;
        private System.Windows.Forms.Label lblSurname;
        private System.Data.SqlClient.SqlConnection MysqlConnection;
        private System.Data.SqlClient.SqlCommand MysqlCommand;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDolzh;
        private System.Data.SqlClient.SqlCommand MsqlCommand2;
        private System.Windows.Forms.Button btnPostavki;
        private System.Windows.Forms.Button btnSotr;
    }
}