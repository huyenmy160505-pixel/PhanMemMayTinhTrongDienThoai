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
    public partial class frmChuyenDoiDonVi : Form
    {
        public Form? FormCha { get; set; }

        public frmChuyenDoiDonVi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // 1. Đóng form chuyển đổi hiện tại
            this.Close();

            // 2. Gọi hàm khôi phục bên Form Main
            // Lưu ý: FormCha là biến bạn đã truyền từ Main sang (kiểu Form)
            // Cần ép kiểu về (frmMainCalculator) mới gọi được hàm HienLaiGiaoDien

            if (FormCha != null)
            {
                frmMainCalculator fMain = (frmMainCalculator)FormCha;
                fMain.HienLaiGiaoDien();
            }

        }
    }
}
