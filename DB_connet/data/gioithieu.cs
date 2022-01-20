using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace web_dien_lanh.DB_connet.data
{
    public class gioithieu
    {
        xl_chung dungchung = new xl_chung();
        public DataTable load()
        {
            DataTable tb = dungchung.load_dulieu("SELECT * FROM dbo.GioiThieu");
            return tb;
        }
        public Boolean update(string noidung)
        {
            // kiểm tra Mã HS Có trong DS hay Không
            string sql = " UPDATE dbo.GioiThieu SET noidung=N'" + noidung.Trim() + "' WHERE id='"+0.ToString().Trim()+"' ";
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
    }
}