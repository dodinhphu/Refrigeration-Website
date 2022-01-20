using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Home.load_theo_dm
{
    public partial class one_load : System.Web.UI.UserControl
    {
        DB_connet.data.post data_post = new DB_connet.data.post();
        DB_connet.data.danhmuc data_dm = new DB_connet.data.danhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tb_dm = new DataTable();
            tb_dm = data_dm.seach_one_dm(layid().Trim());
            for (int i = 0; i < tb_dm.Rows.Count; i++)
            {
                list_post.Text += @"
                        <div class='row mb-md-5 all_card'>
                             <div class='title-cathome clearfix' style='margin-top:20px;'>
                                <div class='title-con'>
                                    <a href='home.aspx?modul=details_dm&id_dm=" + tb_dm.Rows[i]["madanhmuc"].ToString().Trim() + @"' title='danh mục'>
                                                <span class='ttten'>
                                                    " + tb_dm.Rows[i]["tendanhmuc"].ToString().Trim() + @"
                                                </span>
                                    </a>
                                </div>
                             </div>
                               " + load_post(tb_dm.Rows[i]["madanhmuc"].ToString()) + @"
                        </div>
                   ";
            }
        }
        public string layid()
        {
            string id = "";
            if (Request.QueryString["id_dm"] != null)
            {
                id = Request.QueryString["id_dm"];
            }
            return id;
        }    
        public string load_post(string madm)
        {
            string a = "";
            DataTable tb_post = new DataTable();
            tb_post = data_post.seach_theo_dm(madm);
            for (int i = 0; i < tb_post.Rows.Count; i++)
            {
                a += @"
                 <div class='col-md-6 col-xs-12 magin_css ' >
                     <a class='link_card_cha' href='home.aspx?modul=details_post&id_post=" + tb_post.Rows[i]["mapost"].ToString().Trim() + @"'>
                              <div class='card' style='width: 100 %; height: 100 % '>
                                      <img class='img_card' style='max-height: 300px;min-height: 300px;width:100%'
                                        src='../../img/img_post/" + tb_post.Rows[i]["tenanh"].ToString().Trim() + @"'>
                                    <div class='card-body'>
                                        <div class='thesc'>
                                            <p class='card_text'>Sửa Chữa</p>
                                        </div>
                                        <a href = 'home.aspx?modul=details_post&id_post=" + tb_post.Rows[i]["mapost"].ToString().Trim() + @"' class='card-title card_tieude'>" + tb_post.Rows[i]["tieudepost"].ToString().Trim() + @"</a>
                                        <p class='card_text_time'>" + tb_post.Rows[i]["ngaytao"].ToString().Trim() + @"</p>
                                    </div>
                                </div>
                     </a>
                </div>
                ";
            }
            return a;
        }
    }
}