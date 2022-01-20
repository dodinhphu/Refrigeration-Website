using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_baiViet
{
    public partial class baiviet : System.Web.UI.UserControl
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
                case "updatepost":
                    dieu_huong_baiviet.Controls.Add(LoadControl("list_control_baiviet/add_update_baiviet.ascx"));
                    break;
                case "addpost":
                    dieu_huong_baiviet.Controls.Add(LoadControl("list_control_baiviet/add_update_baiviet.ascx"));
                    break;
                default:
                    dieu_huong_baiviet.Controls.Add(LoadControl("list_control_baiviet/show_post.ascx"));
                    break;

            }
        }
    }
}