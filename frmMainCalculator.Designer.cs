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
            rtbMainDisplay = new RichTextBox();
            splitContainer3 = new SplitContainer();
            lblPreview = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnHistory = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnBackspace = new Button();
            btnRuler = new Button();
            splitContainer4 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnToggleFunc = new Button();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
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
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
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
            // rtbMainDisplay
            // 
            rtbMainDisplay.BackColor = Color.White;
            rtbMainDisplay.BorderStyle = BorderStyle.None;
            rtbMainDisplay.Dock = DockStyle.Bottom;
            rtbMainDisplay.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbMainDisplay.Location = new Point(0, -49);
            rtbMainDisplay.Margin = new Padding(5, 5, 5, 5);
            rtbMainDisplay.Name = "rtbMainDisplay";
            rtbMainDisplay.ReadOnly = true;
            rtbMainDisplay.ScrollBars = RichTextBoxScrollBars.None;
            rtbMainDisplay.Size = new Size(1162, 160);
            rtbMainDisplay.TabIndex = 0;
            rtbMainDisplay.Text = "";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
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
            splitContainer3.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer3.Panel2.Controls.Add(tableLayoutPanel4);
            splitContainer3.Size = new Size(1162, 224);
            splitContainer3.SplitterDistance = 112;
            splitContainer3.SplitterWidth = 3;
            splitContainer3.TabIndex = 0;
            // 
            // lblPreview
            // 
            lblPreview.Dock = DockStyle.Top;
            lblPreview.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreview.ForeColor = Color.FromArgb(186, 104, 200);
            lblPreview.Location = new Point(0, 0);
            lblPreview.Margin = new Padding(5, 0, 5, 0);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(1162, 115);
            lblPreview.TabIndex = 1;
            lblPreview.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1162, 112);
            label1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnHistory, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(515, 109);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Fill;
            btnHistory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnHistory.ForeColor = Color.FromArgb(123, 31, 162);
            btnHistory.Location = new Point(5, 5);
            btnHistory.Margin = new Padding(5, 5, 5, 5);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(161, 99);
            btnHistory.TabIndex = 0;
            btnHistory.Text = "🕐";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btnBackspace, 3, 0);
            tableLayoutPanel4.Controls.Add(btnRuler, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Right;
            tableLayoutPanel4.Location = new Point(515, 0);
            tableLayoutPanel4.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tableLayoutPanel4.Size = new Size(647, 109);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnBackspace.ForeColor = Color.FromArgb(123, 31, 162);
            btnBackspace.Location = new Point(488, 5);
            btnBackspace.Margin = new Padding(5, 5, 5, 5);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(154, 99);
            btnBackspace.TabIndex = 0;
            btnBackspace.Text = "⌫ ";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnRuler
            // 
            btnRuler.Dock = DockStyle.Fill;
            btnRuler.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRuler.ForeColor = Color.FromArgb(123, 31, 162);
            btnRuler.Location = new Point(327, 5);
            btnRuler.Margin = new Padding(5, 5, 5, 5);
            btnRuler.Name = "btnRuler";
            btnRuler.Size = new Size(151, 99);
            btnRuler.TabIndex = 1;
            btnRuler.Text = "📏";
            btnRuler.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer4.Size = new Size(1162, 408);
            splitContainer4.SplitterDistance = 507;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 229, 245);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnToggleFunc, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDegRad, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSqrt, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSin, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCos, 1, 1);
            tableLayoutPanel1.Controls.Add(btnTan, 2, 1);
            tableLayoutPanel1.Controls.Add(btnLn, 0, 2);
            tableLayoutPanel1.Controls.Add(btnLog, 1, 2);
            tableLayoutPanel1.Controls.Add(btnInverse, 2, 2);
            tableLayoutPanel1.Controls.Add(btnExpE, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSquare, 1, 3);
            tableLayoutPanel1.Controls.Add(btnPower, 2, 3);
            tableLayoutPanel1.Controls.Add(btnAbs, 0, 4);
            tableLayoutPanel1.Controls.Add(btnPi, 1, 4);
            tableLayoutPanel1.Controls.Add(btnE, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tableLayoutPanel1.ForeColor = Color.FromArgb(49, 27, 146);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(507, 408);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnToggleFunc
            // 
            btnToggleFunc.BackColor = Color.FromArgb(243, 229, 245);
            btnToggleFunc.Dock = DockStyle.Fill;
            btnToggleFunc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnToggleFunc.ForeColor = Color.FromArgb(49, 27, 146);
            btnToggleFunc.Location = new Point(5, 5);
            btnToggleFunc.Margin = new Padding(5, 5, 5, 5);
            btnToggleFunc.Name = "btnToggleFunc";
            btnToggleFunc.Size = new Size(159, 71);
            btnToggleFunc.TabIndex = 0;
            btnToggleFunc.Text = "↑↓";
            btnToggleFunc.UseVisualStyleBackColor = false;
            // 
            // btnDegRad
            // 
            btnDegRad.BackColor = Color.FromArgb(243, 229, 245);
            btnDegRad.Dock = DockStyle.Fill;
            btnDegRad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDegRad.ForeColor = Color.FromArgb(49, 27, 146);
            btnDegRad.Location = new Point(174, 5);
            btnDegRad.Margin = new Padding(5, 5, 5, 5);
            btnDegRad.Name = "btnDegRad";
            btnDegRad.Size = new Size(159, 71);
            btnDegRad.TabIndex = 1;
            btnDegRad.Text = "Rad";
            btnDegRad.UseVisualStyleBackColor = false;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.FromArgb(243, 229, 245);
            btnSqrt.Dock = DockStyle.Fill;
            btnSqrt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSqrt.ForeColor = Color.FromArgb(49, 27, 146);
            btnSqrt.Location = new Point(343, 5);
            btnSqrt.Margin = new Padding(5, 5, 5, 5);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(159, 71);
            btnSqrt.TabIndex = 2;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnSin
            // 
            btnSin.BackColor = Color.FromArgb(243, 229, 245);
            btnSin.Dock = DockStyle.Fill;
            btnSin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSin.ForeColor = Color.FromArgb(49, 27, 146);
            btnSin.Location = new Point(5, 86);
            btnSin.Margin = new Padding(5, 5, 5, 5);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(159, 71);
            btnSin.TabIndex = 3;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.FromArgb(243, 229, 245);
            btnCos.Dock = DockStyle.Fill;
            btnCos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCos.ForeColor = Color.FromArgb(49, 27, 146);
            btnCos.Location = new Point(174, 86);
            btnCos.Margin = new Padding(5, 5, 5, 5);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(159, 71);
            btnCos.TabIndex = 4;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            // 
            // btnTan
            // 
            btnTan.BackColor = Color.FromArgb(243, 229, 245);
            btnTan.Dock = DockStyle.Fill;
            btnTan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnTan.ForeColor = Color.FromArgb(49, 27, 146);
            btnTan.Location = new Point(343, 86);
            btnTan.Margin = new Padding(5, 5, 5, 5);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(159, 71);
            btnTan.TabIndex = 5;
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = false;
            // 
            // btnLn
            // 
            btnLn.BackColor = Color.FromArgb(243, 229, 245);
            btnLn.Dock = DockStyle.Fill;
            btnLn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLn.ForeColor = Color.FromArgb(49, 27, 146);
            btnLn.Location = new Point(5, 167);
            btnLn.Margin = new Padding(5, 5, 5, 5);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(159, 71);
            btnLn.TabIndex = 6;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(243, 229, 245);
            btnLog.Dock = DockStyle.Fill;
            btnLog.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLog.ForeColor = Color.FromArgb(49, 27, 146);
            btnLog.Location = new Point(174, 167);
            btnLog.Margin = new Padding(5, 5, 5, 5);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(159, 71);
            btnLog.TabIndex = 7;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // btnInverse
            // 
            btnInverse.BackColor = Color.FromArgb(243, 229, 245);
            btnInverse.Dock = DockStyle.Fill;
            btnInverse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnInverse.ForeColor = Color.FromArgb(49, 27, 146);
            btnInverse.Location = new Point(343, 167);
            btnInverse.Margin = new Padding(5, 5, 5, 5);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(159, 71);
            btnInverse.TabIndex = 8;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            // 
            // btnExpE
            // 
            btnExpE.BackColor = Color.FromArgb(243, 229, 245);
            btnExpE.Dock = DockStyle.Fill;
            btnExpE.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnExpE.ForeColor = Color.FromArgb(49, 27, 146);
            btnExpE.Location = new Point(5, 248);
            btnExpE.Margin = new Padding(5, 5, 5, 5);
            btnExpE.Name = "btnExpE";
            btnExpE.Size = new Size(159, 71);
            btnExpE.TabIndex = 9;
            btnExpE.Text = "eˣ";
            btnExpE.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.FromArgb(243, 229, 245);
            btnSquare.Dock = DockStyle.Fill;
            btnSquare.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSquare.ForeColor = Color.FromArgb(49, 27, 146);
            btnSquare.Location = new Point(174, 248);
            btnSquare.Margin = new Padding(5, 5, 5, 5);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(159, 71);
            btnSquare.TabIndex = 10;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = false;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.FromArgb(243, 229, 245);
            btnPower.Dock = DockStyle.Fill;
            btnPower.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPower.ForeColor = Color.FromArgb(49, 27, 146);
            btnPower.Location = new Point(343, 248);
            btnPower.Margin = new Padding(5, 5, 5, 5);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(159, 71);
            btnPower.TabIndex = 11;
            btnPower.Text = "xʸ";
            btnPower.UseVisualStyleBackColor = false;
            // 
            // btnAbs
            // 
            btnAbs.BackColor = Color.FromArgb(243, 229, 245);
            btnAbs.Dock = DockStyle.Fill;
            btnAbs.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAbs.ForeColor = Color.FromArgb(49, 27, 146);
            btnAbs.Location = new Point(5, 329);
            btnAbs.Margin = new Padding(5, 5, 5, 5);
            btnAbs.Name = "btnAbs";
            btnAbs.Size = new Size(159, 74);
            btnAbs.TabIndex = 12;
            btnAbs.Text = "|x|";
            btnAbs.UseVisualStyleBackColor = false;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.FromArgb(243, 229, 245);
            btnPi.Dock = DockStyle.Fill;
            btnPi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPi.ForeColor = Color.FromArgb(49, 27, 146);
            btnPi.Location = new Point(174, 329);
            btnPi.Margin = new Padding(5, 5, 5, 5);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(159, 74);
            btnPi.TabIndex = 13;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = Color.FromArgb(243, 229, 245);
            btnE.Dock = DockStyle.Fill;
            btnE.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnE.ForeColor = Color.FromArgb(49, 27, 146);
            btnE.Location = new Point(343, 329);
            btnE.Margin = new Padding(5, 5, 5, 5);
            btnE.Name = "btnE";
            btnE.Size = new Size(159, 74);
            btnE.TabIndex = 14;
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(43, 229, 245);
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
            tableLayoutPanel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tableLayoutPanel2.ForeColor = Color.FromArgb(49, 27, 146);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(650, 408);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAc
            // 
            btnAc.BackColor = Color.FromArgb(243, 229, 245);
            btnAc.Dock = DockStyle.Fill;
            btnAc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAc.ForeColor = Color.FromArgb(49, 27, 146);
            btnAc.Location = new Point(5, 5);
            btnAc.Margin = new Padding(5, 5, 5, 5);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(152, 71);
            btnAc.TabIndex = 0;
            btnAc.Text = "C";
            btnAc.UseVisualStyleBackColor = false;
            // 
            // btnParenthesis
            // 
            btnParenthesis.BackColor = Color.FromArgb(243, 229, 245);
            btnParenthesis.Dock = DockStyle.Fill;
            btnParenthesis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnParenthesis.ForeColor = Color.FromArgb(49, 27, 146);
            btnParenthesis.Location = new Point(167, 5);
            btnParenthesis.Margin = new Padding(5, 5, 5, 5);
            btnParenthesis.Name = "btnParenthesis";
            btnParenthesis.Size = new Size(152, 71);
            btnParenthesis.TabIndex = 1;
            btnParenthesis.Text = "( )";
            btnParenthesis.UseVisualStyleBackColor = false;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.FromArgb(243, 229, 245);
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPercent.ForeColor = Color.FromArgb(49, 27, 146);
            btnPercent.Location = new Point(329, 5);
            btnPercent.Margin = new Padding(5, 5, 5, 5);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(152, 71);
            btnPercent.TabIndex = 2;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(243, 229, 245);
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDivide.ForeColor = Color.FromArgb(49, 27, 146);
            btnDivide.Location = new Point(491, 5);
            btnDivide.Margin = new Padding(5, 5, 5, 5);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(154, 71);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(243, 229, 245);
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn7.ForeColor = Color.FromArgb(49, 27, 146);
            btn7.Location = new Point(5, 86);
            btn7.Margin = new Padding(5, 5, 5, 5);
            btn7.Name = "btn7";
            btn7.Size = new Size(152, 71);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(243, 229, 245);
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(49, 27, 146);
            btn8.Location = new Point(167, 86);
            btn8.Margin = new Padding(5, 5, 5, 5);
            btn8.Name = "btn8";
            btn8.Size = new Size(152, 71);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(243, 229, 245);
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn9.ForeColor = Color.FromArgb(49, 27, 146);
            btn9.Location = new Point(329, 86);
            btn9.Margin = new Padding(5, 5, 5, 5);
            btn9.Name = "btn9";
            btn9.Size = new Size(152, 71);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(243, 229, 245);
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.FromArgb(49, 27, 146);
            btnMultiply.Location = new Point(491, 86);
            btnMultiply.Margin = new Padding(5, 5, 5, 5);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(154, 71);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(243, 229, 245);
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn4.ForeColor = Color.FromArgb(49, 27, 146);
            btn4.Location = new Point(5, 167);
            btn4.Margin = new Padding(5, 5, 5, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(152, 71);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(243, 229, 245);
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(49, 27, 146);
            btn5.Location = new Point(167, 167);
            btn5.Margin = new Padding(5, 5, 5, 5);
            btn5.Name = "btn5";
            btn5.Size = new Size(152, 71);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(243, 229, 245);
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn6.ForeColor = Color.FromArgb(49, 27, 146);
            btn6.Location = new Point(329, 167);
            btn6.Margin = new Padding(5, 5, 5, 5);
            btn6.Name = "btn6";
            btn6.Size = new Size(152, 71);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(243, 229, 245);
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.FromArgb(49, 27, 146);
            btnSubtract.Location = new Point(491, 167);
            btnSubtract.Margin = new Padding(5, 5, 5, 5);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(154, 71);
            btnSubtract.TabIndex = 11;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(243, 229, 245);
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn1.ForeColor = Color.FromArgb(49, 27, 146);
            btn1.Location = new Point(5, 248);
            btn1.Margin = new Padding(5, 5, 5, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(152, 71);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(243, 229, 245);
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn2.ForeColor = Color.FromArgb(49, 27, 146);
            btn2.Location = new Point(167, 248);
            btn2.Margin = new Padding(5, 5, 5, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(152, 71);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(243, 229, 245);
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(49, 27, 146);
            btn3.Location = new Point(329, 248);
            btn3.Margin = new Padding(5, 5, 5, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(152, 71);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(43, 229, 245);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(156, 39, 176);
            btnAdd.Location = new Point(491, 248);
            btnAdd.Margin = new Padding(5, 5, 5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 71);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnToggleSign
            // 
            btnToggleSign.BackColor = Color.FromArgb(243, 229, 245);
            btnToggleSign.Dock = DockStyle.Fill;
            btnToggleSign.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnToggleSign.ForeColor = Color.FromArgb(49, 27, 146);
            btnToggleSign.Location = new Point(5, 329);
            btnToggleSign.Margin = new Padding(5, 5, 5, 5);
            btnToggleSign.Name = "btnToggleSign";
            btnToggleSign.Size = new Size(152, 74);
            btnToggleSign.TabIndex = 16;
            btnToggleSign.Text = "+/-";
            btnToggleSign.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(43, 229, 245);
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.FromArgb(49, 27, 146);
            btn0.Location = new Point(167, 329);
            btn0.Margin = new Padding(5, 5, 5, 5);
            btn0.Name = "btn0";
            btn0.Size = new Size(152, 74);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.FromArgb(43, 229, 245);
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecimal.ForeColor = Color.FromArgb(49, 27, 146);
            btnDecimal.Location = new Point(329, 329);
            btnDecimal.Margin = new Padding(5, 5, 5, 5);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(152, 74);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(243, 229, 245);
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEqual.ForeColor = Color.FromArgb(49, 27, 146);
            btnEqual.Location = new Point(491, 329);
            btnEqual.Margin = new Padding(5, 5, 5, 5);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(154, 74);
            btnEqual.TabIndex = 19;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // frmMainCalculator
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 229, 245);
            ClientSize = new Size(1162, 749);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            ForeColor = Color.FromArgb(49, 27, 146);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(341, 5);
            Name = "frmMainCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy Tính";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnToggleFunc;
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
        private Button btnHistory;
        private Button btnBackspace;
        private Button btnRuler;
        private RichTextBox rtbMainDisplay;
        private Label label1;
        private Label lblPreview;
    }
}
