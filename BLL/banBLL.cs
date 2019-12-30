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
    public class banBLL
    {
        public BAN_DAL bandal = new BAN_DAL();
        public DataTable select_ban()
        {
            return bandal.ban_select();
        }
        public DataTable ban_select_theomaban(string MaBan)
        {
            return bandal.ban_select_theomaban(MaBan);
        }
        public DataTable ban_select_theotinhtrang(bool trangthai)
        {
            return bandal.ban_select_theotinhtrang(trangthai);
        }
        public int ban_insert(string MaBan, string TenBan, bool trangthai)
        {
            return bandal.ban_insert(MaBan, TenBan, trangthai);
        }
        public int ban_update(string MaBan,bool trangthai)
        {
            return bandal.ban_update(MaBan, trangthai);
        }
        public int ban_delete(string MaBan)
        {
            return bandal.ban_delete(MaBan);
        }
    }
}
