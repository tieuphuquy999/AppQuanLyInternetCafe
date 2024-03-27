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
    public partial class frmDoiMatKhau : Form
    {
        private String User;
        AccountKHService accountKHService;
        public frmDoiMatKhau(String User)
        {
            InitializeComponent();
            accountKHService = new AccountKHService();
            this.User = User;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                AccountKH accountKH = accountKHService.GetAccountKHs().Where(a => a.USERR == User).FirstOrDefault();

                if (txtPassCu.Text == "")
                {
                    throw new Exception("Nhập mật khẩu cũ!");
                }

                if (txtPassMoi.Text == "")
                {
                    throw new Exception("Nhập mật khẩu mới!");
                }

                if (txtRePassMoi.Text == "")
                {
                    throw new Exception("Nhập lại mật khẩu!");
                }

                if(txtPassMoi.Text != txtRePassMoi.Text)
                {
                    throw new Exception("Mật khẩu mới không giống nhau!");
                }

                if(txtPassCu.Text != accountKH.PASS)
                {
                    throw new Exception("Sai mật khẩu hoặc tên đăng nhập!");
                }

                accountKH.PASS = txtPassMoi.Text;
                accountKHService.SaveChange();

                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
