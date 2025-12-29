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
    public partial class ucBanPhim : UserControl
    {
        public ucBanPhim()
        {
            InitializeComponent();
        }

        // ========================================================
        // HÀM GỬI LỆNH LÊN FORM CHA (CÁI REMOTE)
        // ========================================================
        private void GuiLenhVeFormCha(string maLenh)
        {
            // 1. Tìm xem Form nào đang chứa cái bàn phím này
            Form parentForm = this.FindForm();

            // 2. Nếu Form cha là Form Chuyển Đổi Đơn Vị
            if (parentForm is frmChuyenDoiDonVi)
            {
                // Gọi hàm nhận lệnh bên đó
                ((frmChuyenDoiDonVi)parentForm).NhanLenhBanPhim(maLenh);
            }

            // (Mở rộng: Nếu sau này bạn dùng bàn phím này cho Form khác thì thêm else if ở đây)
        }

        // ========================================================
        // SỰ KIỆN CLICK CHO CÁC NÚT SỐ (0 - 9)
        // ========================================================
        private void btn0_Click(object sender, EventArgs e) { GuiLenhVeFormCha("0"); }
        private void btn1_Click(object sender, EventArgs e) { GuiLenhVeFormCha("1"); }
        private void btn2_Click(object sender, EventArgs e) { GuiLenhVeFormCha("2"); }
        private void btn3_Click(object sender, EventArgs e) { GuiLenhVeFormCha("3"); }
        private void btn4_Click(object sender, EventArgs e) { GuiLenhVeFormCha("4"); }
        private void btn5_Click(object sender, EventArgs e) { GuiLenhVeFormCha("5"); }
        private void btn6_Click(object sender, EventArgs e) { GuiLenhVeFormCha("6"); }
        private void btn7_Click(object sender, EventArgs e) { GuiLenhVeFormCha("7"); }
        private void btn8_Click(object sender, EventArgs e) { GuiLenhVeFormCha("8"); }
        private void btn9_Click(object sender, EventArgs e) { GuiLenhVeFormCha("9"); }

        // ========================================================
        // SỰ KIỆN CÁC NÚT CHỨC NĂNG
        // ========================================================

        // Nút Dấu Phẩy (,)
        private void btnCham_Click(object sender, EventArgs e)
        {
            GuiLenhVeFormCha(",");
        }

        // Nút Xóa Hết (C - Clear)
        private void btnC_Click(object sender, EventArgs e)
        {
            GuiLenhVeFormCha("C");
        }

        // Nút Xóa Lùi (Backspace - Hình mũi tên có dấu X)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            GuiLenhVeFormCha("DEL");
        }

        // Nút Đổi Dấu (+/-)
        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            GuiLenhVeFormCha("+/-");
        }

        // Nút Mũi Tên Lên (Chỉnh đơn vị đích) - Nếu bạn có nút này
        private void btnLen_Click(object sender, EventArgs e)
        {
            // Tạm thời chưa xử lý hoặc có thể gửi mã "UP" nếu muốn mở rộng sau này
        }

        // Nút Mũi Tên Xuống (Chỉnh đơn vị đích) - Nếu bạn có nút này
        private void btnXuong_Click(object sender, EventArgs e)
        {
            // Tương tự
        }
    }
}