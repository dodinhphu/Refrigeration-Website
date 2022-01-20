using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace web_dien_lanh.DB_connet.data
{
    public class thongtinweb
    {
        xl_chung dungchung = new xl_chung();

        // load thông tin web
        public DataTable load_ttweb()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.thongtinweb ";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }

        // update thông tin web
        public Boolean update_ttweb(string tenweb,string sdt_kythuat,string email_kt,string diachi1, string diachi2, string diachi3, string diachi4, string diachi5, string diachi6)
        {
            // kiểm tra Mã HS Có trong DS hay Không
            string sql = " UPDATE dbo.thongtinweb SET tenweb=N'" + tenweb.Trim()+"',sdtkythuat='"+sdt_kythuat.Trim()+"',emailkythuat='"+email_kt.Trim()+"',diachi1=N'" + diachi1.Trim() + "',diachi2=N'" + diachi2.Trim() + "',diachi3=N'" + diachi3.Trim() + "',diachi4=N'" + diachi4.Trim() + "',diachi5=N'" + diachi5.Trim() + "',diachi6=N'" + diachi6.Trim() + "' WHERE id=0 ";
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
        // lấy tt
        public DataTable laytt_ttweb()
        {
            // kiểm tra Mã HS Có trong DS hay Không
            string sql = "select * from dbo.thongtinweb WHERE id=0  ";
            DataTable a = dungchung.load_dulieu(sql);
            return a;

        }
    }
}