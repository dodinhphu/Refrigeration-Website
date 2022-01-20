using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_danhMuc.list_control_danhmuc
{
    public partial class add_update_danhmuc : System.Web.UI.UserControl
    {
        DB_connet.data.danhmuc data_dm = new DB_connet.data.danhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (laymodul() == "add_danhmuc")
            {
                txt_ngaytao.Text = DateTime.Now.Date.ToString();
                btn_them.Text = "Thêm Mới";
                text_them_or_add.InnerText = "Thêm Danh Mục Mới";
            }
            else
            {
                btn_them.Text = "UPDATE";
                text_them_or_add.InnerText = "Sửa Danh Mục";
                hienthi_tt_dm_sua();
            }
        }

        // lấy module 
        public string laymodul()
        {
            if (Request.QueryString["modulphu"] != null)
            {
                return Request.QueryString["modulphu"].ToString();
            }
            return null;
        }
        // lấy id update
        public string layid()
        {
            if (Request.QueryString["id_dm"] != null)
            {
                return Request.QueryString["id_dm"].ToString();
            }
            return null;
        }

        // hiên thị tt cũ
        public void hienthi_tt_dm_sua()
        {
            DataTable tb = new DataTable();
            tb = data_dm.seach_one_dm(layid());
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txt_tendm.Text = tb.Rows[i]["tendanhmuc"].ToString().Trim();
                    txt_ngaytao.Text = tb.Rows[i]["ngaytao"].ToString();
                }
            }
        }
        // thêm hoăc sửa danh mục
        protected void btn_them_Click(object sender, EventArgs e)
        {
            if (laymodul() == "add_danhmuc")
            {
                Boolean a = data_dm.them_danhMuc(txt_tendm.Text.ToString().Trim(), txt_ngaytao.Text.ToString().Trim());
                if (a == true)
                {
                    tb.CssClass = "alert alert-success tb_css";
                    tb.Text = "Thêm Thành Công Danh Mục: " + txt_tendm.Text;
                    txt_tendm.Text = "";
                }
                else
                {
                    tb.CssClass = "alert alert-danger tb_css";
                    tb.Text = "Sửa Thất Bại";
                }
            }
            else
            {
                Boolean a = data_dm.sua_danhMuc(layid().ToString().Trim(), txt_tendm.Text.Trim(),txt_ngaytao.Text.Trim()) ;
                if (a == true)
                {
                    tb.CssClass = "alert alert-success tb_css";
                    tb.Text = "Đã UPDATE Thành Công Danh Muc : " + txt_tendm.Text;
                    txt_tendm.Text = "";
                    txt_ngaytao.Text = "";
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
            Response.Redirect("admin.aspx?modul=danhmuc");
        }
    }
}