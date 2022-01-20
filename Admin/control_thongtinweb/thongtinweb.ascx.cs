using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_thongtinweb
{
    public partial class thongtinweb : System.Web.UI.UserControl
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
                case "update_ttw":
                    load_ttw.Controls.Add(LoadControl("list_control_ttw/update_ttw.ascx"));
                    break;
                default:
                    load_ttw.Controls.Add(LoadControl("list_control_ttw/show_ttw.ascx"));
                    break;

            }
        }
    }
}