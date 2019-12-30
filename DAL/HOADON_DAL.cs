using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class HOADON_DAL
    {
        thaotac_csdl thaotac = new thaotac_csdl();
        string[] name = { };
        object[] value = { };
        public DataTable hoadon_select()
        {
            return thaotac.sql_laydulieu("select_hoadon");
        }
        public DataTable select_mahd_theomban(string MaBan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = MaBan;
            return thaotac.SQL_LayDuLieu_codk("select_mahoadon_theomaban", name, value, 1);
        }
        public DataTable select_hoadon_search(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = MaHD;
            return thaotac.SQL_LayDuLieu_codk("select_hoadon_searchMaHD", name, value, 1);
        }
        public DataTable select_hoadon_giua2ngay(DateTime ngaybatdau,DateTime ngayketthuc)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@NgayBatDau"; value[0] = ngaybatdau;
            name[1] = "@NgayKetThuc"; value[1] = ngayketthuc;
            return thaotac.SQL_LayDuLieu_codk("select_hoadon_giua2ngay", name, value, 2);
        }
        public DataTable select_hoadon_tenhangvssl(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ngaybatdau"; value[0] = ngaybatdau;
            name[1] = "@ngaykethuc"; value[1] = ngayketthuc;
            return thaotac.SQL_LayDuLieu_codk("select_cthd_tk_tenhangvsSl", name, value, 2);
        }
        public int hoadon_insert(string MaHD, DateTime NgayHD, string MaNV, string MaBan,string TinhTrang)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@NgayHD"; value[1] = NgayHD;
            name[2] = "@MaNV"; value[2] = MaNV;
            name[3] = "@MaBan"; value[3] = MaBan;
            name[4] = "@TinhTrang"; value[4] = TinhTrang;
            return thaotac.SQL_Thuchien("insert_hoadon", name, value, 5);
        }
       
        public int hoadon_update(string MaHD, DateTime NgayHD, string MaNV, string MaBan,string TinhTrang)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@NgayHD"; value[1] = NgayHD;
            name[2] = "@MaNV"; value[2] = MaNV;
            name[3] = "@MaBan"; value[3] = MaBan;
            name[4] = "@TinhTrang"; value[4] = TinhTrang;
            return thaotac.SQL_Thuchien("update_hoadon", name, value, 5);
        }
        public int hoadon_update_tinhtrang( string MaBan, string TinhTrang)
        {
            name = new string[2];
            value = new object[2];
           
            name[0] = "@MaBan"; value[0] = MaBan;
            name[1] = "@TinhTrang"; value[1] = TinhTrang;
            return thaotac.SQL_Thuchien("update_hoadon_tinhtrang", name, value, 2);
        }
        public int hoadon_update_gopban(string MaHD, string MaHDmoi)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaHD"; value[0] = MaHDmoi;
            name[1] = "@MaHDcu"; value[1] = MaHD;
            return thaotac.SQL_Thuchien("update_hoadon_gopban", name, value, 2);
        }
        public int hoadon_update_chuyenban(string MaHD, string MaBan)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaHD"; value[0] = MaHD;
            name[1] = "@MaBan"; value[1] = MaBan;
            return thaotac.SQL_Thuchien("update_hoadon_chuyenban", name, value, 2);
        }
        public int hoadon_delete(string MaHD)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD"; value[0] = MaHD;
            return thaotac.SQL_Thuchien("delete_hoadon", name, value, 1);
        }
    }
}
