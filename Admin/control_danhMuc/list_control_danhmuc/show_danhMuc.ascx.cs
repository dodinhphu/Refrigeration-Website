using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_danhMuc.list_control_danhmuc
{
    public partial class show_danhMuc : System.Web.UI.UserControl
    {
        DB_connet.data.danhmuc data_danhmuc = new DB_connet.data.danhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            show_dm();
        }
        public void show_dm()
        {
            DataTable tb = new DataTable();
            tb = data_danhmuc.load_danhMuc();
            DataTable tb1 = new DataTable();
            tb1 = data_danhmuc.load_so_post();
            for(int i=0;i<tb.Rows.Count;i++)
            {
                show_danhmuc.Text += @"
                <tbody id='ma_" + "" + tb.Rows[i]["madanhmuc"].ToString().Trim() + "" + @"'>
                <th class='item_tb'>"+ tb.Rows[i]["madanhmuc"]+ @"</th>
                <th class='item_tb '>" + tb.Rows[i]["tendanhmuc"].ToString().Trim() + @"</th>
                <th class='item_tb'>" + tb.Rows[i]["ngaytao"].ToString().Trim() + @"</th>
                <th class='item_tb'>" + tb1.Rows[i]["sopost"].ToString().Trim() + @"</th>
                <th class='item_tb'>
                    <a href = '" + "javascript:xoadanhmuc(\"" + tb.Rows[i]["madanhmuc"].ToString().Trim() + "\")" + @"'><i class='icon_hd fas fa-trash-alt'></i></a>
                    <a href = '/admin.aspx?modul=danhmuc&modulphu=update_danhmuc&id_dm=" + tb.Rows[i]["madanhmuc"].ToString().Trim() + @"'><i class='icon_hd fas fa-edit'></i></a>
                </th>
            </tbody>      
                ";
            }    
        }
    }
}