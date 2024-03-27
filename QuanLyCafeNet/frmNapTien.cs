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
    public partial class frmNapTien : Form
    {
        AccountKHService accountKHService;
        KhachHangService khachHangService;
        public frmNapTien(string user)
        {
            InitializeComponent();
            accountKHService = new AccountKHService();
            khachHangService = new KhachHangService();
            if (user != null)
            {
                txtSDT.Text = user;
                txtSDT.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSDT.Text))
                {
                    throw new Exception("nhập đầy đủ thông tin");
                }
                if (!int.TryParse(txtTienNap.Text, out int a) && txtTienNap.Text != null)
                {
                    throw new Exception("Tiền nạp không hợp lệ!");
                }
                AccountKH accountKH = accountKHService.GetAccountKHs().Where(b => b.USERR == txtSDT.Text).FirstOrDefault();
                if (accountKH == null)
                {
                    throw new Exception("Tài khoản không tồn tại trên hệ thống!");
                }
                KhachHang khachHang = khachHangService.GetKhachHangs().Where(b => b.SDT == txtSDT.Text).FirstOrDefault();
                if (txtTienNap.Text == null)
                    khachHang.TongTienNap += 0;
                else
                    khachHang.TongTienNap += float.Parse(txtTienNap.Text);
                khachHangService.SaveChange();
                if (txtTienNap.Text == null)
                    accountKH.SoTien += 0;
                else
                    accountKH.SoTien += float.Parse(txtTienNap.Text);
                accountKHService.SaveChange();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
