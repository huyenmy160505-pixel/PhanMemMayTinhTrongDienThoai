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
        private void btnCloseSplit_Click(object sender, EventArgs e)
                {
                    // Lệnh này sẽ tắt toàn bộ chương trình ngay lập tức
                    Application.Exit();
                }

        // ====== 1. NÚT MỞ FUNCTIONS (BÊN TRÁI - Toggle) ======
        private void btnTongleFunc_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo form chức năng
            frmFunctions f = new frmFunctions();

            // 2. Cấu hình giao diện: Không viền, cho phép chỉnh vị trí tay
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.Manual;
            f.TopMost = true; // Để chắc chắn nó nổi lên trên cùng

            // 3. COPY KÍCH THƯỚC: Bắt form mới to bằng đúng cái khung tlpFunctions
            f.Size = tlpFunctions.Size;

            // 4. COPY VỊ TRÍ: Tìm vị trí thật trên màn hình của tlpFunctions để đè lên
            // Point.Empty nghĩa là lấy góc trên-trái (0,0) của tlpFunctions
            f.Location = tlpFunctions.PointToScreen(Point.Empty);

            // 5. Hiện hình
            f.Show();
        }


        // ==== 2. NÚT CHUYỂN ĐỔI ĐƠN VỊ (ẨN MAIN - HIỆN CONVERT) ====
        private void btnRuler_Click(object sender, EventArgs e)
        {
            if (frmConvert == null || frmConvert.IsDisposed)
            {
                frmConvert = new frmChuyenDoiDonVi();
                frmConvert.FormCha = this; // Truyền Main sang để lát quay về
            }

            // Đồng bộ vị trí
            frmConvert.StartPosition = FormStartPosition.Manual;
            frmConvert.Location = this.Location;

            this.Hide();        // Ẩn Main đi
            frmConvert.Show();  // Hiện Convert lên
        }


        // ========= 3. NÚT LỊCH SỬ (BÊN PHẢI - Toggle) =========
        // (Đã sửa lỗi đoạn này cho bạn)
        // SỰ KIỆN BẤM NÚT ĐỒNG HỒ (LỊCH SỬ)
        private void btnHistory_Click(object sender, EventArgs e)
        {
            // --- TRƯỜNG HỢP 1: ĐANG MỞ THÌ TẮT ---
            if (frmHistory != null && !frmHistory.IsDisposed)
            {
                frmHistory.Close();
                frmHistory = null;

                // Trả Form Main về trạng thái Full màn hình cũ
                this.WindowState = FormWindowState.Maximized;
            }
            // --- TRƯỜNG HỢP 2: ĐANG TẮT THÌ MỞ (BÊN TRÁI) ---
            else
            {
                // A. XỬ LÝ FORM MAIN (CHỦ NHÀ)
                // Phải đưa về Normal mới chỉnh kích thước được (Maximized bị khóa cứng)
                this.WindowState = FormWindowState.Normal;

                // Lấy kích thước màn hình hiện tại
                Rectangle manHinh = Screen.PrimaryScreen.WorkingArea;

                // Đặt Form Main dịch sang phải (để chừa chỗ bên trái)
                this.Top = 0;
                this.Left = historyWidth; // Cách lề trái một đoạn
                this.Height = manHinh.Height;
                this.Width = manHinh.Width - historyWidth; // Chiều rộng còn lại

                // B. XỬ LÝ FORM LỊCH SỬ (KHÁCH)
                frmHistory = new frmLichSu();

                // Code tự chỉnh giao diện (khỏi cần chỉnh tay Property)
                frmHistory.FormBorderStyle = FormBorderStyle.None; // Bỏ viền
                frmHistory.ShowInTaskbar = false;
                frmHistory.Owner = this;
                frmHistory.StartPosition = FormStartPosition.Manual;

                // Đặt Form Lịch sử vào góc trên cùng bên TRÁI (0,0)
                frmHistory.Location = new Point(0, 0);

                // Kích thước lấp đầy phần bên trái
                frmHistory.Width = historyWidth;
                frmHistory.Height = manHinh.Height;

                frmHistory.Show();
            }
        }

        // 3. SỰ KIỆN DI CHUYỂN (Chống lỗi khi user lỡ tay kéo Form Main lung tung)
        private void frmMainCalculator_LocationChanged(object sender, EventArgs e)
        {
            // Nếu Lịch sử đang mở, bắt buộc nó phải dính vào mép trái của Main
            if (frmHistory != null && !frmHistory.IsDisposed)
            {
                // Nếu Form Main bị kéo đi, Form Lịch sử chạy theo (nằm bên trái)
                frmHistory.Location = new Point(this.Location.X - frmHistory.Width, this.Location.Y);
                frmHistory.Height = this.Height;
            }
        }

        // --- DÁN ĐOẠN NÀY VÀO CUỐI CLASS frmMainCalculator ---

        public void HienLaiGiaoDien()
        {
            this.Show(); // Hiện Form Main trước

            // Kiểm tra: Nếu biến frmHistory vẫn còn (tức là lúc trước đang mở)
            if (frmHistory != null && !frmHistory.IsDisposed)
            {
                // 1. Tính toán lại kích thước (đề phòng bị nhảy)
                Rectangle manHinh = Screen.PrimaryScreen.WorkingArea;
                int rongLichSu = 400; // Số này phải khớp với nút btnHistory_Click

                // 2. Ép Form Main về chế độ chia đôi
                this.WindowState = FormWindowState.Normal;
                this.SetBounds(rongLichSu, 0, manHinh.Width - rongLichSu, manHinh.Height);

                // 3. Hiện Form Lịch sử và đặt lại vị trí
                frmHistory.Show(); // Bắt buộc gọi lại lệnh này
                frmHistory.SetBounds(0, 0, rongLichSu, manHinh.Height);
            }
            else
            {
                // Nếu lúc trước không mở lịch sử -> Về Full màn hình
                this.WindowState = FormWindowState.Maximized;
            }
        }

    }
}