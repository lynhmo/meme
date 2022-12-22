namespace Momo
{
    partial class lichsu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLichSu = new System.Windows.Forms.DataGridView();
            this.id_lichsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user_revice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaygiaodich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_uudai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongdiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch sử giao dịch";
            // 
            // tableLichSu
            // 
            this.tableLichSu.AllowUserToAddRows = false;
            this.tableLichSu.AllowUserToDeleteRows = false;
            this.tableLichSu.AllowUserToResizeRows = false;
            this.tableLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableLichSu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.tableLichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLichSu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lichsu,
            this.id_user,
            this.id_user_revice,
            this.total_money,
            this.ngaygiaodich,
            this.id_uudai,
            this.thongdiep});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(45)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLichSu.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableLichSu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.tableLichSu.Location = new System.Drawing.Point(29, 90);
            this.tableLichSu.Name = "tableLichSu";
            this.tableLichSu.RowHeadersVisible = false;
            this.tableLichSu.Size = new System.Drawing.Size(779, 372);
            this.tableLichSu.TabIndex = 2;
            this.tableLichSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLichSu_CellClick);
            // 
            // id_lichsu
            // 
            this.id_lichsu.DataPropertyName = "id_lichsu";
            this.id_lichsu.HeaderText = "Mã giao dịch";
            this.id_lichsu.Name = "id_lichsu";
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.HeaderText = "Mã người dùng";
            this.id_user.Name = "id_user";
            // 
            // id_user_revice
            // 
            this.id_user_revice.DataPropertyName = "id_user_revice";
            this.id_user_revice.HeaderText = "Mã người nhận";
            this.id_user_revice.Name = "id_user_revice";
            // 
            // total_money
            // 
            this.total_money.DataPropertyName = "total_money";
            this.total_money.HeaderText = "Tổng tiền";
            this.total_money.Name = "total_money";
            // 
            // ngaygiaodich
            // 
            this.ngaygiaodich.DataPropertyName = "ngaygiaodich";
            this.ngaygiaodich.HeaderText = "Ngày giao dịch";
            this.ngaygiaodich.Name = "ngaygiaodich";
            // 
            // id_uudai
            // 
            this.id_uudai.DataPropertyName = "id_uudai";
            this.id_uudai.HeaderText = "Mã ưu đãi";
            this.id_uudai.Name = "id_uudai";
            // 
            // thongdiep
            // 
            this.thongdiep.DataPropertyName = "thongdiep";
            this.thongdiep.HeaderText = "Thông điệp";
            this.thongdiep.Name = "thongdiep";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(3)))), ((int)(((byte)(57)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(656, 482);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xem Chi Tiết";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lichsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLichSu);
            this.Controls.Add(this.label1);
            this.Name = "lichsu";
            this.Size = new System.Drawing.Size(841, 559);
            this.Load += new System.EventHandler(this.lichsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lichsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user_revice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygiaodich;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_uudai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongdiep;
        private System.Windows.Forms.Button button2;
    }
}
