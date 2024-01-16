namespace phanmem_karaoke3
{
    partial class dangnhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTieude = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbTaikhoan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTaikhoan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMatkhau = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbMatkhau = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbTieude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 38);
            this.panel1.TabIndex = 0;
            // 
            // lbTieude
            // 
            this.lbTieude.AutoSize = true;
            this.lbTieude.BackColor = System.Drawing.Color.Blue;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieude.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTieude.Location = new System.Drawing.Point(3, 9);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(249, 24);
            this.lbTieude.TabIndex = 0;
            this.lbTieude.Text = "Chủ hộ gia đình đăng nhập";
            this.lbTieude.Click += new System.EventHandler(this.lbTieude_Click);
            // 
            // lbTaikhoan
            // 
            this.lbTaikhoan.AutoSize = true;
            this.lbTaikhoan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan.ForeColor = System.Drawing.Color.Black;
            this.lbTaikhoan.Location = new System.Drawing.Point(23, 92);
            this.lbTaikhoan.Name = "lbTaikhoan";
            this.lbTaikhoan.Size = new System.Drawing.Size(123, 26);
            this.lbTaikhoan.TabIndex = 1;
            this.lbTaikhoan.Text = "Tài khoản:";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtTaikhoan.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtTaikhoan.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtTaikhoan.BorderThickness = 3;
            this.txtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaikhoan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaikhoan.isPassword = false;
            this.txtTaikhoan.Location = new System.Drawing.Point(144, 92);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(253, 44);
            this.txtTaikhoan.TabIndex = 2;
            this.txtTaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtMatkhau.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtMatkhau.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtMatkhau.BorderThickness = 3;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatkhau.isPassword = true;
            this.txtMatkhau.Location = new System.Drawing.Point(144, 144);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(253, 44);
            this.txtMatkhau.TabIndex = 3;
            this.txtMatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.ForeColor = System.Drawing.Color.Black;
            this.lbMatkhau.Location = new System.Drawing.Point(26, 144);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(120, 26);
            this.lbMatkhau.TabIndex = 4;
            this.lbMatkhau.Text = "Mật khẩu:";
            // 
            // btReset
            // 
            this.btReset.ActiveBorderThickness = 1;
            this.btReset.ActiveCornerRadius = 20;
            this.btReset.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btReset.ActiveForecolor = System.Drawing.Color.White;
            this.btReset.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReset.BackgroundImage")));
            this.btReset.ButtonText = "RESET";
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.SeaGreen;
            this.btReset.IdleBorderThickness = 1;
            this.btReset.IdleCornerRadius = 20;
            this.btReset.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btReset.IdleForecolor = System.Drawing.Color.White;
            this.btReset.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btReset.Location = new System.Drawing.Point(16, 197);
            this.btReset.Margin = new System.Windows.Forms.Padding(5);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(381, 41);
            this.btReset.TabIndex = 5;
            this.btReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(98, 41);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(224, 26);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Thông tin đăng nhập";
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 250);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbMatkhau);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.lbTaikhoan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btReset;
        private Bunifu.Framework.UI.BunifuCustomLabel lbMatkhau;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMatkhau;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTaikhoan;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTaikhoan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTieude;
    }
}