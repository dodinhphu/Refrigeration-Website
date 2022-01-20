using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_thongtinweb.list_control_ttw
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        DB_connet.data.thongtinweb data_ttw = new DB_connet.data.thongtinweb();
        protected void Page_Load(object sender, EventArgs e)
        {
            show_ttw(); 
        }
        public void show_ttw()
        {
            DataTable tb = new DataTable();
            tb = data_ttw.load_ttweb();
            for(int i=0;i<tb.Rows.Count;i++)
            {
                list_ttw.Text += @"
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Tên WebSite: </h3>
                         <h3>" + tb.Rows[i]["tenweb"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Số Điện Thoại Kỹ Thuật: </h3>
                         <h3> " + tb.Rows[i]["sdtkythuat"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                          <h3 class='ttd_css'>Email Kỹ Thuật: </h3>
                         <h3>  " + tb.Rows[i]["emailkythuat"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Địa Chỉ 1: </h3>
                         <h3>  " + tb.Rows[i]["diachi1"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Địa Chỉ 2: </h3>
                         <h3>  " + tb.Rows[i]["diachi2"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Địa Chỉ 3: </h3>
                         <h3>  " + tb.Rows[i]["diachi3"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Địa Chỉ 4: </h3>
                         <h3>  " + tb.Rows[i]["diachi4"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Địa Chỉ 5: </h3>
                         <h3>  " + tb.Rows[i]["diachi5"] + @" </h3>
                    </div>
                    <div class='td_ttw'>
                         <h3 class='ttd_css'>Địa Chỉ 6: </h3>
                         <h3>  " + tb.Rows[i]["diachi6"] + @" </h3>
                    </div>
                     
                  ";
            }    
        }
    }
}