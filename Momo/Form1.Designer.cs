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
            this.left_panel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.btn_dautu = new System.Windows.Forms.Button();
            this.btnVicuatoi = new System.Windows.Forms.Button();
            this.btn_money = new System.Windows.Forms.Button();
            this.btnGiaodich = new System.Windows.Forms.Button();
            this.btnWallet = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.register2 = new Momo.register();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(3)))), ((int)(((byte)(57)))));
            this.left_panel.Controls.Add(this.btn_logout);
            this.left_panel.Controls.Add(this.lbl_username);
            this.left_panel.Controls.Add(this.pictureBox2);
            this.left_panel.Controls.Add(this.sidepanel);
            this.left_panel.Controls.Add(this.btn_dautu);
            this.left_panel.Controls.Add(this.btnVicuatoi);
            this.left_panel.Controls.Add(this.btn_money);
            this.left_panel.Controls.Add(this.btnGiaodich);
            this.left_panel.Controls.Add(this.btnWallet);
            this.left_panel.Controls.Add(this.btnHome);
            this.left_panel.Controls.Add(this.pictureBox1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(200, 581);
            this.left_panel.TabIndex = 0;
            this.left_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(3)))), ((int)(((byte)(57)))));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_logout.Image = global::Momo.Properties.Resources.logout2;
            this.btn_logout.Location = new System.Drawing.Point(156, 526);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(38, 43);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(85, 534);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(42, 21);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "User";
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
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(45)))), ((int)(((byte)(139)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 133);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(12, 54);
            this.sidepanel.TabIndex = 2;
            // 
            // btn_dautu
            // 
            this.btn_dautu.FlatAppearance.BorderSize = 0;
            this.btn_dautu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dautu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_dautu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dautu.Location = new System.Drawing.Point(12, 441);
            this.btn_dautu.Name = "btn_dautu";
            this.btn_dautu.Size = new System.Drawing.Size(188, 54);
            this.btn_dautu.TabIndex = 1;
            this.btn_dautu.Text = "ĐẦU TƯ";
            this.btn_dautu.UseVisualStyleBackColor = true;
            this.btn_dautu.Click += new System.EventHandler(this.btn_dautu_click);
            // 
            // btnVicuatoi
            // 
            this.btnVicuatoi.FlatAppearance.BorderSize = 0;
            this.btnVicuatoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVicuatoi.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnVicuatoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVicuatoi.Location = new System.Drawing.Point(12, 381);
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
            this.btn_money.Location = new System.Drawing.Point(12, 319);
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
            this.btnGiaodich.Location = new System.Drawing.Point(12, 257);
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
            this.btnWallet.Location = new System.Drawing.Point(12, 195);
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
            this.btnHome.Location = new System.Drawing.Point(12, 133);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 54);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtPassword.Location = new System.Drawing.Point(638, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(284, 39);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(415, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtUsername.Location = new System.Drawing.Point(638, 214);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(284, 39);
            this.txtUsername.TabIndex = 27;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(415, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnRegister.Location = new System.Drawing.Point(658, 330);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(129, 42);
            this.btnRegister.TabIndex = 30;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnLogin.Location = new System.Drawing.Point(793, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 42);
            this.btnLogin.TabIndex = 29;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(120, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // register2
            // 
            this.register2.Location = new System.Drawing.Point(409, 211);
            this.register2.Name = "register2";
            this.register2.Size = new System.Drawing.Size(513, 224);
            this.register2.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 581);
            this.Controls.Add(this.register2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Momo";
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button btnVicuatoi;
        private System.Windows.Forms.Button btnGiaodich;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btn_money;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_dautu;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private register register2;
        //private home home1;
    }
}

