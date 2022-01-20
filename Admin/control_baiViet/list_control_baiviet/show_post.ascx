<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="show_post.ascx.cs" Inherits="web_dien_lanh.Admin.control_baiViet.list_control_baiviet.show_post" %>
   <div class="container" style="min-height:500px">
          <a href="/admin.aspx?modul=baiviet&modulphu=addpost"> 
            <button type="button" class="btn btn-primary btn_them_bv">
                <i class="fas fa-plus-circle"></i>
                Thêm Mới Bài Viết
            </button>
        </a>
        <table class="table table_bv">
            <thead class="table_css">
                <td class="list_td">STT</td>
                <td class="list_td">Tiêu Đề</td>
                <td class="list_td">Danh Mục</td>
                <td class="list_td">Ngày Đăng</td>
                <td class="list_td">Hành Động</td>
            </thead>
            <asp:Literal ID="list_post" runat="server"></asp:Literal>
  
        </table>
       </div>