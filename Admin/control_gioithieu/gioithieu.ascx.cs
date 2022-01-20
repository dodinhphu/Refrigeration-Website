using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.contro_gioithieu
{
    public partial class gioithieu : System.Web.UI.UserControl
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
                
                case "update_gioithieu":
                    dieuhuong_gioithieu.Controls.Add(LoadControl("list_gioithieu/update_gioithieu.ascx"));
                    break;
                default:
                    dieuhuong_gioithieu.Controls.Add(LoadControl("list_gioithieu/show_gioithieu.ascx"));
                    break;

            }
        }
    }
}