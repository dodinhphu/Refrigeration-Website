using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace web_dien_lanh.DB_connet.data
{
    public class post
    {
        xl_chung dungchung = new xl_chung();


        // load toàn bộ bài post
        public DataTable load_post()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.post";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        // load 1 bài post
        public DataTable load_one_post(string mapost)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.post WHERE mapost=" + int.Parse(mapost.Trim()) + " ";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        // thêm bài post
        public Boolean add_post(string tieude, string madanhmuc, string ngaytao, string mota, string tenanh)
        {
            string sql = "INSERT dbo.post VALUES ( N'" + tieude.Trim() + "'," + int.Parse(madanhmuc.Trim()) + ", CONVERT(DATE,'" + ngaytao + "',103),N'" + mota.Trim() + "',N'" + tenanh.Trim() + "')";
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

        // sửa bài post
        public Boolean update_post(string mabaipost, string tieude, string madanhmuc, string ngaytao, string mota, string tenanh)
        {
            string sql = " UPDATE dbo.post SET tieudepost=N'" + tieude.Trim() + "',madanhmuc=" + int.Parse(madanhmuc.Trim()) + ",ngaytao=CONVERT(DATE,'" + ngaytao + "',103),mota=N'" + mota.Trim() + "',tenanh='" + tenanh.Trim() + "' WHERE mapost=" + int.Parse(mabaipost.Trim()) + " ";
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


        // xóa bài post
        public Boolean delete_post(string mabaipost)
        {
            string sql = " DELETE dbo.post WHERE mapost=" + int.Parse(mabaipost.Trim()) + " ";
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

        // tìm tên danh mục
        public DataTable seach_name_dm(string madm)
        {
            DataTable tb = new DataTable();
            string sql = " SELECT * FROM dbo.danhmuc WHERE madanhmuc = " + int.Parse(madm) + " ";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }

        // tìm post them danh mục
        public DataTable seach_theo_dm(string madm)
        {
            DataTable tb = new DataTable();
            string sql = " SELECT * FROM dbo.post WHERE madanhmuc="+int.Parse(madm)+" ";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
    }
}