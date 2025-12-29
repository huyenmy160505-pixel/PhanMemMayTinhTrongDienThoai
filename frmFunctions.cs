using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemMayTinhTrongDienThoai
{
    public partial class frmFunctions : Form
    {

        // Khi Form Con mở lên, nó cần biết "Ai là bố mình?" để khi cần(ví dụ khi tắt đi) nó còn biết đường báo lại cho bố, hoặc để lấy vị trí của bố mà đứng bên cạnh.

        // Biến FormCha chính là tờ giấy ghi nhớ để Form Con lưu giữ thông tin về Form Bố.
        public Form? FormCha { get; set; }
        public frmFunctions()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Lệnh này đơn giản là đóng Form hiện tại lại
            this.Close();
        }

        // --- HÀM LIÊN KẾT: GỬI LỆNH VỀ FORM CHÍNH ---
        private void GuiLenhVeMain(string noiDung, bool laPhepTinh, bool laHam = false)
        {
            // Tìm Form Chính đang mở
            frmMainCalculator formChinh = Application.OpenForms["frmMainCalculator"] as frmMainCalculator;

            if (formChinh != null)
            {
                if (laHam)
                {
                    // Nếu là hàm (sin, cos...) -> Gọi hàm NhapHam
                    formChinh.NhapHam(noiDung);
                }
                else
                {
                    // Nếu là ký tự thường hoặc phép tính -> Gọi hàm ChenKyTu
                    formChinh.ChenKyTu(noiDung, laPhepTinh);
                }
            }
        }

        // 1. NHÓM LƯỢNG GIÁC NGƯỢC (Arc Functions)
        // Hiển thị: asin(, acos(...
        private void btnAsin_Click(object sender, EventArgs e) { GuiLenhVeMain("asin", false, true); }
        private void btnAcos_Click(object sender, EventArgs e) { GuiLenhVeMain("acos", false, true); }
        private void btnAtan_Click(object sender, EventArgs e) { GuiLenhVeMain("atan", false, true); }

        // 2. NHÓM HYPERBOLIC
        private void btnSinh_Click(object sender, EventArgs e) { GuiLenhVeMain("sinh", false, true); }
        private void btnCosh_Click(object sender, EventArgs e) { GuiLenhVeMain("cosh", false, true); }
        private void btnTanh_Click(object sender, EventArgs e) { GuiLenhVeMain("tanh", false, true); }

        // 3. NHÓM HYPERBOLIC NGƯỢC (sinh⁻¹, cosh⁻¹, tanh⁻¹)
        // Khi bấm sẽ gửi lệnh: asinh, acosh, atanh
        private void btnAsinh_Click(object sender, EventArgs e) { GuiLenhVeMain("asinh", false, true); }
        private void btnAcosh_Click(object sender, EventArgs e) { GuiLenhVeMain("acosh", false, true); }
        private void btnAtanh_Click(object sender, EventArgs e) { GuiLenhVeMain("atanh", false, true); }

        // 4. NHÓM TOÁN HỌC KHÁC
        private void btnCan3_Click(object sender, EventArgs e) { GuiLenhVeMain("∛", false, true); } // Căn 3

        // Giai thừa (!): Màu Đậm (true)
        private void btnGiaiThua_Click(object sender, EventArgs e) { GuiLenhVeMain("!", true, false); }

        // Lập phương (x³): Gửi 2 lần lệnh
        private void btnLapPhuong_Click(object sender, EventArgs e)
        {
            GuiLenhVeMain("^", true, false);  // Dấu mũ (Đậm)
            GuiLenhVeMain("3", false, false); // Số 3 (Nhạt)
        }

        // Lũy thừa cơ số 2 (2ˣ)
        private void btnMu2_Click(object sender, EventArgs e)
        {
            GuiLenhVeMain("2", false, false); // Số 2
            GuiLenhVeMain("^", true, false);  // Dấu mũ
            GuiLenhVeMain("(", false, false); // Mở ngoặc
        }

        // NÚT RAD (Hàng 1, Cột 2)
        private void btnRad_Click(object sender, EventArgs e)
        {
            // Tìm Form Chính và yêu cầu đổi chế độ
            frmMainCalculator? formChinh = Application.OpenForms["frmMainCalculator"] as frmMainCalculator;
            if (formChinh != null)
            {
                formChinh.DoiCheDoRadDeg();
                btnDegRad.Text = "Deg";
            }
        }
    }
}