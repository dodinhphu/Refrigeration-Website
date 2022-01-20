<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="show_ttw.ascx.cs" Inherits="web_dien_lanh.Admin.control_thongtinweb.list_control_ttw.WebUserControl1" %>


      <div class="container" style="min-height:500px">
      
        <h2 class="txt_ttw">Thông Tin Web </h2>
        <div class="khung">
            <asp:Literal ID="list_ttw" runat="server"></asp:Literal>
        </div>
        <a class="link_ud_ttw" href="admin.aspx?modul=thongtinweb&modulphu=update_ttw">
            <button type="button" class="btn btn-primary btn_udw">
                <i class="fas fa-edit"></i>
                UPDATE
            </button>
        </a>
    </div>