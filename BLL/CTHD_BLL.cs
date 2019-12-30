using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CTHD_BLL
    {
        CTHD_DAL cthddal = new CTHD_DAL();
        public DataTable select_CTHD()
        {
            return cthddal.CTHD_select();
        }
        public DataTable CTHD_select_theoban_ckt(string MaBan)
        {
            return cthddal.CTHD_select_theoban_ckt(MaBan);
        }
        public DataTable CTHD_select_theoMAHD(string MaHD)
        {
            return cthddal.CTHD_select_theoMAHD(MaHD);
        }
        public DataTable CTHD_select_chitiet(string MaHD)
        {
            return cthddal.CTHD_select_chitiet(MaHD);
        }
        public int insert_cthd(string MaHD, string MaHang, int SL)
        {
            return cthddal.CTHD_insert(MaHD, MaHang, SL);
        }
        public int cthd_update(string MaHD, string MaHang, int SL)
        {
            return cthddal.CTHD_update(MaHD, MaHang, SL);
        }
        public int cthd_delete(string MaHD, string MaHang)
        {
            return cthddal.CTHD_delete(MaHD,MaHang);
        }
    }
}
