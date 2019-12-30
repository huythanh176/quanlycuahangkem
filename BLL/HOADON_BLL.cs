using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class HOADON_BLL
    {
        HOADON_DAL hddal = new HOADON_DAL();
        public DataTable select_hoadon()
        {
            return hddal.hoadon_select();
        }
        public int insert_noadon(string MaHD, DateTime NgayHD, string MaNV, string MaBan,string TinhTrang)
        {
            return hddal.hoadon_insert(MaHD, NgayHD, MaNV, MaBan,TinhTrang);
        }
        public int hoadon_update(string MaHD, DateTime NgayHD, string MaNV, string MaBan,string TinhTrang)
        {
            return hddal.hoadon_update(MaHD, NgayHD, MaNV, MaBan,TinhTrang);
        }
        public int loaihang_delete(string MaHD)
        {
            return hddal.hoadon_delete(MaHD);
        }
        public int hoadon_update_tinhtrang(string MaBan, string TinhTrang)
        {
            return hddal.hoadon_update_tinhtrang(MaBan, TinhTrang);
        }
        public DataTable select_mahd_theomban(string MaBan)
        {
            return hddal.select_mahd_theomban(MaBan);
        }
        public DataTable select_hoadon_search(string MaHD)
        {
            return hddal.select_hoadon_search(MaHD);
        }
        public DataTable select_hoadon_giua2ngay(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return hddal.select_hoadon_giua2ngay(ngaybatdau, ngayketthuc);
        }
        public DataTable select_hoadon_tenhangvssl(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return hddal.select_hoadon_tenhangvssl(ngaybatdau, ngayketthuc);
        }
        public int hoadon_update_gopban(string MaHD, string MaHDmoi)
        {
            return hddal.hoadon_update_gopban(MaHD,MaHDmoi);
        }
        public int hoadon_update_chuyenban(string MaHD, string MaBan)
        {
            return hddal.hoadon_update_chuyenban(MaHD, MaBan);
        }
    }
}
