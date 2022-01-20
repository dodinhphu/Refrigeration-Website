<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="show_danhMuc.ascx.cs" Inherits="web_dien_lanh.Admin.control_danhMuc.list_control_danhmuc.show_danhMuc" %>
   <div class="container " style="min-height:500px">
        <a href="/admin.aspx?modul=danhmuc&modulphu=add_danhmuc">
            <button type="button" class="btn btn-primary btn_them_bv">
                <i class="fas fa-plus-circle"></i>
                Thêm Mới Danh Mục
            </button>
        </a>
        <table class="table table_bv">
            <thead class="table_css">
                <td class="list_td ">Mã</td>
                <td class="list_td ">Tên Danh Mục</td>
                <td class="list_td ">Ngày Tạo</td>
                <td class="list_td ">Số Lượng Bài Viết</td>
                <td class="list_td  ">Hành Động</td>
            </thead>
            <asp:Literal ID="show_danhmuc" runat="server"></asp:Literal>
            
        </table>
    </div>