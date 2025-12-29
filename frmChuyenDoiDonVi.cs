using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PhanMemMayTinhTrongDienThoai
{
    public partial class frmChuyenDoiDonVi : Form
    {
        public Form FormCha { get; set; }

        // ======================================================================================
        // PHẦN 1: CẤU TRÚC DỮ LIỆU & BIẾN TOÀN CỤC
        // ======================================================================================

        // Class này giống như một cái "Túi" chứa toàn bộ đồ đạc của 1 Tab
        // Giúp ta không cần viết code lặp lại cho từng Tab (Diện tích, Độ dài...)
        private class BoDieuKien
        {
            public ComboBox CboNguon;      // Danh sách đơn vị Nguồn (Trái)
            public ComboBox CboDich;       // Danh sách đơn vị Đích (Phải)
            public TextBox TxtNhap;        // Ô nhập liệu (Trên)
            public TextBox TxtKetQua;      // Ô kết quả (Dưới)
            public Label LblKyHieuNguon;   // Chữ ký hiệu nhỏ (ví dụ: m2)
            public Label LblKyHieuDich;    // Chữ ký hiệu nhỏ (ví dụ: cm2)
            public FlowLayoutPanel PnlPhu; // Cái bảng danh sách mờ bên dưới
            public Dictionary<string, double> DataTyLe; // Bảng tỷ lệ quy đổi của Tab này
        }

        // Đây là "Bản đồ": Giúp máy tính biết Tab hiện tại đang dùng cái "Túi" nào
        private Dictionary<TabPage, BoDieuKien> mapTabs = new Dictionary<TabPage, BoDieuKien>();

        // Biến ghi nhớ: Người dùng đang để con trỏ chuột ở ô nào? (Để bàn phím ảo biết đường nhập)
        private TextBox txtDangFocus = null;

        // Cờ hiệu quan trọng: Ngăn chặn vòng lặp vô tận khi tính toán
        // (Ví dụ: Nhập A -> Tính B -> B thay đổi -> Lại tính ngược ra A -> Vòng lặp chết)
        private bool isUpdating = false;

        public frmChuyenDoiDonVi()
        {
            InitializeComponent();
            KhoiTaoDuLieuVaMap(); // Bước 1: Nạp dữ liệu
            GanSuKienTuDong();    // Bước 2: Nối dây điện (Gắn sự kiện)
        }

        // ======================================================================================
        // PHẦN 2: KHỞI TẠO DỮ LIỆU TỶ LỆ (DATABASE)
        // ======================================================================================
        private void KhoiTaoDuLieuVaMap()
        {
            // Định nghĩa tỷ lệ quy đổi (Lấy 1 đơn vị làm chuẩn = 1, các cái khác nhân/chia theo)
            // Ví dụ: Mét là 1. Kilomet là 1000. Milimet là 0.001
            var dDienTich = new Dictionary<string, double> { { "Mét vuông (m²)", 1 }, { "Centimet vuông (cm²)", 0.0001 }, { "Are (a)", 100 }, { "Hectare (ha)", 10000 }, { "Inch vuông (in²)", 0.00064516 }, { "Feet vuông (ft²)", 0.092903 }, { "Acre (ac)", 4046.86 } };
            var dDoDai = new Dictionary<string, double> { { "Mét (m)", 1 }, { "Milimet (mm)", 0.001 }, { "Centimet (cm)", 0.01 }, { "Kilomet (km)", 1000 }, { "Inch (in)", 0.0254 }, { "Feet (ft)", 0.3048 }, { "Yard (yd)", 0.9144 }, { "Dặm (mi)", 1609.34 }, { "Hải lý (NM)", 1852 } };
            var dTheTich = new Dictionary<string, double> { { "Lít (L)", 1 }, { "Mililit (mL)", 0.001 }, { "Centimet khối (cc)", 0.001 }, { "Mét khối (m3)", 1000 }, { "Inch khối (in3)", 0.0163871 }, { "Feet khối (ft3)", 28.3168 }, { "Gallon Anh (gal)", 4.54609 }, { "Gallon Mỹ (gal)", 3.78541 } };
            var dKhoiLuong = new Dictionary<string, double> { { "Kilogram (kg)", 1 }, { "Gram (g)", 0.001 }, { "Tấn (t)", 1000 }, { "Pound (lb)", 0.453592 }, { "Ounce (oz)", 0.0283495 } };
            var dDuLieu = new Dictionary<string, double> { { "Bit (bit)", 1 }, { "Byte (B)", 8 }, { "Kilobyte (KB)", 8000 }, { "Megabyte (MB)", 8000000 }, { "Gigabyte (GB)", 8000000000 } };
            var dTocDo = new Dictionary<string, double> { { "m/s", 1 }, { "km/h", 0.277778 }, { "mi/h", 0.44704 }, { "kn", 0.514444 } };
            var dThoiGian = new Dictionary<string, double> { { "Giây (s)", 1 }, { "Phút (min)", 60 }, { "Giờ (h)", 3600 }, { "Ngày (d)", 86400 } };

            // Ánh xạ (Mapping): Gán dữ liệu và Control vào từng Tab cụ thể
            // Ví dụ: Tab Diện Tích thì dùng ComboBox Diện Tích và Bảng tỷ lệ Diện Tích
            mapTabs.Add(tabPage2, new BoDieuKien { CboNguon = cboDienTich_Nguon, CboDich = cboDienTich_Dich, TxtNhap = txtDienTich_SoNhap, TxtKetQua = txtDienTich_KetQua, LblKyHieuNguon = lblDienTich_KyHieuNguon, LblKyHieuDich = lblDienTich_KyHieuDich, PnlPhu = pnlDienTich_Phu, DataTyLe = dDienTich });
            mapTabs.Add(tabPage1, new BoDieuKien { CboNguon = cboDoDai_Nguon, CboDich = cboDoDai_Dich, TxtNhap = txtDoDai_SoNhap, TxtKetQua = txtDoDai_Dich, LblKyHieuNguon = lblDoDai_KyHieuNguon, LblKyHieuDich = lblDoDai_KyHieuDich, PnlPhu = pnlDoDai_Phu, DataTyLe = dDoDai });
            mapTabs.Add(tabPage4, new BoDieuKien { CboNguon = cboTheTich_Nguon, CboDich = cboTheTich_Dich, TxtNhap = txtTheTich_SoNhap, TxtKetQua = txtTheTich_KetQua, LblKyHieuNguon = lblTheTich_KyHieuNguon, LblKyHieuDich = lblTheTich_KyHieuDich, PnlPhu = pnlTheTich_Phu, DataTyLe = dTheTich });
            mapTabs.Add(tabPage5, new BoDieuKien { CboNguon = cboKhoiLuong_Nguon, CboDich = cboKhoiLuong_Dich, TxtNhap = txtKhoiLuong_SoNhap, TxtKetQua = txtKhoiLuong_KetQua, LblKyHieuNguon = lblKhoiLuong_KyHieuNguon, LblKyHieuDich = lblKhoiLuong_KyHieuDich, PnlPhu = pnlKhoiLuong_Phu, DataTyLe = dKhoiLuong });
            mapTabs.Add(tabPage6, new BoDieuKien { CboNguon = cboDuLieu_Nguon, CboDich = cboDuLieu_Dich, TxtNhap = txtDuLieu_SoNhap, TxtKetQua = txtDuLieu_KetQua, LblKyHieuNguon = lblDuLieu_KyHieuNguon, LblKyHieuDich = lblDuLieu_KyHieuDich, PnlPhu = pnlDuLieu_Phu, DataTyLe = dDuLieu });
            mapTabs.Add(tabPage7, new BoDieuKien { CboNguon = cboTocDo_Nguon, CboDich = cboTocDo_Dich, TxtNhap = txtTocDo_SoNhap, TxtKetQua = txtTocDo_KetQua, LblKyHieuNguon = lblTocDo_KyHieuNguon, LblKyHieuDich = lblTocDo_KyHieuDich, PnlPhu = pnlTocDo_Phu, DataTyLe = dTocDo });
            mapTabs.Add(tabPage8, new BoDieuKien { CboNguon = cboThoiGian_Nguon, CboDich = cboThoiGian_Dich, TxtNhap = txtThoiGian_SoNhap, TxtKetQua = txtThoiGian_KetQua, LblKyHieuNguon = lblThoiGian_KyHieuNguon, LblKyHieuDich = lblThoiGian_KyHieuDich, PnlPhu = pnlThoiGian_Phu, DataTyLe = dThoiGian });
        }

        // ======================================================================================
        // PHẦN 3: SỰ KIỆN LOAD FORM & CẤU HÌNH GIAO DIỆN
        // ======================================================================================
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // --- Kích hoạt chế độ tự vẽ Tab (Để đổi màu nền/chữ) ---
            tabChuyenDoi.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabChuyenDoi.Padding = new Point(25, 10); // Nới rộng Tab ra cho chữ không bị dính
            tabChuyenDoi.DrawItem += TabChuyenDoi_DrawItem; // Gắn hàm vẽ

            // Tự động giãn chiều rộng ComboBox theo độ dài chữ
            ChinhSuaGiaoDienTuDong(this);

            // Thiết lập giá trị mặc định cho tất cả các Tab (để không bị trống trơn)
            foreach (var item in mapTabs.Values)
            {
                if (item.CboNguon.Items.Count > 0) item.CboNguon.SelectedIndex = 0; // Chọn cái đầu
                if (item.CboDich.Items.Count > 1) item.CboDich.SelectedIndex = 1; // Chọn cái thứ 2
                else if (item.CboDich.Items.Count > 0) item.CboDich.SelectedIndex = 0;

                // Mặc định focus vào ô trên và điền số 1
                txtDangFocus = item.TxtNhap;
                item.TxtNhap.Text = "1";
            }

            // Thiết lập riêng cho Tab Nhiệt độ (vì nó không nằm trong vòng lặp mapTabs)
            if (cboNhietDo_Nguon.Items.Count > 0) cboNhietDo_Nguon.SelectedIndex = 0;
            if (cboNhietDo_Dich.Items.Count > 1) cboNhietDo_Dich.SelectedIndex = 1;
            txtDangFocus = txtNhietDo_SoNhap;
            txtNhietDo_SoNhap.Text = "1";
        }

        // Hàm vẽ màu sắc cho Tab (Tím nhạt khi chọn, Trắng khi không chọn)
        private void TabChuyenDoi_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage currentPage = tabControl.TabPages[e.Index];
            Rectangle tabRect = tabControl.GetTabRect(e.Index);

            // Khai báo bảng màu
            Color mauNenChon = Color.FromArgb(237, 231, 246); // Tím siêu nhạt
            Color mauChuChon = Color.FromArgb(103, 58, 183);  // Tím đậm
            Color mauNenThuong = Color.White;
            Color mauChuThuong = Color.Gray;

            bool isSelected = (e.State == DrawItemState.Selected);

            // Bước 1: Xóa nền cũ
            using (SolidBrush brushNenTrang = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(brushNenTrang, tabRect);
            }

            // Bước 2: Nếu đang chọn thì vẽ đè nền màu Tím lên
            if (isSelected)
            {
                using (SolidBrush brushNenChon = new SolidBrush(mauNenChon))
                {
                    Rectangle rectChon = new Rectangle(tabRect.X + 2, tabRect.Y + 2, tabRect.Width - 4, tabRect.Height - 4);
                    e.Graphics.FillRectangle(brushNenChon, rectChon);
                }
            }

            // Bước 3: Vẽ chữ căn giữa
            string tabText = currentPage.Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            Font fontHienTai = tabControl.Font;
            Font fontVe = isSelected ? new Font(fontHienTai, FontStyle.Bold) : fontHienTai; // Chọn thì in đậm

            using (SolidBrush brushChu = new SolidBrush(isSelected ? mauChuChon : mauChuThuong))
            {
                e.Graphics.DrawString(tabText, fontVe, brushChu, tabRect, sf);
            }
        }

        // ======================================================================================
        // PHẦN 4: GẮN SỰ KIỆN TỰ ĐỘNG (LOGIC 2 CHIỀU)
        // ======================================================================================
        private void GanSuKienTuDong()
        {
            // Duyệt qua tất cả các Tab đã đăng ký trong mapTabs
            foreach (var kvp in mapTabs)
            {
                BoDieuKien bo = kvp.Value;

                // Sự kiện 1: Khi đổi đơn vị ở ComboBox -> Tính toán lại ngay
                EventHandler doiDonVi = (s, e) =>
                {
                    // Nếu người dùng đang nhập ô trên -> Tính ô dưới
                    if (txtDangFocus == bo.TxtNhap) XuLyTinhToanChung(bo, true);
                    // Nếu người dùng đang nhập ô dưới -> Tính ngược lại ô trên
                    else XuLyTinhToanChung(bo, false);
                };

                bo.CboNguon.SelectedIndexChanged += doiDonVi;
                bo.CboDich.SelectedIndexChanged += doiDonVi;

                // Sự kiện 2: Khi nhập liệu vào Ô TRÊN
                bo.TxtNhap.Click += (s, e) => txtDangFocus = bo.TxtNhap; // Bấm vào thì ghi nhớ đang ở đây
                bo.TxtNhap.Enter += (s, e) => txtDangFocus = bo.TxtNhap;
                bo.TxtNhap.TextChanged += (s, e) => XuLyTinhToanChung(bo, true); // Tính xuôi

                // Sự kiện 3: Khi nhập liệu vào Ô DƯỚI (Tính ngược)
                bo.TxtKetQua.Click += (s, e) => txtDangFocus = bo.TxtKetQua;
                bo.TxtKetQua.Enter += (s, e) => txtDangFocus = bo.TxtKetQua;
                bo.TxtKetQua.TextChanged += (s, e) => XuLyTinhToanChung(bo, false); // Tính ngược
            }

            // Gắn riêng cho Nhiệt độ (Vì công thức nhiệt độ khác biệt)
            GanSuKienNhietDo();
        }

        private void GanSuKienNhietDo()
        {
            EventHandler doiDonVi = (s, e) =>
            {
                if (txtDangFocus == txtNhietDo_SoNhap) XuLyTinhToanNhietDo(true);
                else XuLyTinhToanNhietDo(false);
            };
            cboNhietDo_Nguon.SelectedIndexChanged += doiDonVi;
            cboNhietDo_Dich.SelectedIndexChanged += doiDonVi;

            // Xử lý ô trên
            txtNhietDo_SoNhap.Click += (s, e) => txtDangFocus = txtNhietDo_SoNhap;
            txtNhietDo_SoNhap.Enter += (s, e) => txtDangFocus = txtNhietDo_SoNhap;
            txtNhietDo_SoNhap.TextChanged += (s, e) => XuLyTinhToanNhietDo(true);

            // Xử lý ô dưới
            txtNhietDo_KetQua.Click += (s, e) => txtDangFocus = txtNhietDo_KetQua;
            txtNhietDo_KetQua.Enter += (s, e) => txtDangFocus = txtNhietDo_KetQua;
            txtNhietDo_KetQua.TextChanged += (s, e) => XuLyTinhToanNhietDo(false);
        }

        // ======================================================================================
        // PHẦN 5: XỬ LÝ LỆNH TỪ BÀN PHÍM ẢO (ucBanPhim)
        // ======================================================================================
        public void NhanLenhBanPhim(string phim)
        {
            // Bước 1: Xác định xem đang đứng ở Tab nào?
            BoDieuKien bo = null;
            if (mapTabs.ContainsKey(tabChuyenDoi.SelectedTab)) bo = mapTabs[tabChuyenDoi.SelectedTab];

            // Bước 2: Nếu chưa biết đang nhập ở đâu, mặc định chọn ô nhập của Tab hiện tại
            if (txtDangFocus == null)
            {
                if (tabChuyenDoi.SelectedTab == tabPage3) txtDangFocus = txtNhietDo_SoNhap;
                else if (bo != null) txtDangFocus = bo.TxtNhap;
                else return;
            }

            // Bước 3: Xử lý từng nút bấm
            switch (phim)
            {
                case "UP":
                    // Nút Lên: Nhảy focus lên ô trên
                    if (tabChuyenDoi.SelectedTab == tabPage3) { txtDangFocus = txtNhietDo_SoNhap; txtDangFocus.Focus(); }
                    else if (bo != null) { txtDangFocus = bo.TxtNhap; txtDangFocus.Focus(); }
                    break;

                case "DOWN":
                    // Nút Xuống: Nhảy focus xuống ô dưới
                    if (tabChuyenDoi.SelectedTab == tabPage3) { txtDangFocus = txtNhietDo_KetQua; txtDangFocus.Focus(); }
                    else if (bo != null) { txtDangFocus = bo.TxtKetQua; txtDangFocus.Focus(); }
                    break;

                case "C": txtDangFocus.Text = ""; break; // Xóa hết
                case "DEL":
                case "⌫": // Xóa lùi 1 ký tự
                    if (txtDangFocus.Text.Length > 0)
                        txtDangFocus.Text = txtDangFocus.Text.Substring(0, txtDangFocus.Text.Length - 1);
                    break;
                case "+/-": // Đổi dấu âm/dương
                    if (txtDangFocus.Text.StartsWith("-")) txtDangFocus.Text = txtDangFocus.Text.Substring(1);
                    else txtDangFocus.Text = "-" + txtDangFocus.Text;
                    break;
                case ",": // Dấu phẩy
                    if (!txtDangFocus.Text.Contains(",")) txtDangFocus.Text += ",";
                    break;
                default: // Nhập số 0-9
                    if (txtDangFocus.Text == "0") txtDangFocus.Text = ""; // Xóa số 0 vô nghĩa đầu dòng
                    if (txtDangFocus.Text == "-0") txtDangFocus.Text = "-";
                    txtDangFocus.Text += phim;
                    break;
            }

            // Đưa con trỏ nháy về cuối dòng chữ
            txtDangFocus.SelectionStart = txtDangFocus.Text.Length;
        }

        // ======================================================================================
        // PHẦN 6: LOGIC TÍNH TOÁN & HIỂN THỊ KẾT QUẢ
        // ======================================================================================
        private void XuLyTinhToanChung(BoDieuKien bo, bool tinhXuoi)
        {
            if (isUpdating) return; // Nếu đang tính toán dở thì thôi, tránh lặp
            isUpdating = true;      // Khóa lại: "Đang tính, đừng làm phiền"

            try
            {
                // Cập nhật nhãn ký hiệu nhỏ (ví dụ: m, cm)
                bo.LblKyHieuNguon.Text = LayKyHieu(bo.CboNguon.Text);
                bo.LblKyHieuDich.Text = LayKyHieu(bo.CboDich.Text);

                // Lấy tỷ lệ từ Dictionary. Nếu không tìm thấy thì mặc định là 1.
                double rateNguon = bo.DataTyLe.ContainsKey(bo.CboNguon.Text) ? bo.DataTyLe[bo.CboNguon.Text] : 1;
                double rateDich = bo.DataTyLe.ContainsKey(bo.CboDich.Text) ? bo.DataTyLe[bo.CboDich.Text] : 1;

                if (tinhXuoi) // Trường hợp 1: Nhập trên -> Tính dưới
                {
                    if (double.TryParse(bo.TxtNhap.Text, out double val))
                    {
                        // Công thức: Giá trị * (Tỷ lệ Nguồn / Tỷ lệ Đích)
                        double kq = val * (rateNguon / rateDich);
                        bo.TxtKetQua.Text = kq.ToString("0.################"); // Format gọn số 0

                        // Hiển thị danh sách các đơn vị khác bên dưới (List phụ)
                        HienThiListPhu(val, rateNguon, bo.DataTyLe, bo.PnlPhu);
                    }
                    else { bo.TxtKetQua.Text = ""; bo.PnlPhu.Controls.Clear(); }
                }
                else // Trường hợp 2: Nhập dưới -> Tính trên
                {
                    if (double.TryParse(bo.TxtKetQua.Text, out double val))
                    {
                        // Công thức ngược: Giá trị * (Tỷ lệ Đích / Tỷ lệ Nguồn)
                        double kq = val * (rateDich / rateNguon);
                        bo.TxtNhap.Text = kq.ToString("0.################");

                        // List phụ vẫn tính dựa trên kết quả quy đổi ra đơn vị chuẩn
                        HienThiListPhu(kq, rateNguon, bo.DataTyLe, bo.PnlPhu);
                    }
                    else { bo.TxtNhap.Text = ""; bo.PnlPhu.Controls.Clear(); }
                }
            }
            finally
            {
                isUpdating = false; // Mở khóa: "Tính xong rồi"
            }
        }

        // Hàm vẽ danh sách phụ (Google Style)
        private void HienThiListPhu(double valInput, double rateNguon, Dictionary<string, double> data, FlowLayoutPanel pnl)
        {
            pnl.SuspendLayout(); // Tạm dừng vẽ để nạp nhanh hơn
            pnl.Controls.Clear();
            pnl.WrapContents = false;
            pnl.AutoScroll = true;

            foreach (var item in data)
            {
                // Tính toán giá trị cho dòng này
                double valResult = valInput * (rateNguon / item.Value);
                string tenDonVi = LayTenKhongKyHieu(item.Key);
                string kyHieu = LayKyHieu(item.Key);

                // Tạo Panel chứa 1 dòng
                Panel pnlRow = new Panel();
                pnlRow.Width = pnl.ClientSize.Width - 10;
                pnlRow.Height = 70; // Cao 70px để chứa chữ to 20pt
                pnlRow.Padding = new Padding(0, 0, 0, 5);

                // Tạo Label Tên đơn vị (Bên Trái - Màu xám)
                Label lblName = new Label();
                lblName.Text = tenDonVi;
                lblName.Font = new Font("Segoe UI", 20, FontStyle.Regular);
                lblName.ForeColor = Color.DimGray;
                lblName.TextAlign = ContentAlignment.MiddleLeft;
                lblName.Dock = DockStyle.Left;
                lblName.AutoSize = true;

                // Tạo Label Kết quả (Bên Phải - Đậm đen)
                Label lblValue = new Label();
                lblValue.Text = $"{valResult.ToString("0.####")} {kyHieu}";
                lblValue.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                lblValue.ForeColor = Color.Black;
                lblValue.TextAlign = ContentAlignment.MiddleRight;
                lblValue.Dock = DockStyle.Right;
                lblValue.AutoSize = true;

                // Thêm vào Panel dòng
                pnlRow.Controls.Add(lblValue);
                pnlRow.Controls.Add(lblName);

                // Vẽ đường kẻ mờ phân cách bên dưới
                pnlRow.Paint += (s, e) =>
                {
                    using (Pen p = new Pen(Color.FromArgb(240, 240, 240)))
                        e.Graphics.DrawLine(p, 0, pnlRow.Height - 1, pnlRow.Width, pnlRow.Height - 1);
                };

                pnl.Controls.Add(pnlRow);
            }
            pnl.ResumeLayout();
        }

        // Logic tính toán riêng cho Nhiệt độ (Vì công thức cộng trừ, không nhân chia tỷ lệ)
        private void XuLyTinhToanNhietDo(bool tinhXuoi)
        {
            if (isUpdating) return;
            isUpdating = true;
            try
            {
                lbalNhietDo_KyHieuNguon.Text = LayKyHieu(cboNhietDo_Nguon.Text);
                lbalNhietDo_KyHieuDich.Text = LayKyHieu(cboNhietDo_Dich.Text);

                if (tinhXuoi)
                {
                    if (double.TryParse(txtNhietDo_SoNhap.Text, out double val))
                    {
                        double kq = TinhNhietDo(val, cboNhietDo_Nguon.Text, cboNhietDo_Dich.Text);
                        txtNhietDo_KetQua.Text = kq.ToString("0.##");
                        HienThiListPhuNhietDo(val, cboNhietDo_Nguon.Text);
                    }
                    else { txtNhietDo_KetQua.Text = ""; pnlNhietDo_Phu.Controls.Clear(); }
                }
                else
                {
                    if (double.TryParse(txtNhietDo_KetQua.Text, out double val))
                    {
                        double kq = TinhNhietDo(val, cboNhietDo_Dich.Text, cboNhietDo_Nguon.Text);
                        txtNhietDo_SoNhap.Text = kq.ToString("0.##");
                        HienThiListPhuNhietDo(kq, cboNhietDo_Nguon.Text);
                    }
                    else { txtNhietDo_SoNhap.Text = ""; pnlNhietDo_Phu.Controls.Clear(); }
                }
            }
            finally { isUpdating = false; }
        }

        // ======================================================================================
        // PHẦN 7: CÁC HÀM TIỆN ÍCH HỖ TRỢ
        // ======================================================================================

        // Tách chữ trong ngoặc: "Are (a)" -> Lấy "a"
        private string LayKyHieu(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            int mo = text.LastIndexOf('('); int dong = text.LastIndexOf(')');
            if (mo == -1) { mo = text.LastIndexOf('['); dong = text.LastIndexOf(']'); }
            if (mo != -1 && dong != -1 && dong > mo) return text.Substring(mo + 1, dong - mo - 1);
            return "";
        }

        // Lấy tên bỏ ngoặc: "Are (a)" -> Lấy "Are"
        private string LayTenKhongKyHieu(string text)
        {
            int mo = text.LastIndexOf('(');
            if (mo == -1) mo = text.LastIndexOf('[');
            if (mo > 0) return text.Substring(0, mo).Trim();
            return text;
        }

        // Tự động đo chiều dài chữ để nới rộng ComboBox
        private void ChinhSuaGiaoDienTuDong(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is ComboBox cbo && cbo.Items.Count > 0)
                {
                    int maxRong = 0;
                    using (Graphics g = cbo.CreateGraphics())
                        foreach (object item in cbo.Items) { int w = (int)g.MeasureString(item.ToString(), cbo.Font).Width; if (w > maxRong) maxRong = w; }
                    cbo.Width = maxRong + 40; cbo.DropDownWidth = maxRong + 40;
                }
                if (c.HasChildren) ChinhSuaGiaoDienTuDong(c);
            }
        }

        // Công thức chuyển đổi nhiệt độ (C, F, K)
        private double TinhNhietDo(double val, string tu, string sang)
        {
            double doC = 0;
            // Bước 1: Đổi hết về độ C
            if (tu.Contains("C")) doC = val;
            else if (tu.Contains("F")) doC = (val - 32) / 1.8;
            else if (tu.Contains("K")) doC = val - 273.15;

            // Bước 2: Từ độ C đổi sang đích
            if (sang.Contains("C")) return doC;
            if (sang.Contains("F")) return doC * 1.8 + 32;
            if (sang.Contains("K")) return doC + 273.15;
            return 0;
        }

        // Hiển thị list phụ cho nhiệt độ
        private void HienThiListPhuNhietDo(double val, string nguon)
        {
            pnlNhietDo_Phu.SuspendLayout();
            pnlNhietDo_Phu.Controls.Clear();

            string[] cacDonVi = { "Độ C (°C)", "Độ F (°F) ", "Kelvin (K)" };
            foreach (var dv in cacDonVi)
            {
                double kq = TinhNhietDo(val, nguon, dv);

                Panel pnlRow = new Panel { Width = pnlNhietDo_Phu.Width - 10, Height = 70 };

                Label lblName = new Label
                {
                    Text = LayTenKhongKyHieu(dv),
                    Dock = DockStyle.Left,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 20, FontStyle.Regular),
                    ForeColor = Color.DimGray,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Label lblValue = new Label
                {
                    Text = $"{kq:0.##} {LayKyHieu(dv)}",
                    Dock = DockStyle.Right,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 20, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight
                };

                pnlRow.Controls.Add(lblValue);
                pnlRow.Controls.Add(lblName);

                pnlRow.Paint += (s, e) =>
                {
                    using (Pen p = new Pen(Color.FromArgb(240, 240, 240)))
                        e.Graphics.DrawLine(p, 0, pnlRow.Height - 1, pnlRow.Width, pnlRow.Height - 1);
                };

                pnlNhietDo_Phu.Controls.Add(pnlRow);
            }
            pnlNhietDo_Phu.ResumeLayout();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (FormCha != null && FormCha is frmMainCalculator) ((frmMainCalculator)FormCha).HienLaiGiaoDien();
            else if (FormCha != null) FormCha.Show();
        }

        private void lblDienTich_KyHieuNguon_Click(object sender, EventArgs e)
        {

        }
    }
}