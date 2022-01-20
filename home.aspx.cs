using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh
{
    public partial class home : System.Web.UI.Page
    {
        DB_connet.data.thongtinweb data_ttw = new DB_connet.data.thongtinweb();
        DB_connet.data.danhmuc data_dm = new DB_connet.data.danhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_ttw();
            load_dv();
            load_lien_he();
        }
        public void load_ttw()
        {
            DataTable tb = new DataTable();
            tb = data_ttw.load_ttweb();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                ten_web.Text = tb.Rows[0]["tenweb"].ToString().Trim();
                dia_chi.Text = tb.Rows[0]["diachi1"].ToString().Trim();
                sdt_kt.Text = tb.Rows[0]["sdtkythuat"].ToString().Trim();
                sdt_lh.Text = tb.Rows[0]["sdtkythuat"].ToString().Trim();
                f_diachi1.Text = tb.Rows[0]["diachi1"].ToString().Trim();
                f_diachi2.Text = tb.Rows[0]["diachi2"].ToString().Trim();
                f_diachi3.Text = tb.Rows[0]["diachi3"].ToString().Trim();
                f_diachi4.Text = tb.Rows[0]["diachi4"].ToString().Trim();
                f_diachi5.Text = tb.Rows[0]["diachi5"].ToString().Trim();
                f_diachi6.Text = tb.Rows[0]["diachi6"].ToString().Trim();
                f_emailkt.Text = tb.Rows[0]["emailkythuat"].ToString().Trim();
                f_sdtHL.Text = tb.Rows[0]["sdtkythuat"].ToString().Trim();
                f_sdtKt.Text = tb.Rows[0]["sdtkythuat"].ToString().Trim();
                f_tencty.Text = tb.Rows[0]["tenweb"].ToString().Trim();

            }
        }
        public void load_dv()
        {
            DataTable tb = new DataTable();
            tb = data_dm.load_danhMuc();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                list_dv.Text += @"
                 <li class='nav_showlist'><a class='dropdown-item' href='home.aspx?modul=details_dm&id_dm=" + tb.Rows[i]["madanhmuc"].ToString().Trim() + @"'>" + tb.Rows[i]["tendanhmuc"].ToString().Trim() + @"</a></li>
                ";
            }

        }
        public void load_lien_he()
        {
            DataTable tb_lienhe = data_ttw.load_ttweb();
            for(int i = 0; i < tb_lienhe.Rows.Count; i++)
            {
                lien_he.Text = @"
                      <div class='tong_lh'>
        <div class='aa_lienhen '>
            <div class='call-mobile2'>
                <a data-animate='fadeInDown' rel='noopener noreferrer' href='http://zalo.me/" + tb_lienhe.Rows[i]["sdtkythuat"].ToString().Trim() + @"' target='_blank'
                    class='button success' style='border-radius:99px;' data-animated='true'>
                    <span>Chat Zalo</span></a>
            </div>
            <div class='call-mobile1'>
                <a data-animate='fadeInDown' rel='noopener noreferrer' href='https://www.messenger.com/t/kinh.tenhju'
                    rel='nofollow' target='_blank' class='button success' style='border-radius:99px;' data-animated='true'>
                    <span>Chat Facebook</span></a>
            </div>
            <div class='call-mobile'>
                <a id ='callnowbutton' href='tel:" + tb_lienhe.Rows[i]["sdtkythuat"].ToString().Trim() + @"' rel='nofollow'>" + tb_lienhe.Rows[i]["sdtkythuat"].ToString().Trim() + @"</a><i class='fa fa-phone'></i>
            </div>
        </div>
        <div class='lienhe_mobi container-fluid'>
            <div class='phone'>
                <a href='tel:" + tb_lienhe.Rows[i]["sdtkythuat"].ToString().Trim() + @"' class='link_mobi_lienhe'>
                    Gọi Ngay
                    <i class='fas fa-phone'></i>
                </a>
            </div>
            <div class='zalo'>
                <a class='link_mobi_lienhe' href='http://zalo.me/" + tb_lienhe.Rows[i]["sdtkythuat"].ToString().Trim() + @"'>
                    Zalo
                </a>

            </div>
        </div>
    </div>
                ";
            }
        }

        protected void btn_admin_Click(object sender, EventArgs e)
        {
            
        }
    }
} 
   
    