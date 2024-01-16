using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace phanmem_karaoke3
{
    class database
    {
        string KetnoiSQL;
        SqlConnection cnn;
        SqlDataAdapter da;
        DataSet ds;
        public database()
        {

            //KetnoiSQL = "server="+ kndb.server +";database="+ kndb.db +";UID ="+ kndb.uid +";PWD="+ kndb.pwd +";";
            KetnoiSQL = "Data Source=VIETHOANG\\SQLEXPRESS;Initial Catalog=QLKaraoke;Integrated Security=True";
            cnn = new SqlConnection(KetnoiSQL);
        }
        public DataTable thuchien(string SQLstr)
        {
            da = new SqlDataAdapter(SQLstr, KetnoiSQL);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }
        public void thuchienlenh(string strsql)
        {
            SqlCommand cmn = new SqlCommand(strsql, cnn);
            cnn.Open();
            cmn.ExecuteNonQuery();
            cnn.Close();
        }
        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = cnn = new SqlConnection(KetnoiSQL);
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            cnn.Close();
            return rowsaffected;
        }




    }
}
