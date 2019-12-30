using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class CTHD_DAL
    {
        thaotac_csdl thaotac = new thaotac_csdl();
        string[] name = { };
        object[] value = { };
        public DataTable CTHD_select()
        {
            return thaotac.sql_laydulieu("select_cthd");
        }
        public DataTable CTHD_select_theoban_ckt(string MaBan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = MaBan;
            return thaotac.SQL_LayDuLieu_codk("select_cthd_theoban_ckt", name, value, 1);
        }
        public DataTable CTHD_select_chitiet(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;
            return thaotac.SQL_LayDuLieu_codk("select_cthd_chitiet", name, value, 1);
        }
        public DataTable CTHD_select_theoMAHD(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;
            return thaotac.SQL_LayDuLieu_codk("select_cthd_theoMaHD", name, value, 1);
        }
        public int CTHD_insert(string MaHD,string MaHang,int SL)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaHang;
            name[2] = "@SL"; value[2] = SL;
          
            return thaotac.SQL_Thuchien("insert_cthd", name, value, 3);
        }

        public int CTHD_update(string MaHD, string MaHang, int SL)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaHang;
            name[2] = "@SL"; value[2] = SL;
            return thaotac.SQL_Thuchien("update_cthd", name, value, 3);
        }
        public int CTHD_delete(string MaHD, string MaHang)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaHang;
            return thaotac.SQL_Thuchien("delete_cthd", name, value, 2);
        }
    }
}
