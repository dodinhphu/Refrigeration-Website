<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="taikhoan.ascx.cs" Inherits="web_dien_lanh.Admin.control_taiKhoan.taikhoan" %>



                 <div class="container">
                             <asp:Label id="tb" class="an"  runat="server" role="alert" Text=""></asp:Label>
                        <h3  runat="server" class="them_bv_txt">Đỗi Mật Khẩu</h3>

                        <div class="mg_bt">
                            <label for="exampleInputEmail1" class="label_tieude form-label">Mật Khẩu Cũ</label>
                            <asp:TextBox ID="txt_mkCu" runat="server"  class="form-control form-control-lg" placeholder="Mật Khẩu Cũ" TextMode="Password"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_mkCu" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="mg_bt">
                            <label for="exampleInputEmail1" class="label_tieude form-label">Mật Khẩu Mới</label>
                            <asp:TextBox ID="txt_mkMoi" runat="server"  class="form-control form-control-lg" placeholder="Mật Khẩu Mới" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_mkMoi" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        </div>
                        <div class="mg_bt">
                            <label for="exampleInputEmail1" class="label_tieude form-label">Xác Nhận Mật Khẩu Mới</label>
                            <asp:TextBox ID="txt_ktMK" runat="server"  class="form-control form-control-lg" placeholder="Xác Nhận Mật Khẩu Mới" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_ktMK" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                              <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_ktMK" ControlToValidate="txt_mkMoi" ErrorMessage="CompareValidator" ForeColor="Red">*</asp:CompareValidator>
                            </div>
                        <div class="btn_th">
                        <asp:Button  class="btn btn_t_h btn-danger" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click"  ValidationGroup="huy"  />
                        <asp:Button  class="btn btn_t_h btn-primary" ID="btn_capnhat" runat="server" Text="Thay Đỗi" OnClick="btn_capnhat_Click"  />
                    </div>
                </div>