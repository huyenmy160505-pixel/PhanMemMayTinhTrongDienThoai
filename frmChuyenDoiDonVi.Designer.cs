namespace PhanMemMayTinhTrongDienThoai
{
    partial class frmChuyenDoiDonVi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            btnThoat = new Button();
            tabChuyenDoi = new TabControl();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            splitContainer2 = new SplitContainer();
            cboNguon = new ComboBox();
            txtSoNhap = new TextBox();
            lblKyHieuNguon = new Label();
            splitContainer3 = new SplitContainer();
            cboDich = new ComboBox();
            textBox1 = new TextBox();
            lblKyHieuDich = new Label();
            pnlListPhu = new FlowLayoutPanel();
            ucBanPhim1 = new ucBanPhim();
            tabPage1 = new TabPage();
            panel1.SuspendLayout();
            tabChuyenDoi.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThoat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(49, 27, 146);
            label1.Location = new Point(50, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 60);
            label1.TabIndex = 3;
            label1.Text = "Chuyển đổi đơn vị";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Left;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(49, 27, 146);
            btnThoat.Location = new Point(0, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(50, 60);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "<";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // tabChuyenDoi
            // 
            tabChuyenDoi.Controls.Add(tabPage2);
            tabChuyenDoi.Controls.Add(tabPage1);
            tabChuyenDoi.Dock = DockStyle.Fill;
            tabChuyenDoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabChuyenDoi.Location = new Point(0, 60);
            tabChuyenDoi.Name = "tabChuyenDoi";
            tabChuyenDoi.SelectedIndex = 0;
            tabChuyenDoi.Size = new Size(1156, 928);
            tabChuyenDoi.TabIndex = 2;
            tabChuyenDoi.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 41);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1148, 883);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Diện tích";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ucBanPhim1);
            splitContainer1.Size = new Size(1142, 877);
            splitContainer1.SplitterDistance = 571;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer3, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlListPhu, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(571, 877);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 213);
            panel2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(cboNguon);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtSoNhap);
            splitContainer2.Panel2.Controls.Add(lblKyHieuNguon);
            splitContainer2.Size = new Size(565, 213);
            splitContainer2.SplitterDistance = 158;
            splitContainer2.TabIndex = 1;
            // 
            // cboNguon
            // 
            cboNguon.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboNguon.Dock = DockStyle.Left;
            cboNguon.FlatStyle = FlatStyle.Flat;
            cboNguon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboNguon.ForeColor = Color.BlueViolet;
            cboNguon.FormattingEnabled = true;
            cboNguon.Location = new Point(0, 0);
            cboNguon.Name = "cboNguon";
            cboNguon.Size = new Size(270, 40);
            cboNguon.TabIndex = 1;
            // 
            // txtSoNhap
            // 
            txtSoNhap.BackColor = Color.White;
            txtSoNhap.BorderStyle = BorderStyle.None;
            txtSoNhap.Dock = DockStyle.Fill;
            txtSoNhap.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoNhap.ForeColor = Color.BlueViolet;
            txtSoNhap.Location = new Point(0, 0);
            txtSoNhap.Name = "txtSoNhap";
            txtSoNhap.Size = new Size(470, 55);
            txtSoNhap.TabIndex = 1;
            txtSoNhap.TextAlign = HorizontalAlignment.Right;
            // 
            // lblKyHieuNguon
            // 
            lblKyHieuNguon.Dock = DockStyle.Right;
            lblKyHieuNguon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblKyHieuNguon.ForeColor = Color.BlueViolet;
            lblKyHieuNguon.Location = new Point(470, 0);
            lblKyHieuNguon.Name = "lblKyHieuNguon";
            lblKyHieuNguon.Padding = new Padding(0, 0, 10, 10);
            lblKyHieuNguon.Size = new Size(95, 51);
            lblKyHieuNguon.TabIndex = 0;
            lblKyHieuNguon.TextAlign = ContentAlignment.BottomCenter;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 222);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(cboDich);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(textBox1);
            splitContainer3.Panel2.Controls.Add(lblKyHieuDich);
            splitContainer3.Size = new Size(565, 213);
            splitContainer3.SplitterDistance = 158;
            splitContainer3.TabIndex = 1;
            // 
            // cboDich
            // 
            cboDich.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboDich.Dock = DockStyle.Left;
            cboDich.FlatStyle = FlatStyle.Flat;
            cboDich.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboDich.ForeColor = Color.BlueViolet;
            cboDich.FormattingEnabled = true;
            cboDich.Location = new Point(0, 0);
            cboDich.Name = "cboDich";
            cboDich.Size = new Size(270, 40);
            cboDich.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.BlueViolet;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 55);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblKyHieuDich
            // 
            lblKyHieuDich.Dock = DockStyle.Right;
            lblKyHieuDich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblKyHieuDich.ForeColor = Color.BlueViolet;
            lblKyHieuDich.Location = new Point(470, 0);
            lblKyHieuDich.Name = "lblKyHieuDich";
            lblKyHieuDich.Padding = new Padding(0, 0, 10, 10);
            lblKyHieuDich.Size = new Size(95, 51);
            lblKyHieuDich.TabIndex = 1;
            lblKyHieuDich.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlListPhu
            // 
            pnlListPhu.AutoScroll = true;
            pnlListPhu.Dock = DockStyle.Fill;
            pnlListPhu.FlowDirection = FlowDirection.TopDown;
            pnlListPhu.Location = new Point(3, 441);
            pnlListPhu.Name = "pnlListPhu";
            pnlListPhu.Padding = new Padding(20, 20, 20, 0);
            pnlListPhu.Size = new Size(565, 433);
            pnlListPhu.TabIndex = 2;
            pnlListPhu.WrapContents = false;
            // 
            // ucBanPhim1
            // 
            ucBanPhim1.Location = new Point(12, 165);
            ucBanPhim1.Name = "ucBanPhim1";
            ucBanPhim1.Size = new Size(525, 600);
            ucBanPhim1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 41);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1148, 883);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmChuyenDoiDonVi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 988);
            Controls.Add(tabChuyenDoi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmChuyenDoiDonVi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chuyển Đổi Đơn Vị";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            tabChuyenDoi.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnThoat;
        private TabControl tabChuyenDoi;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private SplitContainer splitContainer2;
        private ComboBox cboNguon;
        private TextBox txtSoNhap;
        private Label lblKyHieuNguon;
        private SplitContainer splitContainer3;
        private ComboBox cboDich;
        private TextBox textBox1;
        private Label lblKyHieuDich;
        private FlowLayoutPanel pnlListPhu;
        private TabPage tabPage1;
        private ucBanPhim ucBanPhim1;
    }
}