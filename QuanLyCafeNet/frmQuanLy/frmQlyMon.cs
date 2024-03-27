using QuanLyCafeNet.Data;
using QuanLyCafeNet.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafeNet.frmQuanLy
{
    public partial class frmQlyMon : Form
    {
        MonService monService;
        DanhMucService danhMucService;
        public frmQlyMon()
        {
            InitializeComponent();
        }

        private void frnQlyMon_Load(object sender, EventArgs e)
        {
            monService = new MonService();
            danhMucService = new DanhMucService();
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = monService.GetMonTheoDanhMuc(danhMucService.GetDanhMucs().ToList().FirstOrDefault().MaDanhMuc);

            cbxCategory.ValueMember = "MaDanhMuc";
            cbxCategory.DisplayMember = "TenDanhMuc";
            cbxCategory.DataSource = danhMucService.GetDanhMucs();

            cbxCategorySearch.ValueMember = "MaDanhMuc";
            cbxCategorySearch.DisplayMember = "TenDanhMuc";
            cbxCategorySearch.DataSource = danhMucService.GetDanhMucs();
            dgvMenu.AutoGenerateColumns = false;
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                string id = dgvMenu.SelectedRows[0].Cells[0].Value.ToString();
                Mon m = monService.GetMonTheoDanhMuc(cbxCategory.SelectedValue.ToString()).Where(n => n.MaMon == id).FirstOrDefault();
                if (m == null)
                    return;
                txtDishName.Text = m.TenMon;
                txtUnit.Text = m.DVT;
                txtPrice.Text = m.DonGia.ToString();
                cbxCategory.Text = danhMucService.GetDanhMucs().Where(d => d.MaDanhMuc == m.MaDanhMuc).FirstOrDefault().TenDanhMuc;
            }
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
            {
                return;
            }
            row = dgvMenu.Rows[e.RowIndex];
            string id = row.Cells[0].Value.ToString();
            Mon m = monService.GetMonTheoDanhMuc(cbxCategory.SelectedValue.ToString()).Where(n => n.MaMon == id).FirstOrDefault();
            if (m == null)
                return;
            txtDishName.Text = m.TenMon;
            txtUnit.Text = m.DVT;
            txtPrice.Text = m.DonGia.ToString();
            cbxCategory.Text = danhMucService.GetDanhMucs().Where(c => c.MaDanhMuc == m.MaDanhMuc).FirstOrDefault().TenDanhMuc;
            
        }

        private void btnRemoved_Click(object sender, EventArgs e)
        { 

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                return;
                if (String.IsNullOrEmpty(txtDishName.Text) || String.IsNullOrEmpty(txtUnit.Text) || String.IsNullOrEmpty(txtPrice.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ dữ liệu!");
                }
                if (!float.TryParse(txtPrice.Text, out float b))
                {
                    throw new Exception("Giá nhập không hợp lệ!");
                }

                if (danhMucService.GetDanhMucs().Where(d => d.TenDanhMuc == cbxCategory.Text).FirstOrDefault() == null)
                {
                    throw new Exception("Danh mục chọn không hợp lệ!");
                }
                Mon mon = monService.GetMonTheoDanhMuc(cbxCategory.SelectedValue.ToString()).Where(m => m.TenMon ==txtDishName.Text).FirstOrDefault();
                if (mon == null)
                {
                    string mamon = monService.GetMonTheoDanhMuc(cbxCategory.SelectedValue.ToString()).Last().MaMon;
                    mon = new Mon();

                    mon.MaMon = string.Format(mamon.Substring(0, 1) + (int.Parse(mamon.Substring(2, 5)) + 1).ToString());
                    //mon.MaMon = "acbc";
                    mon.TenMon = txtDishName.Text;
                    monService.ThemMon(mon);
                }
                mon.DonGia = float.Parse(txtPrice.Text);
                mon.MaDanhMuc = cbxCategory.SelectedValue.ToString();
                mon.DVT = txtUnit.Text;
                mon.Hinh = txtDishName.Text+".png";
                monService.SaveChange();

                //dgvEmployee.DataSource = null;
                dgvMenu.DataSource = monService.GetMonTheoDanhMuc(cbxCategory.SelectedValue.ToString());
                dgvMenu.Refresh();
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
                dgvMenu.DataSource = monService.GetMonTheoDanhMuc(cbxCategorySearch.SelectedValue.ToString()).Where(n => (n.TenMon.ToLower().Contains(txtSearchByText.Text.ToLower())) || (n.MaMon == txtSearchByText.Text)).ToList();
                dgvMenu.Refresh();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                dgvMenu.DataSource = monService.GetMonTheoDanhMuc(cbxCategorySearch.SelectedValue.ToString()).Where(n => n.TenDanhMuc == cbxCategorySearch.Text).ToList();
                dgvMenu.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
