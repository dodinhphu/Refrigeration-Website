<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="all_dm.ascx.cs" Inherits="web_dien_lanh.Home.load_theo_dm.all_dm" %>


     <div class="col-md-9 col-xs-12">
                <div class="container conten_css">

                    <div class="row all_card">
                            <div class="title-cathome clearfix" style="margin-top:20px;" >
                                <div class="title-con">
                                    <a href="home.aspx?modul=details_giothieu" title="giới thiệu">
                                                <span class="ttten">
                                                   Giới Thiệu
                                                </span>
                                    </a>
                                </div>
                             </div>
                              <div class="col-md-12 col-xs-12 magin_css p_gioithieu">
                                  <asp:Literal ID="load_gt" runat="server"></asp:Literal>
                              </div>
                        </div>
                    <asp:Literal ID="list_post" runat="server"></asp:Literal>
                  
                </div>
            </div>