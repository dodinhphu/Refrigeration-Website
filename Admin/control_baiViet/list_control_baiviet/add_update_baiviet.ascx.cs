using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_baiViet.list_control_baiviet
{
    public partial class add_update_baiviet : System.Web.UI.UserControl
    {
        DB_connet.data.post data_post = new DB_connet.data.post();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_danh_muc();
            load_time();
            if (laymodulphu() == "addpost")
            {
                btn_them.Text = "Thêm Mới";
                text_them_or_add.InnerText = "Thêm Mới Bài Viết";
            }
            else
            {
                btn_them.Text = "UPDATE";
                text_them_or_add.InnerText = "UPDATE Bài Viết";
                hienthi_tt_sp_sua();
            }
        }
        public void hienthi_tt_sp_sua()
        {
            DataTable tb = new DataTable();
            tb = data_post.load_one_post(layid());
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txt_tieude.Text = tb.Rows[i]["tieudepost"].ToString().Trim();
                    txt_mota.Text = tb.Rows[i]["mota"].ToString().Trim();
                    list_dm.SelectedValue = tb.Rows[i]["madanhmuc"].ToString().Trim();
                    txt_ngaytao.Text = tb.Rows[i]["ngaytao"].ToString().Trim();
                 
                }
            }
        }
        public string laymodulphu()
        {
            if (Request.QueryString["modulphu"] != null)
            {
                return Request.QueryString["modulphu"].ToString();
            }
            return null;
        }
        public string layid()
        {
            if (Request.QueryString["id_post"] != null)
            {
                return Request.QueryString["id_post"].ToString();
            }
            return null;
        }
        public void load_danh_muc()
        {
            DB_connet.data.danhmuc data_dm= new DB_connet.data.danhmuc();
            DataTable tb = new DataTable();
            tb = data_dm.load_danhMuc();
            list_dm.Items.Clear();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                list_dm.Items.Add(new ListItem(tb.Rows[i]["tendanhmuc"].ToString().Trim(), tb.Rows[i]["madanhmuc"].ToString().Trim()));
            }
        }
        public void load_time()
        {
            txt_ngaytao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void btn_them_Click(object sender, EventArgs e)
        {
            if (up_anh.FileContent.Length > 0)
            {
                if (up_anh.FileName.EndsWith(".jpeg") || up_anh.FileName.EndsWith(".jpg") || up_anh.FileName.EndsWith(".png") || up_anh.FileName.EndsWith(".gif"))
                {
                    up_anh.SaveAs(Server.MapPath("img/img_post/") + up_anh.FileName);
                }
            }
            //code thêm sp
            if (laymodulphu () == "addpost")
            {
                Boolean a = data_post.add_post(txt_tieude.Text,list_dm.SelectedValue.ToString().Trim(),txt_ngaytao.Text.ToString().Trim(),txt_mota.Text,up_anh.FileName.ToString());
                if (a == true)
                {
                    tb.CssClass = "alert alert-success tb_css";
                    tb.Text = "Thêm Thành Công bài Viết : " + txt_tieude.Text;
                    txt_mota.Text = "";
                    txt_tieude.Text = "";
                   
                }
                else
                {
                    tb.CssClass = "alert alert-danger tb_css";
                    tb.Text = "Sửa Thất Bại";
                }
            }
            else
            {
                Boolean a = data_post.update_post(layid().ToString().Trim(), txt_tieude.Text.Trim(), list_dm.SelectedValue.ToString().Trim(), txt_ngaytao.Text.ToString().Trim(), txt_mota.Text, up_anh.FileName.ToString());
                if(a==true)
                {
                    tb.CssClass = "alert alert-success tb_css";
                    tb.Text = "UPDATE Thành Công Bài Viết : " + txt_tieude.Text;
                    txt_mota.Text = "";
                    txt_tieude.Text = "";
                }
                else
                {
                    tb.CssClass = "alert alert-danger tb_css";
                    tb.Text = "UPDATE Thất Bại";
                }
            }
        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx?modul=baiviet");
        }
    }
}
