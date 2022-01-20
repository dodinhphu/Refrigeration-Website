using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_dien_lanh.DB_connet.data
{
    public class danhmuc
    {
        xl_chung dungchung = new xl_chung();
        // load toàn bộ các danh mục
        public DataTable load_danhMuc()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.danhmuc";   
            tb = dungchung.load_dulieu(sql);
            return tb;
        }

        // thêm danh mục
        public Boolean them_danhMuc( string tendanhmuc,string ngaythem)
        {
            string sql = " INSERT dbo.danhmuc VALUES ( N'" + tendanhmuc.Trim()+ "',CONVERT(DATE,'" + ngaythem + "',103) )  ";
            int a = dungchung.them_sua_xoa(sql);
            if(a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }


        // sửa danh mục
        public Boolean sua_danhMuc( string madanhmuc, string tendanhmuc,string ngaythem)
        {
            // kiểm tra Mã HS Có trong DS hay Không
            string sql = " UPDATE dbo.danhmuc SET tendanhmuc=N'" + tendanhmuc.Trim()+ "',ngaytao=CONVERT(DATE,'" + ngaythem + "',103) WHERE madanhmuc='"+madanhmuc.Trim()+"' ";
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


        // xóa danh mục
        public Boolean delete_danhMuc(string madanhmuc)
        {
            // kiểm tra Mã HS Có trong DS hay Không
            string sql = " DELETE dbo.danhmuc WHERE madanhmuc ='"+madanhmuc.Trim()+"' ";
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

        // load số bài post của từng danh mục
        public DataTable load_so_post()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT danhmuc.madanhmuc, COUNT(mapost) as sopost FROM dbo.danhmuc  left JOIN dbo.post ON post.madanhmuc = danhmuc.madanhmuc GROUP BY danhmuc.madanhmuc";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }

        // tìm kiếm 1 danh mục
        public DataTable seach_one_dm(string madm)
        {
            DataTable tb = new DataTable();
            string sql = " SELECT * FROM dbo.danhmuc WHERE madanhmuc="+int.Parse(madm.Trim())+" ";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }

        public DataTable load_so_lop_tk(string madanhmuc)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT danhmuc.madanhmuc,COUNT(mapost) AS sopost FROM dbo.danhmuc left JOIN dbo.post ON post.madanhmuc = danhmuc.madanhmuc WHERE danhmuc.madanhmuc = '" + madanhmuc + "' GROUP BY danhmuc.madanhmuc";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
    }

}