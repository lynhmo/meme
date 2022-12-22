namespace Momo
{
    partial class mywallet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_username_wallet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_user_money = new System.Windows.Forms.Label();
            this.btn_update_profile = new System.Windows.Forms.Button();
            this.lbl_birth1 = new System.Windows.Forms.Label();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cccd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tableBank = new System.Windows.Forms.DataGridView();
            this.id_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txtbirth = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.btn_doimatkhau_done = new System.Windows.Forms.Button();
            this.panel_resetPass = new System.Windows.Forms.Panel();
            this.txtCurr_pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).BeginInit();
            this.panel_resetPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ví Của Tôi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Momo.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(22, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_username_wallet
            // 
            this.lbl_username_wallet.AutoSize = true;
            this.lbl_username_wallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_username_wallet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username_wallet.Location = new System.Drawing.Point(0, 0);
            this.lbl_username_wallet.Name = "lbl_username_wallet";
            this.lbl_username_wallet.Size = new System.Drawing.Size(24, 37);
            this.lbl_username_wallet.TabIndex = 2;
            this.lbl_username_wallet.Text = ".";
            this.lbl_username_wallet.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_user_money);
            this.panel1.Controls.Add(this.lbl_username_wallet);
            this.panel1.Location = new System.Drawing.Point(144, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 102);
            this.panel1.TabIndex = 4;
            // 
            // lbl_user_money
            // 
            this.lbl_user_money.AutoSize = true;
            this.lbl_user_money.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_user_money.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbl_user_money.Location = new System.Drawing.Point(0, 74);
            this.lbl_user_money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_money.Name = "lbl_user_money";
            this.lbl_user_money.Size = new System.Drawing.Size(16, 28);
            this.lbl_user_money.TabIndex = 3;
            this.lbl_user_money.Text = ".";
            // 
            // btn_update_profile
            // 
            this.btn_update_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.btn_update_profile.FlatAppearance.BorderSize = 0;
            this.btn_update_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_profile.Location = new System.Drawing.Point(22, 496);
            this.btn_update_profile.Name = "btn_update_profile";
            this.btn_update_profile.Size = new System.Drawing.Size(127, 36);
            this.btn_update_profile.TabIndex = 5;
            this.btn_update_profile.Text = "Sửa thông tin cá nhân";
            this.btn_update_profile.UseVisualStyleBackColor = false;
            this.btn_update_profile.Click += new System.EventHandler(this.btn_update_profile_Click);
            // 
            // lbl_birth1
            // 
            this.lbl_birth1.AutoSize = true;
            this.lbl_birth1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birth1.Location = new System.Drawing.Point(18, 259);
            this.lbl_birth1.Name = "lbl_birth1";
            this.lbl_birth1.Size = new System.Drawing.Size(108, 28);
            this.lbl_birth1.TabIndex = 4;
            this.lbl_birth1.Text = "Ngày sinh: ";
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birth.Location = new System.Drawing.Point(18, 296);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(16, 28);
            this.lbl_birth.TabIndex = 4;
            this.lbl_birth.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ và Tên: ";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(18, 223);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(16, 28);
            this.lbl_fullname.TabIndex = 4;
            this.lbl_fullname.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Căn cước công dân:";
            // 
            // lbl_cccd
            // 
            this.lbl_cccd.AutoSize = true;
            this.lbl_cccd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cccd.Location = new System.Drawing.Point(18, 367);
            this.lbl_cccd.Name = "lbl_cccd";
            this.lbl_cccd.Size = new System.Drawing.Size(16, 28);
            this.lbl_cccd.TabIndex = 4;
            this.lbl_cccd.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ: ";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(19, 438);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(16, 28);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = ".";
            // 
            // tableBank
            // 
            this.tableBank.AllowUserToAddRows = false;
            this.tableBank.AllowUserToDeleteRows = false;
            this.tableBank.AllowUserToResizeRows = false;
            this.tableBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableBank.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.tableBank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bank,
            this.bankname});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(45)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableBank.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableBank.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.tableBank.Location = new System.Drawing.Point(420, 221);
            this.tableBank.Name = "tableBank";
            this.tableBank.RowHeadersVisible = false;
            this.tableBank.Size = new System.Drawing.Size(388, 311);
            this.tableBank.TabIndex = 6;
            // 
            // id_bank
            // 
            this.id_bank.DataPropertyName = "id_bank";
            this.id_bank.HeaderText = "Mã ngân hàng";
            this.id_bank.Name = "id_bank";
            // 
            // bankname
            // 
            this.bankname.DataPropertyName = "bankname";
            this.bankname.HeaderText = "Tên ngân hàng";
            this.bankname.Name = "bankname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Danh sách ngân hàng liên kết";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_fullname.Location = new System.Drawing.Point(24, 223);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(321, 34);
            this.txt_fullname.TabIndex = 7;
            // 
            // txtbirth
            // 
            this.txtbirth.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtbirth.Location = new System.Drawing.Point(22, 296);
            this.txtbirth.Name = "txtbirth";
            this.txtbirth.Size = new System.Drawing.Size(321, 34);
            this.txtbirth.TabIndex = 7;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_cccd.Location = new System.Drawing.Point(22, 370);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(321, 34);
            this.txt_cccd.TabIndex = 7;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_diachi.Location = new System.Drawing.Point(22, 438);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(321, 34);
            this.txt_diachi.TabIndex = 7;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(159, 496);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(47, 36);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Quay trở lại";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Done
            // 
            this.btn_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.btn_Done.FlatAppearance.BorderSize = 0;
            this.btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Done.Location = new System.Drawing.Point(216, 496);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(127, 36);
            this.btn_Done.TabIndex = 5;
            this.btn_Done.Text = "Hoàn tất";
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.btn_doimatkhau.FlatAppearance.BorderSize = 0;
            this.btn_doimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doimatkhau.Location = new System.Drawing.Point(681, 70);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(127, 36);
            this.btn_doimatkhau.TabIndex = 5;
            this.btn_doimatkhau.Text = "Thay mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = false;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // btn_doimatkhau_done
            // 
            this.btn_doimatkhau_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.btn_doimatkhau_done.FlatAppearance.BorderSize = 0;
            this.btn_doimatkhau_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doimatkhau_done.Location = new System.Drawing.Point(12, 280);
            this.btn_doimatkhau_done.Name = "btn_doimatkhau_done";
            this.btn_doimatkhau_done.Size = new System.Drawing.Size(127, 36);
            this.btn_doimatkhau_done.TabIndex = 5;
            this.btn_doimatkhau_done.Text = "Done";
            this.btn_doimatkhau_done.UseVisualStyleBackColor = false;
            this.btn_doimatkhau_done.Click += new System.EventHandler(this.btn_doimatkhau_done_Click);
            // 
            // panel_resetPass
            // 
            this.panel_resetPass.Controls.Add(this.btn_doimatkhau_done);
            this.panel_resetPass.Controls.Add(this.txtCurr_pass);
            this.panel_resetPass.Controls.Add(this.label6);
            this.panel_resetPass.Controls.Add(this.txtNewPass);
            this.panel_resetPass.Controls.Add(this.label8);
            this.panel_resetPass.Controls.Add(this.txtConfirmNewPass);
            this.panel_resetPass.Controls.Add(this.label4);
            this.panel_resetPass.Location = new System.Drawing.Point(14, 189);
            this.panel_resetPass.Name = "panel_resetPass";
            this.panel_resetPass.Size = new System.Drawing.Size(342, 343);
            this.panel_resetPass.TabIndex = 8;
            this.panel_resetPass.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCurr_pass
            // 
            this.txtCurr_pass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtCurr_pass.Location = new System.Drawing.Point(8, 39);
            this.txtCurr_pass.Name = "txtCurr_pass";
            this.txtCurr_pass.Size = new System.Drawing.Size(321, 34);
            this.txtCurr_pass.TabIndex = 7;
            this.txtCurr_pass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mật khẩu cũ";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtNewPass.Location = new System.Drawing.Point(10, 128);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(319, 34);
            this.txtNewPass.TabIndex = 7;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mật khẩu mới";
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtConfirmNewPass.Location = new System.Drawing.Point(10, 214);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.Size = new System.Drawing.Size(319, 34);
            this.txtConfirmNewPass.TabIndex = 7;
            this.txtConfirmNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // mywallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.btn_doimatkhau);
            this.Controls.Add(this.panel_resetPass);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_cccd);
            this.Controls.Add(this.txtbirth);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.tableBank);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_cccd);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_birth1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.btn_update_profile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "mywallet";
            this.Size = new System.Drawing.Size(841, 559);
            this.Load += new System.EventHandler(this.mywallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).EndInit();
            this.panel_resetPass.ResumeLayout(false);
            this.panel_resetPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_username_wallet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_user_money;
        private System.Windows.Forms.Button btn_update_profile;
        private System.Windows.Forms.Label lbl_birth1;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_cccd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.DataGridView tableBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txtbirth;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankname;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.Button btn_doimatkhau_done;
        private System.Windows.Forms.Panel panel_resetPass;
        private System.Windows.Forms.TextBox txtCurr_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label8;
    }
}
