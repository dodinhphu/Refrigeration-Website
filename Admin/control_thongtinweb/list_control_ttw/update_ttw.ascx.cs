using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_thongtinweb.list_control_ttw
{
    public partial class update_ttw : System.Web.UI.UserControl
    {
        DB_connet.data.thongtinweb data_ttw = new DB_connet.data.thongtinweb();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_ttw();

        }
        public void load_ttw()
        {
            DataTable tb = new DataTable();
            tb = data_ttw.laytt_ttweb();
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txt_tenweb.Text = tb.Rows[i]["tenweb"].ToString().Trim();
                    txt_emailkt.Text = tb.Rows[i]["emailkythuat"].ToString().Trim();
                    txt_sdtkt.Text = tb.Rows[i]["sdtkythuat"].ToString().Trim();
                    txt_diachi1.Text = tb.Rows[i]["diachi1"].ToString().Trim();
                    txt_diachi2.Text = tb.Rows[i]["diachi2"].ToString().Trim();
                    txt_diachi3.Text = tb.Rows[i]["diachi3"].ToString().Trim();
                    txt_diachi4.Text = tb.Rows[i]["diachi4"].ToString().Trim();
                    txt_diachi5.Text = tb.Rows[i]["diachi5"].ToString().Trim();
                    txt_diachi6.Text = tb.Rows[i]["diachi6"].ToString().Trim();
                }
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            Boolean a = data_ttw.update_ttweb(txt_tenweb.Text,txt_sdtkt.Text,txt_emailkt.Text,txt_diachi1.Text, txt_diachi2.Text, txt_diachi3.Text, txt_diachi4.Text, txt_diachi5.Text, txt_diachi6.Text);
            if (a == true)
            {
                tb.CssClass = "alert alert-success tb_css";
                tb.Text = "Đã UPDATE Thành Công Thông Tin WebSite";
                txt_tenweb.Text = "";
                txt_emailkt.Text ="";
                txt_sdtkt.Text ="";
                txt_diachi1.Text = "";
                txt_diachi2.Text = "";
                txt_diachi3.Text = "";
                txt_diachi4.Text = "";
                txt_diachi5.Text = "";
                txt_diachi6.Text = "";
            }
            else
            {
                tb.CssClass = "alert alert-danger tb_css";
                tb.Text = "UPDATE Thất Bại";
            }
        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx?modul=thongtinweb");
        }
    }
}