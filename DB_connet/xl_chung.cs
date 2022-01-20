using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace web_dien_lanh.DB_connet
{
    public class xl_chung
    {
        string chuoikn = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public SqlConnection con;

        public xl_chung()
        {
            con = new SqlConnection(chuoikn);
        }
        public int them_sua_xoa(string sql)
        {
            SqlCommand coman = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)coman.ExecuteNonQuery();
            con.Close();
            return kq;
        }
        public int dangnhap(string sql)
        {
            SqlCommand coman = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)coman.ExecuteScalar();
            con.Close();
            return kq;
        }
        public DataTable load_dulieu(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}