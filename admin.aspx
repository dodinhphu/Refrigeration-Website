<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="web_dien_lanh.admin" ValidateRequest="false" %>

<%@ Register Src="~/Admin/dieu_huong.ascx" TagPrefix="uc1" TagName="dieu_huong" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="icon/icon_code_web/fontawesome-free-5.15.3-web/css/all.min.css" rel="stylesheet" />
     <!-- forn chữ-->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;500;700&display=swap" rel="stylesheet">
     <!-- link bootrap -->
    <link rel="stylesheet" href="/bootstrap-5.1.3/bootstrap-5.1.3-dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="Admin/css/admin_css.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
                        <li class="nav-item  me-xl-3 ">
                            <a class="nav-link nav_link_css  " aria-current="page" href="admin.aspx">Trang Chủ</a>
                        </li>
                        <li class="nav-item  me-xl-3">
                            <a class="nav-link nav_link_css " href="admin.aspx?modul=danhmuc">Danh Mục</a>
                        </li>
                        <li class="nav-item  me-xl-3">
                            <a class="nav-link nav_link_css " href="admin.aspx?modul=baiviet">Bài Viết</a>
                        </li>
                        <li class="nav-item  me-xl-3">
                            <a class="nav-link nav_link_css " href="admin.aspx?modul=taikhoan">Tài Khoản</a>
                        </li>
                        <li class="nav-item  me-xl-3">
                            <a class="nav-link nav_link_css " href="admin.aspx?modul=thongtinweb">Thông Tin Web</a>
                        </li>
                         <li class="nav-item  me-xl-3">
                            <a class="nav-link nav_link_css " href="admin.aspx?modul=gioithieu">Giới Thiệu</a>
                        </li>
                    </ul>
                    <div class="d-flex ">
                        <div class=" form_admin">
                            <i class="fas fa-user-circle icon_admin"></i>
                            <h6 class=" tk_admin"><asp:Literal ID="userName" runat="server"></asp:Literal></h6>
                            <asp:LinkButton ID="txt_dang_xuat" runat="server" OnClick="txt_dang_xuat_Click">  <i class="fas fa-sign-out-alt icon_admin"></i></asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </nav>
            <uc1:dieu_huong runat="server" ID="dieu_huong" />


        <footer style="margin-top:60px" class="bg-dark text-center text-white footer_css">
        <!-- Grid container -->
        <div class="container p-4">
            <!-- Section: Social media -->
            <section class="mb-4">
                <!-- Facebook -->
                <a class="btn btn-primary btn-floating m-1" style="background-color: #3b5998;"
                    href="https://www.facebook.com/profile.php?id=100072368852606" role="button"><i
                        class="fab fa-facebook-f"></i></a>

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

            <!-- Section: Form -->
            <section class="">
                <form action="">
                    <!--Grid row-->
                    <div class="row d-flex justify-content-center">

                        <!--Grid column-->
                        <div class="col-md-5 col-12">
                            <div class="spinner-border text-primary" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <div class="spinner-border text-secondary" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <div class="spinner-border text-success" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <div class="spinner-border text-danger" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <div class="spinner-border text-warning" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <div class="spinner-border text-info" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <div class="spinner-border text-light" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <div class="spinner-border text-dark" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                        </div>
                        <!--Grid row-->
                </form>
            </section>
            <!-- Section: Form -->

            <!-- Section: Text -->
            <section class="mb-4">
                <p>
                <h3>Nhận Thiết Kế - Chỉnh Sửa Web</h3>
                <h6>Địa Chỉ: Số 64, Thanh Nghị, Hòa Minh, Liên Chiễu, Đà Nẳng.</h6>
                <h6>Điện Thoại: 0912.306.253 </h6>
                <h6>Hotline: 0912.306.253 </h6>
                <h6>Email: Dodinhphu316@gmail.com</h6>
                </p>
            </section>
        </div>
        <div class="text-center p-3" style="background-color: rgba(0, 0, 0, 0.2);">
            © 2021 Copyright:
            <a class="text-white" href="https://www.facebook.com/profile.php?id=100072368852606">Designer by DinhPhu</a>
        </div>
    </footer>
  </div>
</form>
  
     <script src="/js/jquery-3.6.0.min.js"></script>
      <script src="Admin/js/xu_ly.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"
        integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB"
        crossorigin="anonymous"></script>
    <script src="/bootstrap-5.1.3/bootstrap-5.1.3-dist/js/bootstrap.min.js"></script>
</body>
</html>
