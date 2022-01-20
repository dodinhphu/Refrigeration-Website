using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Home.load_chi_tiet_post
{
    public partial class details_post : System.Web.UI.UserControl
    {
        DB_connet.data.post data_post = new DB_connet.data.post();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = data_post.load_one_post(layid().Trim());
            for(int i =0;i<tb.Rows.Count;i++)
            {
                tieude.Text = tb.Rows[i]["tieudepost"].ToString();
                noi_dung_post.Text = tb.Rows[i]["mota"].ToString();
                ngaydang.Text = tb.Rows[i]["ngaytao"].ToString().Trim();
            }    

        }
        public string layid()
        {
            string id = "";
            if (Request.QueryString["id_post"] != null)
            {
                id = Request.QueryString["id_post"];
            }
            return id;
        }
    }
}