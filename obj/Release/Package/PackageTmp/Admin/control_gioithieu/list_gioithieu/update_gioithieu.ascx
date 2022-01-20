<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="update_gioithieu.ascx.cs" Inherits="web_dien_lanh.Admin.contro_gioithieu.update_gioithieu" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="container">
        <h3 class="them_bv_txt">Chỉnh Sửa Giới Thiệu WebSite</h3>
        <asp:Label id="tb" class="an"  runat="server" role="alert" Text=""></asp:Label>
        <div class="form_css">
              <div class="mg_bt">
                  <label for="exampleInputEmail1" class="label_tieude form-label">Nội Dung Giới Thiệu</label>
                <CKEditor:CKEditorControl id="txt_noidung" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=img"></CKEditor:CKEditorControl>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_noidung" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="btn_th">
                <asp:Button class="btn btn_t_h btn-danger" ID="btn_huy" runat="server" Text="Hủy"  ValidationGroup="huy" OnClick="btn_huy_Click" />
                <asp:Button class="btn btn_t_h btn-primary" ID="btn_update" runat="server" Text="UPDATE" OnClick="btn_update_Click"    />
            </div>
        </div>
    </div>