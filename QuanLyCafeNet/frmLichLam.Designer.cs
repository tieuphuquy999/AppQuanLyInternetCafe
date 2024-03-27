namespace QuanLyCafeNet
{
    partial class frmLichLam
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
            this.dgvLich = new System.Windows.Forms.DataGridView();
            this.gbCa = new System.Windows.Forms.GroupBox();
            this.rdbCa3 = new System.Windows.Forms.CheckBox();
            this.rdbCa2 = new System.Windows.Forms.CheckBox();
            this.rdbCa1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxThu = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macalam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).BeginInit();
            this.gbCa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLich
            // 
            this.dgvLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.nhanv,
            this.macalam});
            this.dgvLich.Location = new System.Drawing.Point(353, 12);
            this.dgvLich.Name = "dgvLich";
            this.dgvLich.RowHeadersWidth = 51;
            this.dgvLich.Size = new System.Drawing.Size(244, 329);
            this.dgvLich.TabIndex = 0;
            // 
            // gbCa
            // 
            this.gbCa.Controls.Add(this.rdbCa3);
            this.gbCa.Controls.Add(this.rdbCa2);
            this.gbCa.Controls.Add(this.rdbCa1);
            this.gbCa.Location = new System.Drawing.Point(42, 126);
            this.gbCa.Name = "gbCa";
            this.gbCa.Size = new System.Drawing.Size(281, 216);
            this.gbCa.TabIndex = 1;
            this.gbCa.TabStop = false;
            this.gbCa.Text = "Ca";
            // 
            // rdbCa3
            // 
            this.rdbCa3.AutoSize = true;
            this.rdbCa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbCa3.Location = new System.Drawing.Point(37, 138);
            this.rdbCa3.Name = "rdbCa3";
            this.rdbCa3.Size = new System.Drawing.Size(150, 21);
            this.rdbCa3.TabIndex = 2;
            this.rdbCa3.Text = "OverNight (18h-6h)";
            this.rdbCa3.UseVisualStyleBackColor = true;            
            // 
            // rdbCa2
            // 
            this.rdbCa2.AutoSize = true;
            this.rdbCa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbCa2.Location = new System.Drawing.Point(37, 93);
            this.rdbCa2.Name = "rdbCa2";
            this.rdbCa2.Size = new System.Drawing.Size(119, 21);
            this.rdbCa2.TabIndex = 1;
            this.rdbCa2.Text = "Ca2 (12h-18h)";
            this.rdbCa2.UseVisualStyleBackColor = true;            
            // 
            // rdbCa1
            // 
            this.rdbCa1.AutoSize = true;
            this.rdbCa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbCa1.Location = new System.Drawing.Point(37, 44);
            this.rdbCa1.Name = "rdbCa1";
            this.rdbCa1.Size = new System.Drawing.Size(107, 21);
            this.rdbCa1.TabIndex = 0;
            this.rdbCa1.Text = "Ca1(6h-12h)";
            this.rdbCa1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thu";
            // 
            // cbxThu
            // 
            this.cbxThu.FormattingEnabled = true;
            this.cbxThu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ Nhật"});
            this.cbxThu.Location = new System.Drawing.Point(127, 82);
            this.cbxThu.Name = "cbxThu";
            this.cbxThu.Size = new System.Drawing.Size(121, 21);
            this.cbxThu.TabIndex = 3;
            this.cbxThu.TextChanged += new System.EventHandler(this.cbxThu_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(127, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TenNV";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "thu";
            this.Column1.HeaderText = "Thu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ca";
            this.Column2.HeaderText = "Ca";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // nhanv
            // 
            this.nhanv.DataPropertyName = "IDNhanVien";
            this.nhanv.HeaderText = "nhanv";
            this.nhanv.Name = "nhanv";
            this.nhanv.Visible = false;
            // 
            // macalam
            // 
            this.macalam.DataPropertyName = "MaCa";
            this.macalam.HeaderText = "macalam";
            this.macalam.Name = "macalam";
            this.macalam.Visible = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(248, 358);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 37);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmLichLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 424);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbxThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCa);
            this.Controls.Add(this.dgvLich);
            this.Name = "frmLichLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichLam";
            this.Load += new System.EventHandler(this.frmLichLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).EndInit();
            this.gbCa.ResumeLayout(false);
            this.gbCa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLich;
        private System.Windows.Forms.GroupBox gbCa;
        private System.Windows.Forms.CheckBox rdbCa3;
        private System.Windows.Forms.CheckBox rdbCa2;
        private System.Windows.Forms.CheckBox rdbCa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxThu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn macalam;
        private System.Windows.Forms.Button btnCapNhat;
    }
}