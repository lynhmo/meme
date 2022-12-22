namespace Momo
{
    partial class nguontien
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableBank = new System.Windows.Forms.DataGridView();
            this.id_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nguồn Tiền";
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
            this.tableBank.Location = new System.Drawing.Point(466, 132);
            this.tableBank.Name = "tableBank";
            this.tableBank.RowHeadersVisible = false;
            this.tableBank.Size = new System.Drawing.Size(342, 386);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liên kết ngân hàng vào ví";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel1.Location = new System.Drawing.Point(29, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 92);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(461, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngân hàng đã liên kết";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel2.Location = new System.Drawing.Point(129, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 92);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel3.Location = new System.Drawing.Point(229, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 92);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel4.Location = new System.Drawing.Point(29, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 92);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel5.Location = new System.Drawing.Point(129, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(94, 92);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel6.Location = new System.Drawing.Point(229, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(94, 92);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel7.Location = new System.Drawing.Point(29, 328);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(94, 92);
            this.panel7.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel8.Location = new System.Drawing.Point(29, 426);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(94, 92);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel9.Location = new System.Drawing.Point(129, 328);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(94, 92);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel10.Location = new System.Drawing.Point(129, 426);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(94, 92);
            this.panel10.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel11.Location = new System.Drawing.Point(229, 328);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(94, 92);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel12.Location = new System.Drawing.Point(229, 426);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(94, 92);
            this.panel12.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(210)))));
            this.panel13.Location = new System.Drawing.Point(390, 310);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(294, 386);
            this.panel13.TabIndex = 9;
            // 
            // nguontien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableBank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "nguontien";
            this.Size = new System.Drawing.Size(841, 559);
            this.Load += new System.EventHandler(this.nguontien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
    }
}
