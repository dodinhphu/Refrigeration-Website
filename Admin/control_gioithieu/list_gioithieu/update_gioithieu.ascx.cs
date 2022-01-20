using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.contro_gioithieu
{
    public partial class update_gioithieu : System.Web.UI.UserControl
    {
        DB_connet.data.gioithieu data = new DB_connet.data.gioithieu();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_gt();
        }
        public void load_gt()
        {
            DataTable tb = new DataTable();
            tb = data.load();
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txt_noidung.Text = tb.Rows[i]["noidung"].ToString();
                }
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            Boolean a = data.update(txt_noidung.Text);
            if (a == true)
            {
                tb.CssClass = "alert alert-success tb_css";
                tb.Text = "Đã UPDATE Thành Công";
                txt_noidung.Text = "";
            }
            else
            {
                tb.CssClass = "alert alert-danger tb_css";
                tb.Text = "UPDATE Thất Bại";
            }
        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx?modul=gioithieu");
        }
    }
}