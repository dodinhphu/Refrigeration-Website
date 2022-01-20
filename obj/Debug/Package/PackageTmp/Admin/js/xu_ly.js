function xoadanhmuc(ma) {
    if (confirm("Bạn Chắc Chắn Muốn Xóa Danh Mục Này ?")) {

        $.post("Admin/ajax/thao_tac_DanhMuc.aspx",
            {
                "thaotac": "xoadanhmuc",
                "ma": ma
            },
            function (data, status) {
                if (data == "1") {
                    $("#ma_" + ma).remove();
                }
                else {
                    alert("Danh Muc Này Đang Chứa Các Bài Viết !!, Trước Khi Xóa Danh Mục Bạn Cần Xóa Hết Các Bài Viết !!! ");
                }
            });
    }
}

function xoapost(ma) {
    if (confirm("Bạn Chắc Chắn Muốn Xóa Bài Viết " + ma + " ?")) {

        $.post("Admin/ajax/thao_tac_post.aspx",
            {
                "thaotac": "xoapost",
                "ma": ma
            },
            function (data, status) {

                if (data == "1") {
                    $("#ma_" + ma).remove();
                }
                else {
                    alert("Xoá Không Thành Công!");
                }
            });
    }
}