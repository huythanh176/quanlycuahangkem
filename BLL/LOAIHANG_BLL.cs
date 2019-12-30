using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace BLL
{
    public class LOAIHANG_BLL
    {
        LOAIHANG_DAL lhdal = new LOAIHANG_DAL();
        public DataTable select_loaihang()
        {
            return lhdal.loaihang_select();
        }
        public int insert_loaihang(string MaLH, string TenLH, string Ghichu, byte[] image)
        {
            return lhdal.loaihang_insert(MaLH, TenLH, Ghichu, image);
        }
        public int loaihang_update(string MaLH, string TenLH, string Ghichu, byte[] image)
        {
            return lhdal.loaihang_update(MaLH, TenLH, Ghichu, image);
        }
        public int loaihang_delete(string MaLH)
        {
            return lhdal.loaihang_delete(MaLH);
        }
        public int loaihang_update_kohinh(string MaLH, string TenLH, string Ghichu)
        {
            return lhdal.loaihang_update_kohinh(MaLH, TenLH, Ghichu);
        }
    }
}
