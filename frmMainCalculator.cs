using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;          // Thư viện dùng để tính toán (DataTable)
using System.Drawing;       // Thư viện dùng để chỉnh màu sắc
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemMayTinhTrongDienThoai
{
    public partial class frmMainCalculator : Form
    {
        // ========= KHAI BÁO BIẾN TOÀN CỤC =========

        // +++++++++++++++++++++++++++++++++ Khai báo những thao tác chuyển đổi from +++++++++++++++++++++++++++++++++++++++++++++++++
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


        public frmMainCalculator()
        {
            InitializeComponent();
        }


        // +++++++++++++++++++++++++++++++++ Khai báo những thao tác chuyển đổi from +++++++++++++++++++++++++++++++++++++++++++++++++

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




    }
}