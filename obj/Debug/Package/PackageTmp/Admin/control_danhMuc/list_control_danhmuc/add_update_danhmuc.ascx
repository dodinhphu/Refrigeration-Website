<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="add_update_danhmuc.ascx.cs" Inherits="web_dien_lanh.Admin.control_danhMuc.list_control_danhmuc.add_update_danhmuc" %>
    <div class="container">
        <asp:Label id="tb" class="an"  runat="server" role="alert" Text=""></asp:Label>
        <h3 id="text_them_or_add" runat="server" class="them_bv_txt"></h3>
        <div class="form_css">
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Tên Danh Mục</label>
                <asp:TextBox ID="txt_tendm" runat="server"  class="form-control form-control-lg" placeholder="Tên Danh Mục"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_tendm" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Thời Gian Tạo</label>
                <asp:TextBox ID="txt_ngaytao" runat="server" class="form-control form-control-lg"  TextMode="DateTime"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_ngaytao" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="btn_th">
                <asp:Button  class="btn btn_t_h btn-danger" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click" ValidationGroup="huy"  />
                <asp:Button  class="btn btn_t_h btn-primary" ID="btn_them" runat="server" Text="Thêm" OnClick="btn_them_Click" />
            </div>
        </div>
    </div>