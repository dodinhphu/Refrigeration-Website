<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="web_dien_lanh.home" %>

<%@ Register Src="~/Home/home_dieuhuong.ascx" TagPrefix="uc1" TagName="home_dieuhuong" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <!-- link forn -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;500;700&display=swap" rel="stylesheet">
    <!-- link icon -->
    <link href="icon/icon_code_web/fontawesome-free-5.15.3-web/css/all.min.css" rel="stylesheet" />
     <!-- link bootrap -->
    <link href="bootstrap-5.1.3/bootstrap-5.1.3-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Home/css/home_css.css" rel="stylesheet" />
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="app">
                 <!-- hearder -->
    <header>
        <div class="all_header">
            <div class="container">
                <div class="phan_dau">
                    <div class="logo">
                        <img class="img-logo" src="/img/LOGO.png" alt="">
                    </div>
                    <div class="gioi-thieu">
                        <h2 class="ten-cty">
                            <asp:Literal ID="ten_web" runat="server"></asp:Literal>
                        </h2>
                        <h6 class="dia-chi">
                            <asp:Literal ID="dia_chi" runat="server"></asp:Literal>
                        </h6>
                        <h6 class="dia-chi">
                            Điện thoại: <asp:Literal ID="sdt_kt" runat="server"></asp:Literal>
                        </h6>
                    </div>
                    <div class="lien-he">
                        <i class="fas fa-phone-alt icon_lienhe"></i>
                        <h1 class="text_lien-he">
                            HOTLINE : <asp:Literal ID="sdt_lh" runat="server"></asp:Literal>
                        </h1>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- navbar -->
    <nav class="sticky-top navbar navbar-expand-lg navbar-light bg-light nav_css">
        <div class="container">
            <div class="container-fluid">
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                    data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item_css  nav-item  me-xl-3 ">
                            <a class="nav-link nav_link_css  " aria-current="page" href="home.aspx">Trang Chủ</a>
                        </li>
                        
                        <li class="nav-item_css   me-xl-3 dropdown ">
                            <a class="nav-link nav_link_css dropdown-toggle" href="#" id="navbarDropdown" role="button"
                                data-bs-toggle="dropdown" aria-expanded="false">
                                Dịch Vụ
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <asp:Literal ID="list_dv" runat="server"></asp:Literal>
                                <li class="">
                                    <hr class="dropdown-divider">
                                </li>
                                <li class="mr-10"><a class="dropdown-item" href="#">Something else here</a></li>
                            </ul>
                        </li>
                        <li class="nav-item_css nav-item  me-xl-3">
                            <a class="nav-link nav_link_css " href="#">Tin Tức</a>
                        </li>
                        
                        <li class="nav-item_css nav-item  me-xl-3">
                            <a class="nav-link nav_link_css " href="#">Tuyển Dụng</a>
                        </li>
                        <li class="nav-item_css  me-xl-3">
                            <a class="nav-link nav_link_css " href="#">Liên Hệ</a>
                        </li>
                    </ul>
                    <form class="d-flex">
                        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
                        <asp:Button class="btn btn-outline-success" ID="btn_admin" runat="server" Text="Search" OnClick="btn_admin_Click" />
                    </form>
                </div>
            </div>
        </div>
    </nav>
    <!-- slide -->
    <div class="container">
        <div id="carouselExampleControls" class="carousel slide " data-bs-ride="carousel">
            <div class="carousel-inner  ">
                <div class="carousel-item active">
                    <img src="./img/a1.png" class="d-block w-100 img_slide" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="./img/a2.jpg" class="d-block w-100 img_slide" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="./img/a3.jpg" class="d-block w-100 img_slide" alt="...">
                </div>
            </div>
            <button class="carousel-control-prev btn_slide  " type="button" data-bs-target="#carouselExampleControls"
                data-bs-slide="prev">
                <i class="fas fa-arrow-left icon_slide "></i>
            </button>
            <button class="carousel-control-next btn_slide  " type="button" data-bs-target="#carouselExampleControls"
                data-bs-slide="next">
                <i class="fas fa-arrow-right icon_slide" aria-hidden="true"></i>
            </button>
        </div>
    </div>
            <!-- ảnh chạy -->
    <div class="container">
        <marquee id="marq" onmouseover="this.stop()" onmouseout="this.start()" scrollamount="8"style="background-color: #0d5d83" >
        <img class="img_logodoitac" src="./img/electrolux.jpg" alt="">
        <img class="img_logodoitac" src="./img/hitachi.jpg" alt="">
        <img class="img_logodoitac" src="./img/logo_doi_tac__2.jpg" alt="">
        <img class="img_logodoitac" src="./img/logo_doi_tac__3.jpg" alt="">
        <img class="img_logodoitac" src="./img/logo_doi_tac__4.jpg" alt="">
        <img class="img_logodoitac" src="./img/toshiba.jpg" alt="">
        <img class="img_logodoitac" src="./img/sanyo.jpg" alt="">
    </marquee>
    </div>
    <!-- content -->
    <uc1:home_dieuhuong runat="server" ID="home_dieuhuong" />
    <!-- footer -->
    <footer class="bg-dark text-center text-white footer_css">
        <!-- Grid container -->
        <div class="container p-4">
            <!-- Section: Social media -->
            <section class="mb-4">
                <!-- Facebook -->
                <a class="btn btn-primary btn-floating m-1" style="background-color: #3b5998;" href="#!"
                    role="button"><i class="fab fa-facebook-f"></i></a>

                <!-- Twitter -->
                <a class="btn btn-primary btn-floating m-1" style="background-color: #55acee;" href="#!"
                    role="button"><i class="fab fa-twitter"></i></a>

                <!-- Google -->
                <a class="btn btn-primary btn-floating m-1" style="background-color: #dd4b39;" href="#!"
                    role="button"><i class="fab fa-google"></i></a>

                <!-- Instagram -->
                <a class="btn btn-primary btn-floating m-1" style="background-color: #ac2bac;" href="#!"
                    role="button"><i class="fab fa-instagram"></i></a>

                <!-- Linkedin -->
                <a class="btn btn-primary btn-floating m-1" style="background-color: #0082ca;" href="#!"
                    role="button"><i class="fab fa-linkedin-in"></i></a>
                <!-- Github -->
                <a class="btn btn-primary btn-floating m-1" style="background-color: #333333;" href="#!"
                    role="button"><i class="fab fa-github"></i></a>
            </section>
            <!-- Section: Social media -->
            <!-- Section: Text -->
            <section class="mb-4">
                <p>
                    <!--  Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt distinctio earum
                    repellat quaerat voluptatibus placeat nam, commodi optio pariatur est quia magnam
                    eum harum corrupti dicta, aliquam sequi voluptate quas. -->
                <h3><asp:Literal ID="f_tencty" runat="server"></asp:Literal></h3>
                <h6>Địa Chỉ: <asp:Literal ID="f_diachi" runat="server"></asp:Literal>.</h6>
                <h6>Điện Thoại: <asp:Literal ID="f_sdtKt" runat="server"></asp:Literal> </h6>
                <h6>Hotline: <asp:Literal ID="f_sdtHL" runat="server"></asp:Literal></h6>
                <h6>Email: <asp:Literal ID="f_emailkt" runat="server"></asp:Literal></h6>
                </p>
            </section>
        </div>
        <!-- Grid container -->

        <!-- Copyright -->
        <div class="text-center p-3" style="background-color: rgba(0, 0, 0, 0.2);">
            © 2021 Copyright:
            <a class="text-white" href="/admin.aspx">Designer by DinhPhu</a>
        </div>
        <!-- Copyright -->
    </footer>
    <!-- Footer -->

    <!-- Liên Hệ -->
      <asp:Literal ID="lien_he" runat="server"></asp:Literal>

    <!-- link -->     
        </div>
    </form>
    <script src="js/jquery-3.6.0.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"
            integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB"
            crossorigin="anonymous"></script>
        <script src="bootstrap-5.1.3/bootstrap-5.1.3-dist/js/bootstrap.min.js"></script>
     <!-- jquery -->
        <script type="text/javascript">
            $(document).ready(function () {
                $('.nav-item_css').on('click', function () {
                    $(this).siblings().removeClass('nav-item_css_active');
                    $(this).addClass('nav-item_css_active');
                })
            })

        </script>
</body>
</html>
