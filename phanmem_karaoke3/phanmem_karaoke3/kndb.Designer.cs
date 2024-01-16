namespace phanmem_karaoke3
{
    partial class kndb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kndb));
            this.txtSv = new System.Windows.Forms.TextBox();
            this.lbSv = new System.Windows.Forms.Label();
            this.lbUid = new System.Windows.Forms.Label();
            this.lbDb = new System.Windows.Forms.Label();
            this.lbPwd = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btKetnoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btThoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtSv
            // 
            this.txtSv.Location = new System.Drawing.Point(70, 39);
            this.txtSv.Name = "txtSv";
            this.txtSv.Size = new System.Drawing.Size(100, 20);
            this.txtSv.TabIndex = 1;
            // 
            // lbSv
            // 
            this.lbSv.AutoSize = true;
            this.lbSv.Location = new System.Drawing.Point(12, 39);
            this.lbSv.Name = "lbSv";
            this.lbSv.Size = new System.Drawing.Size(38, 13);
            this.lbSv.TabIndex = 2;
            this.lbSv.Text = "Server";
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Location = new System.Drawing.Point(12, 99);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(40, 13);
            this.lbUid.TabIndex = 3;
            this.lbUid.Text = "UserID";
            // 
            // lbDb
            // 
            this.lbDb.AutoSize = true;
            this.lbDb.Location = new System.Drawing.Point(317, 46);
            this.lbDb.Name = "lbDb";
            this.lbDb.Size = new System.Drawing.Size(53, 13);
            this.lbDb.TabIndex = 4;
            this.lbDb.Text = "Database";
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Location = new System.Drawing.Point(317, 99);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(53, 13);
            this.lbPwd.TabIndex = 5;
            this.lbPwd.Text = "Password";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(70, 96);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 20);
            this.txtUid.TabIndex = 3;
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(385, 39);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(100, 20);
            this.txtDb.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(385, 96);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 4;
            // 
            // btKetnoi
            // 
            this.btKetnoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btKetnoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btKetnoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btKetnoi.BorderRadius = 0;
            this.btKetnoi.ButtonText = "Ket noi";
            this.btKetnoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKetnoi.DisabledColor = System.Drawing.Color.Gray;
            this.btKetnoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btKetnoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btKetnoi.Iconimage")));
            this.btKetnoi.Iconimage_right = null;
            this.btKetnoi.Iconimage_right_Selected = null;
            this.btKetnoi.Iconimage_Selected = null;
            this.btKetnoi.IconMarginLeft = 0;
            this.btKetnoi.IconMarginRight = 0;
            this.btKetnoi.IconRightVisible = true;
            this.btKetnoi.IconRightZoom = 0D;
            this.btKetnoi.IconVisible = true;
            this.btKetnoi.IconZoom = 90D;
            this.btKetnoi.IsTab = false;
            this.btKetnoi.Location = new System.Drawing.Point(32, 178);
            this.btKetnoi.Name = "btKetnoi";
            this.btKetnoi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btKetnoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btKetnoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btKetnoi.selected = false;
            this.btKetnoi.Size = new System.Drawing.Size(182, 48);
            this.btKetnoi.TabIndex = 10;
            this.btKetnoi.Text = "Ket noi";
            this.btKetnoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKetnoi.Textcolor = System.Drawing.Color.White;
            this.btKetnoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetnoi.Click += new System.EventHandler(this.btKetnoi_Click_1);
            // 
            // btThoat
            // 
            this.btThoat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.BorderRadius = 0;
            this.btThoat.ButtonText = "Thoat";
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.DisabledColor = System.Drawing.Color.Gray;
            this.btThoat.Iconcolor = System.Drawing.Color.Transparent;
            this.btThoat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btThoat.Iconimage")));
            this.btThoat.Iconimage_right = null;
            this.btThoat.Iconimage_right_Selected = null;
            this.btThoat.Iconimage_Selected = null;
            this.btThoat.IconMarginLeft = 0;
            this.btThoat.IconMarginRight = 0;
            this.btThoat.IconRightVisible = true;
            this.btThoat.IconRightZoom = 0D;
            this.btThoat.IconVisible = true;
            this.btThoat.IconZoom = 90D;
            this.btThoat.IsTab = false;
            this.btThoat.Location = new System.Drawing.Point(262, 178);
            this.btThoat.Name = "btThoat";
            this.btThoat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btThoat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btThoat.OnHoverTextColor = System.Drawing.Color.White;
            this.btThoat.selected = false;
            this.btThoat.Size = new System.Drawing.Size(202, 48);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoat";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Textcolor = System.Drawing.Color.White;
            this.btThoat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // kndb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 279);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKetnoi);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lbPwd);
            this.Controls.Add(this.lbDb);
            this.Controls.Add(this.lbUid);
            this.Controls.Add(this.lbSv);
            this.Controls.Add(this.txtSv);
            this.KeyPreview = true;
            this.Name = "kndb";
            this.Text = "kndb";
            this.Enter += new System.EventHandler(this.btKetnoi_Click_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kndb_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSv;
        private System.Windows.Forms.Label lbSv;
        private System.Windows.Forms.Label lbUid;
        private System.Windows.Forms.Label lbDb;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.TextBox txtPwd;
        private Bunifu.Framework.UI.BunifuFlatButton btKetnoi;
        private Bunifu.Framework.UI.BunifuFlatButton btThoat;
    }
}