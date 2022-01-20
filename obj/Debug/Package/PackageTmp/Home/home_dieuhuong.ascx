<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="home_dieuhuong.ascx.cs" Inherits="web_dien_lanh.Home.home_dieuhuong" %>
  <div class="container  pt-xl-2 ">
        <div class="row">
            <!-- Danh Mục -->
            <div class="col-md-3 col-xs-12">
                <div class="navbar_dm">
                    <ul class="list_danhmuc">
                        <p class="ten_dm">
                            <i class="fas fa-comment-dots icon_ct"></i>
                            <strong> HỖ TRỢ TRỰC TUYẾN </strong>
                        </p>
                        <li class="item_dm_t">
                            <p class="gt"> Tư vấn, giải đáp thắc mắc trực tiếp các vấn đề về điện lạnh 24/24</p>
                        </li>
                        <li class="item_dm_t">
                            <p class="text_center">
                                Kinh doanh
                            </p>
                            <p class="std">
                               <asp:Literal ID="sdt_kt" runat="server"></asp:Literal>
                            </p>
                            <p class="email">
                                Email: <asp:Literal ID="emai_kt" runat="server"></asp:Literal>
                            </p>
                            <div class="list_lienhe">
                                <p>Liên Hệ : </p>
                                <a href=""> <i class="fas fa-envelope iconlienhe"></i></a>
                                <a href=""> <i class="fab fa-facebook iconlienhe"></i></a>
                            </div>
                        </li>
                        <li class="item_dm_t">
                            <p class="text_center">
                                Kỹ Thuật
                            </p>
                            <p class="std">
                               <asp:Literal ID="_sdt_kt" runat="server"></asp:Literal>
                            </p>
                            <p class="email">
                                Email: <asp:Literal ID="_email_kt" runat="server"></asp:Literal>
                            </p>
                            <div class="list_lienhe">
                                <p>Liên Hệ : </p>
                                <a href=""> <i class="fas fa-envelope iconlienhe"></i></a>
                                <a href=""> <i class="fab fa-facebook iconlienhe"></i></a>
                            </div>
                        </li>
                    </ul>
                    <!-- dữ liệu động -->
                    <asp:Literal ID="list_dm" runat="server"></asp:Literal>

                </div>
            </div>
            <!-- content Danh Mục -->
           <asp:PlaceHolder ID="load_content_home" runat="server"></asp:PlaceHolder>   
       
        </div>
    </div>
 