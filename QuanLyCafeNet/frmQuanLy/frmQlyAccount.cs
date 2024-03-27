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
using System.Xml.Linq;

namespace QuanLyCafeNet.frmQuanLy
{
    public partial class frmQlyAccount : Form
    {
        AccountNVService accountNVService;
        LoaiAccService loaiAccService;
        NhanVienService nhanVienService;
        
        public frmQlyAccount()
        {
            InitializeComponent();
        }

        private void frmQlyAccount_Load(object sender, EventArgs e)
        {
            accountNVService = new AccountNVService();
            loaiAccService = new LoaiAccService();
            nhanVienService = new NhanVienService();

            dgvAccountInfo.DataSource = null;
            dgvAccountInfo.DataSource = accountNVService.GetAccountNVs();
            dgvAccountInfo.Refresh();

            cbxCategoryAcc.ValueMember = "IDLoaiAcc";
            cbxCategoryAcc.DisplayMember = "TenLoaiACC";
            cbxCategoryAcc.DataSource = loaiAccService.GetLoaiACCs();

            cbxCategoryAccSearch.ValueMember = "IDLoaiAcc";
            cbxCategoryAccSearch.DisplayMember = "TenLoaiACC";
            cbxCategoryAccSearch.DataSource = loaiAccService.GetLoaiACCs();
        }

        private void cbxCategoryAccSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvAccountInfo.DataSource = accountNVService.GetAccountNVs().Where(n => n.TenLoaiTaiKhoan == cbxCategoryAccSearch.Text).ToList();
                dgvAccountInfo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAccountInfo.DataSource = accountNVService.GetAccountNVs().Where(n => n.USERR.ToLower() == txtSearchByText.Text.ToLower()).ToList();
                dgvAccountInfo.Refresh();               
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtAccount.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtEmloyeeID.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ dữ liệu!");
                }
                if (!int.TryParse(txtEmloyeeID.Text, out int b))
                {
                    throw new Exception("Mã nhân viên không hợp lệ!");
                }
    
                if (loaiAccService.GetLoaiACCs().Where(la => la.TenLoaiACC == cbxCategoryAcc.Text).FirstOrDefault() == null)
                {
                    throw new Exception("Loại tài khoản không hợp hệ!");
                }
                NhanVien nv = nhanVienService.GetNhanViens().Where(n => n.IDNhanVien == int.Parse(txtEmloyeeID.Text)).FirstOrDefault();
                if (nv == null)
                {
                    throw new Exception("Nhân viên không tồn tại!");
                }
                AccountNV acc = accountNVService.GetAccountNVs().Where(a => a.USERR == txtAccount.Text).FirstOrDefault();
                if(acc == null)
                {
                    acc = new AccountNV();
                    acc.USERR = txtAccount.Text;
                    acc.NgayLap = DateTime.Now;
                    accountNVService.AddAcc(acc);
                }
                acc.PASS = txtPassword.Text;
                acc.IDLoaiACC = int.Parse(cbxCategoryAcc.SelectedValue.ToString());
                accountNVService.SaveChange();
                MessageBox.Show("Thành công!");

                //dgvEmployee.DataSource = null;
                dgvAccountInfo.DataSource = accountNVService.GetAccountNVs();
                dgvAccountInfo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemoved_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccountInfo.SelectedRows.Count > 0)
                {
                    string user = dgvAccountInfo.SelectedRows[0].Cells[0].Value.ToString();
                    AccountNV acc = accountNVService.GetAccountNVs().Where(a => a.USERR == user).FirstOrDefault();
                    if (acc == null)
                        return;
                    if (MessageBox.Show("Bạn có chắc chắn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        accountNVService.RemoveAcc(acc);
                        //dgvEmployee.DataSource = null;
                        dgvAccountInfo.DataSource = nhanVienService.GetNhanViens();
                        dgvAccountInfo.Refresh();
                    }
                }
                else
                {
                    throw new Exception("Vui lòng chọn nhân viên muốn xóa!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAccountInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccountInfo.SelectedRows.Count > 0)
            {
                string user = dgvAccountInfo.SelectedRows[0].Cells[0].Value.ToString();
                AccountNV acc = accountNVService.GetAccountNVs().Where(a => a.USERR == user).FirstOrDefault();
                if (acc == null)
                    return;
                txtAccount.Text = acc.TenNhanVien;
                txtPassword.Text = acc.PASS;
                txtEmloyeeID.Text = acc.IDNhanVien.ToString();
                cbxCategoryAcc.SelectedValue = acc.IDLoaiACC;
            }
        }

        
    }
}
