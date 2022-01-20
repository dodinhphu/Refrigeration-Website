using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_danhMuc
{
    public partial class danhmuc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string modulphu = "";
            if (Request.QueryString["modulphu"] != null)
            {
                modulphu = Request.QueryString["modulphu"];
            }

            switch (modulphu)
            {
                case "add_danhmuc":
                    dieu_huong_list_dm.Controls.Add(LoadControl("list_control_danhmuc/add_update_danhmuc.ascx"));
                    break;
                case "update_danhmuc":
                    dieu_huong_list_dm.Controls.Add(LoadControl("list_control_danhmuc/add_update_danhmuc.ascx"));
                    break;
                default:
                    dieu_huong_list_dm.Controls.Add(LoadControl("list_control_danhmuc/show_danhMuc.ascx"));
                    break;

            }
        }
    }
}