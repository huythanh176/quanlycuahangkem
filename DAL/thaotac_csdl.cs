using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class thaotac_csdl
    {
        SqlConnection conn;
        public void Ketnoicosodulieu()
        {
            conn = new SqlConnection("Data Source=DESKTOP-96ROPSG; database=QLCHK; Integrated Security=true");
            conn.Open();
        }
        private void NgatKetNoi()
        {
            conn.Close();
            conn.Dispose();
        }
        public DataTable sql_laydulieu(string tenSP)
        {
            Ketnoicosodulieu();
            SqlCommand cmd = new SqlCommand(tenSP,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public DataTable SQL_LayDuLieu_codk(string TenSP, string[] name, object[] value, int Npara)
        {
            Ketnoicosodulieu();
            SqlCommand cmd = new SqlCommand(TenSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;


        }
        public int SQL_Thuchien(string TenSP, string[] name, object[] value, int Npara)
        {
            Ketnoicosodulieu();
            SqlCommand cmd = new SqlCommand(TenSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }


    }
}
