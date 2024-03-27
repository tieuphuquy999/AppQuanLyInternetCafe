namespace QuanLyCafeNet
{
    partial class frmMainOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainOrder));
            this.pnlMayM = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbxDanhMuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.col_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldanhmuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nupSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.grbThongTinMay = new System.Windows.Forms.GroupBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDKhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMayVip = new System.Windows.Forms.Panel();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMónVàDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.môPhỏngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.waringOrder = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).BeginInit();
            this.grbThongTinMay.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waringOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMayM
            // 
            this.pnlMayM.Location = new System.Drawing.Point(16, 43);
            this.pnlMayM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMayM.Name = "pnlMayM";
            this.pnlMayM.Size = new System.Drawing.Size(412, 624);
            this.pnlMayM.TabIndex = 0;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(459, 400);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.Size = new System.Drawing.Size(624, 277);
            this.dgvOrder.TabIndex = 1;
            // 
            // cbxDanhMuc
            // 
            this.cbxDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxDanhMuc.FormattingEnabled = true;
            this.cbxDanhMuc.Location = new System.Drawing.Point(563, 43);
            this.cbxDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDanhMuc.Name = "cbxDanhMuc";
            this.cbxDanhMuc.Size = new System.Drawing.Size(160, 28);
            this.cbxDanhMuc.TabIndex = 2;
            this.cbxDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbxDanhMuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(459, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(743, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeColumns = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TenMon,
            this.colCTHD,
            this.colCTPC,
            this.coldanhmuc,
            this.col_mamon,
            this.coldvt,
            this.col_DanhMuc,
            this.col_gia});
            this.dgvMenu.Location = new System.Drawing.Point(456, 96);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.Size = new System.Drawing.Size(627, 279);
            this.dgvMenu.TabIndex = 7;
            // 
            // col_TenMon
            // 
            this.col_TenMon.DataPropertyName = "TenMon";
            this.col_TenMon.HeaderText = "Tên món";
            this.col_TenMon.MinimumWidth = 6;
            this.col_TenMon.Name = "col_TenMon";
            this.col_TenMon.Width = 200;
            // 
            // colCTHD
            // 
            this.colCTHD.DataPropertyName = "CTHoaDons";
            this.colCTHD.HeaderText = "cthd";
            this.colCTHD.MinimumWidth = 6;
            this.colCTHD.Name = "colCTHD";
            this.colCTHD.Visible = false;
            this.colCTHD.Width = 125;
            // 
            // colCTPC
            // 
            this.colCTPC.DataPropertyName = "CTPhaChes";
            this.colCTPC.HeaderText = "ctpc";
            this.colCTPC.MinimumWidth = 6;
            this.colCTPC.Name = "colCTPC";
            this.colCTPC.Visible = false;
            this.colCTPC.Width = 125;
            // 
            // coldanhmuc
            // 
            this.coldanhmuc.DataPropertyName = "DanhMuc";
            this.coldanhmuc.HeaderText = "danhmuc";
            this.coldanhmuc.MinimumWidth = 6;
            this.coldanhmuc.Name = "coldanhmuc";
            this.coldanhmuc.Visible = false;
            this.coldanhmuc.Width = 125;
            // 
            // col_mamon
            // 
            this.col_mamon.DataPropertyName = "MaMon";
            this.col_mamon.HeaderText = "mamon";
            this.col_mamon.MinimumWidth = 6;
            this.col_mamon.Name = "col_mamon";
            this.col_mamon.Visible = false;
            this.col_mamon.Width = 125;
            // 
            // coldvt
            // 
            this.coldvt.DataPropertyName = "DVT";
            this.coldvt.HeaderText = "dvt";
            this.coldvt.MinimumWidth = 6;
            this.coldvt.Name = "coldvt";
            this.coldvt.Visible = false;
            this.coldvt.Width = 125;
            // 
            // col_DanhMuc
            // 
            this.col_DanhMuc.DataPropertyName = "MaDanhMuc";
            this.col_DanhMuc.HeaderText = "Danh mục";
            this.col_DanhMuc.MinimumWidth = 6;
            this.col_DanhMuc.Name = "col_DanhMuc";
            this.col_DanhMuc.Width = 120;
            // 
            // col_gia
            // 
            this.col_gia.DataPropertyName = "DonGia";
            this.col_gia.HeaderText = "Giá";
            this.col_gia.MinimumWidth = 6;
            this.col_gia.Name = "col_gia";
            this.col_gia.Width = 125;
            // 
            // nupSoLuong
            // 
            this.nupSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nupSoLuong.Location = new System.Drawing.Point(836, 43);
            this.nupSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nupSoLuong.Name = "nupSoLuong";
            this.nupSoLuong.Size = new System.Drawing.Size(160, 26);
            this.nupSoLuong.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(535, 700);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Voucher";
            // 
            // txtVoucher
            // 
            this.txtVoucher.Location = new System.Drawing.Point(624, 702);
            this.txtVoucher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(132, 22);
            this.txtVoucher.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(900, 702);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(181, 22);
            this.txtTongTien.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(801, 700);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(1004, 30);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(79, 59);
            this.btnThemMon.TabIndex = 13;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(824, 747);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 59);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa món";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(961, 747);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(121, 59);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // grbThongTinMay
            // 
            this.grbThongTinMay.Controls.Add(this.txtSoTien);
            this.grbThongTinMay.Controls.Add(this.label7);
            this.grbThongTinMay.Controls.Add(this.txtIDKhach);
            this.grbThongTinMay.Controls.Add(this.label6);
            this.grbThongTinMay.Controls.Add(this.txtTenMay);
            this.grbThongTinMay.Controls.Add(this.label5);
            this.grbThongTinMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbThongTinMay.Location = new System.Drawing.Point(1115, 43);
            this.grbThongTinMay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTinMay.Name = "grbThongTinMay";
            this.grbThongTinMay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTinMay.Size = new System.Drawing.Size(507, 262);
            this.grbThongTinMay.TabIndex = 16;
            this.grbThongTinMay.TabStop = false;
            this.grbThongTinMay.Text = "Thông tin máy";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(160, 142);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(264, 26);
            this.txtSoTien.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số tiền";
            // 
            // txtIDKhach
            // 
            this.txtIDKhach.Location = new System.Drawing.Point(160, 34);
            this.txtIDKhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDKhach.Name = "txtIDKhach";
            this.txtIDKhach.Size = new System.Drawing.Size(264, 26);
            this.txtIDKhach.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID khách";
            // 
            // txtTenMay
            // 
            this.txtTenMay.Location = new System.Drawing.Point(160, 86);
            this.txtTenMay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(264, 26);
            this.txtTenMay.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Máy";
            // 
            // pnlMayVip
            // 
            this.pnlMayVip.Location = new System.Drawing.Point(1115, 334);
            this.pnlMayVip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMayVip.Name = "pnlMayVip";
            this.pnlMayVip.Size = new System.Drawing.Size(507, 361);
            this.pnlMayVip.TabIndex = 17;
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIDNV.Location = new System.Drawing.Point(39, 747);
            this.lblIDNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(26, 20);
            this.lblIDNV.TabIndex = 18;
            this.lblIDNV.Text = "ID";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTenNV.Location = new System.Drawing.Point(39, 788);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(42, 20);
            this.lblTenNV.TabIndex = 19;
            this.lblTenNV.Text = "TEN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.môPhỏngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1685, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýMónVàDanhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLToolStripMenuItem
            // 
            this.quảnLToolStripMenuItem.Name = "quảnLToolStripMenuItem";
            this.quảnLToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.quảnLToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLToolStripMenuItem.Click += new System.EventHandler(this.quảnLToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýMónVàDanhMụcToolStripMenuItem
            // 
            this.quảnLýMónVàDanhMụcToolStripMenuItem.Enabled = false;
            this.quảnLýMónVàDanhMụcToolStripMenuItem.Name = "quảnLýMónVàDanhMụcToolStripMenuItem";
            this.quảnLýMónVàDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.quảnLýMónVàDanhMụcToolStripMenuItem.Text = "Quản lý món và danh mục";
            this.quảnLýMónVàDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMónVàDanhMụcToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // môPhỏngToolStripMenuItem
            // 
            this.môPhỏngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởMáyToolStripMenuItem});
            this.môPhỏngToolStripMenuItem.Name = "môPhỏngToolStripMenuItem";
            this.môPhỏngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.môPhỏngToolStripMenuItem.Text = "Mô Phỏng";
            // 
            // mởMáyToolStripMenuItem
            // 
            this.mởMáyToolStripMenuItem.Name = "mởMáyToolStripMenuItem";
            this.mởMáyToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.mởMáyToolStripMenuItem.Text = "Mở Máy";
            this.mởMáyToolStripMenuItem.Click += new System.EventHandler(this.mởMáyToolStripMenuItem_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(1303, 747);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(133, 59);
            this.btnTaoTK.TabIndex = 21;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnNapTien
            // 
            this.btnNapTien.Location = new System.Drawing.Point(1464, 747);
            this.btnNapTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(157, 59);
            this.btnNapTien.TabIndex = 22;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = true;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // waringOrder
            // 
            this.waringOrder.ContainerControl = this;
            // 
            // frmMainOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.btnNapTien);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblIDNV);
            this.Controls.Add(this.pnlMayVip);
            this.Controls.Add(this.grbThongTinMay);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVoucher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupSoLuong);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDanhMuc);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.pnlMayM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CafeEsport1.9";
            this.Load += new System.EventHandler(this.frmMainOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).EndInit();
            this.grbThongTinMay.ResumeLayout(false);
            this.grbThongTinMay.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waringOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMayM;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cbxDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.NumericUpDown nupSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldanhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gia;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox grbThongTinMay;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlMayVip;
        private System.Windows.Forms.Label lblIDNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem môPhỏngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởMáyToolStripMenuItem;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.ToolStripMenuItem quảnLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMónVàDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider waringOrder;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}