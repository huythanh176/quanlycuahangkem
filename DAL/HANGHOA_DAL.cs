using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HANGHOA_DAL
    {
        thaotac_csdl thaotac = new thaotac_csdl();
        string[] name = { };
        object[] value = { };
        public DataTable select_hanghoa()
        {
            return thaotac.sql_laydulieu("select_hanghoa");
        }
        public DataTable select_hanghoa_theomlh(string MaLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = MaLH;
            return thaotac.SQL_LayDuLieu_codk("select_hanghoa_theomaloaihang",name,value,1);
        }
        public DataTable select_hanghoa_theomh(string MaHH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = MaHH;
            return thaotac.SQL_LayDuLieu_codk("select_hanghoa_theomahang", name, value, 1);
        }
        public int hanghoa_insert(string MaHH, string TenHH, float Dongia,int SLcon,string MaLH, byte[] image)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaHang"; value[0] = MaHH;
            name[1] = "@TenHang"; value[1] = TenHH;
            name[2] = "@Dongia"; value[2] = Dongia;
            name[3] = "@SLcon"; value[3] = SLcon;
            name[4] = "@MaLoaiHang"; value[4] = MaLH;
            name[5] = "@Hinhanh"; value[5] = image;
            return thaotac.SQL_Thuchien("insert_hanghoa", name, value, 6);
        }
        public int hanghoa_update_kohinh(string MaHH, string TenHH, float Dongia, int SLcon, string MaLH)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHang"; value[0] = MaHH;
            name[1] = "@TenHang"; value[1] = TenHH;
            name[2] = "@Dongia"; value[2] = Dongia;
            name[3] = "@SLcon"; value[3] = SLcon;
            name[4] = "@MaLoaiHang"; value[4] = MaLH;
            
            return thaotac.SQL_Thuchien("update_hanghoa_kohinh", name, value, 5);
        }
        public int hanghoa_update(string MaHH, string TenHH, float Dongia, int SLcon, string MaLH, byte[] image)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaHang"; value[0] = MaHH;
            name[1] = "@TenHang"; value[1] = TenHH;
            name[2] = "@Dongia"; value[2] = Dongia;
            name[3] = "@SLcon"; value[3] = SLcon;
            name[4] = "@MaLoaiHang"; value[4] = MaLH;
            name[5] = "@Hinhanh"; value[5] = image;
            return thaotac.SQL_Thuchien("update_hanghoa", name, value, 6);
        }
        public int hanghoa_update_soluong(string MaHH, int SLcon)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHang"; value[0] = MaHH;
           
            name[1] = "@SLcon"; value[1] = SLcon;
           
            return thaotac.SQL_Thuchien("update_hanghoa_soluong", name, value, 2);
        }
        public int hanghoa_delete(string MaHH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = MaHH;
            return thaotac.SQL_Thuchien("delete_hanghoa", name, value, 1);
        }
    }
}
