using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Home
{
    public partial class home_dieuhuong : System.Web.UI.UserControl
    {
        DB_connet.data.danhmuc data_dm = new DB_connet.data.danhmuc();
        DB_connet.data.thongtinweb data_ttw = new DB_connet.data.thongtinweb();
        DB_connet.data.post data_post = new DB_connet.data.post();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_ttw();
            load_dm_home();
            string modul = "";
            if (Request.QueryString["modul"] != null)
            {
                modul = Request.QueryString["modul"];
            }

            switch (modul)
            {
               
                case "details_dm":
                    load_content_home.Controls.Add(LoadControl("load_theo_dm/one_load.ascx"));
                    break;
                case "details_post":
                    load_content_home.Controls.Add(LoadControl("load_chi_tiet_post/details_post.ascx"));
                    break;
                default:
                    load_content_home.Controls.Add(LoadControl("load_theo_dm/all_dm.ascx"));
                    break;

            }
        }
        public void load_dm_home()
        {
            DataTable tb_dm = new DataTable();
            tb_dm = data_dm.load_danhMuc();
            for(int i=0;i<tb_dm.Rows.Count;i++)
            {
                list_dm.Text += @"
                 <a href='home.aspx?modul=details_dm&id_dm= " + tb_dm.Rows[i]["madanhmuc"].ToString().Trim() + @"'>   <ul class='list_danhmuc'>
                        <p class='ten_dm'>
                            <i class='fas fa-tools icon_ct'></i>
                            <strong> " + tb_dm.Rows[i]["tendanhmuc"].ToString().Trim() + @"</strong>
                        </p>
                        " + load_post(tb_dm.Rows[i]["madanhmuc"].ToString().Trim()) + @"
                    </ul></a>
                ";

            }
        }
        public string load_post(string dm)
        {
            string daura = "";
            DataTable tb_post = data_post.seach_theo_dm(dm);
            for (int j = 0; j < tb_post.Rows.Count; j++)
            {
                daura += @"
                        <li class='item_dm'>
                            <a class='item_dm1' href='home.aspx?modul=details_post&id_post=" + tb_post.Rows[j]["mapost"].ToString().Trim()+@"'>" + tb_post.Rows[j]["tieudepost"]+@"</a>
                        </li>
                ";
            }
            return daura;

        }
        public void load_ttw()
        {
            DataTable tb_ttw = new DataTable();
            tb_ttw = data_ttw.load_ttweb();
            sdt_kt.Text = tb_ttw.Rows[0]["sdtkythuat"].ToString().Trim();
            emai_kt.Text = tb_ttw.Rows[0]["emailkythuat"].ToString().Trim();
            _sdt_kt.Text = tb_ttw.Rows[0]["sdtkythuat"].ToString().Trim();
            _email_kt.Text= tb_ttw.Rows[0]["emailkythuat"].ToString().Trim();
        }
    }
}