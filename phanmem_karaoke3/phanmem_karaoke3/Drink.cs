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
    public partial class Drink : UserControl
    {
        public Drink()
        {
            InitializeComponent();
        }

        
        order or = new order();
        DataTable dt = new DataTable();
        private void Drink_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Tên nước");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Giá tiền");
            cbbAqua.SelectedIndex = 0;
            cbbCoca.SelectedIndex = 0;
            cbbDasani.SelectedIndex = 0;
            cbbMirinda.SelectedIndex = 0;
            cbbSting.SelectedIndex = 0;
        }
        public void setnut()
        {
            btAqua.Text = "Order Nước";
            btCoca.Text = "Order Nước";
            btDasani.Text = "Order Nước";
            btMirinda.Text = "Order Nước";
            btSting.Text = "Order Nước";
        }
        private int MonDaChon(string foodname, DataTable dt)
        {
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Tên nước"].ToString() == foodname)
                {
                    dong = i;
                    break;
                }
            }
            return dong;
        }
        void them(string foodname, int sl,float tien)
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
                dr["Tên nước"] = foodname;
                dr["Số Lượng"] = sl;
                dr["Giá tiền"] = tien * sl;
                dt.Rows.Add(dr);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvDrink.Rows.Count; i++)
            {
                string ten = DgvDrink.Rows[i].Cells["Tên nước"].Value.ToString();
                int sls = Int32.Parse(DgvDrink.Rows[i].Cells["Số Lượng"].Value.ToString());
                float tien = float.Parse(DgvDrink.Rows[i].Cells["Giá tiền"].Value.ToString());
                or.Them(ten, sls,tien);
            }
            if (DgvDrink.DataSource == null)
            {
                MessageBox.Show("Bạn chưa Order gì hết", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Cảm ơn đã Order vui lòng đợi 1 tí <3", "Thông Báo");
                DgvDrink.DataSource = null;
                
            }
            dt.Rows.Clear();
            setnut();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (DgvDrink.Rows.Count > 0)
            {
                if (DgvDrink.Rows.Count == 1)
                {
                    DgvDrink.DataSource = null;
                    dt.Rows.Clear();
                    setnut();
                }
                else
                {
                    dt.Rows.RemoveAt(DgvDrink.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại đồ uống để hủy Order", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btSting_Click(object sender, EventArgs e)
        {
            string a = cbbSting.Text.ToString();
            string b = lbTotalSting.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbSting.Text, int.Parse(a),float.Parse(b));
                DgvDrink.DataSource = dt;
                btSting.Text = "Thêm";
                cbbSting.SelectedIndex = 0;
                DgvDrink.Focus();
            }
        }

        private void btMirinda_Click(object sender, EventArgs e)
        {
            string a = cbbMirinda.Text.ToString();
            string b = lbTotalMi.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbMirinda.Text, int.Parse(a),float.Parse(b));
                DgvDrink.DataSource = dt;
                btMirinda.Text = "Thêm";
                cbbMirinda.SelectedIndex = 0;
                DgvDrink.Focus();
            }
        }

        private void btCoca_Click(object sender, EventArgs e)
        {
            string a = cbbCoca.Text.ToString();
            string b = lbTotalCoca.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbCoca.Text, int.Parse(a),float.Parse(b));
                DgvDrink.DataSource = dt;
                btCoca.Text = "Thêm";
                cbbCoca.SelectedIndex = 0;
                DgvDrink.Focus();
            }
        }

        private void btAqua_Click(object sender, EventArgs e)
        {
            string a = cbbAqua.Text.ToString();
            string b = lbTotalAqua.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbAqua.Text, int.Parse(a),float.Parse(b));
                DgvDrink.DataSource = dt;
                btAqua.Text = "Thêm";
                cbbAqua.SelectedIndex = 0;
                DgvDrink.Focus();
            }
        }

        private void btDasani_Click(object sender, EventArgs e)
        {
            string a = cbbDasani.Text.ToString();
            string b = lbTotalDa.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbDasani.Text, int.Parse(a),float.Parse(b));
                DgvDrink.DataSource = dt;
                btDasani.Text = "Thêm";
                cbbDasani.SelectedIndex = 0;
                DgvDrink.Focus();
            }
        }
    }
}
