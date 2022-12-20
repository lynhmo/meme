namespace Momo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.btnVicuatoi = new System.Windows.Forms.Button();
            this.btn_money = new System.Windows.Forms.Button();
            this.btnGiaodich = new System.Windows.Forms.Button();
            this.btnWallet = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lichsu1 = new Momo.lichsu();
            this.home = new Momo.home();
            this.uudai = new Momo.uudai();
            this.login = new Momo.login();
            this.nguontien1 = new Momo.nguontien();
            this.mywallet1 = new Momo.mywallet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(3)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.btnVicuatoi);
            this.panel1.Controls.Add(this.btn_money);
            this.panel1.Controls.Add(this.btnGiaodich);
            this.panel1.Controls.Add(this.btnWallet);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 581);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(85, 529);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(42, 21);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "User";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(45)))), ((int)(((byte)(139)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 139);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(12, 54);
            this.sidepanel.TabIndex = 2;
            // 
            // btnVicuatoi
            // 
            this.btnVicuatoi.FlatAppearance.BorderSize = 0;
            this.btnVicuatoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVicuatoi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnVicuatoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVicuatoi.Location = new System.Drawing.Point(12, 387);
            this.btnVicuatoi.Name = "btnVicuatoi";
            this.btnVicuatoi.Size = new System.Drawing.Size(188, 54);
            this.btnVicuatoi.TabIndex = 1;
            this.btnVicuatoi.Text = "VÍ CỦA TÔI";
            this.btnVicuatoi.UseVisualStyleBackColor = true;
            this.btnVicuatoi.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_money
            // 
            this.btn_money.FlatAppearance.BorderSize = 0;
            this.btn_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_money.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_money.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_money.Location = new System.Drawing.Point(12, 325);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(188, 54);
            this.btn_money.TabIndex = 1;
            this.btn_money.Text = "NGUỒN TIỀN";
            this.btn_money.UseVisualStyleBackColor = true;
            this.btn_money.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGiaodich
            // 
            this.btnGiaodich.FlatAppearance.BorderSize = 0;
            this.btnGiaodich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaodich.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnGiaodich.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGiaodich.Location = new System.Drawing.Point(12, 263);
            this.btnGiaodich.Name = "btnGiaodich";
            this.btnGiaodich.Size = new System.Drawing.Size(188, 54);
            this.btnGiaodich.TabIndex = 1;
            this.btnGiaodich.Text = "LỊCH SỬ GIAO DỊCH";
            this.btnGiaodich.UseVisualStyleBackColor = true;
            this.btnGiaodich.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWallet.Location = new System.Drawing.Point(12, 201);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(188, 54);
            this.btnWallet.TabIndex = 1;
            this.btnWallet.Text = "ƯU ĐÃI";
            this.btnWallet.UseVisualStyleBackColor = true;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(12, 139);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 54);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(45)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.btn_minimize);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 22);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // lichsu1
            // 
            this.lichsu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.lichsu1.Location = new System.Drawing.Point(200, 22);
            this.lichsu1.Name = "lichsu1";
            this.lichsu1.Size = new System.Drawing.Size(841, 559);
            this.lichsu1.TabIndex = 5;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.home.Location = new System.Drawing.Point(200, 22);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(841, 559);
            this.home.TabIndex = 2;
            this.home.Load += new System.EventHandler(this.home_Load);
            // 
            // uudai
            // 
            this.uudai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.uudai.Location = new System.Drawing.Point(200, 22);
            this.uudai.Name = "uudai";
            this.uudai.Size = new System.Drawing.Size(841, 559);
            this.uudai.TabIndex = 3;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1041, 581);
            this.login.TabIndex = 4;
            // 
            // nguontien1
            // 
            this.nguontien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.nguontien1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nguontien1.Location = new System.Drawing.Point(723, 114);
            this.nguontien1.Name = "nguontien1";
            this.nguontien1.Size = new System.Drawing.Size(841, 559);
            this.nguontien1.TabIndex = 6;
            // 
            // mywallet1
            // 
            this.mywallet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.mywallet1.Location = new System.Drawing.Point(200, 22);
            this.mywallet1.Name = "mywallet1";
            this.mywallet1.Size = new System.Drawing.Size(841, 559);
            this.mywallet1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Momo.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(783, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(58, 22);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_minimize.Location = new System.Drawing.Point(725, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(58, 22);
            this.btn_minimize.TabIndex = 0;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_logout.Location = new System.Drawing.Point(125, 558);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 581);
            this.Controls.Add(this.home);
            this.Controls.Add(this.mywallet1);
            this.Controls.Add(this.nguontien1);
            this.Controls.Add(this.lichsu1);
            this.Controls.Add(this.uudai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Momo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button btnVicuatoi;
        private System.Windows.Forms.Button btnGiaodich;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Button btnHome;
        private home home;
        private uudai uudai;
        private login login;
        private System.Windows.Forms.Button btn_money;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private lichsu lichsu1;
        private nguontien nguontien1;
        private mywallet mywallet1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_logout;
    }
}

