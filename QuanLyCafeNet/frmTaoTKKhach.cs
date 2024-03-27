using QuanLyCafeNet.Data;
using QuanLyCafeNet.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafeNet
{
    public partial class frmTaoTKKhach : Form
    {
        AccountKHService accountKHService;
        KhachHangService khachHangService;
        public frmTaoTKKhach()
        {
            InitializeComponent();
            accountKHService = new AccountKHService();
            khachHangService = new KhachHangService();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSDT.Text) && String.IsNullOrEmpty(txtHoTen.Text) && String.IsNullOrEmpty(txtCMND.Text))
                {
                    throw new Exception("nhập đầy đủ thông tin");
                }
                if (!int.TryParse(txtTienNap.Text,out int a)&&txtTienNap.Text!=null)
                {
                    throw new Exception("Tiền nạp không hợp lệ!");
                }
                KhachHang khachHang = khachHangService.GetKhachHangs().Where(k => k.SDT == txtSDT.Text).FirstOrDefault();
                if (khachHang != null)
                {
                    throw new Exception("Tài khoản đã tồn tại trên hệ thống!");
                }
                khachHang = new KhachHang();
                khachHang.SDT = txtSDT.Text;
                khachHang.HoTen = txtHoTen.Text;
                if (txtTienNap.Text == null)
                    khachHang.TongTienNap = 0;
                else
                    khachHang.TongTienNap = float.Parse(txtTienNap.Text);
                khachHang.CMND = txtCMND.Text;
                khachHangService.ThemKhach(khachHang);
                AccountKH accountKH = new AccountKH();
                accountKH.USERR = txtSDT.Text;
                accountKH.PASS = "1";
                accountKH.NgayLap = DateTime.Now;
                if(txtTienNap.Text==null)
                    accountKH.SoTien = 0;
                else
                    accountKH.SoTien = float.Parse(txtTienNap.Text);
                accountKHService.ThemAcc(accountKH);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
