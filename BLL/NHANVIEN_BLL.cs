using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class NHANVIEN_BLL
    {   NHANVIEN_DAL nvdal = new NHANVIEN_DAL();
        public DataTable nhanvien_select()
        {
            return nvdal.nhanvien_select();
        }
        public DataTable select_nhanvien_searchTenNV(string TenNV)
        {
            return nvdal.select_nhanvien_searchTenNV(TenNV);
        }
        public int nhanvien_insert(string MaNV, string TenNV, DateTime ngaysinh, bool gioitinh, string sdt)
        {
            return nvdal.nhanvien_insert(MaNV, TenNV, ngaysinh, gioitinh, sdt);
        }
        public int nhanvien_update(string MaNV, string TenNV, DateTime ngaysinh, bool gioitinh, string sdt)
        {
            return nvdal.nhanvien_update(MaNV, TenNV, ngaysinh, gioitinh, sdt);
        }
        public int nhanvien_delete(string MaNV)
        {
            return nvdal.nhanvien_delete(MaNV);
        }
    }
}
