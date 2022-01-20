using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_dien_lanh.Admin.contro_gioithieu.list_giothieu
{
    public partial class show_gioiithieu : System.Web.UI.UserControl
    {
        DB_connet.data.gioithieu data_gt = new DB_connet.data.gioithieu();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_nd_gt();
        }
        public void load_nd_gt()
        {
            DataTable tb = new DataTable();
            tb = data_gt.load();
            for(int i=0;i<tb.Rows.Count;i++)
            {
                show_gt.Text = @"
                "+tb.Rows[i]["noidung"].ToString() +@"
                        ";
            }    
        }
    }
}