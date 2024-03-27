namespace QuanLyCafeNet.frmQuanLy
{
    partial class frmQlyAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmloyeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoved = new System.Windows.Forms.Button();
            this.cbxCategoryAcc = new System.Windows.Forms.ComboBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.dgvAccountInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeach = new System.Windows.Forms.Button();
            this.txtSearchByText = new System.Windows.Forms.TextBox();
            this.cbxCategoryAccSearch = new System.Windows.Forms.ComboBox();
            this.clmAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoryAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmloyeeID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnRemoved);
            this.groupBox1.Controls.Add(this.cbxCategoryAcc);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Location = new System.Drawing.Point(29, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(724, 156);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 44);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm/Sửa";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài khoản";
            // 
            // txtEmloyeeID
            // 
            this.txtEmloyeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmloyeeID.Location = new System.Drawing.Point(40, 118);
            this.txtEmloyeeID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmloyeeID.Name = "txtEmloyeeID";
            this.txtEmloyeeID.Size = new System.Drawing.Size(241, 26);
            this.txtEmloyeeID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại tài khoản";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(311, 50);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRemoved
            // 
            this.btnRemoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoved.Location = new System.Drawing.Point(590, 99);
            this.btnRemoved.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoved.Name = "btnRemoved";
            this.btnRemoved.Size = new System.Drawing.Size(78, 44);
            this.btnRemoved.TabIndex = 9;
            this.btnRemoved.Text = "Xóa";
            this.btnRemoved.UseVisualStyleBackColor = true;
            this.btnRemoved.Click += new System.EventHandler(this.btnRemoved_Click);
            // 
            // cbxCategoryAcc
            // 
            this.cbxCategoryAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoryAcc.FormattingEnabled = true;
            this.cbxCategoryAcc.Location = new System.Drawing.Point(311, 115);
            this.cbxCategoryAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCategoryAcc.Name = "cbxCategoryAcc";
            this.cbxCategoryAcc.Size = new System.Drawing.Size(246, 28);
            this.cbxCategoryAcc.TabIndex = 3;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(40, 50);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(241, 26);
            this.txtAccount.TabIndex = 6;
            // 
            // dgvAccountInfo
            // 
            this.dgvAccountInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAccount,
            this.clmPassword,
            this.clmCategoryAcc,
            this.clmDateCreate,
            this.clmEmployeeID,
            this.clmEmployeeName,
            this.Column3,
            this.Column2,
            this.Column1});
            this.dgvAccountInfo.Location = new System.Drawing.Point(29, 287);
            this.dgvAccountInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAccountInfo.Name = "dgvAccountInfo";
            this.dgvAccountInfo.RowHeadersWidth = 51;
            this.dgvAccountInfo.RowTemplate.Height = 24;
            this.dgvAccountInfo.Size = new System.Drawing.Size(724, 202);
            this.dgvAccountInfo.TabIndex = 29;
            this.dgvAccountInfo.SelectionChanged += new System.EventHandler(this.dgvAccountInfo_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ ACCOUNT";
            // 
            // btnSeach
            // 
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Location = new System.Drawing.Point(344, 58);
            this.btnSeach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(96, 29);
            this.btnSeach.TabIndex = 26;
            this.btnSeach.Text = "Tìm kiếm";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // txtSearchByText
            // 
            this.txtSearchByText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByText.Location = new System.Drawing.Point(178, 60);
            this.txtSearchByText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchByText.Name = "txtSearchByText";
            this.txtSearchByText.Size = new System.Drawing.Size(162, 26);
            this.txtSearchByText.TabIndex = 28;
            // 
            // cbxCategoryAccSearch
            // 
            this.cbxCategoryAccSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoryAccSearch.FormattingEnabled = true;
            this.cbxCategoryAccSearch.Location = new System.Drawing.Point(29, 58);
            this.cbxCategoryAccSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCategoryAccSearch.Name = "cbxCategoryAccSearch";
            this.cbxCategoryAccSearch.Size = new System.Drawing.Size(146, 28);
            this.cbxCategoryAccSearch.TabIndex = 27;
            this.cbxCategoryAccSearch.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryAccSearch_SelectedIndexChanged);
            // 
            // clmAccount
            // 
            this.clmAccount.DataPropertyName = "USERR";
            this.clmAccount.HeaderText = "Tên tài khoản";
            this.clmAccount.MinimumWidth = 6;
            this.clmAccount.Name = "clmAccount";
            this.clmAccount.ReadOnly = true;
            this.clmAccount.Width = 125;
            // 
            // clmPassword
            // 
            this.clmPassword.DataPropertyName = "PASS";
            this.clmPassword.HeaderText = "Mật khẩu";
            this.clmPassword.MinimumWidth = 6;
            this.clmPassword.Name = "clmPassword";
            this.clmPassword.ReadOnly = true;
            this.clmPassword.Width = 125;
            // 
            // clmCategoryAcc
            // 
            this.clmCategoryAcc.DataPropertyName = "TenLoaiTaiKhoan";
            this.clmCategoryAcc.HeaderText = "Loại tài khoản";
            this.clmCategoryAcc.MinimumWidth = 6;
            this.clmCategoryAcc.Name = "clmCategoryAcc";
            this.clmCategoryAcc.ReadOnly = true;
            this.clmCategoryAcc.Width = 125;
            // 
            // clmDateCreate
            // 
            this.clmDateCreate.DataPropertyName = "NgayLap";
            this.clmDateCreate.HeaderText = "Ngày khởi tạo";
            this.clmDateCreate.MinimumWidth = 6;
            this.clmDateCreate.Name = "clmDateCreate";
            this.clmDateCreate.ReadOnly = true;
            this.clmDateCreate.Width = 125;
            // 
            // clmEmployeeID
            // 
            this.clmEmployeeID.DataPropertyName = "IDNhanVien";
            this.clmEmployeeID.HeaderText = "Mã nhân viên";
            this.clmEmployeeID.MinimumWidth = 6;
            this.clmEmployeeID.Name = "clmEmployeeID";
            this.clmEmployeeID.ReadOnly = true;
            this.clmEmployeeID.Width = 125;
            // 
            // clmEmployeeName
            // 
            this.clmEmployeeName.DataPropertyName = "TenNhanVien";
            this.clmEmployeeName.HeaderText = "Họ tên";
            this.clmEmployeeName.MinimumWidth = 6;
            this.clmEmployeeName.Name = "clmEmployeeName";
            this.clmEmployeeName.ReadOnly = true;
            this.clmEmployeeName.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NhanVien";
            this.Column3.HeaderText = "NhanVien";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoaiACC";
            this.Column2.HeaderText = "LoaiAcc";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDLoaiACC";
            this.Column1.HeaderText = "Ma Loai";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // frmQlyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAccountInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.txtSearchByText);
            this.Controls.Add(this.cbxCategoryAccSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQlyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQlyAccount";
            this.Load += new System.EventHandler(this.frmQlyAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmloyeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoved;
        private System.Windows.Forms.ComboBox cbxCategoryAcc;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.DataGridView dgvAccountInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtSearchByText;
        private System.Windows.Forms.ComboBox cbxCategoryAccSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoryAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}