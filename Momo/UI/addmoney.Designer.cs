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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.tableBank = new System.Windows.Forms.DataGridView();
            this.id_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).BeginInit();
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
            this.button1.Margin = new System.Windows.Forms.Padding(2);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(45)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableBank.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableBank.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.tableBank.Location = new System.Drawing.Point(516, 83);
            this.tableBank.Name = "tableBank";
            this.tableBank.RowHeadersVisible = false;
            this.tableBank.Size = new System.Drawing.Size(280, 425);
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
            // addmoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.tableBank);
            this.Controls.Add(this.button1);
            this.Name = "addmoney";
            this.Size = new System.Drawing.Size(841, 559);
            ((System.ComponentModel.ISupportInitialize)(this.tableBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankname;
    }
}
