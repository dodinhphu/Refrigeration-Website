using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.ajax
{
    public partial class thao_tac_DanhMuc1 : System.Web.UI.Page
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
                case "xoadanhmuc":
                    xoadanhmuc();
                    break;
            }
        }

        private void xoadanhmuc()
        {
            string ma = "";
            if (Request.Params["ma"] != null)
            {
                ma = Request.Params["ma"];
            }
            DB_connet.data.danhmuc data_danhmuc = new DB_connet.data.danhmuc();

            DataTable tb = new DataTable();
            tb = data_danhmuc.load_so_lop_tk(ma);

            if (tb.Rows[0]["sopost"].ToString().Trim() == "0")
            {
                data_danhmuc.delete_danhMuc(ma);
                Response.Write("1");
            }
            else
            {
                Response.Write("0");
            }

        }
    }
}