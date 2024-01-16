using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanmem_karaoke3
{
    public partial class Beer : UserControl
    {
        public Beer()
        {
            InitializeComponent();      
        }
        order or = new order();
        DataTable dt = new DataTable();
      


        private void Beer_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Tên Bia");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Giá tiền");
            cbbSaigon.SelectedIndex = 0;
            cbbHeineken.SelectedIndex = 0;
            cbbSapp.SelectedIndex = 0;
            cbbTiger.SelectedIndex = 0;
            cbb333.SelectedIndex = 0;
        }

        public void setnut()
        {
            btSaigon.Text = "Order Bia";
            btHeineken.Text = "Order Bia";
            btTiger.Text = "Order Bia";
            bt333.Text = "Order Bia";
            btSapp.Text = "Order Bia";
        }



        private int MonDaChon(string foodname, DataTable dt)
        {
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Tên Bia"].ToString() == foodname)
                {
                    dong = i;
                    break;
                }
            }
            return dong;
        }
        void them(string foodname, int sl, float tien)
        {
            DataRow dr = dt.NewRow();  // Tao dong moi
            int dong = MonDaChon(foodname, dt);
            if (dong != -1)
            {
                dt.Rows[dong]["Số Lượng"] = Convert.ToInt32(dt.Rows[dong]["Số Lượng"]) + sl;
                dt.Rows[dong]["Giá tiền"] = Convert.ToInt32(dt.Rows[dong]["Giá tiền"]) + (tien*sl);
            }
            else
            {
                dr["Tên Bia"] = foodname;
                dr["Số Lượng"] = sl;
                dr["Giá tiền"] = (tien*sl);
                dt.Rows.Add(dr);
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < DgvBeer.Rows.Count; i++)
            {

                string ten = DgvBeer.Rows[i].Cells["Tên Bia"].Value.ToString();
                int sls = Int32.Parse(DgvBeer.Rows[i].Cells["Số Lượng"].Value.ToString());
                float tien = float.Parse(DgvBeer.Rows[i].Cells["Giá tiền"].Value.ToString());
                or.Them(ten, sls,tien);
            }
            if (DgvBeer.DataSource == null)
            {
                MessageBox.Show("Bạn chưa Order gì hết", "Thông Báo");
            }


            else
            {
                MessageBox.Show("Cảm ơn đã Order vui lòng đợi 1 tí <3", "Thông Báo");
                DgvBeer.DataSource = null;
                
            }
            dt.Rows.Clear();
            setnut();
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            if (DgvBeer.Rows.Count > 0)
            {
                if (DgvBeer.Rows.Count == 1)
                {
                    DgvBeer.DataSource = null;
                    dt.Rows.Clear();
                    setnut();
                }
                else
                {
                    dt.Rows.RemoveAt(DgvBeer.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại bia để hủy Order", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSaigon_Click(object sender, EventArgs e)
        {
            {
                string a = cbbSaigon.Text.ToString();
                string b = lbTotalSG.Text.ToString();
                if (int.Parse(a) == 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    them(lbSaigon.Text, int.Parse(a),float.Parse(b));
                    DgvBeer.DataSource = dt;
                    btSaigon.Text = "Thêm Bia";
                    cbbSaigon.SelectedIndex = 0;
                    DgvBeer.Focus();
                }
            }
        }

        private void btTiger_Click(object sender, EventArgs e)
        {
            string a = cbbTiger.Text.ToString();
            string b = lbTotalTiger.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbTiger.Text, int.Parse(a),float.Parse(b));
                DgvBeer.DataSource = dt;
                btTiger.Text = "Thêm Bia";
                cbbTiger.SelectedIndex = 0;
                DgvBeer.Focus();
            }
        }

        private void btHeineken_Click(object sender, EventArgs e)
        {
            string a = cbbHeineken.Text.ToString();
            string b = lbTotalHeineken.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbHeineken.Text, int.Parse(a),float.Parse(b));
                DgvBeer.DataSource = dt;
                btHeineken.Text = "Thêm Bia";
                cbbHeineken.SelectedIndex = 0;
                DgvBeer.Focus();
            }
        }

        private void btSapp_Click(object sender, EventArgs e)
        {
            string a = cbbSapp.Text.ToString();
            string b = lbTotalSap.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbSapp.Text, int.Parse(a), float.Parse(b));
                DgvBeer.DataSource = dt;
                btSapp.Text = "Thêm Bia";
                cbbSapp.SelectedIndex = 0;
                DgvBeer.Focus();
            }
        }

        private void bt333_Click(object sender, EventArgs e)
        {
            string a = cbb333.Text.ToString();
            string b = lbTotal333.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lb333.Text, int.Parse(a), float.Parse(b));
                DgvBeer.DataSource = dt;
                bt333.Text = "Thêm Bia";
                cbb333.SelectedIndex = 0;
                DgvBeer.Focus();
            }
        }

    }
}










   
           