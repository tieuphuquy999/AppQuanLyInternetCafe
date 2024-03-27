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

namespace QuanLyCafeNet.frmQuanLy
{
    public partial class frmQlyNhanVien : Form
    {
        NhanVienService nhanVienService;
        ChucVuService chucVuService;
        AccountNVService accountNVService;
        public frmQlyNhanVien()
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
            chucVuService = new ChucVuService();
            accountNVService = new AccountNVService();
        }

        private void frmQlyNhanVien_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = nhanVienService.GetNhanViens();
            dgvEmployee.Refresh();

            cbxPosition.ValueMember = "MaChucVu";
            cbxPosition.DisplayMember = "TenChucVu";
            cbxPosition.DataSource = chucVuService.GetChucVus();

            cbxPositionSearch.ValueMember = "MaChucVu";
            cbxPositionSearch.DisplayMember = "TenChucVu";
            cbxPositionSearch.DataSource = chucVuService.GetChucVus();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtIdentityCard.Text) || String.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ dữ liệu!");
                }
                if (!int.TryParse(txtPhoneNumber.Text, out int a))
                {
                    throw new Exception("Số điện thoại không hợp lệ!");
                }
                if (!int.TryParse(txtIdentityCard.Text, out int b))
                {
                    throw new Exception("Số chứng minh không hợp lệ!");
                }
                if (string.IsNullOrEmpty(cbxPosition.Text))
                {
                    throw new Exception("Vui lòng chọn chức vụ!");
                }

                if (chucVuService.GetChucVus().Where(c => c.TenChucVu == cbxPosition.Text).FirstOrDefault() == null)
                {
                    throw new Exception("Chức vụ không hợp hệ!");
                }
                NhanVien nv = nhanVienService.GetNhanViens().Where(n => n.CMND == txtIdentityCard.Text).FirstOrDefault();
                if (nv == null)
                {
                    nv = new NhanVien();
                    nv.IDNhanVien = nhanVienService.GetNhanViens().Last().IDNhanVien+1;
                    nv.HoTen = txtName.Text;
                    nv.SDT = txtPhoneNumber.Text;
                    nv.CMND = txtIdentityCard.Text;
                    nv.MaChucVu = cbxPosition.SelectedValue.ToString();
                    nhanVienService.ThemNhanVien(nv);
                }
                else
                {
                    nv.HoTen = txtName.Text;
                    nv.SDT = txtPhoneNumber.Text;
                    nv.CMND = txtIdentityCard.Text;
                    nv.MaChucVu = cbxPosition.SelectedValue.ToString();
                    nhanVienService.SaveChange();
                }
                MessageBox.Show("Thành công!");
                //dgvEmployee.DataSource = null;
                dgvEmployee.DataSource = nhanVienService.GetNhanViens();
                dgvEmployee.Refresh();
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
                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dgvEmployee.SelectedRows[0].Cells[0].Value.ToString());
                    NhanVien nv = nhanVienService.GetNhanViens().Where(n => n.IDNhanVien == id).FirstOrDefault();
                    if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if(accountNVService.GetAccountNVs().Where(n => n.IDNhanVien == nv.IDNhanVien).FirstOrDefault() != null)
                        {
                            throw new Exception("Không thể xóa nhân viên, nhân viên đã có tài khoản!");
                        }
                        nhanVienService.XoaNhanVien(nv);
                        //dgvEmployee.DataSource = null;
                        dgvEmployee.DataSource = nhanVienService.GetNhanViens();
                        dgvEmployee.Refresh();
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

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                    if (int.TryParse(txtSearchByText.Text, out int a))
                    {                        
                        dgvEmployee.DataSource = nhanVienService.GetNhanViens().Where(n => n.IDNhanVien == int.Parse(txtSearchByText.Text)).ToList();
                        dgvEmployee.Refresh();
                    }
                    else
                    {                        
                        dgvEmployee.DataSource = nhanVienService.GetNhanViens().Where(n => n.HoTen.ToLower().Contains(txtSearchByText.Text.ToLower())).ToList();
                        dgvEmployee.Refresh();
                    }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvEmployee.SelectedRows[0].Cells[0].Value.ToString());
                NhanVien nv = nhanVienService.GetNhanViens().Where(n => n.IDNhanVien == id).FirstOrDefault();
                if (nv == null)
                    return;
                txtName.Text = nv.HoTen;
                txtPhoneNumber.Text = nv.SDT.ToString();
                txtIdentityCard.Text = nv.CMND;
                cbxPosition.Text = chucVuService.GetChucVus().Where(c => c.MaChucVu == nv.MaChucVu).FirstOrDefault().TenChucVu;
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvEmployee.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Value.ToString());
            NhanVien nv = nhanVienService.GetNhanViens().Where(n => n.IDNhanVien == id).FirstOrDefault();
            if (nv == null)
                return;
            txtName.Text = nv.HoTen;
            txtPhoneNumber.Text = nv.SDT.ToString();
            txtIdentityCard.Text = nv.CMND;
            cbxPosition.Text = chucVuService.GetChucVus().Where(c => c.MaChucVu == nv.MaChucVu).FirstOrDefault().TenChucVu;

        }

        private void cbxPositionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = nhanVienService.GetNhanViens().Where(n => n.TenChucVu == cbxPositionSearch.Text).ToList();
                dgvEmployee.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployee_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dgvEmployee.SelectedRows[0].Cells[1].Value.ToString());
                    NhanVien nhanVien = nhanVienService.GetNhanViens().Where(n => n.IDNhanVien == id).FirstOrDefault();
                    if (nhanVien == null)
                        return;
                    txtName.Text = nhanVien.HoTen;
                    txtIdentityCard.Text = nhanVien.CMND;
                    txtPhoneNumber.Text = nhanVien.SDT;
                    cbxPosition.SelectedValue = nhanVien.MaChucVu;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLichLam_Click(object sender, EventArgs e)
        {
            if(dgvEmployee.SelectedRows.Count>0)
                new frmLichLam(txtIdentityCard.Text).Show();
            else
                MessageBox.Show("Vui lòng chọn nhận viên!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);    
        }
    }
}
