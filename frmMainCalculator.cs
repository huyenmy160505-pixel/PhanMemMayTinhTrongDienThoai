using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;          // Thư viện dùng để tính toán (DataTable)
using System.Drawing;       // Thư viện dùng để chỉnh màu sắc
using System.IO;            // Thư viện đọc ghi file


namespace PhanMemMayTinhTrongDienThoai
{
    public partial class frmMainCalculator : Form
    {
        // ========= KHAI BÁO BIẾN TOÀN CỤC =========

        // +++++++++++++++++++++++++++++++++ 1. KHAI BÁO NHỮNG THAO TÁC CHUYỂN ĐỔI FROM +++++++++++++++++++++++++++++++++++++++++++++++++
        // Khai báo biến lưu form lịch sử
        private frmLichSu frmHistory = null;

        // Cài đặt chiều rộng bạn muốn cho phần Lịch sử (ví dụ 400 pixel)
        private int historyWidth = 400;

        // Lưu lại chiều rộng chuẩn
        private int doRongThuGon;
        private int doRongMoRong;

        // 2. Biến lưu Form Chức năng (Bên Trái)
        private frmFunctions? frmFunc = null;

        // 3. Biến lưu Form Chuyển đổi đơn vị (Hiện thay thế)
        private frmChuyenDoiDonVi? frmConvert = null;

        // ++++++++++++++++++++++++++++++++++++ 2. KHAI BÁO NHỮNG  BIẾN DÙNG CHO TÍNH TOÁN ++++++++++++++++++++++++++++++++
        // ============================================================
        // 1. KHAI BÁO BIẾN TOÀN CỤC & MÀU SẮC (THEO YÊU CẦU)
        // ============================================================

        // MÀU TÍM ĐẬM (156, 39, 176) -> Dành cho Phép tính (+ - * / ^ %)
        Color mauDam = Color.FromArgb(156, 39, 176);

        // MÀU TÍM NHẠT (49, 27, 146) -> Dành cho Số, Chữ (sin, cos), Hằng số
        Color mauNhat = Color.FromArgb(49, 27, 146);

        // Biến trạng thái: Radian (True) hay Degree (False)
        private bool isRadian = true;

        public frmMainCalculator()
        {
            InitializeComponent();
        }

        // +++++++++++++++++++++++++++++++++ 1. NHỮNG THAO TÁC CHUYỂN ĐỔI FROM  +++++++++++++++++++++++++++++++++++++++++++++++++
        // ==========================================
        // 1. KHAI BÁO BIẾN CHO KHU VỰC HIỂN THỊ
        // ==========================================

        // Màu tím nhạt theo yêu cầu (#BA68C8)
        Color mauChuDao = ColorTranslator.FromHtml("#BA68C8");

        // Cờ kiểm tra: Vừa bấm dấu Bằng xong phải không?
        private bool vuaBamBang = false;

        // ====== 1. NÚT MỞ Thoát (X) ======
        private void btnCloseSplit_Click(object sender, EventArgs e)
        {
            // Lệnh này sẽ tắt toàn bộ chương trình ngay lập tức
            Application.Exit();
        }

        // ====== 2. NÚT MỞ FUNCTIONS (BÊN TRÁI - Toggle) ======
        private void btnTongleFunc_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu đã mở rồi thì đóng lại (cơ chế Toggle)
            if (frmFunc != null && !frmFunc.IsDisposed)
            {
                frmFunc.Close();
                frmFunc = null;
                return;
            }

            // 1. Gán vào biến TOÀN CỤC (frmFunc) thay vì tạo biến f cục bộ
            frmFunc = new frmFunctions();

            // 2. Cấu hình giao diện
            frmFunc.FormBorderStyle = FormBorderStyle.None;
            frmFunc.StartPosition = FormStartPosition.Manual;
            frmFunc.TopMost = true;
            frmFunc.ShowInTaskbar = false; // Ẩn khỏi thanh taskbar cho gọn

