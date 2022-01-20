<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="details_post.ascx.cs" Inherits="web_dien_lanh.Home.load_chi_tiet_post.details_post" %>

   <div class="col-md-9 col-xs-12">
            <div class="container all_details_post">
                    <div class="details_post_tieude">
                        <i class="details_post_tieude_icon fas fa-align-justify"></i>
                        <h1 class="details_post_tieude_text">
                            <asp:Literal ID="tieude" runat="server"></asp:Literal>

                        </h1>
                    </div>
                    <div class="details_post_date">
                        <small class="date_post">Ngày Đăng: <asp:Literal ID="ngaydang" runat="server"></asp:Literal></small>
                    </div>
                    <div class="mg_70">
                        <asp:Literal ID="noi_dung_post" runat="server"></asp:Literal>
                    </div>
               </div>
       </div>