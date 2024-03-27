using QuanLyCafeNet.Data;
using QuanLyCafeNet.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafeNet
{
    public partial class Login : Form
    {
        AccountNVService accountNVService;
        NhanVienService nhanVienService;
        public Login()
        {
            InitializeComponent();
            accountNVService = new AccountNVService();
            nhanVienService = new NhanVienService();
            
            //NhanVien staff = nhanVienService.GetNhanViens().FirstOrDefault();
            //frmMainOrder.staff = staff;
            //this.Hide();
            //new frmMainOrder().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text;
                string pass = txtPass.Text;

                if (user == "")
                {
                    throw new Exception("Nhập tài khoản!");
                }

                if (pass == "")
                {
                    throw new Exception("Nhập mật khẩu!");
                }

                AccountNV acc = accountNVService.GetAccountNVs().Where(a => a.USERR.Equals(user) && a.PASS.Equals(pass)).FirstOrDefault();

                if (acc == null)
                {
                    throw new Exception("Sai mật khẩu hoặc tên đăng nhập!");
                }
                MessageBox.Show("Đăng nhập thành công");
                NhanVien staff = nhanVienService.GetNhanViens().FirstOrDefault(p => p.IDNhanVien == acc.IDNhanVien);

                frmMainOrder.staff = staff;
                this.Hide();
                new frmMainOrder().ShowDialog();
                this.Show();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
