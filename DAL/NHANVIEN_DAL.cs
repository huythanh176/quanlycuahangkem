using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class NHANVIEN_DAL
    {
        thaotac_csdl thaotac = new thaotac_csdl();
        string[] name = { };
        object[] value = { };
        public DataTable nhanvien_select()
        {
            return thaotac.sql_laydulieu("select_nhanvien");
        }
        public DataTable select_nhanvien_searchTenNV(string TenNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenNV"; value[0] = TenNV;
            return thaotac.SQL_LayDuLieu_codk("select_nhanvien_searchTenNV", name, value, 1);
        }
        public int nhanvien_insert(string MaNV, string TenNV, DateTime ngaysinh, bool gioitinh, string sdt)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@TenNV"; value[1] = TenNV;
            name[2] = "@NgaySinh"; value[2] = ngaysinh;
            name[3] = "@GioiTinh"; value[3] = gioitinh;
            name[4] = "@SDT"; value[4] = sdt;
            return thaotac.SQL_Thuchien("insert_nhanvien", name, value, 5);
        }
        public int nhanvien_update(string MaNV, string TenNV, DateTime ngaysinh, bool gioitinh, string sdt)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@TenNV"; value[1] = TenNV;
            name[2] = "@NgaySinh"; value[2] = ngaysinh;
            name[3] = "@GioiTinh"; value[3] = gioitinh;
            name[4] = "@SDT"; value[4] = sdt;
            return thaotac.SQL_Thuchien("update_nhanvien", name, value, 5);
        }
        public int nhanvien_delete(string MaNV)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaNV"; value[0] = MaNV;

            return thaotac.SQL_Thuchien("delete_nhanvien", name, value, 1);
        }
    }
}
