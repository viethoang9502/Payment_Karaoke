namespace phanmem_karaoke3
{
    partial class Bill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btThanhtoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtTT = new Bunifu.Framework.UI.BunifuTextbox();
            this.btHienHD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTiengio = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcbDn = new System.Windows.Forms.PictureBox();
            this.hproBill = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // DgvBill
            // 
            this.DgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvBill.Location = new System.Drawing.Point(3, 200);
            this.DgvBill.Name = "DgvBill";
            this.DgvBill.Size = new System.Drawing.Size(669, 701);
            this.DgvBill.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenmon";
            this.Column1.HeaderText = "Tên Sản Phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sl";
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "giatien";
            this.Column3.HeaderText = "Giá tiền";
            this.Column3.Name = "Column3";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(332, 81);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 24);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Tiền dịch vụ";
            // 
            // btThanhtoan
            // 
            this.btThanhtoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btThanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btThanhtoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThanhtoan.BorderRadius = 0;
            this.btThanhtoan.ButtonText = "Thanh toán";
            this.btThanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThanhtoan.DisabledColor = System.Drawing.Color.Gray;
            this.btThanhtoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btThanhtoan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btThanhtoan.Iconimage")));
            this.btThanhtoan.Iconimage_right = null;
            this.btThanhtoan.Iconimage_right_Selected = null;
            this.btThanhtoan.Iconimage_Selected = null;
            this.btThanhtoan.IconMarginLeft = 0;
            this.btThanhtoan.IconMarginRight = 0;
            this.btThanhtoan.IconRightVisible = true;
            this.btThanhtoan.IconRightZoom = 0D;
            this.btThanhtoan.IconVisible = true;
            this.btThanhtoan.IconZoom = 90D;
            this.btThanhtoan.IsTab = false;
            this.btThanhtoan.Location = new System.Drawing.Point(18, 72);
            this.btThanhtoan.Name = "btThanhtoan";
            this.btThanhtoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btThanhtoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btThanhtoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btThanhtoan.selected = false;
            this.btThanhtoan.Size = new System.Drawing.Size(165, 48);
            this.btThanhtoan.TabIndex = 12;
            this.btThanhtoan.Text = "Thanh toán";
            this.btThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThanhtoan.Textcolor = System.Drawing.Color.White;
            this.btThanhtoan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhtoan.Click += new System.EventHandler(this.btThanhtoan_Click);
            // 
            // TxtTT
            // 
            this.TxtTT.BackColor = System.Drawing.Color.Silver;
            this.TxtTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtTT.BackgroundImage")));
            this.TxtTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtTT.Enabled = false;
            this.TxtTT.ForeColor = System.Drawing.Color.SeaGreen;
            this.TxtTT.Icon = ((System.Drawing.Image)(resources.GetObject("TxtTT.Icon")));
            this.TxtTT.Location = new System.Drawing.Point(456, 72);
            this.TxtTT.Name = "TxtTT";
            this.TxtTT.Size = new System.Drawing.Size(201, 42);
            this.TxtTT.TabIndex = 15;
            this.TxtTT.text = "";
            // 
            // btHienHD
            // 
            this.btHienHD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btHienHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btHienHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHienHD.BorderRadius = 0;
            this.btHienHD.ButtonText = "Hiện hóa đơn";
            this.btHienHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHienHD.DisabledColor = System.Drawing.Color.Gray;
            this.btHienHD.Iconcolor = System.Drawing.Color.Transparent;
            this.btHienHD.Iconimage = ((System.Drawing.Image)(resources.GetObject("btHienHD.Iconimage")));
            this.btHienHD.Iconimage_right = null;
            this.btHienHD.Iconimage_right_Selected = null;
            this.btHienHD.Iconimage_Selected = null;
            this.btHienHD.IconMarginLeft = 0;
            this.btHienHD.IconMarginRight = 0;
            this.btHienHD.IconRightVisible = true;
            this.btHienHD.IconRightZoom = 0D;
            this.btHienHD.IconVisible = true;
            this.btHienHD.IconZoom = 90D;
            this.btHienHD.IsTab = false;
            this.btHienHD.Location = new System.Drawing.Point(189, 72);
            this.btHienHD.Name = "btHienHD";
            this.btHienHD.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btHienHD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btHienHD.OnHoverTextColor = System.Drawing.Color.White;
            this.btHienHD.selected = false;
            this.btHienHD.Size = new System.Drawing.Size(145, 48);
            this.btHienHD.TabIndex = 17;
            this.btHienHD.Text = "Hiện hóa đơn";
            this.btHienHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienHD.Textcolor = System.Drawing.Color.White;
            this.btHienHD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienHD.Click += new System.EventHandler(this.btHienHD_Click);
            // 
            // dgvTotal
            // 
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgvTotal.Location = new System.Drawing.Point(248, 200);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.Size = new System.Drawing.Size(234, 150);
            this.dgvTotal.TabIndex = 16;
            this.dgvTotal.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tong tien";
            this.Column4.Name = "Column4";
            // 
            // lbSecond
            // 
            this.lbSecond.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.Location = new System.Drawing.Point(283, 140);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(51, 45);
            this.lbSecond.TabIndex = 18;
            this.lbSecond.Text = "00";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = ":";
            // 
            // lbMinute
            // 
            this.lbMinute.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.Location = new System.Drawing.Point(224, 140);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(59, 32);
            this.lbMinute.TabIndex = 21;
            this.lbMinute.Text = "00";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = ":";
            // 
            // lbHour
            // 
            this.lbHour.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(162, 140);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(55, 35);
            this.lbHour.TabIndex = 19;
            this.lbHour.Text = "00";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 45);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thời gian sử dụng";
            // 
            // txtTiengio
            // 
            this.txtTiengio.BackColor = System.Drawing.Color.Silver;
            this.txtTiengio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTiengio.BackgroundImage")));
            this.txtTiengio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTiengio.Enabled = false;
            this.txtTiengio.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtTiengio.Icon = ((System.Drawing.Image)(resources.GetObject("txtTiengio.Icon")));
            this.txtTiengio.Location = new System.Drawing.Point(456, 140);
            this.txtTiengio.Name = "txtTiengio";
            this.txtTiengio.Size = new System.Drawing.Size(201, 40);
            this.txtTiengio.TabIndex = 24;
            this.txtTiengio.text = "";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(332, 148);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 24);
            this.bunifuCustomLabel2.TabIndex = 25;
            this.bunifuCustomLabel2.Text = "Tiền Giờ";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcbDn
            // 
            this.pcbDn.Image = ((System.Drawing.Image)(resources.GetObject("pcbDn.Image")));
            this.pcbDn.Location = new System.Drawing.Point(18, 0);
            this.pcbDn.Name = "pcbDn";
            this.pcbDn.Size = new System.Drawing.Size(51, 43);
            this.pcbDn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDn.TabIndex = 26;
            this.pcbDn.TabStop = false;
            this.pcbDn.Click += new System.EventHandler(this.pcbDn_Click);
            // 
            // hproBill
            // 
            this.hproBill.HelpNamespace = "filehelp.chm";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.pcbDn);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtTiengio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.btHienHD);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(this.TxtTT);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btThanhtoan);
            this.Controls.Add(this.DgvBill);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(672, 901);
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvBill;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btThanhtoan;
        private Bunifu.Framework.UI.BunifuTextbox TxtTT;
        private Bunifu.Framework.UI.BunifuFlatButton btHienHD;
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTextbox txtTiengio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbDn;
        private System.Windows.Forms.HelpProvider hproBill;
    }
}
