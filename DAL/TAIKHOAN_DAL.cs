using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class TAIKHOAN_DAL
    {
        thaotac_csdl thaotac = new thaotac_csdl();
        string[] name = { };
        object[] value = { };
        public DataTable taikhoan_select()
        {
            return thaotac.sql_laydulieu("select_taikhoan");
        }
        public int taikhoan_insert(string MaTK, string TenTK, string MatKhau, string chucvu, string MaNV)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaTK"; value[0] = MaTK;
            name[1] = "@TenTK"; value[1] = TenTK;
            name[2] = "@MatKhau"; value[2] = MatKhau;
            name[3] = "@ChucVu"; value[3] = chucvu;
            name[4] = "@MaNV"; value[4] = MaNV;
            return thaotac.SQL_Thuchien("insert_taikhoan", name, value, 5);
        }
        public DataTable select_nhanvien_searchTenTK(string TenTK)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenTK"; value[0] = TenTK;
            return thaotac.SQL_LayDuLieu_codk("select_taikhoan_searchTenTK", name, value, 1);
        }
        public DataTable select_tennhanvien_theoTenTK(string TenTK)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenTK"; value[0] = TenTK;
            return thaotac.SQL_LayDuLieu_codk("select_tenNV_theoTenTK", name, value, 1);
        }
        public DataTable select_chucvu_theoTenNV(string TenNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenNV"; value[0] = TenNV;
            return thaotac.SQL_LayDuLieu_codk("select_chucvu_theoTenNV", name, value, 1);
        }
        public int taikhoan_update(string MaTK, string TenTK, string MatKhau, string chucvu, string MaNV)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaTK"; value[0] = MaTK;
            name[1] = "@TenTK"; value[1] = TenTK;
            name[2] = "@MatKhau"; value[2] = MatKhau;
            name[3] = "@ChucVu"; value[3] = chucvu;
            name[4] = "@MaNV"; value[4] = MaNV;
            return thaotac.SQL_Thuchien("update_taikhoan", name, value, 5);
        }
        public int taikhoan_delete(string MaTK)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaTK"; value[0] = MaTK;

            return thaotac.SQL_Thuchien("delete_taikhoan", name, value, 1);
        }
    }
}
