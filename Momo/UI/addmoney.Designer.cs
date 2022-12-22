namespace Momo.UI
{
    partial class addmoney
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.tableBank = new System.Windows.Forms.DataGridView();
            this.id_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.naptienNumber = new System.Windows.Forms.NumericUpDown();
            this.cbb_bankname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bankName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naptienNumber)).BeginInit();
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
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(45)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableBank.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableBank.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.tableBank.Location = new System.Drawing.Point(39, 335);
            this.tableBank.Name = "tableBank";
            this.tableBank.RowHeadersVisible = false;
            this.tableBank.Size = new System.Drawing.Size(757, 167);
            this.tableBank.TabIndex = 7;
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
            this.label7.Location = new System.Drawing.Point(34, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Danh sách ngân hàng liên kết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thêm tiền vào ví";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.Location = new System.Drawing.Point(520, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thêm tiền vào ví";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // naptienNumber
            // 
            this.naptienNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.naptienNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.naptienNumber.Location = new System.Drawing.Point(39, 234);
            this.naptienNumber.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.naptienNumber.Name = "naptienNumber";
            this.naptienNumber.Size = new System.Drawing.Size(466, 28);
            this.naptienNumber.TabIndex = 11;
            this.naptienNumber.ThousandsSeparator = true;
            // 
            // cbb_bankname
            // 
            this.cbb_bankname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_bankname.FormattingEnabled = true;
            this.cbb_bankname.Location = new System.Drawing.Point(196, 179);
            this.cbb_bankname.Name = "cbb_bankname";
            this.cbb_bankname.Size = new System.Drawing.Size(121, 36);
            this.cbb_bankname.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn ngân hàng";
            // 
            // txt_bankName
            // 
            this.txt_bankName.Location = new System.Drawing.Point(338, 192);
            this.txt_bankName.Name = "txt_bankName";
            this.txt_bankName.Size = new System.Drawing.Size(100, 20);
            this.txt_bankName.TabIndex = 13;
            // 
            // addmoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.txt_bankName);
            this.Controls.Add(this.cbb_bankname);
            this.Controls.Add(this.naptienNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableBank);
            this.Controls.Add(this.button1);
            this.Name = "addmoney";
            this.Size = new System.Drawing.Size(841, 559);
            this.Load += new System.EventHandler(this.addmoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naptienNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown naptienNumber;
        private System.Windows.Forms.ComboBox cbb_bankname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bankName;
    }
}
