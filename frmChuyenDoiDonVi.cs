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
            // Chỉ ẩn Form này đi thôi, KHÔNG đóng hẳn
            this.Hide();

            // Nếu có Form Cha (Form Máy Tính) thì hiện nó lên lại
            if (FormCha != null)
            {
                FormCha.Location = this.Location; // Form Cha hiện ra đúng chỗ này
                FormCha.Show();
            }

        }
    }
}
