<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="update_ttw.ascx.cs" Inherits="web_dien_lanh.Admin.control_thongtinweb.list_control_ttw.update_ttw" %>
   <div class="container">
        <h3 class="them_bv_txt">Chỉnh Sửa Thông Tin WebSite</h3>
        <asp:Label id="tb" class="an"  runat="server" role="alert" Text=""></asp:Label>
        <div class="form_css">
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Tên WebSite</label>
 
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Tên WebSite" ID="txt_tenweb" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_tenweb" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Số Điện Thoại Kỹ Thuật</label>
                
                <asp:TextBox class="form-control form-control-lg" type="text" placeholder="Số Điện Thoại Kỹ Thuật" ID="txt_sdtkt" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_sdtkt" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Email Kỹ Thuật</label>
        
                <asp:TextBox type="email" class="form-control form-control-lg"
                    placeholder="name@gmail.com" ID="txt_emailkt" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_emailkt" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Địa Chỉ 1</label>
 
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Địa Chỉ 1" ID="txt_diachi1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_diachi1" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Địa Chỉ 2</label>
 
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Địa Chỉ 2" ID="txt_diachi2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_diachi2" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Địa Chỉ 3</label>
 
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Địa Chỉ 3" ID="txt_diachi3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_diachi3" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Địa Chỉ 4</label>
 
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Địa Chỉ 4" ID="txt_diachi4" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_diachi4" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Địa Chỉ 5</label>
 
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Địa Chỉ 5" ID="txt_diachi5" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_diachi5" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Địa Chỉ 6</label>
 
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Địa Chỉ 6" ID="txt_diachi6" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_diachi6" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="btn_th">
                <asp:Button class="btn btn_t_h btn-danger" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click" ValidationGroup="huy" />
                <asp:Button class="btn btn_t_h btn-primary" ID="btn_update" runat="server" Text="UPDATE" OnClick="btn_update_Click"   />
            </div>
        </div>
    </div>