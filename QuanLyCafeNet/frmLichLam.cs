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
    public partial class frmLichLam : Form
    {
        NhanVienService nhanVienService;
        LichLamService lichLamService;
        CaLamService caLamService;
        NhanVien nhanVien;
        public frmLichLam(string cmnd)
        {
            InitializeComponent();
            nhanVienService = new NhanVienService();
            lichLamService = new LichLamService();
            caLamService = new CaLamService();
            nhanVien = nhanVienService.GetNhanViens().Where(nv => nv.CMND == cmnd).FirstOrDefault();
            txtName.Text = nhanVien.HoTen;
            
        }
        private void frmLichLam_Load(object sender, EventArgs e)
        {
            //dgvLich.DataSource = null;
            dgvLich.DataSource = lichLamService.GetLichLams().Where(l => l.IDNhanVien == nhanVien.IDNhanVien).ToList();
            dgvLich.Refresh();

            cbxThu.SelectedIndex = 0;

        }


        

        private void cbxThu_TextChanged(object sender, EventArgs e)
        {
            List<LichLam> lichLamList = lichLamService.GetLichLams().Where(l => l.IDNhanVien == nhanVien.IDNhanVien).ToList();
            List<CaLam> caLams = caLamService.GetCaLams().Where(c => c.Thu == cbxThu.SelectedIndex + 2).ToList();
            if (lichLamList == null)
                return;
            rdbCa1.Checked = false;
            rdbCa2.Checked = false;
            rdbCa3.Checked = false;
            foreach (LichLam lichLam in lichLamList)
            {
                foreach(CaLam caLam in caLams)
                {
                    if (lichLam.MaCa == caLam.MaCa)
                    {
                        if(lichLam.ca == 1)
                        {
                            rdbCa1.Checked = true;
                        }
                        if (lichLam.ca == 2)
                        {
                            rdbCa2.Checked = true;
                        }
                        if (lichLam.ca == 3)
                        {
                            rdbCa3.Checked = true;
                        }
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                List<LichLam> lichLamList = lichLamService.GetLichLams().Where(l => l.IDNhanVien == nhanVien.IDNhanVien).ToList();
                if (rdbCa1.Checked == true)
                {
                    int maca = caLamService.GetCaLams().Where(c => c.Ca == 1 && c.Thu == cbxThu.SelectedIndex + 2).FirstOrDefault().MaCa;
                    if (lichLamList.Where(l => l.MaCa == maca).FirstOrDefault() == null)
                    {
                        LichLam lichLam = new LichLam();
                        lichLam.MaCa = maca;
                        lichLam.IDNhanVien = nhanVien.IDNhanVien;
                        lichLamService.ThemLichLam(lichLam);
                    }
                }
                else
                {
                    int maca = caLamService.GetCaLams().Where(c => c.Ca == 1 && c.Thu == cbxThu.SelectedIndex + 2).FirstOrDefault().MaCa;
                    LichLam lichLam = lichLamList.Where(l => l.MaCa == maca).FirstOrDefault();
                    if (lichLam != null)
                    {
                        lichLamService.XoaLichLam(lichLam);
                    }
                }
                if (rdbCa2.Checked == true)
                {
                    int maca = caLamService.GetCaLams().Where(c => c.Ca == 2 && c.Thu == cbxThu.SelectedIndex + 2).FirstOrDefault().MaCa;
                    if (lichLamList.Where(l => l.MaCa == maca).FirstOrDefault() == null)
                    {
                        LichLam lichLam = new LichLam();
                        lichLam.MaCa = maca;
                        lichLam.IDNhanVien = nhanVien.IDNhanVien;
                        lichLamService.ThemLichLam(lichLam);
                    }
                }
                else
                {
                    int maca = caLamService.GetCaLams().Where(c => c.Ca == 2 && c.Thu == cbxThu.SelectedIndex + 2).FirstOrDefault().MaCa;
                    LichLam lichLam = lichLamList.Where(l => l.MaCa == maca).FirstOrDefault();
                    if (lichLam != null)
                    {
                        lichLamService.XoaLichLam(lichLam);
                    }
                }
                if (rdbCa3.Checked == true)
                {
                    int maca = caLamService.GetCaLams().Where(c => c.Ca == 3 && c.Thu == cbxThu.SelectedIndex + 2).FirstOrDefault().MaCa;
                    if (lichLamList.Where(l => l.MaCa == maca).FirstOrDefault() == null)
                    {
                        LichLam lichLam = new LichLam();
                        lichLam.MaCa = maca;
                        lichLam.IDNhanVien = nhanVien.IDNhanVien;
                        lichLamService.ThemLichLam(lichLam);
                    }
                }
                else
                {
                    int maca = caLamService.GetCaLams().Where(c => c.Ca == 3 && c.Thu == cbxThu.SelectedIndex + 2).FirstOrDefault().MaCa;
                    LichLam lichLam = lichLamList.Where(l => l.MaCa == maca).FirstOrDefault();
                    if (lichLam != null)
                    {
                        lichLamService.XoaLichLam(lichLam);
                    }
                }
                dgvLich.DataSource = lichLamService.GetLichLams().Where(l => l.IDNhanVien == nhanVien.IDNhanVien).ToList();
                dgvLich.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
