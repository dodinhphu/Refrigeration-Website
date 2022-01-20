using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin
{
    public partial class dieu_huong : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string modul = "";
            if (Request.QueryString["modul"] != null)
            {
                modul = Request.QueryString["modul"];
            }

            switch (modul)
            {
                case "baiviet":
                    admin_dieu_huong.Controls.Add(LoadControl("control_baiViet/baiviet.ascx"));
                    break;
                case "danhmuc":
                    admin_dieu_huong.Controls.Add(LoadControl("control_danhMuc/danhmuc.ascx"));
                    break;
                case "taikhoan":
                    admin_dieu_huong.Controls.Add(LoadControl("control_taiKhoan/taikhoan.ascx"));
                    break;
                case "thongtinweb":
                    admin_dieu_huong.Controls.Add(LoadControl("control_thongtinweb/thongtinweb.ascx"));
                    break;
                case "gioithieu":
                    admin_dieu_huong.Controls.Add(LoadControl("control_gioithieu/gioithieu.ascx"));
                    break;
                default:
                    admin_dieu_huong.Controls.Add(LoadControl("control_adminHome/adminhome.ascx"));
                    break;

            }
        }
    }
}