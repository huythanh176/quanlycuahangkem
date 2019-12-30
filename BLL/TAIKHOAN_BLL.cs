using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class TAIKHOAN_BLL
    {
        TAIKHOAN_DAL tkdal = new TAIKHOAN_DAL();
        public DataTable taikhoan_select()
        {
            return tkdal.taikhoan_select();
        }
        public int taikhoan_insert(string MaTK, string TenTK, string MatKhau, string chucvu, string MaNV)
        {
            return tkdal.taikhoan_insert(MaTK, TenTK, MatKhau, chucvu, MaNV);
        }
        public DataTable select_taikhoan_searchTenTK(string TenTK)
        {
            return tkdal.select_nhanvien_searchTenTK(TenTK);
        }
        public DataTable select_tennhanvien_theoTenTK(string TenTK)
        {
            return tkdal.select_tennhanvien_theoTenTK(TenTK);
        }
        public DataTable select_chucvu_theoTenNV(string TenNV)
        {
            return tkdal.select_chucvu_theoTenNV(TenNV);
        }
        public int taikhoan_update(string MaTK, string TenTK, string MatKhau, string chucvu, string MaNV)
        {
            return tkdal.taikhoan_update(MaTK, TenTK, MatKhau, chucvu, MaNV);
        }
        public int taikhoan_delete(string MaTK)
        {
            return tkdal.taikhoan_delete(MaTK);
        }
    }
}
