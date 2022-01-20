<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="show_gioithieu.ascx.cs" Inherits="web_dien_lanh.Admin.contro_gioithieu.list_giothieu.show_gioiithieu" %>


  <div class="container" style="min-height:500px">
          <div class="row">
              <a href="/admin.aspx?modul=gioithieu&modulphu=update_gioithieu"> 
            <button type="button" class="btn btn-primary btn_them_bv">
                Chỉnh Sửa Giới Thiệu
            </button>
        </a>
          </div>
      <div class="row">
          <asp:Literal ID="show_gt" runat="server"></asp:Literal>
          </div>
       </div>