<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="web_dien_lanh.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <!-- link forn -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;500;700&display=swap" rel="stylesheet">
    <link href="../icon/icon_code_web/fontawesome-free-5.15.3-web/css/all.min.css" rel="stylesheet" />
    <link href="../bootstrap-5.1.3/bootstrap-5.1.3-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="login.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
        <div class="row">
            <div class="col-md-6 col-sm-12 col-xs-10 mx-auto">
                <div class="card border-0 shadow rounded-3 my-5">
                    <div class="card-body p-4 p-sm-5">
                        <h5 class="card-title text-center mb-5 fw-light fs-5">Sign In</h5>
                        <form>
                            <asp:Label id="tb_tb" class="an"  runat="server" role="alert" Text=""></asp:Label>
                            <div class="form-floating mb-3">
                                <asp:TextBox placeholder="User Name" class="form-control" ID="txt_username" runat="server"  ></asp:TextBox>
                                <label for="floatingInput">User Name</label>
                            </div>
                            <div class="form-floating mb-3">
                                <asp:TextBox class="form-control" placeholder="Password" ID="txt_pass" runat="server" TextMode="Password" ></asp:TextBox>
                                 <label for="floatingPassword">Password</label>
                            </div>

                            <div class="form-check mb-3">
                                <input class="form-check-input" type="checkbox" value="" id="rememberPasswordCheck">
                                <label class="form-check-label" for="rememberPasswordCheck">
                                    Remember password
                                </label>
                            </div>
                            <div class="d-grid mg_12px" >
                                <asp:Button class="btn btn-primary btn-login text-uppercase fw-bold" ID="btn_dang_nhap" runat="server" Text="Sign in" OnClick="btn_dang_nhap_Click" />
                            </div>
                            <div class="d-grid">
                                <asp:Button class="btn btn-danger btn-login text-uppercase fw-bold" ID="btn_thoat" runat="server" Text="Về Trang Chủ" OnClick="btn_thoat_Click"  />
                            </div>
                            <hr class="my-4">
                            <div class="d-grid mb-2">
                                <button class="btn btn-google btn-login text-uppercase fw-bold" type="submit">
                                    <i class="fab fa-google me-2"></i> Sign in with Google</button>
                            </div>
                            <div class="d-grid">
                                <button class="btn btn-facebook btn-login text-uppercase fw-bold" type="submit">
                                    <i class="fab fa-facebook-f me-2"></i> Sign in with Facebook
                                </button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <script src="../js/jquery-3.6.0.min.js"></script>
         <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js"
            integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB"
            crossorigin="anonymous"></script>
        <script src="../bootstrap-5.1.3/bootstrap-5.1.3-dist/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
