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
            lblThongBao = new Label();
            btnXoaNhatKy = new Button();
            pnlDanhSachLichSu = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblThongBao
            // 
            lblThongBao.Dock = DockStyle.Fill;
            lblThongBao.Font = new Font("Microsoft Sans Serif", 20F);
            lblThongBao.ForeColor = Color.DimGray;
            lblThongBao.Location = new Point(0, 0);
            lblThongBao.Margin = new Padding(2, 0, 2, 0);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(265, 431);
            lblThongBao.TabIndex = 3;
            lblThongBao.Text = "Không có nhật ký";
            lblThongBao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoaNhatKy
            // 
            btnXoaNhatKy.BackColor = Color.Gainsboro;
            btnXoaNhatKy.Dock = DockStyle.Bottom;
            btnXoaNhatKy.FlatAppearance.BorderSize = 0;
            btnXoaNhatKy.Font = new Font("Microsoft Sans Serif", 20F);
            btnXoaNhatKy.ForeColor = Color.Black;
            btnXoaNhatKy.Location = new Point(0, 431);
            btnXoaNhatKy.Margin = new Padding(2, 2, 2, 2);
            btnXoaNhatKy.Name = "btnXoaNhatKy";
            btnXoaNhatKy.Size = new Size(265, 42);
            btnXoaNhatKy.TabIndex = 2;
            btnXoaNhatKy.Text = "Xóa nhật ký";
            btnXoaNhatKy.UseVisualStyleBackColor = false;
            btnXoaNhatKy.Click += btnXoaNhatKy_Click;
            // 
            // pnlDanhSachLichSu
            // 
            pnlDanhSachLichSu.AutoScroll = true;
            pnlDanhSachLichSu.Dock = DockStyle.Fill;
            pnlDanhSachLichSu.FlowDirection = FlowDirection.TopDown;
            pnlDanhSachLichSu.ForeColor = SystemColors.Control;
            pnlDanhSachLichSu.Location = new Point(0, 0);
            pnlDanhSachLichSu.Margin = new Padding(2, 2, 2, 2);
            pnlDanhSachLichSu.Name = "pnlDanhSachLichSu";
            pnlDanhSachLichSu.Size = new Size(265, 431);
            pnlDanhSachLichSu.TabIndex = 4;
            pnlDanhSachLichSu.Visible = false;
            pnlDanhSachLichSu.WrapContents = false;
            // 
            // frmLichSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 473);
            Controls.Add(pnlDanhSachLichSu);
            Controls.Add(lblThongBao);
            Controls.Add(btnXoaNhatKy);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1, 1, 1, 1);
            Name = "frmLichSu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Lịch Sử";
            Load += frmLichSu_Load;
            ResumeLayout(false);
        }

        #endregion
        public Label label1;
        public Label lblThongBao;
        private Button btnXoaNhatKy;
        public FlowLayoutPanel pnlDanhSachLichSu;
    }
}