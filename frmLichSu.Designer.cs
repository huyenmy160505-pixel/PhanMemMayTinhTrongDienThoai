namespace PhanMemMayTinhTrongDienThoai
{
    partial class frmLichSu
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
            splitContainer1 = new SplitContainer();
            lblThongBao = new Label();
            btnXoaNhatKy = new Button();
            pnlDanhSachLichSu = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlDanhSachLichSu);
            splitContainer1.Panel1.Controls.Add(lblThongBao);
            splitContainer1.Panel1.Controls.Add(btnXoaNhatKy);
            splitContainer1.Size = new Size(1160, 997);
            splitContainer1.SplitterDistance = 401;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // lblThongBao
            // 
            lblThongBao.Dock = DockStyle.Fill;
            lblThongBao.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThongBao.ForeColor = Color.DimGray;
            lblThongBao.Location = new Point(0, 0);
            lblThongBao.Margin = new Padding(5);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(401, 947);
            lblThongBao.TabIndex = 1;
            lblThongBao.Text = "Không có nhật ký";
            lblThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoaNhatKy
            // 
            btnXoaNhatKy.BackColor = Color.Gainsboro;
            btnXoaNhatKy.Dock = DockStyle.Bottom;
            btnXoaNhatKy.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaNhatKy.ForeColor = Color.Black;
            btnXoaNhatKy.Location = new Point(0, 947);
            btnXoaNhatKy.Name = "btnXoaNhatKy";
            btnXoaNhatKy.Size = new Size(401, 50);
            btnXoaNhatKy.TabIndex = 0;
            btnXoaNhatKy.Text = "Xóa nhật ký";
            btnXoaNhatKy.UseVisualStyleBackColor = false;
            // 
            // pnlDanhSachLichSu
            // 
            pnlDanhSachLichSu.AutoScroll = true;
            pnlDanhSachLichSu.BackColor = Color.White;
            pnlDanhSachLichSu.Dock = DockStyle.Fill;
            pnlDanhSachLichSu.FlowDirection = FlowDirection.TopDown;
            pnlDanhSachLichSu.Location = new Point(0, 0);
            pnlDanhSachLichSu.Name = "pnlDanhSachLichSu";
            pnlDanhSachLichSu.Size = new Size(401, 947);
            pnlDanhSachLichSu.TabIndex = 2;
            pnlDanhSachLichSu.WrapContents = false;
            // 
            // frmLichSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 997);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "frmLichSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch Sử";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnXoaNhatKy;
        private Label lblThongBao;
        public Label label1;
        private FlowLayoutPanel pnlDanhSachLichSu;
        public FlowLayoutPanel pnlDanhSachLichSu;
    }
}