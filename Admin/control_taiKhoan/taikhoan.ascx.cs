using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_taiKhoan
{
    public partial class taikhoan : System.Web.UI.UserControl
    {
        DB_connet.data.login data_login = new DB_connet.data.login();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_capnhat_Click(object sender, EventArgs e)
        {
            Boolean kt = data_login.check_mk(txt_mkCu.Text.Trim());
            if(kt==false)
            {
                tb.CssClass = "alert alert-danger tb_css";
                tb.Text = "Sai Mật Khẩu Cũ";
                txt_ktMK.Text = "";
                txt_mkCu.Text = "";
                txt_mkMoi.Text = "";
            }
            else
            {
                Boolean a = data_login.update_tk(txt_ktMK.Text.Trim());
                if (a == true)
                {
                    tb.CssClass = "alert alert-success tb_css";
                    tb.Text = "Đỗi Mật Khẩu Thành Công";
                    txt_ktMK.Text = "";
                    txt_mkCu.Text = "";
                    txt_mkMoi.Text = "";
                }
                else
                {
                    tb.CssClass = "alert alert-danger tb_css";
                    tb.Text = "Đỗi Mật Khẩu Thất Bại";
                }
            }
           
        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx?modul=taikhoan");
        }
    }
}