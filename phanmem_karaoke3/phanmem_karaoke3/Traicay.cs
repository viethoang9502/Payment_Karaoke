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
    public partial class Traicay : UserControl
    {
        
        public Traicay()
        {
            InitializeComponent();
        }
        order or = new order();
        DataTable dt = new DataTable();
        private void Traicay_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Loại Trái Cây");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Giá tiền");
            cbbLoai1.SelectedIndex = 0;
            cbbLoai2.SelectedIndex = 0;
            cbbLoai3.SelectedIndex = 0;
        }
        public void setnut()
        {
            btLoai1.Text = "Order";
            btLoai2.Text = "Order";
            btLoai3.Text = "Order";
        }
        private int MonDaChon(string foodname, DataTable dt)
        {
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Loại Trái Cây"].ToString() == foodname)
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
                dr["Loại Trái Cây"] = foodname;
                dr["Số Lượng"] = sl;
                dr["Giá tiền"] = tien*sl;
                dt.Rows.Add(dr);
            }
        }


        private void btXacnhantc_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < DgvTraicay.Rows.Count; i++)
            {
                string ten = DgvTraicay.Rows[i].Cells["Loại Trái Cây"].Value.ToString();
                int sls = Int32.Parse(DgvTraicay.Rows[i].Cells["Số Lượng"].Value.ToString());
                float tien = float.Parse(DgvTraicay.Rows[i].Cells["Giá tiền"].Value.ToString());
                or.Them(ten, sls,tien);
             }
            if (DgvTraicay.DataSource == null)
            {
                MessageBox.Show("Bạn chưa Order gì hết", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Cảm ơn đã Order vui lòng đợi 1 tí <3", "Thông Báo");
                DgvTraicay.DataSource = null;
                
            }
            dt.Rows.Clear();
            setnut();
        }

        private void btHuytc_Click(object sender, EventArgs e)
        {
            if (DgvTraicay.Rows.Count > 0)
            {
                if (DgvTraicay.Rows.Count == 1)
                {
                    DgvTraicay.DataSource = null;
                    dt.Rows.Clear();
                    setnut();
                }
                else
                {
                    dt.Rows.RemoveAt(DgvTraicay.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại trái cây để hủy Order", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btLoai1_Click(object sender, EventArgs e)
        {
            string a = cbbLoai1.Text.ToString();
            string b = lbTotal1.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbLoai1.Text, int.Parse(a),float.Parse(b));
                DgvTraicay.DataSource = dt;
                btLoai1.Text = "Thêm";
                cbbLoai1.SelectedIndex = 0;
                DgvTraicay.Focus();
            }
        }

        private void btLoai2_Click(object sender, EventArgs e)
        {
            string a = cbbLoai2.Text.ToString();
            string b = lbTotal2.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbLoai2.Text, int.Parse(a),float.Parse(b));
                DgvTraicay.DataSource = dt;
                btLoai2.Text = "Thêm";
                cbbLoai2.SelectedIndex = 0;
                DgvTraicay.Focus();
            }
        }

        private void btLoai3_Click(object sender, EventArgs e)
        {
            string a = cbbLoai3.Text.ToString();
            string b = lbTotal3.Text.ToString();
            if (int.Parse(a) == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng để order !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                them(lbLoai3.Text, int.Parse(a),float.Parse(b));
                DgvTraicay.DataSource = dt;
                btLoai3.Text = "Thêm";
                cbbLoai3.SelectedIndex = 0;
                DgvTraicay.Focus();
            }
        }
    }
}
             
           
        
            
        
             
            
           
            

        



      
    

