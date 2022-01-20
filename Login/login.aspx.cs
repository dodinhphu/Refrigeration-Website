using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh
{
    public partial class login : System.Web.UI.Page
    {
        DB_connet.data.login data_login = new DB_connet.data.login();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = data_login.check_login(txt_username.Text.Trim(), txt_pass.Text.Trim());
            if (tb.Rows.Count > 0)
            {
                Session["dangnhap"] = "1";
                Session["username"] = tb.Rows[0]["username"].ToString().Trim();
                Response.Redirect("/Admin.aspx");
            }
            else
            {
                tb_tb.CssClass = "alert alert-danger tb_css";
                tb_tb.Text = "Tài Khoản Hoặc Mật Khẩu Không Chính Xác !!!";
                txt_pass.Text = "";
            }
        }

        protected void btn_thoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("/home.aspx");
        }
    }
}