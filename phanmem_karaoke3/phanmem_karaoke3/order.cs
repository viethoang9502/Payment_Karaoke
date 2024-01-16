using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;

namespace phanmem_karaoke3
{
    class order
    {
        database db = new database();
        public DataTable LayTien(string sql)
        {
            sql = "select * FROM BEER";
            DataTable dt = db.thuchien(sql);
            return dt;
        }
        public void Them(string ten, int sl,float tien)
        {
            string sql = string.Format("Insert Into Tam values(N'" + ten + "'," + sl + ","+ tien +")");
            db.thuchienlenh(sql);
            
        }
        public DataTable layHoadon()
        {
            string sql = "  select tenmon, sum (sl) as sl , sum (giatien) as giatien from tam group by tenmon";
            DataTable dt = db.thuchien(sql);
            return dt;
        }
        public DataTable laytientong()
        {     
            string sql = "select sum(giatien) as tongtien from tam";
            DataTable dt = db.thuchien(sql);
            return dt;         
        }
        public bool xoatam()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tam";
                db.ExeNonQuery(cmd);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }

}
