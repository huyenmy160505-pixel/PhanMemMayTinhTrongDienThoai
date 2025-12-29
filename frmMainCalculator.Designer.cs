namespace PhanMemMayTinhTrongDienThoai
{
    partial class frmMainCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            pnlHeader = new Panel();
            btnCloseSplit = new Button();
            rtbMainDisplay = new RichTextBox();
            splitContainer3 = new SplitContainer();
            lblPreview = new Label();
            label1 = new Label();
            splitContainer5 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnHistory = new Button();
            lblDegRad = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnRuler = new Button();
            btnBackspace = new Button();
            splitContainer4 = new SplitContainer();
            tlpFunctions = new TableLayoutPanel();
            btnTongleFunc = new Button();
            btnDegRad = new Button();
            btnSqrt = new Button();
            btnSin = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnLn = new Button();
            btnLog = new Button();
            btnInverse = new Button();
            btnExpE = new Button();
            btnSquare = new Button();
            btnPower = new Button();
            btnAbs = new Button();
            btnPi = new Button();
            btnE = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAc = new Button();
            btnParenthesis = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtract = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btnToggleSign = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEqual = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            tlpFunctions.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer4);
            splitContainer1.Size = new Size(1162, 749);
            splitContainer1.SplitterDistance = 338;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(pnlHeader);
            splitContainer2.Panel1.Controls.Add(rtbMainDisplay);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1162, 338);
            splitContainer2.SplitterDistance = 111;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnCloseSplit);
            pnlHeader.ForeColor = Color.White;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(5, 5, 0, 5);
            pnlHeader.RightToLeft = RightToLeft.No;
            pnlHeader.Size = new Size(60, 60);
            pnlHeader.TabIndex = 1;
            // 
            // btnCloseSplit
            // 
            btnCloseSplit.Dock = DockStyle.Left;
            btnCloseSplit.FlatStyle = FlatStyle.Flat;
            btnCloseSplit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseSplit.ForeColor = Color.Red;
            btnCloseSplit.Location = new Point(5, 5);
            btnCloseSplit.Name = "btnCloseSplit";
            btnCloseSplit.Size = new Size(50, 50);
            btnCloseSplit.TabIndex = 0;
            btnCloseSplit.Text = "❌";
            btnCloseSplit.UseVisualStyleBackColor = true;
            btnCloseSplit.Click += btnCloseSplit_Click;
            // 
            // rtbMainDisplay
            // 
            rtbMainDisplay.BackColor = Color.White;
            rtbMainDisplay.BorderStyle = BorderStyle.None;
            rtbMainDisplay.Dock = DockStyle.Bottom;
            rtbMainDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            rtbMainDisplay.Location = new Point(0, 0);
            rtbMainDisplay.Margin = new Padding(5);
            rtbMainDisplay.Name = "rtbMainDisplay";
            rtbMainDisplay.ScrollBars = RichTextBoxScrollBars.None;
            rtbMainDisplay.Size = new Size(1162, 111);
            rtbMainDisplay.TabIndex = 0;
            rtbMainDisplay.Text = "";
            rtbMainDisplay.TextChanged += rtbMainDisplay_TextChanged;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(lblPreview);
            splitContainer3.Panel1.Controls.Add(label1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer5);
            splitContainer3.Size = new Size(1162, 224);
            splitContainer3.SplitterDistance = 112;
            splitContainer3.SplitterWidth = 3;
            splitContainer3.TabIndex = 0;
            // 
            // lblPreview
            // 
            lblPreview.Dock = DockStyle.Top;
            lblPreview.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblPreview.ForeColor = Color.FromArgb(186, 104, 200);
            lblPreview.Location = new Point(0, 0);
            lblPreview.Margin = new Padding(5, 0, 5, 0);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(1162, 115);
            lblPreview.TabIndex = 1;
            lblPreview.TextAlign = ContentAlignment.TopRight;
            lblPreview.Click += lblPreview_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1162, 112);
            label1.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer5.Size = new Size(1162, 109);
            splitContainer5.SplitterDistance = 478;
            splitContainer5.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnHistory, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDegRad, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(478, 109);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Fill;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.ForeColor = Color.FromArgb(49, 27, 146);
            btnHistory.Location = new Point(3, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(153, 103);
            btnHistory.TabIndex = 0;
            btnHistory.Text = "🕒";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // lblDegRad
            // 
            lblDegRad.AutoSize = true;
            lblDegRad.Dock = DockStyle.Fill;
            lblDegRad.FlatStyle = FlatStyle.Flat;
            lblDegRad.ForeColor = Color.FromArgb(49, 27, 146);
            lblDegRad.Location = new Point(164, 5);
            lblDegRad.Margin = new Padding(5);
            lblDegRad.Name = "lblDegRad";
            lblDegRad.Size = new Size(149, 99);
            lblDegRad.TabIndex = 1;
            lblDegRad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnRuler, 2, 0);
            tableLayoutPanel3.Controls.Add(btnBackspace, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(680, 109);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnRuler
            // 
            btnRuler.Dock = DockStyle.Fill;
            btnRuler.FlatAppearance.BorderSize = 0;
            btnRuler.FlatStyle = FlatStyle.Flat;
            btnRuler.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuler.ForeColor = Color.FromArgb(49, 27, 146);
            btnRuler.Location = new Point(343, 3);
            btnRuler.Name = "btnRuler";
            btnRuler.Size = new Size(164, 103);
            btnRuler.TabIndex = 0;
            btnRuler.Text = "📏";
            btnRuler.UseVisualStyleBackColor = true;
            btnRuler.Click += btnRuler_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.FlatAppearance.BorderSize = 0;
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.ForeColor = Color.FromArgb(49, 27, 146);
            btnBackspace.Location = new Point(513, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(164, 103);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "⌫ ";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnXoa_Click;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(tlpFunctions);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer4.Size = new Size(1162, 408);
            splitContainer4.SplitterDistance = 478;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 0;
            // 
            // tlpFunctions
            // 
            tlpFunctions.AccessibleRole = AccessibleRole.None;
            tlpFunctions.BackColor = Color.White;
            tlpFunctions.ColumnCount = 3;
            tlpFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFunctions.Controls.Add(btnTongleFunc, 0, 0);
            tlpFunctions.Controls.Add(btnDegRad, 1, 0);
            tlpFunctions.Controls.Add(btnSqrt, 2, 0);
            tlpFunctions.Controls.Add(btnSin, 0, 1);
            tlpFunctions.Controls.Add(btnCos, 1, 1);
            tlpFunctions.Controls.Add(btnTan, 2, 1);
            tlpFunctions.Controls.Add(btnLn, 0, 2);
            tlpFunctions.Controls.Add(btnLog, 1, 2);
            tlpFunctions.Controls.Add(btnInverse, 2, 2);
            tlpFunctions.Controls.Add(btnExpE, 0, 3);
            tlpFunctions.Controls.Add(btnSquare, 1, 3);
            tlpFunctions.Controls.Add(btnPower, 2, 3);
            tlpFunctions.Controls.Add(btnAbs, 0, 4);
            tlpFunctions.Controls.Add(btnPi, 1, 4);
            tlpFunctions.Controls.Add(btnE, 2, 4);
            tlpFunctions.Dock = DockStyle.Fill;
            tlpFunctions.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            tlpFunctions.ForeColor = Color.FromArgb(49, 27, 146);
            tlpFunctions.Location = new Point(0, 0);
            tlpFunctions.Margin = new Padding(5);
            tlpFunctions.Name = "tlpFunctions";
            tlpFunctions.RowCount = 5;
            tlpFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpFunctions.Size = new Size(478, 408);
            tlpFunctions.TabIndex = 0;
            // 
            // btnTongleFunc
            // 
            btnTongleFunc.BackColor = Color.FromArgb(243, 229, 245);
            btnTongleFunc.Dock = DockStyle.Fill;
            btnTongleFunc.FlatAppearance.BorderSize = 0;
            btnTongleFunc.FlatStyle = FlatStyle.Flat;
            btnTongleFunc.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnTongleFunc.ForeColor = Color.FromArgb(49, 27, 146);
            btnTongleFunc.Location = new Point(5, 5);
            btnTongleFunc.Margin = new Padding(5);
            btnTongleFunc.Name = "btnTongleFunc";
            btnTongleFunc.Size = new Size(149, 71);
            btnTongleFunc.TabIndex = 0;
            btnTongleFunc.Text = "↑↓";
            btnTongleFunc.UseVisualStyleBackColor = false;
            btnTongleFunc.Click += btnTongleFunc_Click;
            // 
            // btnDegRad
            // 
            btnDegRad.BackColor = Color.FromArgb(243, 229, 245);
            btnDegRad.Dock = DockStyle.Fill;
            btnDegRad.FlatAppearance.BorderSize = 0;
            btnDegRad.FlatStyle = FlatStyle.Flat;
            btnDegRad.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnDegRad.ForeColor = Color.FromArgb(49, 27, 146);
            btnDegRad.Location = new Point(164, 5);
            btnDegRad.Margin = new Padding(5);
            btnDegRad.Name = "btnDegRad";
            btnDegRad.Size = new Size(149, 71);
            btnDegRad.TabIndex = 1;
            btnDegRad.Text = "Rad";
            btnDegRad.UseVisualStyleBackColor = false;
            btnDegRad.Click += btnRadDeg_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.FromArgb(243, 229, 245);
            btnSqrt.Dock = DockStyle.Fill;
            btnSqrt.FlatAppearance.BorderSize = 0;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnSqrt.ForeColor = Color.FromArgb(49, 27, 146);
            btnSqrt.Location = new Point(323, 5);
            btnSqrt.Margin = new Padding(5);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(150, 71);
            btnSqrt.TabIndex = 2;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnCan_Click;
            // 
            // btnSin
            // 
            btnSin.BackColor = Color.FromArgb(243, 229, 245);
            btnSin.Dock = DockStyle.Fill;
            btnSin.FlatAppearance.BorderSize = 0;
            btnSin.FlatStyle = FlatStyle.Flat;
            btnSin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnSin.ForeColor = Color.FromArgb(49, 27, 146);
            btnSin.Location = new Point(5, 86);
            btnSin.Margin = new Padding(5);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(149, 71);
            btnSin.TabIndex = 3;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += btnSin_Click;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.FromArgb(243, 229, 245);
            btnCos.Dock = DockStyle.Fill;
            btnCos.FlatAppearance.BorderSize = 0;
            btnCos.FlatStyle = FlatStyle.Flat;
            btnCos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnCos.ForeColor = Color.FromArgb(49, 27, 146);
            btnCos.Location = new Point(164, 86);
            btnCos.Margin = new Padding(5);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(149, 71);
            btnCos.TabIndex = 4;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Click += btnCos_Click;
            // 
            // btnTan
            // 
            btnTan.BackColor = Color.FromArgb(243, 229, 245);
            btnTan.Dock = DockStyle.Fill;
            btnTan.FlatAppearance.BorderSize = 0;
            btnTan.FlatStyle = FlatStyle.Flat;
            btnTan.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnTan.ForeColor = Color.FromArgb(49, 27, 146);
            btnTan.Location = new Point(323, 86);
            btnTan.Margin = new Padding(5);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(150, 71);
            btnTan.TabIndex = 5;
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = false;
            btnTan.Click += btnTan_Click;
            // 
            // btnLn
            // 
            btnLn.BackColor = Color.FromArgb(243, 229, 245);
            btnLn.Dock = DockStyle.Fill;
            btnLn.FlatAppearance.BorderSize = 0;
            btnLn.FlatStyle = FlatStyle.Flat;
            btnLn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnLn.ForeColor = Color.FromArgb(49, 27, 146);
            btnLn.Location = new Point(5, 167);
            btnLn.Margin = new Padding(5);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(149, 71);
            btnLn.TabIndex = 6;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = false;
            btnLn.Click += btnLn_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(243, 229, 245);
            btnLog.Dock = DockStyle.Fill;
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnLog.ForeColor = Color.FromArgb(49, 27, 146);
            btnLog.Location = new Point(164, 167);
            btnLog.Margin = new Padding(5);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(149, 71);
            btnLog.TabIndex = 7;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnInverse
            // 
            btnInverse.BackColor = Color.FromArgb(243, 229, 245);
            btnInverse.Dock = DockStyle.Fill;
            btnInverse.FlatAppearance.BorderSize = 0;
            btnInverse.FlatStyle = FlatStyle.Flat;
            btnInverse.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnInverse.ForeColor = Color.FromArgb(49, 27, 146);
            btnInverse.Location = new Point(323, 167);
            btnInverse.Margin = new Padding(5);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(150, 71);
            btnInverse.TabIndex = 8;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            btnInverse.Click += btnNghichDao_Click;
            // 
            // btnExpE
            // 
            btnExpE.BackColor = Color.FromArgb(243, 229, 245);
            btnExpE.Dock = DockStyle.Fill;
            btnExpE.FlatAppearance.BorderSize = 0;
            btnExpE.FlatStyle = FlatStyle.Flat;
            btnExpE.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnExpE.ForeColor = Color.FromArgb(49, 27, 146);
            btnExpE.Location = new Point(5, 248);
            btnExpE.Margin = new Padding(5);
            btnExpE.Name = "btnExpE";
            btnExpE.Size = new Size(149, 71);
            btnExpE.TabIndex = 9;
            btnExpE.Text = "eˣ";
            btnExpE.UseVisualStyleBackColor = false;
            btnExpE.Click += btnMuE_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.FromArgb(243, 229, 245);
            btnSquare.Dock = DockStyle.Fill;
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnSquare.ForeColor = Color.FromArgb(49, 27, 146);
            btnSquare.Location = new Point(164, 248);
            btnSquare.Margin = new Padding(5);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(149, 71);
            btnSquare.TabIndex = 10;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnBinhPhuong_Click;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.FromArgb(243, 229, 245);
            btnPower.Dock = DockStyle.Fill;
            btnPower.FlatAppearance.BorderSize = 0;
            btnPower.FlatStyle = FlatStyle.Flat;
            btnPower.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnPower.ForeColor = Color.FromArgb(49, 27, 146);
            btnPower.Location = new Point(323, 248);
            btnPower.Margin = new Padding(5);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(150, 71);
            btnPower.TabIndex = 11;
            btnPower.Text = "xʸ";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += btnMu_Click;
            // 
            // btnAbs
            // 
            btnAbs.BackColor = Color.FromArgb(243, 229, 245);
            btnAbs.Dock = DockStyle.Fill;
            btnAbs.FlatAppearance.BorderSize = 0;
            btnAbs.FlatStyle = FlatStyle.Flat;
            btnAbs.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnAbs.ForeColor = Color.FromArgb(49, 27, 146);
            btnAbs.Location = new Point(5, 329);
            btnAbs.Margin = new Padding(5);
            btnAbs.Name = "btnAbs";
            btnAbs.Size = new Size(149, 74);
            btnAbs.TabIndex = 12;
            btnAbs.Text = "|x|";
            btnAbs.UseVisualStyleBackColor = false;
            btnAbs.Click += btnAbs_Click;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.FromArgb(243, 229, 245);
            btnPi.Dock = DockStyle.Fill;
            btnPi.FlatAppearance.BorderSize = 0;
            btnPi.FlatStyle = FlatStyle.Flat;
            btnPi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnPi.ForeColor = Color.FromArgb(49, 27, 146);
            btnPi.Location = new Point(164, 329);
            btnPi.Margin = new Padding(5);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(149, 74);
            btnPi.TabIndex = 13;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += btnPi_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.FromArgb(243, 229, 245);
            btnE.Dock = DockStyle.Fill;
            btnE.FlatAppearance.BorderSize = 0;
            btnE.FlatStyle = FlatStyle.Flat;
            btnE.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnE.ForeColor = Color.FromArgb(49, 27, 146);
            btnE.Location = new Point(323, 329);
            btnE.Margin = new Padding(5);
            btnE.Name = "btnE";
            btnE.Size = new Size(150, 74);
            btnE.TabIndex = 14;
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnAc, 0, 0);
            tableLayoutPanel2.Controls.Add(btnParenthesis, 1, 0);
            tableLayoutPanel2.Controls.Add(btnPercent, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDivide, 3, 0);
            tableLayoutPanel2.Controls.Add(btn7, 0, 1);
            tableLayoutPanel2.Controls.Add(btn8, 1, 1);
            tableLayoutPanel2.Controls.Add(btn9, 2, 1);
            tableLayoutPanel2.Controls.Add(btnMultiply, 3, 1);
            tableLayoutPanel2.Controls.Add(btn4, 0, 2);
            tableLayoutPanel2.Controls.Add(btn5, 1, 2);
            tableLayoutPanel2.Controls.Add(btn6, 2, 2);
            tableLayoutPanel2.Controls.Add(btnSubtract, 3, 2);
            tableLayoutPanel2.Controls.Add(btn1, 0, 3);
            tableLayoutPanel2.Controls.Add(btn2, 1, 3);
            tableLayoutPanel2.Controls.Add(btn3, 2, 3);
            tableLayoutPanel2.Controls.Add(btnAdd, 3, 3);
            tableLayoutPanel2.Controls.Add(btnToggleSign, 0, 4);
            tableLayoutPanel2.Controls.Add(btn0, 1, 4);
            tableLayoutPanel2.Controls.Add(btnDecimal, 2, 4);
            tableLayoutPanel2.Controls.Add(btnEqual, 3, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            tableLayoutPanel2.ForeColor = Color.FromArgb(156, 39, 176);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(679, 408);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAc
            // 
            btnAc.BackColor = Color.FromArgb(243, 229, 245);
            btnAc.Dock = DockStyle.Fill;
            btnAc.FlatAppearance.BorderSize = 0;
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnAc.ForeColor = Color.Red;
            btnAc.Location = new Point(5, 5);
            btnAc.Margin = new Padding(5);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(159, 71);
            btnAc.TabIndex = 0;
            btnAc.Text = "C";
            btnAc.UseVisualStyleBackColor = false;
            btnAc.Click += btnC_Click;
            // 
            // btnParenthesis
            // 
            btnParenthesis.BackColor = Color.FromArgb(243, 229, 245);
            btnParenthesis.Dock = DockStyle.Fill;
            btnParenthesis.FlatAppearance.BorderSize = 0;
            btnParenthesis.FlatStyle = FlatStyle.Flat;
            btnParenthesis.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnParenthesis.ForeColor = Color.FromArgb(156, 39, 176);
            btnParenthesis.Location = new Point(174, 5);
            btnParenthesis.Margin = new Padding(5);
            btnParenthesis.Name = "btnParenthesis";
            btnParenthesis.Size = new Size(159, 71);
            btnParenthesis.TabIndex = 1;
            btnParenthesis.Text = "()";
            btnParenthesis.UseVisualStyleBackColor = false;
            btnParenthesis.Click += btnNgoac_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.FromArgb(243, 229, 245);
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.FlatAppearance.BorderSize = 0;
            btnPercent.FlatStyle = FlatStyle.Flat;
            btnPercent.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnPercent.ForeColor = Color.FromArgb(156, 39, 176);
            btnPercent.Location = new Point(343, 5);
            btnPercent.Margin = new Padding(5);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(159, 71);
            btnPercent.TabIndex = 2;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPhanTram_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(243, 229, 245);
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnDivide.ForeColor = Color.FromArgb(156, 39, 176);
            btnDivide.Location = new Point(512, 5);
            btnDivide.Margin = new Padding(5);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(162, 71);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnChia_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(243, 229, 245);
            btn7.Dock = DockStyle.Fill;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn7.ForeColor = Color.FromArgb(49, 27, 146);
            btn7.Location = new Point(5, 86);
            btn7.Margin = new Padding(5);
            btn7.Name = "btn7";
            btn7.Size = new Size(159, 71);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += NhapSo_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(243, 229, 245);
            btn8.Dock = DockStyle.Fill;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(49, 27, 146);
            btn8.Location = new Point(174, 86);
            btn8.Margin = new Padding(5);
            btn8.Name = "btn8";
            btn8.Size = new Size(159, 71);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += NhapSo_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(243, 229, 245);
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn9.ForeColor = Color.FromArgb(49, 27, 146);
            btn9.Location = new Point(343, 86);
            btn9.Margin = new Padding(5);
            btn9.Name = "btn9";
            btn9.Size = new Size(159, 71);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += NhapSo_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(243, 229, 245);
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.FromArgb(156, 39, 176);
            btnMultiply.Location = new Point(512, 86);
            btnMultiply.Margin = new Padding(5);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(162, 71);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnNhan_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(243, 229, 245);
            btn4.Dock = DockStyle.Fill;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn4.ForeColor = Color.FromArgb(49, 27, 146);
            btn4.Location = new Point(5, 167);
            btn4.Margin = new Padding(5);
            btn4.Name = "btn4";
            btn4.Size = new Size(159, 71);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += NhapSo_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(243, 229, 245);
            btn5.Dock = DockStyle.Fill;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(49, 27, 146);
            btn5.Location = new Point(174, 167);
            btn5.Margin = new Padding(5);
            btn5.Name = "btn5";
            btn5.Size = new Size(159, 71);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += NhapSo_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(243, 229, 245);
            btn6.Dock = DockStyle.Fill;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn6.ForeColor = Color.FromArgb(49, 27, 146);
            btn6.Location = new Point(343, 167);
            btn6.Margin = new Padding(5);
            btn6.Name = "btn6";
            btn6.Size = new Size(159, 71);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += NhapSo_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(243, 229, 245);
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.FromArgb(156, 39, 176);
            btnSubtract.Location = new Point(512, 167);
            btnSubtract.Margin = new Padding(5);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(162, 71);
            btnSubtract.TabIndex = 11;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnTru_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(243, 229, 245);
            btn1.Dock = DockStyle.Fill;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn1.ForeColor = Color.FromArgb(49, 27, 146);
            btn1.Location = new Point(5, 248);
            btn1.Margin = new Padding(5);
            btn1.Name = "btn1";
            btn1.Size = new Size(159, 71);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += NhapSo_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(243, 229, 245);
            btn2.Dock = DockStyle.Fill;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn2.ForeColor = Color.FromArgb(49, 27, 146);
            btn2.Location = new Point(174, 248);
            btn2.Margin = new Padding(5);
            btn2.Name = "btn2";
            btn2.Size = new Size(159, 71);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += NhapSo_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(243, 229, 245);
            btn3.Dock = DockStyle.Fill;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(49, 27, 146);
            btn3.Location = new Point(343, 248);
            btn3.Margin = new Padding(5);
            btn3.Name = "btn3";
            btn3.Size = new Size(159, 71);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += NhapSo_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(243, 229, 245);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(156, 39, 176);
            btnAdd.Location = new Point(512, 248);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 71);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnCong_Click;
            // 
            // btnToggleSign
            // 
            btnToggleSign.BackColor = Color.FromArgb(243, 229, 245);
            btnToggleSign.Dock = DockStyle.Fill;
            btnToggleSign.FlatAppearance.BorderSize = 0;
            btnToggleSign.FlatStyle = FlatStyle.Flat;
            btnToggleSign.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnToggleSign.ForeColor = Color.FromArgb(49, 27, 146);
            btnToggleSign.Location = new Point(5, 329);
            btnToggleSign.Margin = new Padding(5);
            btnToggleSign.Name = "btnToggleSign";
            btnToggleSign.Size = new Size(159, 74);
            btnToggleSign.TabIndex = 16;
            btnToggleSign.Text = "+/-";
            btnToggleSign.UseVisualStyleBackColor = false;
            btnToggleSign.Click += btnDoiDau_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(243, 229, 245);
            btn0.Dock = DockStyle.Fill;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn0.ForeColor = Color.FromArgb(49, 27, 146);
            btn0.Location = new Point(174, 329);
            btn0.Margin = new Padding(5);
            btn0.Name = "btn0";
            btn0.Size = new Size(159, 74);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += NhapSo_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.FromArgb(243, 229, 245);
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.FlatAppearance.BorderSize = 0;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnDecimal.ForeColor = Color.FromArgb(49, 27, 146);
            btnDecimal.Location = new Point(343, 329);
            btnDecimal.Margin = new Padding(5);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(159, 74);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnCham_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(123, 31, 162);
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(512, 329);
            btnEqual.Margin = new Padding(5);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(162, 74);
            btnEqual.TabIndex = 19;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnBang_Click;
            // 
            // frmMainCalculator
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 749);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(341, 5);
            Name = "frmMainCalculator";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy Tính";
            WindowState = FormWindowState.Maximized;
            LocationChanged += frmMainCalculator_LocationChanged;
            SizeChanged += frmMainCalculator_SizeChanged;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            tlpFunctions.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private TableLayoutPanel tlpFunctions;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnTongleFunc;
        private Button btnDegRad;
        private Button btnSqrt;
        private Button btnSin;
        private Button btnCos;
        private Button btnTan;
        private Button btnLn;
        private Button btnLog;
        private Button btnInverse;
        private Button btnExpE;
        private Button btnSquare;
        private Button btnPower;
        private Button btnAbs;
        private Button btnPi;
        private Button btnE;
        private Button btnAc;
        private Button btnParenthesis;
        private Button btnPercent;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtract;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnToggleSign;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEqual;
        private RichTextBox rtbMainDisplay;
        private Label label1;
        private Label lblPreview;
        private Panel pnlHeader;
        private Button btnCloseSplit;
        private SplitContainer splitContainer5;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnRuler;
        private Button btnBackspace;
        private Button btnHistory;
        private Label lblDegRad;
    }
}
