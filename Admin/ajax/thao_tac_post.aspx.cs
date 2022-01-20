using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.ajax
{
    public partial class thao_tac_post : System.Web.UI.Page
    {
        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["dangnhap"] != null && Session["dangnhap"].ToString().Trim() == "1")
            {
                // da dang nhap
            }
            else
            {
                return;
            }
            // thực hiện code
            if (Request.Params["thaotac"] != null)
            {
                thaotac = Request.Params["thaotac"];
            }
            switch (thaotac)
            {
                case "xoapost":
                    xoapost();
                    break;
            }
        }
        private void xoapost()
        {
            string ma = "";
            if (Request.Params["ma"] != null)
            {
                ma = Request.Params["ma"];
            }
            DB_connet.data.post data_post = new DB_connet.data.post();
            Boolean a = data_post.delete_post(ma);
            if (a == true)
            {
                Response.Write("1");
            }
            else
            {
                Response.Write("0");
            }

        }
    }
}