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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_username_wallet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_user_money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ví Của Tôi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Momo.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(30, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 126);
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
            this.lbl_username_wallet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panel1.Location = new System.Drawing.Point(192, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 96);
            this.panel1.TabIndex = 4;
            // 
            // lbl_user_money
            // 
            this.lbl_user_money.AutoSize = true;
            this.lbl_user_money.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_user_money.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbl_user_money.Location = new System.Drawing.Point(0, 68);
            this.lbl_user_money.Name = "lbl_user_money";
            this.lbl_user_money.Size = new System.Drawing.Size(16, 28);
            this.lbl_user_money.TabIndex = 3;
            this.lbl_user_money.Text = ".";
            // 
            // mywallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mywallet";
            this.Size = new System.Drawing.Size(1121, 688);
            this.Load += new System.EventHandler(this.mywallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_username_wallet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_user_money;
    }
}
