# DA_ASP
HỆ THỐNG WEBSITE GIỚI THIỆU SẢN PHẨM VÀ ĐẶT HÀNG
• Công nghệ cốt lõi: ASP.NET Core (MVC hoặc Razor Pages), Entity Framework
Core, SQL Server.
• Tài nguyên đầu vào: Bộ giao diện tĩnh (HTML, CSS, JS, Images) cho cả trang người
dùng (Client) và trang quản trị (Admin) đã được cung cấp sẵn.
1. Yêu cầu Chức năng (Functional Requirements)
Phân hệ Người dùng (Client)
Hiển thị sản phẩm:
• Tích hợp giao diện hiển thị danh sách tất cả sản phẩm.
• Lọc sản phẩm theo danh mục.
• Xem chi tiết một sản phẩm (hình ảnh, giá bán, mô tả).
Giỏ hàng (Shopping Cart):
• Thêm sản phẩm vào giỏ hàng từ trang danh sách hoặc trang chi tiết.
• Xem giỏ hàng: Cập nhật số lượng, tính tổng tiền, xóa sản phẩm khỏi giỏ.
• Lưu ý: Trạng thái giỏ hàng cần được lưu trữ bằng Session hoặc Cookie để không bị mất
khi tải lại trang.
Đặt hàng (Checkout):
• Cung cấp form điền thông tin người đặt mua (Họ tên, Số điện thoại, Địa chỉ giao hàng,
Ghi chú).
• Lưu thông tin tổng quan của đơn hàng và chi tiết từng sản phẩm trong đơn vào cơ sở
dữ liệu.
• Hiển thị trang thông báo đặt hàng thành công và làm sạch giỏ hàng.
Phân hệ Quản trị (Admin)
Quản lý Danh mục (Categories):
• Thêm mới, xem danh sách, cập nhật và xóa danh mục sản phẩm.

HỆ THỐNG WEBSITE GIỚI THIỆU SẢN PHẨM VÀ ĐẶT HÀNG
Quản lý Sản phẩm (Products):
• Thêm mới sản phẩm (bao gồm chức năng upload hình ảnh và lưu file vào thư mục
wwwroot/images).
• Xem, sửa, xóa thông tin sản phẩm.
Quản lý Đơn hàng (Orders):
• Xem danh sách các đơn hàng khách đã đặt.
• Xem chi tiết sản phẩm của từng đơn hàng.
• Cập nhật trạng thái đơn hàng (Ví dụ: Chờ xử lý → Đang giao → Hoàn thành / Đã hủy).
2. Yêu cầu Kỹ thuật & Tích hợp
Tích hợp Giao diện (UI Integration):
• Chuyển đổi bộ mã HTML/CSS tĩnh thành các Razor Views (.cshtml).
• Tách các thành phần dùng chung như Header, Footer, Sidebar, Menu vào file
_Layout.cshtml hoặc sử dụng Partial Views để tái sử dụng mã nguồn.
Tương tác Cơ sở dữ liệu:
• Sử dụng Entity Framework Core (mô hình Code-First hoặc Database-First).
• Thiết kế cơ sở dữ liệu với tối thiểu 4 bảng quan hệ: Category, Product, Order,
OrderDetail.
Xử lý Dữ liệu & Bảo mật cơ bản:
• Sử dụng Data Annotations trong Models để validate dữ liệu từ server-side (ví dụ: Tên
sản phẩm không được để trống, số điện thoại phải đúng định dạng).
• Yêu cầu đăng nhập tài khoản Admin (Authentication đơn giản) trước khi cho phép truy
cập vào các trang quản lý.
3. Cấu trúc Bàn giao (Deliverables)
• Mã nguồn: Toàn bộ source code dự án ASP.NET Core (đã xóa các thư mục bin, obj
để giảm dung lượng).
• Cơ sở dữ liệu: File script (.sql) để khởi tạo database và dữ liệu mẫu, hoặc đảm bảo
cấu hình EF Core Migrations có thể tự động tạo database (Update-Database).

HỆ THỐNG WEBSITE GIỚI THIỆU SẢN PHẨM VÀ ĐẶT HÀNG
• Tài liệu: Báo cáo ngắn hoặc file README.md hướng dẫn cấu hình chuỗi kết nối
(Connection String) và cách chạy dự án.
