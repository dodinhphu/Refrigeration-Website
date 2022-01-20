using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["dangnhap"]!= null && Session["dangnhap"].ToString().Trim()=="1")
            {
                // da dang nhap
            }
            else
            {
                Response.Redirect("/Login/login.aspx");
            }
            if (!IsPostBack)
            {
                userName.Text = Session["username"].ToString().Trim();
            }
        }

        protected void txt_dang_xuat_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["dangnhap"] = null;
            Response.Redirect("/Login/login.aspx");
        }
    }
}