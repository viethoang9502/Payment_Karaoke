using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace phanmem_karaoke3
{ 
    public partial class dangnhap : Form
    {
       
        order or = new order();
        database db = new database();
        public dangnhap()
        {
            InitializeComponent();
        }


        public void reset()
        {
            SqlConnection KetnoiSQL = new SqlConnection("Data Source=VIETHOANG\\SQLEXPRESS;Initial Catalog=QLKaraoke;Integrated Security=True");
            KetnoiSQL.Open();
            string a = txtTaikhoan.Text;
            string b = txtMatkhau.Text;
            string sql = "select * from dangnhap where dn = '" + a + "' and pass = '" + b + "'";
            SqlCommand cmdd = KetnoiSQL.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "delete from tam";
            cmdd.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand(sql, KetnoiSQL);
            SqlDataReader dtr = cmd.ExecuteReader();          
            
            if (dtr.Read() == true)
            {
                MessageBox.Show("Yêu cầu Reset thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yêu cầu Reset không thành công. Vui lòng nhập lại!!!", "Thông báo");
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            reset();
            
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbTieude_Click(object sender, EventArgs e)
        {

        }
    }
}
