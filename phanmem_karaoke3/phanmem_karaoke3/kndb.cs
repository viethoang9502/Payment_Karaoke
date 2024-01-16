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
    public partial class kndb : Form
    {
        SqlConnection cnn = new SqlConnection();
        public static string server;
        public static string db;
        public static string uid;
        public static string pwd;
        Form1 f1;
        public kndb()
        {
            InitializeComponent();
        }
        private void btKetnoi_Click_1(object sender, EventArgs e)
        {
            
            server = txtSv.Text;
            db = txtDb.Text;
            uid = txtUid.Text;
            pwd = txtPwd.Text;
            cnn.ConnectionString = "server=" + server + ";database=" + db + ";UID=" + uid + ";PWD=" + pwd+";";
            try
            {
                cnn.Open();
                MessageBox.Show("Kết nối thành công", "Thong bao");
                this.Hide();
                f1 = new Form1();
                f1.Show();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại", "Thong bao");
            }
        }
        
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kndb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btKetnoi_Click_1(sender, e);
            }
        }
    }
}
