using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace phanmem_karaoke3
{
    public partial class Bill : UserControl
    {
        order or = new order();
        DataTable dt = new DataTable();
        
        public Bill()
        {
            InitializeComponent();
        }
        public void setnut(bool a)
        {
            btThanhtoan.Enabled = a;
            btHienHD.Enabled = !a;
        }
        private void btHienHD_Click(object sender, EventArgs e)
        {
            DgvBill.DataSource = or.layHoadon();
            setnut(true);
            dt = or.laytientong();
            dgvTotal.DataSource = dt;
            TxtTT.DataBindings.Clear();
            TxtTT.DataBindings.Add("Text", dgvTotal.DataSource, "tongtien");
        }
        private int tinhtien()
        {
            int tong;
            int a = Int32.Parse(lbHour.Text);
            int b = Int32.Parse(lbMinute.Text);
            b = b * 2000;
            a = a * 100000 + b;
            tong = a;
            return tong;
        }
        public void setgio()
        {
            lbHour.Text = "00";
            lbMinute.Text = "00";
            lbSecond.Text = "00";
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            timer1.Start();
            setnut(false);
        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            
            float Tong = tinhtien();
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thanh toán hóa đơn??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                setnut(true);
                timer1.Stop();
                txtTiengio.text = tinhtien().ToString();
                Tong = Int32.Parse(txtTiengio.text.ToString()) + Int32.Parse(TxtTT.text.ToString());
                MessageBox.Show("Cảm ơn bạn đã đến KARAOKE ĐẠI BÀNG số tiền bạn cần thanh toán là : " + Tong + " VNĐ ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                btThanhtoan.Enabled = false;
                setgio();
               
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbMinute.Text);
            int b = Int32.Parse(lbSecond.Text);
            int c = Int32.Parse(lbHour.Text);
            b++;
            if (b > 59)
            {
                b = 0;
                a++;
            }
            if (a > 59)
            {
                a = 0;
                c++;
            }
            if (a < 10)
                lbMinute.Text = "0" + a;
            else
                lbMinute.Text = a + "";
            if (b < 10)
                lbSecond.Text = "0" + b;
            else
                lbSecond.Text = b + "";
            if (c < 10)
                lbHour.Text = "0" + c;
            else
                lbHour.Text = c + "";
        }
        public void reset()
        {
            setnut(false);
            DgvBill.DataSource = null;
            dgvTotal.DataSource = null;
            
            
            dt.Rows.Clear();
            txtTiengio.text = "";
        }
        private void pcbDn_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.ShowDialog();
            reset();
            or.xoatam();
            timer1.Start();
        }
    }
    
}
