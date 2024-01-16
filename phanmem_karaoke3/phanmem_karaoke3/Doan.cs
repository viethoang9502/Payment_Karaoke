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
    public partial class Doan : UserControl
    {
        public Doan()
        {
            InitializeComponent();
        }
        order or = new order();
        DataTable dt = new DataTable();
        private void Doan_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Tên món ăn");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Giá tiền");
            cbbBap.SelectedIndex = 0;
            cbbChagio.SelectedIndex = 0;
            cbbGoi.SelectedIndex = 0;
            cbbHotvit.SelectedIndex = 0;
            cbbMiy.SelectedIndex = 0;
        }
        public void setnut()
        {
            btBap.Text = "Order Món";
            btChagio.Text = "Order Món";
            btGoi.Text = "Order Món";
            btHotvit.Text = "Order Món";
            btMiy.Text = "Order Món";
        }
        private int MonDaChon(string foodname, DataTable dt)
        {
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Tên món ăn"].ToString() == foodname)
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
                dr["Tên món ăn"] = foodname;
                dr["Số Lượng"] = sl;
                dr["Giá tiền"] = tien*sl;
                dt.Rows.Add(dr);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvMonan.Rows.Count; i++)
            {
                string ten = DgvMonan.Rows[i].Cells["Tên món ăn"].Value.ToString();
                int sls = Int32.Parse(DgvMonan.Rows[i].Cells["Số Lượng"].Value.ToString());
                float tien = float.Parse(DgvMonan.Rows[i].Cells["Giá tiền"].Value.ToString());
                or.Them(ten, sls,tien);
            }
            if (DgvMonan.DataSource == null)
            {
                MessageBox.Show("Bạn chưa Order gì hết", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Cảm ơn đã Order vui lòng đợi 1 tí <3", "Thông Báo");
                DgvMonan.DataSource = null;
            }
            dt.Rows.Clear();
            setnut();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (DgvMonan.Rows.Count > 0)
            {
                if (DgvMonan.Rows.Count == 1)
                {
                    DgvMonan.DataSource = null;
                    dt.Rows.Clear();
                    setnut();
                }
                else
                {
                    dt.Rows.RemoveAt(DgvMonan.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại món ăn để hủy Order", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btBap_Click(object sender, EventArgs e)
        {
            string a = cbbBap.Text.ToString();
            string b = lbTotalBap.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbBap.Text, int.Parse(a), float.Parse(b));
                DgvMonan.DataSource = dt;
                btBap.Text = "Thêm";
                cbbBap.SelectedIndex = 0;
                DgvMonan.Focus();
            }
        }

        private void btChagio_Click(object sender, EventArgs e)
        {
            string a = cbbChagio.Text.ToString();
            string b = lbTotalCha.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbChagio.Text, int.Parse(a),float.Parse(b));
                DgvMonan.DataSource = dt;
                btChagio.Text = "Thêm";
                cbbChagio.SelectedIndex = 0;
                DgvMonan.Focus();
            }
        }

        private void btGoi_Click(object sender, EventArgs e)
        {
            string a = cbbGoi.Text.ToString();
            string b = lbTotalGoi.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbGoitom.Text, int.Parse(a), float.Parse(b));
                DgvMonan.DataSource = dt;
                btGoi.Text = "Thêm";
                cbbGoi.SelectedIndex = 0;
                DgvMonan.Focus();
            }
        }

        private void btMiy_Click(object sender, EventArgs e)
        {
            string a = cbbMiy.Text.ToString();
            string b = lbTotalMiY.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbMiy.Text, int.Parse(a),float.Parse(b));
                DgvMonan.DataSource = dt;
                btMiy.Text = "Thêm";
                cbbMiy.SelectedIndex = 0;
                DgvMonan.Focus();
            }
        }

        private void btHotvit_Click(object sender, EventArgs e)
        {
            string a = cbbHotvit.Text.ToString();
            string b = lbTotalVit.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbHotvit.Text, int.Parse(a),float.Parse(b));
                DgvMonan.DataSource = dt;
                btHotvit.Text = "Thêm";
                cbbHotvit.SelectedIndex = 0;
                DgvMonan.Focus();
            }
        }
    }
}
