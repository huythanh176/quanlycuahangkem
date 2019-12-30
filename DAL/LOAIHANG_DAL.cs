using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LOAIHANG_DAL
    {
        thaotac_csdl thaotac = new thaotac_csdl();
        string[] name = { };
        object[] value = { };
        public DataTable loaihang_select()
        {
            return thaotac.sql_laydulieu("select_loaihang");
        }
        public int loaihang_insert(string MaLH, string TenLH, string Ghichu, byte[] image)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            name[1] = "@TenLoaiHang"; value[1] = TenLH;
            name[2] = "@Ghichu"; value[2] = Ghichu;
            name[3] = "@Hinhanh"; value[3] = image;
            return thaotac.SQL_Thuchien("insert_loaihang", name, value, 4);
        }
        public int loaihang_update_kohinh(string MaLH, string TenLH, string Ghichu)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            name[1] = "@TenLoaiHang"; value[1] = TenLH;
            name[2] = "@Ghichu"; value[2] = Ghichu;
            
            return thaotac.SQL_Thuchien("update_loaihang_kohinh", name, value, 3);
        }
        public int loaihang_update(string MaLH, string TenLH, string Ghichu, byte[] image)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            name[1] = "@TenLoaiHang"; value[1] = TenLH;
            name[2] = "@Ghichu"; value[2] = Ghichu;
            name[3] = "@Hinhanh"; value[3] = image;
            return thaotac.SQL_Thuchien("update_loaihang", name, value, 4);
        }
        public int loaihang_delete(string MaLH)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            return thaotac.SQL_Thuchien("delete_loaihang", name, value, 1);
        }
    }
}
