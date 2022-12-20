namespace Momo
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loginclose = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Momo.Properties.Resources.MoMo_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(59, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(382, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 539);
            this.panel2.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtPassword.Location = new System.Drawing.Point(237, 232);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(284, 39);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.Location = new System.Drawing.Point(14, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtUsername.Location = new System.Drawing.Point(237, 179);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(284, 39);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(14, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Username";
            // 
            // btn_loginclose
            // 
            this.btn_loginclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_loginclose.FlatAppearance.BorderSize = 0;
            this.btn_loginclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginclose.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btn_loginclose.Location = new System.Drawing.Point(536, 0);
            this.btn_loginclose.Name = "btn_loginclose";
            this.btn_loginclose.Size = new System.Drawing.Size(44, 44);
            this.btn_loginclose.TabIndex = 23;
            this.btn_loginclose.Text = "X";
            this.btn_loginclose.UseVisualStyleBackColor = true;
            this.btn_loginclose.Click += new System.EventHandler(this.loginclose);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnRegister.Location = new System.Drawing.Point(257, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(129, 42);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnLogin.Location = new System.Drawing.Point(392, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_loginclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 44);
            this.panel1.TabIndex = 29;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Size = new System.Drawing.Size(962, 539);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btn_loginclose;
        private System.Windows.Forms.Panel panel1;
    }
}
