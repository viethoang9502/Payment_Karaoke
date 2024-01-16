using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace phanmem_karaoke3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            pntruot.Height = bthoadon.Height;
            pntruot.Top = bthoadon.Top;
            anuser();
            bill1.Visible = true;
            P1.BringToFront();
            //bill1.BringToFront();
        }
        void anuser()
        {
            beer1.Visible = false;
            doan1.Visible = false;
            traicay1.Visible = false;
            drink1.Visible = false;
            bill1.Visible = false;
        }

        public void thu (bool a)
        {
           
            btamthuc.Enabled = a;
            bthoadon.Enabled = a;
            btnuocngot.Enabled = a;
            bttraicay.Enabled = a;
            btbia.Enabled = a;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Bạn muốn đóng ứng dụng??","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void bthoadon_Click(object sender, EventArgs e)
        {
            pntruot.Height = bthoadon.Height;
            pntruot.Top = bthoadon.Top;
            anuser();
            bill1.Visible = true;
            P1.BringToFront();
           
            

        }

        public void btamthuc_Click(object sender, EventArgs e)
        {
            pntruot.Height = btamthuc.Height;
            pntruot.Top = btamthuc.Top;
            anuser();
            doan1.Visible = true;
           
        }

        public void btbia_Click(object sender, EventArgs e)
        {
            pntruot.Height = btbia.Height;
            pntruot.Top = btbia.Top;
            anuser();
            beer1.Visible = true;
           
        }
        public void bttraicay_Click_1(object sender, EventArgs e)
        {
            pntruot.Height = bttraicay.Height;
            pntruot.Top = bttraicay.Top;
            anuser();
            traicay1.Visible = true;
            
        }

        private void btnuocngot_Click_1(object sender, EventArgs e)
        {
            pntruot.Height = btnuocngot.Height;
            pntruot.Top = btnuocngot.Top;
            anuser();
            drink1.Visible = true;
        }

        private void ptbHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://D:\\helpfile\\filehelp.chm");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "file://D:\\helpfile\\filehelp.chm");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
