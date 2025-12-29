
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;            // Thư viện đọc file

namespace PhanMemMayTinhTrongDienThoai
{
    public partial class frmLichSu : Form
    {
        public Form? FormCha { get; set; }

        // ==========================================
        // 1. KHAI BÁO MÀU SẮC (GIỐNG FORM CHÍNH)
        // ==========================================
        Color mauDam = Color.FromArgb(156, 39, 176); // Kết quả
        Color mauNhat = Color.FromArgb(49, 27, 146); // Biểu thức

        public frmLichSu()
        {
            InitializeComponent();
        }
        // ==========================================
        // 2. LOGIC TẢI DỮ LIỆU (LOAD)
        // ==========================================
        private void frmLichSu_Load(object sender, EventArgs e)
        {
            TaiLichSu();
        }

        public void TaiLichSu()
        {
            // A. Dọn dẹp cũ
            pnlDanhSachLichSu.Controls.Clear();

            // B. Đường dẫn file (Dùng chung logic với Form Chính)
            string filePath = Path.Combine(Application.StartupPath, "history.txt");

            // C. Kiểm tra xem file có tồn tại và có dữ liệu không
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                // TRƯỜNG HỢP TRỐNG:
                HienThiTrangThaiRong(true);
                return;
            }

            // TRƯỜNG HỢP CÓ DỮ LIỆU:
            HienThiTrangThaiRong(false);

            try
            {
                // Đọc tất cả các dòng
                string[] lines = File.ReadAllLines(filePath);

                // D. Vòng lặp ĐẢO NGƯỢC (i--) để cái MỚI NHẤT hiện lên TRÊN CÙNG
                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    string line = lines[i];
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Tách Biểu thức | Kết quả
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        string bieuThuc = parts[0];
                        string ketQua = parts[1];

                        // Tạo giao diện cho dòng này
                        TaoDongLichSu(bieuThuc, ketQua);
                    }
                }
            }
            catch
            {
                // Nếu lỗi đọc file thì coi như rỗng
                HienThiTrangThaiRong(true);
            }
        }

        // Hàm ẩn hiện thông báo "Chưa có lịch sử"
        public void HienThiTrangThaiRong(bool isEmpty)
        {
            if (isEmpty)
            {
                lblThongBao.Visible = true;          // Hiện thông báo
                lblThongBao.BringToFront();          // Đưa lên trên cùng
                pnlDanhSachLichSu.Visible = false;   // Ẩn danh sách
                btnXoaNhatKy.Enabled = false;        // Khóa nút xóa
            }
            else
            {
                lblThongBao.Visible = false;         // Ẩn thông báo
                pnlDanhSachLichSu.Visible = true;    // Hiện danh sách
                pnlDanhSachLichSu.BringToFront();
                btnXoaNhatKy.Enabled = true;         // Mở nút xóa
            }
        }

        // ==========================================
        // 3. LOGIC TẠO GIAO DIỆN ĐỘNG (ĐÃ CĂN CHỈNH ĐẸP)
        // ==========================================
        private void TaoDongLichSu(string bieuThuc, string ketQua)
        {
            // 1. Tạo Panel chứa (Một dòng lịch sử)
            Panel pnlItem = new Panel();
            // Trừ hao thanh cuộn nhiều hơn chút (30px) để không bị che
            pnlItem.Width = pnlDanhSachLichSu.Width - 30;

            // TĂNG CHIỀU CAO: Từ 60 lên 90 để chứa chữ to
            pnlItem.Height = 90;

            // Căn lề: Cách phải 10px để chữ không dính sát lề
            pnlItem.Padding = new Padding(5, 5, 10, 5);
            pnlItem.Margin = new Padding(0, 0, 0, 5); // Khoảng cách giữa các ô
            pnlItem.BackColor = Color.WhiteSmoke;     // Màu nền nhẹ

            // Sự kiện click
            pnlItem.Click += (s, e) => ChonLichSu(bieuThuc);

            // 2. Label Biểu thức (Ở trên) -> TĂNG CỠ CHỮ
            Label lblBieuThuc = new Label();
            lblBieuThuc.Text = bieuThuc;
            lblBieuThuc.ForeColor = mauNhat;

            // Font chữ to hơn: Cỡ 13 (Cũ là 10)
            lblBieuThuc.Font = new Font("Segoe UI", 13, FontStyle.Regular);

            lblBieuThuc.Dock = DockStyle.Top;       // Dính lên trên
            lblBieuThuc.Height = 40;                // Chiếm 40px chiều cao
            lblBieuThuc.TextAlign = ContentAlignment.BottomRight; // Căn dưới - phải
            lblBieuThuc.Click += (s, e) => ChonLichSu(bieuThuc);

            // 3. Label Kết quả (Ở dưới) -> TĂNG CỠ CHỮ ĐẬM
            Label lblKetQua = new Label();
            lblKetQua.Text = "= " + ketQua;
            lblKetQua.ForeColor = mauDam;

            // Font chữ to hơn: Cỡ 17 Đậm (Cũ là 12)
            lblKetQua.Font = new Font("Segoe UI", 17, FontStyle.Bold);

            lblKetQua.Dock = DockStyle.Bottom;      // Dính xuống dưới
            lblKetQua.Height = 40;                  // Chiếm 40px chiều cao
            lblKetQua.TextAlign = ContentAlignment.TopRight; // Căn trên - phải
            lblKetQua.Click += (s, e) => ChonLichSu(bieuThuc);

            // 4. Gắn vào Panel cha
            pnlItem.Controls.Add(lblBieuThuc);
            pnlItem.Controls.Add(lblKetQua);

            // 5. Đưa Panel vào danh sách
            pnlDanhSachLichSu.Controls.Add(pnlItem);
        }

        // ==========================================
        // 4. TƯƠNG TÁC NGƯỢC (RECALL - BẤM LÀ CHỌN)
        // ==========================================
        private void ChonLichSu(string bieuThuc)
        {
            // Tìm Form Chính
            frmMainCalculator formChinh = Application.OpenForms["frmMainCalculator"] as frmMainCalculator;

            if (formChinh != null)
            {
                // A. Gán biểu thức vào màn hình chính
                // Lưu ý: Cần đảm bảo rtbMainDisplay ở Form Chính là 'public' hoặc có hàm gán
                // Ở đây mình giả định bạn đã có hàm ChenKyTu hoặc truy cập trực tiếp

                // Cách an toàn nhất: Gọi hàm ChenKyTu bên Form Chính (Xóa cũ đi trước)
                formChinh.XoaManHinh(); // Bạn cần thêm hàm public XoaManHinh() bên Form Chính nếu chưa có
                formChinh.ChenKyTu(bieuThuc, false);
            }
        }

        // ==========================================
        // 5. CHỨC NĂNG XÓA (DELETE) - KHÔNG CẦN HỎI
        // ==========================================
        private void btnXoaNhatKy_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "history.txt");

                // 1. Xóa file ngay lập tức
                if (File.Exists(filePath)) File.Delete(filePath);

                // 2. Tải lại giao diện (Nó sẽ tự nhảy vào case Rỗng: "Chưa có lịch sử...")
                TaiLichSu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xóa được: " + ex.Message);
            }
        }
    }
}



