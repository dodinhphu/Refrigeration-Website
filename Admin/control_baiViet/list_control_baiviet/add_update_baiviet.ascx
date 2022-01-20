    <%@ Control Language="C#" AutoEventWireup="true" CodeBehind="add_update_baiviet.ascx.cs" Inherits="web_dien_lanh.Admin.control_baiViet.list_control_baiviet.add_update_baiviet" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="container"> 
   
           <asp:Label id="tb" class="an"  runat="server" role="alert" Text=""></asp:Label>
         <h3 id="text_them_or_add" runat="server" class="them_bv_txt"></h3>
        <div class="form_css">
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Tiêu Đề Bài Viết</label>
         
                <asp:TextBox  class="form-control form-control-lg" type="text" placeholder="Tiêu Đề" ID="txt_tieude" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_tieude" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <br>
            <div class="mg_bt">
                 <label for="exampleInputEmail1" class="label_tieude form-label">Chọn Ảnh</label>
                  <asp:FileUpload  class="form-control form-control-lg" ID="up_anh" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="up_anh" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <label for="exampleInputEmail1" class="label_tieude form-label">Danh Mục</label>
            
            <asp:DropDownList  class="form-select form-select-lg mg_bt" ID="list_dm" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="list_dm" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            <div class="mg_bt">
                <label for="exampleInputEmail1" class="label_tieude form-label">Thời Gian Đăng Bài</label>
               
                <asp:TextBox ID="txt_ngaytao" runat="server" class="form-control form-control-lg"  TextMode="DateTime"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_ngaytao" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="mg_bt">
                <CKEditor:CKEditorControl id="txt_mota" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=img"></CKEditor:CKEditorControl>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_mota" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </div>
            <div class="btn_th">
                
                <asp:Button  class="btn btn_t_h btn-danger" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click"  ValidationGroup="huy"  />
               
                <asp:Button  class="btn btn_t_h btn-primary" ID="btn_them" runat="server" Text="Thêm" OnClick="btn_them_Click" />
            </div>

        </div>
    </div>
