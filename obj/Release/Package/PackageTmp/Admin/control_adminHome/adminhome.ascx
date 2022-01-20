<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminhome.ascx.cs" Inherits="web_dien_lanh.Admin.control_adminHome.adminhome" %>
 <div>
        <div class="warning">
            <i class="icon_warning fas fa-exclamation-triangle"></i>
        </div>
        <div class="text_warning">
            <p>
                Tài Khoản Admin Là Tài Khoản Quản Trị WebSite, Không Cung Cấp Hoặc Để Lộ Nó Cho Người Không Đáng Tin
                Cậy.
                Điều Này Sẽ Gây Ảnh Hưởng Xấu Đến WebSite Của Bạn !!!
            </p>
            <p>
                Mọi Thực Hiện Thêm Mới, Xóa, Chỉnh Sửa Của Bạn Trên Trang Này Sẽ Thay Đổi Toàn Bộ Trang Web Của Bạn. Hãy
                Cẩn
                Trọng Về Việc Này !!!
            </p>
            <p>
                Chúng Tôi Sẽ Không Chịu Trách Nhiệm Cho Việc Cố Tình Phá Hoại, Hoặc Hành Vi Can Thiệp Và Các Tập Tin
                Private
                Không Cho Phép !!!
            </p>
        </div>
        <!-- hướng dẩn sử dụng -->
        <div class="book_user">
            <i class="icon_book_user fas fa-book-reader"></i>
        </div>
        <div class="item_book_user">
            <button type="button" class="btn_details_book btn btn-primary" data-bs-toggle="modal"
                data-bs-target="#exampleModal1">
                Danh Mục
            </button>

            <!-- Modal -->
            <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel"
                aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel1">Quản Trị Danh Mục</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body details_test">
                            Bạn Có Thể Xem Tổng Quát Các Danh Mục Hiện Có Trên WebSite Của Bạn.
                            <br>
                            Cho Phép Bạn Thực Hiện Các Chức Năng Như: Thêm danh Mục, Sửa Danh Mục, Xóa Danh Mục.
                            <br>
                            <br>
                            LƯU Ý: Không Thể Xóa Các Danh Mục Đang Chứa Các Bài Viết !!!
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đã Hiểu</button>
                        </div>
                    </div>
                </div>
            </div>


            <!-- Button trigger modal -->
            <button type="button" class="btn_details_book btn btn-primary" data-bs-toggle="modal"
                data-bs-target="#exampleModal2">
                Bài Viết
            </button>

            <!-- Modal -->
            <div class="modal fade" id="exampleModal2" tabindex="-1" aria-labelledby="exampleModalLabel1"
                aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel2">Quản Trị Bài Viết</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body details_test">
                            Bạn Có Thể Xem Tổng Quát Các Bài Viết Hiện Có Trên WebSite Của Bạn.
                            <br>
                            Cho Phép Bạn Thực Hiện Các Chức Năng Như: Thêm Bài Viết, Sửa Bài Viết, Xóa Bài Viết.
                            <br>
                            <br>
                            LƯU Ý: Mỗi Bài Viết Thuộc Một Danh Mục Nhất Định !!!
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đã Hiểu</button>
                        </div>
                    </div>
                </div>
            </div>


            <button type="button" class="btn_details_book btn btn-primary" data-bs-toggle="modal"
                data-bs-target="#exampleModal3">
                Tài Khoản
            </button>

            <!-- Modal -->
            <div class="modal fade" id="exampleModal3" tabindex="-1" aria-labelledby="exampleModalLabel1"
                aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel3">Quản Trị Tài Khoản</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body details_test">
                            Cho Phép Bạn Đỗi Mật Khẩu Tài Khoản Quản Trị WebSite Của Bạn.
                            <br>
                            <br>
                            LƯU Ý: Chỉ Có Một Tài Khoản Duy Nhất, Hãy Ghi Nhớ Nó Thật Cẩn Thận !!!
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đã Hiểu</button>
                        </div>
                    </div>
                </div>
            </div>

            <button type="button" class="btn_details_book btn btn-primary" data-bs-toggle="modal"
                data-bs-target="#exampleModal4">
                Thông Tin WebSite
            </button>

            <!-- Modal -->
            <div class="modal fade" id="exampleModal4" tabindex="-1" aria-labelledby="exampleModalLabel1"
                aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel4">Quản trị THông Tin Web</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body details_test">
                            Bạn Có Thể Xem Tổng Quát Các Thông Tin Của Công Ty Bạn Được Hiển Thị Trên WebSite.
                            <br>
                            Cho Phép Bạn Tùy Biến, Chỉnh Sửa Các Thông Tin Như: Địa Chỉ,Số Điện Thoại,Tên
                            webSite,Email.....
                            <br>
                            <br>
                            LƯU Ý: Đây Là Thông Tin Mà Khách Hàng Dựa Vào Để Tìm Đến Bạn, Hãy Chỉnh Sửa Thật Cẩn Thận
                            !!!

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" data-bs-dismiss="modal">Đã
                                Hiểu</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>