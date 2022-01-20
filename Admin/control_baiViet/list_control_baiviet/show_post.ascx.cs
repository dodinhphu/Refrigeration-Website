using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.control_baiViet.list_control_baiviet
{
    public partial class show_post : System.Web.UI.UserControl
    {
        DB_connet.data.post data_post = new DB_connet.data.post();
        protected void Page_Load(object sender, EventArgs e)
        {
            show__post();
        }
        public void show__post()
        {
            DataTable tb = new DataTable();
            tb = data_post.load_post();
            for(int i=0;i<tb.Rows.Count;i++)
            {
                DataTable tb1 = new DataTable();
                tb1 = data_post.seach_name_dm(tb.Rows[i]["madanhmuc"].ToString().Trim());
                string tendm = tb1.Rows[0]["tendanhmuc"].ToString().Trim();
                list_post.Text += @"
             <tbody id='ma_" + "" + tb.Rows[i]["mapost"].ToString().Trim() + "" + @"'>
                <th class='item_tb'>" + (i + 1) + @"</th>
                <th class='item_tb'>" + tb.Rows[i]["tieudepost"].ToString().Trim() + @"</th>
                <th class='item_tb'>" + tendm + @"</th>
                <th class='item_tb'>" + tb.Rows[i]["ngaytao"].ToString().Trim() + @"</th>
                <th class='item_tb'>
                     <a href = '" + "javascript:xoapost(\"" + tb.Rows[i]["mapost"].ToString().Trim() + "\")" + @"' >
                        <i class='icon_hd fas fa-trash-alt'></i>
                    </a>
                    <a href = '/admin.aspx?modul=baiviet&modulphu=updatepost&id_post=" + tb.Rows[i]["mapost"].ToString().Trim() + @"' >
                        <i class='icon_hd fas fa-edit'></i>
                    </a>
                </th>
            </tbody>
                ";
            }    
        }
    }
}