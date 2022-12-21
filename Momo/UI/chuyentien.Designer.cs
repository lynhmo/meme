namespace Momo.UI
{
    partial class chuyentien
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername_receive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_money_transfer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tableDanhBa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhBa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::Momo.Properties.Resources.left_arrow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(36, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập tên người chuyển khoản";
            // 
            // txtusername_receive
            // 
            this.txtusername_receive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername_receive.Location = new System.Drawing.Point(40, 214);
            this.txtusername_receive.Name = "txtusername_receive";
            this.txtusername_receive.Size = new System.Drawing.Size(502, 25);
            this.txtusername_receive.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(36, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số tiền";
            // 
            // txt_money_transfer
            // 
            this.txt_money_transfer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_money_transfer.Location = new System.Drawing.Point(40, 309);
            this.txt_money_transfer.Name = "txt_money_transfer";
            this.txt_money_transfer.Size = new System.Drawing.Size(502, 25);
            this.txt_money_transfer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(36, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lời nhắn";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(40, 411);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(502, 25);
            this.txtMessage.TabIndex = 4;
            // 
            // tableDanhBa
            // 
            this.tableDanhBa.AllowUserToAddRows = false;
            this.tableDanhBa.AllowUserToDeleteRows = false;
            this.tableDanhBa.AllowUserToResizeRows = false;
            this.tableDanhBa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDanhBa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDanhBa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username_,
            this.fullname});
            this.tableDanhBa.Location = new System.Drawing.Point(595, 161);
            this.tableDanhBa.Name = "tableDanhBa";
            this.tableDanhBa.RowHeadersVisible = false;
            this.tableDanhBa.RowHeadersWidth = 51;
            this.tableDanhBa.RowTemplate.Height = 24;
            this.tableDanhBa.Size = new System.Drawing.Size(470, 472);
            this.tableDanhBa.TabIndex = 5;
            this.tableDanhBa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDanhBa_CellClick);
            this.tableDanhBa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyển tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(589, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Danh bạ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(3)))), ((int)(((byte)(57)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(305, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Chuyển Tiền";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã người dùng";
            this.id.Name = "id";
            // 
            // username_
            // 
            this.username_.DataPropertyName = "username";
            this.username_.HeaderText = "Tên người dùng";
            this.username_.Name = "username_";
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Họ và Tên";
            this.fullname.Name = "fullname";
            // 
            // chuyentien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableDanhBa);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txt_money_transfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername_receive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "chuyentien";
            this.Size = new System.Drawing.Size(1121, 688);
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhBa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername_receive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_money_transfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.DataGridView tableDanhBa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username_;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
    }
}
