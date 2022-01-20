using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace web_dien_lanh.DB_connet.data
{
    public class login
    {
        xl_chung dungchung = new xl_chung();
        public DataTable check_login(string username,string password)
        {
            DataTable tb = new DataTable();
            string sql = " SELECT * FROM dbo.account WHERE username='" + username.Trim() + "' AND password ='" + password.Trim() + "' ";
            tb = dungchung.load_dulieu(sql);
            return tb;
                
        }
        public Boolean update_tk(string mkmoi)
        {
            string sql = " UPDATE dbo.account SET password='" + mkmoi.Trim() + "' WHERE username='admin' ";
            int a = dungchung.them_sua_xoa(sql);
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean check_mk( string password)
        {
            DataTable tb = new DataTable();
            string sql = " SELECT * FROM dbo.account WHERE username='admin' AND password ='" + password.Trim() + "' ";
            tb = dungchung.load_dulieu(sql);
            if(tb.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}