            // 3. COPY KÍCH THƯỚC & VỊ TRÍ (Dùng hàm cập nhật chung để đảm bảo chuẩn)
            CapNhatViTriFormCon();

            // 4. Hiện hình
            frmFunc.Show();
        }

        // ==== 3. NÚT CHUYỂN ĐỔI ĐƠN VỊ (ẨN MAIN - HIỆN CONVERT) ====
        private void btnRuler_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo Form Convert nếu chưa có
            if (frmConvert == null || frmConvert.IsDisposed)
            {
                frmConvert = new frmChuyenDoiDonVi();
                frmConvert.FormCha = this; // Truyền Main sang để lát quay về
            }

            // 2. Đồng bộ vị trí (Để Convert hiện ra đúng chỗ Main đang đứng)
            frmConvert.StartPosition = FormStartPosition.Manual;
            frmConvert.Location = this.Location;

            // --- PHẦN THÊM MỚI: Ẩn Form Chức năng (frmFunc) ---
            // Nếu frmFunc đang mở thì ẩn nó đi luôn cho gọn
            if (frmFunc != null && !frmFunc.IsDisposed)
            {
                frmFunc.Hide();
            }
            // -------------------------------------------------

            // 3. Ẩn Main và Hiện Convert
            this.Hide();
            frmConvert.Show();
        }

        // ========= 4. NÚT LỊCH SỬ (BÊN PHẢI - Toggle) =========
        // --- SỰ KIỆN BẤM NÚT ĐỒNG HỒ (LỊCH SỬ) ---
        private void btnHistory_Click(object sender, EventArgs e)
        {
            // --- TRƯỜNG HỢP 1: ĐANG MỞ THÌ TẮT ---
            if (frmHistory != null && !frmHistory.IsDisposed)
            {
                frmHistory.Close();
                frmHistory = null;
                // Khi tắt thì trả về Full màn hình (Maximized) cho đẹp
                this.WindowState = FormWindowState.Maximized;
            }
            // --- TRƯỜNG HỢP 2: ĐANG TẮT THÌ MỞ ---
            else
            {
                // A. THIẾT LẬP CHẾ ĐỘ CHIA ĐÔI MÀN HÌNH
                this.WindowState = FormWindowState.Normal;

                // Lấy kích thước màn hình
                Rectangle manHinh = Screen.PrimaryScreen.WorkingArea;

                // 1. Đặt Form Main sang bên PHẢI (Chừa chỗ 400px bên trái)
                this.Top = 0;
                this.Left = historyWidth; // Cách lề trái 400px
                this.Height = manHinh.Height;
                this.Width = manHinh.Width - historyWidth; // Chiều rộng còn lại

                // B. TẠO VÀ HIỆN FORM LỊCH SỬ
                frmHistory = new frmLichSu();
                frmHistory.StartPosition = FormStartPosition.Manual;
                frmHistory.Width = historyWidth; // 400px

                frmHistory.Show();

                // C. CẬP NHẬT VỊ TRÍ (Để nó dính vào bên trái ngay lập tức)
                CapNhatViTriFormCon();
            }
        }

        // HÀM DÙNG CHUNG: Cập nhật vị trí (Bắt các Form con chạy về đúng chỗ)
        private void CapNhatViTriFormCon()
        {
            // 1. Xử lý Form Lịch Sử (BÁM SÁT BÊN TRÁI)
            if (frmHistory != null && !frmHistory.IsDisposed)
            {
                frmHistory.Height = this.Height;
                // Logic mới: Lịch sử nằm bên trái của Form Main
                frmHistory.Location = new Point(this.Left - frmHistory.Width, this.Top);
                frmHistory.BringToFront();
            }

            // 2. Xử lý Form Chức Năng (Giữ nguyên bám vào tlpFunctions)
            if (frmFunc != null && !frmFunc.IsDisposed)
            {
                if (!this.Visible)
                {
                    frmFunc.Hide();
                    return;
                }
                frmFunc.Visible = true;
                frmFunc.Size = tlpFunctions.Size;
                frmFunc.Location = tlpFunctions.PointToScreen(Point.Empty);
                frmFunc.BringToFront();
            }
        }

        // Sự kiện DI CHUYỂN: Chỉ cần gọi hàm chung, không viết dài dòng
        private void frmMainCalculator_LocationChanged(object sender, EventArgs e)
        {
            CapNhatViTriFormCon();
        }

        // Sự kiện ĐỔI KÍCH THƯỚC: Chỉ cần gọi hàm chung
        private void frmMainCalculator_SizeChanged(object sender, EventArgs e)
        {
            CapNhatViTriFormCon();
        }

        // --- KHAI BÁO CÁC MẶC ĐỊNH KHUÔN KHỔ THOÁT RA VÀO CỦA GIAO DIỆN  ---
        public void HienLaiGiaoDien()
        {
            // 1. Hiện lại Form Main
            this.Show();

            // 2. Hiện lại Form Chức năng
            if (frmFunc != null && !frmFunc.IsDisposed)
            {
                frmFunc.Show();
                frmFunc.BringToFront();
            }

            // 3. Hiện lại Form Lịch sử
            if (frmHistory != null && !frmHistory.IsDisposed)
            {
                frmHistory.Show();

                // Nếu đang mở lịch sử -> Ép lại chế độ Full màn hình chia đôi
                Rectangle manHinh = Screen.PrimaryScreen.WorkingArea;
                this.WindowState = FormWindowState.Normal;
                this.SetBounds(historyWidth, 0, manHinh.Width - historyWidth, manHinh.Height);
            }
            else
            {
                // Nếu không có lịch sử -> Full màn hình thường
                this.WindowState = FormWindowState.Maximized;
            }

            // 4. Cập nhật dính vị trí
            CapNhatViTriFormCon();
        }

        // ++++++++++++++++++++++++++++++++++++++ 2. NHỮNG BIẾN TÍNH TOÁN ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // SỰ KIỆN LOAD FORM: Cài đặt giao diện ban đầu
        private void frmMainCalculator_Load(object sender, EventArgs e)
        {
            // 1. Căn lề PHẢI cho màn hình nhập (Giống ảnh thực tế)
            rtbMainDisplay.SelectAll();
            rtbMainDisplay.SelectionAlignment = HorizontalAlignment.Right;
            rtbMainDisplay.DeselectAll();

            // 2. Mặc định hiển thị chế độ Rad
            isRadian = false;
            lblDegRad.Text = "";    // Màn hình trên trống
            btnDegRad.Text = "Rad"; // Nút hiện chữ Rad
        }

        // ============================================================
        // 2. CÁC HÀM HỖ TRỢ GIAO DIỆN (CHÈN CHỮ, MÀU SẮC)
        // ============================================================

        // Hàm chèn ký tự chung (Tự động chọn màu dựa vào loại ký tự)
        public void ChenKyTu(string text, bool laPhepTinh)
        {
            // A. Nếu vừa bấm Bằng xong -> Reset màn hình nếu nhập số mới
            if (vuaBamBang)
            {
                // Nếu nhập phép tính thì giữ lại kết quả cũ để tính tiếp
                if (!laPhepTinh)
                {
                    rtbMainDisplay.Text = "";
                    lblPreview.Text = "";
                }
                vuaBamBang = false;
            }

            // B. Chọn màu sắc đúng yêu cầu
            Color mauCanDung = laPhepTinh ? mauDam : mauNhat;

            // C. Kỹ thuật chèn ngay tại con trỏ
            rtbMainDisplay.SelectionColor = mauCanDung;
            rtbMainDisplay.SelectedText = text;

            // D. Reset màu về Tím Nhạt (cho các ký tự nhập phím cứng sau đó) & Căn phải
            rtbMainDisplay.SelectionColor = mauNhat;
            rtbMainDisplay.SelectionAlignment = HorizontalAlignment.Right;
            rtbMainDisplay.Focus();

            // Dòng này giúp cập nhật kết quả ở màn hình dưới ngay khi bấm nút bên Form chức năng
            TinhNhamKetQua();
        }

        // Hàm nhập hàm khoa học (sin, cos...) -> Luôn là Màu Nhạt
        public void NhapHam(string tenHam)
        {
            ChenKyTu(tenHam + "(", false); // false = Không phải phép tính -> Màu Nhạt
        }

        // ============================================================
        // 3. XỬ LÝ NHẬP LIỆU (BÀN PHÍM SỐ & CƠ BẢN)
        // ============================================================

        // Sự kiện cho các nút SỐ (0-9)
        private void NhapSo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChenKyTu(btn.Text, false); // Số -> Màu Nhạt
        }

        // Sự kiện cho các nút PHÉP TÍNH (+, -, x, ÷)
        private void btnCong_Click(object sender, EventArgs e) { ChenKyTu("+", true); } // Phép tính -> Màu Đậm
        private void btnTru_Click(object sender, EventArgs e) { ChenKyTu("-", true); }
        private void btnNhan_Click(object sender, EventArgs e) { ChenKyTu("×", true); }
        private void btnChia_Click(object sender, EventArgs e) { ChenKyTu("÷", true); }

        // Nút Phần trăm (%)
        private void btnPhanTram_Click(object sender, EventArgs e) { ChenKyTu("%", true); }

        // Nút Dấu chấm (,)
        private void btnCham_Click(object sender, EventArgs e) { ChenKyTu(",", false); }

        // Nút Xóa màn hình (C)
        private void btnC_Click(object sender, EventArgs e)
        {
            rtbMainDisplay.Text = "";
            lblPreview.Text = "";
            rtbMainDisplay.Focus();
        }

        // Nút Đổi dấu (+/-)
        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            // Logic: Tìm về đầu số, nếu có '-' thì xóa, chưa có thì thêm
            // (Bạn dùng code cũ cho phần này hoặc code xử lý chuỗi đơn giản)
            ChenKyTu("-", false); // Tạm thời cho chèn dấu trừ đơn giản
        }

        // Nút Ngoặc ()
        private void btnNgoac_Click(object sender, EventArgs e)
        {
            // Logic đơn giản: Nếu ký tự trước là số hoặc ')' -> Đóng ngoặc
            // Ngược lại -> Mở ngoặc
            string s = rtbMainDisplay.Text;
            int pos = rtbMainDisplay.SelectionStart;
            bool moNgoac = true;

            if (pos > 0 && s.Length > 0)
            {
                char c = s[pos - 1];
                if (char.IsDigit(c) || c == ')') moNgoac = false;
            }

            if (moNgoac) ChenKyTu("(", false); // Mở ngoặc -> Màu Nhạt
            else ChenKyTu(")", true);          // Đóng ngoặc -> Màu Đậm
        }

        // ============================================================
        // 4. XỬ LÝ BÀN PHÍM KHOA HỌC (BÊN TRÁI)
        // ============================================================

        private void btnSin_Click(object sender, EventArgs e) { NhapHam("sin"); }
        private void btnCos_Click(object sender, EventArgs e) { NhapHam("cos"); }
        private void btnTan_Click(object sender, EventArgs e) { NhapHam("tan"); }
        private void btnLog_Click(object sender, EventArgs e) { NhapHam("log"); }
        private void btnLn_Click(object sender, EventArgs e) { NhapHam("ln"); }
        private void btnCan_Click(object sender, EventArgs e) { NhapHam("√"); } // Căn bậc 2
        private void btnAbs_Click(object sender, EventArgs e) { NhapHam("Abs"); }

        private void btnPi_Click(object sender, EventArgs e) { ChenKyTu("π", false); }
        private void btnE_Click(object sender, EventArgs e) { ChenKyTu("e", false); }

        // Các nút Mũ (Pow)
        private void btnBinhPhuong_Click(object sender, EventArgs e) { ChenKyTu("^", true); ChenKyTu("2", false); }
        private void btnMu_Click(object sender, EventArgs e) { ChenKyTu("^", true); }
        private void btnMuE_Click(object sender, EventArgs e) { ChenKyTu("e", false); ChenKyTu("^", true); ChenKyTu("(", false); }
        // Nút x^y (Lũy thừa)
        // Khi bấm sẽ hiện dấu ^ (Ví dụ nhập 2 rồi bấm nút này sẽ ra 2^)
        private void btnNghichDao_Click(object sender, EventArgs e) { ChenKyTu("1", false); ChenKyTu("÷", true); ChenKyTu("(", false); }

        // Nút Đổi Chế độ Rad/Deg
        private void btnRadDeg_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem nút đang ghi chữ gì?
            if (btnDegRad.Text == "Rad")
            {
                // --- NGƯỜI DÙNG MUỐN CHUYỂN SANG RADIAN ---
                isRadian = true;          // Bật biến Radian
                lblDegRad.Text = "Rad";   // Màn hình trên hiện chữ "Rad" (Giống ảnh 2)
                btnDegRad.Text = "Deg";   // Nút đổi thành chữ "Deg" (Để lần sau bấm về Độ)
            }
            else
            {
                // --- NGƯỜI DÙNG MUỐN CHUYỂN VỀ ĐỘ (DEGREE) ---
                isRadian = false;         // Tắt biến Radian
                lblDegRad.Text = "";      // Màn hình trên để trống (Giống ảnh 1)
                btnDegRad.Text = "Rad";   // Nút đổi lại thành chữ "Rad"
            }

            // Tính lại kết quả ngay lập tức
            TinhNhamKetQua();
        }

        // ============================================================
        // 5. NÚT XÓA (DEL) - THÔNG MINH (SMART DELETE)
        // ============================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Lấy vị trí con trỏ & Text hiện tại
            int pos = rtbMainDisplay.SelectionStart;
            string text = rtbMainDisplay.Text;

            // Nếu không có gì hoặc con trỏ ở đầu dòng thì không làm gì cả
            if (pos == 0 || string.IsNullOrEmpty(text)) return;

            // 2. DANH SÁCH CÁC HÀM CẦN XÓA CẢ CỤM (CẬP NHẬT ĐẦY ĐỦ)
            // Lưu ý: Phải đặt hàm tên dài lên trước, hàm tên ngắn xuống dưới
            string[] cacHam = {
                // Nhóm Hyperbolic ngược & Lượng giác ngược (5-6 ký tự)
                "asinh(", "acosh(", "atanh(",
                "asin(", "acos(", "atan(", 

                // Nhóm Hyperbolic (4-5 ký tự)
                "sinh(", "cosh(", "tanh(", 

                // Nhóm Toán thường (3-4 ký tự)
                "sin(", "cos(", "tan(",
                "log(", "Abs(", "Exp(", 
                
                // Nhóm ký tự đặc biệt
                "e^(",   // Nút e mũ x
                "1÷(",   // Nút nghịch đảo
                "ln(",   // Logarit tự nhiên
                
                // Nhóm Căn
                "√(", "∛("
            };

            int soKyTuXoa = 1; // Mặc định xóa 1 ký tự (cho số thường)

            // 3. Kiểm tra xem con trỏ có đang đứng sau một hàm nào không?
            string chuoiTruocConTro = text.Substring(0, pos);

            foreach (string ham in cacHam)
            {
                if (chuoiTruocConTro.EndsWith(ham))
                {
                    soKyTuXoa = ham.Length; // Nếu khớp thì xóa độ dài bằng tên hàm
                    break;
                }
            }

            // 4. Thực hiện xóa
            // Bôi đen đoạn cần xóa
            rtbMainDisplay.Select(pos - soKyTuXoa, soKyTuXoa);
            // Thay thế bằng rỗng
            rtbMainDisplay.SelectedText = "";

            // 5. Tính lại kết quả ngay lập tức và Focus lại
            TinhNhamKetQua();
            rtbMainDisplay.Focus();
        }

        // ============================================================
        // 6. BỘ NÃO TÍNH TOÁN (CORE ENGINE)
        // ============================================================

        // Hàm tính toán chính: Trả về số thực (double)
        // HÀM TÍNH TOÁN (ĐÃ CẬP NHẬT ĐỂ HIỂU HÀNG 4 CỦA FORM CHỨC NĂNG)
        // Trong frmMainCalculator.cs

        // CẬP NHẬT LẠI HÀM TÍNH TOÁN (PHIÊN BẢN SỬA LỖI e^ VÀ ASINH)
        private double TinhGiaTriBieuThuc(string bieuThuc)
        {
            // 1. MẸO SỬA LỖI e^: 
            // Đổi "e^" thành hàm "Exp" để máy tính dễ hiểu hơn
            // Ví dụ: e^(2) sẽ thành Exp(2)
            string s = bieuThuc.Replace("e^", "Exp");

            // 2. Chuẩn hóa các ký tự khác
            s = s.Replace(",", ".")
                 .Replace("×", "*")
                 .Replace("÷", "/")
                 .Replace("%", "*0.01")
                 .Replace("π", Math.PI.ToString())
                 .Replace("e", Math.E.ToString()); // Chữ e đứng một mình thì đổi thành số 2.718...

            // 3. Xử lý Giai thừa (!)
            s = XuLyGiaiThua(s);

            // 4. Xử lý Hàm Exp (Chính là e mũ) - MỚI THÊM
            s = XuLyHam(s, "Exp", x => Math.Exp(x));

            // 5. Xử lý Lượng giác thường
            s = XuLyHam(s, "sin", x => isRadian ? Math.Sin(x) : Math.Sin(x * Math.PI / 180));
            s = XuLyHam(s, "cos", x => isRadian ? Math.Cos(x) : Math.Cos(x * Math.PI / 180));
            s = XuLyHam(s, "tan", x => isRadian ? Math.Tan(x) : Math.Tan(x * Math.PI / 180));

            // 6. Xử lý Lượng giác ngược
            s = XuLyHam(s, "asin", x => isRadian ? Math.Asin(x) : Math.Asin(x) * 180 / Math.PI);
            s = XuLyHam(s, "acos", x => isRadian ? Math.Acos(x) : Math.Acos(x) * 180 / Math.PI);
            s = XuLyHam(s, "atan", x => isRadian ? Math.Atan(x) : Math.Atan(x) * 180 / Math.PI);

            // 7. Xử lý Hyperbolic
            s = XuLyHam(s, "sinh", x => Math.Sinh(x));
            s = XuLyHam(s, "cosh", x => Math.Cosh(x));
            s = XuLyHam(s, "tanh", x => Math.Tanh(x));

            // 8. Xử lý HYPERBOLIC NGƯỢC (Đảm bảo logic Logarit thay thế nếu lỗi)
            try
            {
                s = XuLyHam(s, "asinh", x => Math.Asinh(x));
                s = XuLyHam(s, "acosh", x => Math.Acosh(x));
                s = XuLyHam(s, "atanh", x => Math.Atanh(x));
            }
            catch
            {
                // Công thức thay thế cho .NET cũ
                s = XuLyHam(s, "asinh", x => Math.Log(x + Math.Sqrt(x * x + 1)));
                s = XuLyHam(s, "acosh", x => Math.Log(x + Math.Sqrt(x * x - 1)));
                s = XuLyHam(s, "atanh", x => 0.5 * Math.Log((1 + x) / (1 - x)));
            }

            // 9. Xử lý Toán cao cấp khác
            s = XuLyHam(s, "√", x => Math.Sqrt(x));
            s = XuLyHam(s, "∛", x => Math.Cbrt(x));
            s = XuLyHam(s, "log", x => Math.Log10(x));
            s = XuLyHam(s, "ln", x => Math.Log(x));
            s = XuLyHam(s, "Abs", x => Math.Abs(x));

            // 10. Xử lý Mũ (^) thường (Ví dụ 2^3)
            s = XuLyPhepMu(s);

            // 11. Tính toán cuối cùng
            DataTable dt = new DataTable();
            var kq = dt.Compute(s, "");
            return Convert.ToDouble(kq);
        }

        // --- HÀM PHỤ TRỢ: TÍNH GIAI THỪA (!) ---
        private string XuLyGiaiThua(string s)
        {
            // Logic: Quét tìm dấu !
            while (s.Contains("!"))
            {
                int index = s.IndexOf("!");

                // Tìm số đứng trước dấu !
                int left = index - 1;
                while (left >= 0 && (char.IsDigit(s[left]) || s[left] == '.')) left--;
                left++;

                // Lấy con số đó ra
                string soCanTinh = s.Substring(left, index - left);
                if (double.TryParse(soCanTinh, out double n))
                {
                    // Tính giai thừa
                    double ketQua = 1;
                    for (int i = 1; i <= n; i++) ketQua *= i;

                    // Thay thế "5!" bằng "120"
                    s = s.Remove(left, index - left + 1).Insert(left, ketQua.ToString());
                }
                else
                {
                    break; // Tránh treo máy nếu lỗi
                }
            }
            return s;
        }

        // Hàm hỗ trợ xử lý cụm từ khóa (sin, cos...)
        private string XuLyHam(string s, string tenHam, Func<double, double> phepTinh)
        {
            string tuKhoa = tenHam + "(";
            while (s.Contains(tuKhoa))
            {
                try
                {
                    int batDau = s.IndexOf(tuKhoa);
                    int ketThuc = s.IndexOf(")", batDau);
                    if (ketThuc == -1) break;

                    // Lấy ruột bên trong và tính toán nó trước (Đệ quy)
                    string ruot = s.Substring(batDau + tuKhoa.Length, ketThuc - (batDau + tuKhoa.Length));
                    double giaTriRuot = TinhGiaTriBieuThuc(ruot);

                    // Áp dụng phép tính (sin, cos...)
                    double ketQua = phepTinh(giaTriRuot);

                    // Thay thế vào chuỗi cũ
                    s = s.Substring(0, batDau) + ketQua.ToString().Replace(",", ".") + s.Substring(ketThuc + 1);
                }
                catch { break; }
            }
            return s;
        }

        // Hàm hỗ trợ xử lý mũ (^)
        private string XuLyPhepMu(string s)
        {
            while (s.Contains("^"))
            {
                try
                {
                    int index = s.IndexOf("^");
                    // Tìm số bên trái (Cơ số)
                    int left = index - 1;
                    while (left >= 0 && (char.IsDigit(s[left]) || s[left] == '.' || s[left] == '-')) left--;
                    left++;
                    string coSo = s.Substring(left, index - left);

                    // Tìm số bên phải (Số mũ)
                    int right = index + 1;
                    while (right < s.Length && (char.IsDigit(s[right]) || s[right] == '.' || s[right] == '-')) right++;
                    string soMu = s.Substring(index + 1, right - (index + 1));

                    double kq = Math.Pow(double.Parse(coSo), double.Parse(soMu));
                    s = s.Remove(left, right - left).Insert(left, kq.ToString().Replace(",", "."));
                }
                catch { break; }
            }
            return s;
        }

        // ============================================================
        // 7. TÍNH NHẨM (REAL-TIME) & NÚT BẰNG (=)
        // ============================================================

        // Tự động tính mỗi khi nhập liệu
        private void rtbMainDisplay_TextChanged(object sender, EventArgs e)
        {
            TinhNhamKetQua();

            // Đảm bảo luôn căn phải
            rtbMainDisplay.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void TinhNhamKetQua()
        {
            try
            {
                string s = rtbMainDisplay.Text;

                // 1. Nếu trống thì xóa kết quả
                if (string.IsNullOrWhiteSpace(s))
                {
                    lblPreview.Text = "";
                    return;
                }

                // 2. LOGIC TỰ ĐÓNG NGOẶC (Giúp tính nhẩm ngay khi đang nhập)
                // Ví dụ: Nhập "sin(30" -> Tự hiểu là "sin(30)" để tính ra 0.5
                int moNgoac = s.Count(c => c == '(');
                int dongNgoac = s.Count(c => c == ')');

                if (moNgoac > dongNgoac)
                {
                    s += new string(')', moNgoac - dongNgoac);
                }

                // 3. GỌI HÀM TÍNH TOÁN (Nó sẽ tự check biến isRadian để tính Độ hay Rad)
                double kq = TinhGiaTriBieuThuc(s);

                // 4. Hiển thị kết quả
                lblPreview.Text = kq.ToString().Replace(".", ",");
            }
            catch
            {
                // Nếu biểu thức lỗi (ví dụ "5+") thì không hiện gì cả
                lblPreview.Text = "";
            }
        }

        // Nút BẰNG (=) - CHỐT KẾT QUẢ
        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Tính toán lại cho chắc chắn (hoặc lấy từ lblPreview)
                string bieuThuc = rtbMainDisplay.Text;
                if (string.IsNullOrWhiteSpace(bieuThuc)) return;

                double ketQuaSo = TinhGiaTriBieuThuc(bieuThuc);
                string ketQuaChu = ketQuaSo.ToString().Replace(".", ",");

                // 2. LƯU LỊCH SỬ (Biểu thức | Kết quả)
                LuuLichSu(bieuThuc, ketQuaChu);
                // CẬP NHẬT FORM LỊCH SỬ NGAY LẬP TỨC ---
                //if (frmHistory != null && !frmHistory.IsDisposed)
                //{
                //    // Gọi hàm TaiLichSu() bạn vừa đổi thành public ở Bước 1
                //    frmHistory.TaiLichSu();

                //    // Cuộn xuống dòng mới nhất (nếu cần, nhưng code TaiLichSu đã đưa cái mới lên đầu rồi) ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //}

                // 3. ĐƯA KẾT QUẢ LÊN MÀN HÌNH CHÍNH (Thay thế biểu thức)
                rtbMainDisplay.Text = ketQuaChu;

                // Căn chỉnh lại giao diện
                rtbMainDisplay.SelectAll();
                rtbMainDisplay.SelectionAlignment = HorizontalAlignment.Right; // Căn phải
                rtbMainDisplay.DeselectAll();
                rtbMainDisplay.SelectionStart = rtbMainDisplay.Text.Length;

                // 4. Xóa màn hình phụ
                lblPreview.Text = "";
                vuaBamBang = true; // Đánh dấu để lần sau nhập số mới thì tự xóa kết quả này
            }
            catch
            {
                lblPreview.Text = "Lỗi";
            }
        }

        // Hàm ghi file lịch sử (Append)
        private void LuuLichSu(string bieuThuc, string ketQua)
        {
            try
            {
                // Định dạng: Biểu thức|Kết quả
                string line = $"{bieuThuc}|{ketQua}\n";
                File.AppendAllText("history.txt", line);
            }
            catch { }
        }


        ////----------------------------------- frmFunctions --------------------+++++++++++++++++++++++++++++++++++++++++++++++
        //// --- HÀM CHO FORM KHÁC GỌI ĐỂ ĐỔI RAD/DEG ---
        //public void DoiCheDoRadDeg()
        //{
        //    // Gọi lại sự kiện click của nút RadDeg trên Form chính
        //    btnDegRad.PerformClick();
        //}

        ////-----------------------------------frmLichSu -------------------+++++++++++++++++++++++++++++++++++++++++++++++++++++
        //// --- HÀM CHO FORM LỊCH SỬ GỌI ĐỂ XÓA MÀN HÌNH ---
        //public void XoaManHinh()
        //{
        //    // Xóa sạch nội dung đang hiển thị
        //    rtbMainDisplay.Text = "";
        //    lblPreview.Text = "";

        //    // Reset trạng thái
        //    vuaBamBang = false;

        //    // Đưa con trỏ về lại màn hình nhập để sẵn sàng nhập số từ lịch sử
        //    rtbMainDisplay.Focus();
        //}

    }
}

