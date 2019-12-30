using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BAN_DAL
    {
        public int chieurongban = 100;
        public int chieudaiban = 100;
        public int soluongban=25;
        thaotac_csdl thaotac = new thaotac_csdl();
        string[] name = { };
        Object[] value= { };
        public DataTable ban_select()
        {
            return thaotac.sql_laydulieu("select_ban");
        }
        public DataTable ban_select_theomaban(string MaBan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = MaBan;
            return thaotac.SQL_LayDuLieu_codk("select_tenban_theomaban", name, value, 1);
        }
        public DataTable ban_select_theotinhtrang(bool trangthai)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@trangthai"; value[0] = trangthai;
            return thaotac.SQL_LayDuLieu_codk("select_tenban_ckt", name, value, 1);
        }
        public int ban_insert(string MaBan,string TenBan,bool trangthai)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaBan"; value[0] = MaBan;
            name[1] = "@TenBan"; value[1] = TenBan;
            name[2] = "@trangthai"; value[2] = trangthai;
            return thaotac.SQL_Thuchien("insert_ban", name, value, 3);
        }
        public int ban_update(string MaBan,bool trangthai)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBan"; value[0] = MaBan;
            name[1] = "@trangthai"; value[1] = trangthai;
            return thaotac.SQL_Thuchien("update_tinhtrangban", name, value, 2);
        }
        public int ban_delete(string MaBan)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBan"; value[0] = MaBan;
            
            return thaotac.SQL_Thuchien("delete_ban", name, value, 1);
        }
    }
   
}
