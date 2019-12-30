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
    public class HANGHOA_BLL
    {
        HANGHOA_DAL hhdal = new HANGHOA_DAL();
        public DataTable select_hanghoa()
        {
            return hhdal.select_hanghoa();
        }
        public int insert_hanghoa(string MaHH, string TenHH, float Dongia, int SLcon, string MaLH, byte[] image)
        {
            return hhdal.hanghoa_insert(MaHH,TenHH,Dongia,SLcon,MaLH,image);
        }
        public int update_hanghoa(string MaHH, string TenHH, float Dongia, int SLcon, string MaLH, byte[] image)
        {
            return hhdal.hanghoa_update(MaHH, TenHH, Dongia, SLcon, MaLH, image);
        }
        public int delete_hanghoa(string MaHH)
        {
            return hhdal.hanghoa_delete(MaHH);
        }
        public int update_hanghoa_kohinh(string MaHH, string TenHH, float Dongia, int SLcon, string MaLH)
        {
            return hhdal.hanghoa_update_kohinh(MaHH, TenHH, Dongia, SLcon, MaLH);
        }
        public int hanghoa_update_soluong(string MaHH, int SLcon)
        {
            return hhdal.hanghoa_update_soluong(MaHH, SLcon);
        }
        public DataTable select_hanghoa_theomlq(string MaLH)
        {
            return hhdal.select_hanghoa_theomlh(MaLH);
        }
        public DataTable select_hanghoa_theomh(string MaHH)
        {
            return hhdal.select_hanghoa_theomh(MaHH);
        }
    }
}
