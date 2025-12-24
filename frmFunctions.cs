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
    }
}
