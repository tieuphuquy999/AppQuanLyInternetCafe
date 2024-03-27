using QuanLyCafeNet.Data;
using QuanLyCafeNet.frmQuanLy;
using QuanLyCafeNet.Properties;
using QuanLyCafeNet.Service;
using QuanLyCafeNet.View_Model;
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
    public partial class frmMainOrder : Form
    {
        public static NhanVien staff;
        //public List<KeyValuePair<May, AccountKH>> data = new List<KeyValuePair<May, AccountKH>>();
        public List<KeyValuePair<String, String>> data = new List<KeyValuePair<String, String>>();
        public static May mayTuongTac;
        Button mayChon;
        float tongTien;
        MayService mayService;
        DanhMucService danhMucService;
        HoaDonService hoaDonService;
        MonService monService;
        KhachHangService khachHangService;
        ThongKeService thongKeService;
        AccountKHService accountKHService;
        AccountNVService accountNVService;
        List<DanhSachMon> orders;
        DanhSachMon danhSachMon;
        List<DanhSachMon> danhSachOrders;
        public void initData()
        {
            foreach(May may in new MayService().GetMays())
            {
                data.Add(new KeyValuePair<String, String>(may.IDMay, null));
            }
        }
        public frmMainOrder()
        {
            InitializeComponent();
            initService();
        }

        public void initService()
        {
            lblIDNV.Text = staff.IDNhanVien.ToString();
            lblTenNV.Text = staff.HoTen;
            mayService = new MayService();
            danhMucService = new DanhMucService();
            monService = new MonService();
            orders = new List<DanhSachMon>();
            danhSachOrders = new List<DanhSachMon>();
            khachHangService = new KhachHangService();
            hoaDonService = new HoaDonService();
            thongKeService = new ThongKeService();
            accountKHService = new AccountKHService();
            accountNVService = new AccountNVService();
            ThongKe tk = thongKeService.GetThongKes().Last();
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            if (tk.Nam < nam) {
                thongKeService.AddThongKe(new ThongKe(int.Parse(thang.ToString() + nam.ToString()), thang, nam, 0, 0));
            }
            else
            {
                if(tk.Nam == nam && tk.Thang < thang)
                {
                    thongKeService.AddThongKe(new ThongKe(int.Parse(thang.ToString() + nam.ToString()), thang, nam, 0, 0));
                }
            }
            if (accountNVService.GetAccountNVs().Where(a => a.IDNhanVien == staff.IDNhanVien).FirstOrDefault().IDLoaiACC == 2001)
            {
                menuStrip1.Enabled = false;
            }
        }


        private void frmMainOrder_Load(object sender, EventArgs e)
        {
            CaiDatMay();
            cbxDanhMuc.DataSource = danhMucService.GetDanhMucs();
            cbxDanhMuc.DisplayMember = "TenDanhMuc";
            cbxDanhMuc.ValueMember = "MaDanhMuc";
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = monService.GetMonTheoDanhMuc(cbxDanhMuc.SelectedValue.ToString());
            dgvMenu.Refresh();
        }

        public void CaiDatMay()
        {
            int count = 1, x = 22, y = 59, xv = 30, yv =50;
            foreach (May m in mayService.GetMays().Where(m=>m.IDLoaiMay == "m1001"))
            {
                TaoMayT(x, y, count, m);
                x += 70;
                if (count % 4 == 0)
                {
                    y += 65;
                    x = 22;
                }
                count++;
            }
            count = 1;
            foreach (May m in mayService.GetMays().Where(m => m.IDLoaiMay == "v1001"))
            {
                TaoMayV(xv, yv, count, m);
                xv += 70;
                if (count % 4 == 0)
                {
                    yv += 65;
                    xv = 30;
                }
                count++;
            }
        }
        //836, 263
        public void TaoMayT(int x, int y, int count, May m)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            pnlMayM.Controls.Add(btn);
            btn.BackColor = Color.White;
            btn.Text = "MáyM " + count++;
            btn.Tag = m.IDMay;
            btn.Height = 50;
            btn.Width = 50;
            btn.Location = new Point(x, y);
            btn.Image = Image.FromFile("../../pic/off.png");
            btn.Click += Btn_Click;
        }
        public void TaoMayV(int x, int y, int count, May m)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            pnlMayVip.Controls.Add(btn);
            btn.BackColor = Color.White;
            btn.Text = "MáyV " + count++;
            btn.Tag = m.IDMay;
            btn.Height = 50;
            btn.Width = 50;
            btn.Location = new Point(x, y);
            btn.Image = Image.FromFile("../../pic/off.png");
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (mayChon == null)
            {
                mayChon = sender as Button;
                mayChon.BackColor = Color.Blue;
            }
            else if (mayChon == sender as Button)
            {
                mayChon.BackColor = Color.White;
                mayChon = null;
                tongTien = 0;
                txtTongTien.Text = tongTien.ToString();
                txtTenMay.Text = "";

                txtIDKhach.Text = "";
                txtSoTien.Text = "";

                dgvOrder.DataSource = null;
                dgvOrder.Refresh();
                return;
            }
            else
            {
                mayChon.BackColor = Color.White;
                mayChon = sender as Button;
                mayChon.BackColor = Color.Blue;

                txtIDKhach.Text = "";
                txtSoTien.Text = "";

                dgvOrder.DataSource = null;
                dgvOrder.Refresh();
            }
            txtTenMay.Text = mayChon.Text;

            string user = data.Where(d => d.Key == mayChon.Tag.ToString()).FirstOrDefault().Value;
            AccountKH accountKH = accountKHService.GetAccountKHs().Where(a => a.USERR == user).FirstOrDefault();
            if (accountKH != null)
            {
                txtIDKhach.Text = accountKH.USERR;
                txtSoTien.Text = accountKH.SoTien.ToString();
            }

            danhSachMon = danhSachOrders.Where(d => d.IDMay == mayChon.Tag.ToString()).FirstOrDefault();
            if (danhSachMon == null)
                return;
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = danhSachMon.GetDanhSachMonDat();
            dgvOrder.Refresh();
            tongTien = float.Parse(danhSachMon.GetDanhSachMonDat().Sum(md => md.thanhTien).ToString());
            txtTongTien.Text = tongTien.ToString();

        }

        private void cbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            String madanhmuc = cbx.SelectedValue.ToString();
            nupSoLuong.Value = 1;
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = monService.GetMonTheoDanhMuc(madanhmuc);
            dgvMenu.Refresh();
        }
        
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(nupSoLuong.Value.ToString()) <= 0)
                {
                    throw new Exception("Chọn số lượng");
                }
                if (dgvMenu.SelectedRows.Count < 1)
                {
                    throw new Exception("Chọn món");
                }
                Mon mon = monService.GetMonTheoDanhMuc(cbxDanhMuc.SelectedValue.ToString()).Where(m => m.MaMon == dgvMenu.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                MonDat monDat = new MonDat(mon);
                monDat.soLuong = int.Parse(nupSoLuong.Value.ToString());
                if (danhSachMon == null)
                    danhSachMon = new DanhSachMon();
                danhSachMon.ThemMon(monDat);

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = danhSachMon.GetDanhSachMonDat();
                dgvOrder.Refresh();

                tongTien = float.Parse(danhSachMon.GetDanhSachMonDat().Sum(md => md.thanhTien).ToString());
                txtTongTien.Text = tongTien.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try 
            {
                if(danhSachMon == null)
                {
                    throw new Exception("Không tồn tại order!");
                }
                if(dgvOrder.SelectedRows.Count < 1)
                {
                    throw new Exception("Chọn món cần xóa!");
                }
                MonDat monDat = danhSachMon.GetDanhSachMonDat().Where(md=>md.maMon == dgvOrder.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                danhSachMon.XoaMon(monDat);

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = danhSachMon.GetDanhSachMonDat();
                dgvOrder.Refresh();

                tongTien = float.Parse(danhSachMon.GetDanhSachMonDat().Sum(md => md.thanhTien).ToString());
                txtTongTien.Text = tongTien.ToString();
                if (danhSachMon.GetDanhSachMonDat().Count == 0)
                {
                    danhSachMon = null;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int idHoadonNew()
        {

            return hoaDonService.GetHoaDons().Last().SoHD + 1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachMon == null)
                {
                    throw new Exception("Vui lòng đặt món!");
                }
                ThongKe thongKe = thongKeService.GetThongKes().Last();
 
                HoaDon hoaDon = new HoaDon();
                hoaDon.SoHD = idHoadonNew();
                hoaDon.TongTien = tongTien;
                hoaDon.NgayLap = DateTime.Now.Date;
                hoaDon.IDNhanVien = staff.IDNhanVien;
                hoaDon.IDVoucher = txtVoucher.Text;
                hoaDon.MaThongKe = thongKe.MaThongKe;
                CTHoaDon chiTietHoaDon;
                foreach (var item in danhSachMon.GetDanhSachMonDat())
                {
                    chiTietHoaDon = new CTHoaDon();
                    chiTietHoaDon.SoLuong = item.soLuong;
                    chiTietHoaDon.MaMon = item.maMon;
                    chiTietHoaDon.DVT = item.dvt;
                    hoaDon.CTHoaDons.Add(chiTietHoaDon);
                }
                hoaDonService.AddHoaDon(hoaDon);
                txtTongTien.Text = "";
                tongTien = 0;
                if (danhSachOrders.Contains(danhSachMon))
                {
                    danhSachOrders.Remove(danhSachMon);
                    Button button = this.pnlMayVip.Controls.OfType<Button>().Where(b => b.Tag.ToString() == danhSachMon.IDMay).FirstOrDefault();
                    if (button == null)
                        button = this.pnlMayM.Controls.OfType<Button>().Where(b => b.Tag.ToString() == danhSachMon.IDMay).FirstOrDefault();
                    waringOrder.SetError(button,"");
                }
                danhSachMon = null;
                dgvOrder.DataSource = null;
                dgvOrder.Refresh();
                tongTien = 0;
                txtTongTien.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mởMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginKH frmmp = new frmLoginKH();
            frmmp.nhanOrder += NhanOrder;
            frmmp.turnOn += TurnOn;
            frmmp.turnOff += TurnOff;
            frmmp.Show();
        }

        private void TurnOn(May may,AccountKH acc)
        {
            
            Button button = pnlMayM.Controls.OfType<Button>().Where(b => b.Tag.ToString() == may.IDMay).FirstOrDefault();
            if(button == null)
                button = pnlMayVip.Controls.OfType<Button>().Where(b => b.Tag.ToString() == may.IDMay).FirstOrDefault();
            //button.BackColor = Color.Red;
            button.Image = Image.FromFile("../../pic/on.png");
            KeyValuePair<String, String> ds = data.Where(d => d.Key == may.IDMay).FirstOrDefault();
            data.Remove(ds);
            data.Add(new KeyValuePair<String, String>(may.IDMay, acc.USERR));
        }

        
        private void TurnOff(May may)
        {
            Button button = pnlMayM.Controls.OfType<Button>().Where(b => b.Tag.ToString() == may.IDMay).FirstOrDefault();
            if (button == null)
                button = pnlMayVip.Controls.OfType<Button>().Where(b => b.Tag.ToString() == may.IDMay).FirstOrDefault();
            //button.BackColor = Color.White;
            button.Image = Image.FromFile("../../pic/off.png");
            KeyValuePair<String, String> ds = data.Where(d => d.Key == may.IDMay).FirstOrDefault();
            data.Remove(ds);
            data.Add(new KeyValuePair<String, String>(may.IDMay, null));

        }

        private void NhanOrder(DanhSachMon a)
        {
            if(danhSachOrders == null)
            {
                danhSachOrders = new List<DanhSachMon>();
            }
            DanhSachMon dsm = danhSachOrders.Where(d => d.IDMay == a.IDMay).FirstOrDefault();
            if(dsm == null)
            {
                danhSachOrders.Add(a);
            }
            else
            {
                foreach(var item in a.GetDanhSachMonDat())
                {
                    dsm.ThemMon(item);
                }
            }
            Button button = this.pnlMayVip.Controls.OfType<Button>().Where(b => b.Tag.ToString() == a.IDMay).FirstOrDefault();
            if(button == null)
                button = this.pnlMayM.Controls.OfType<Button>().Where(b => b.Tag.ToString() == a.IDMay).FirstOrDefault();
            waringOrder.SetError(button, "Có Order!");
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            new frmTaoTKKhach().Show();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            if(mayChon == null)
                new frmNapTien(null).Show();
            else
                new frmNapTien(data.Where(d=>d.Key==mayChon.Tag.ToString()).FirstOrDefault().Value).Show();
        }

        private void quảnLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQlyAccount().Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQlyNhanVien().Show();
        }

        private void quảnLýMónVàDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQlyMon().Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThongKe();
            new frmReport().Show();
        }

        public void CapNhatThongKe()
        {
            foreach(ThongKe thongKe in thongKeService.GetThongKes())
            {
                double tongThu = thongKe.HoaDons.Sum(h => h.TongTien);
                thongKe.TongThu = tongThu;
                double tongChi = thongKe.LuongTras.Sum(l => l.Luong) + thongKe.PhieuBaoTris.Sum(p => p.ChiPhi) + thongKe.DonHangs.Sum(d => d.TongTien);
                thongKe.TongChi = tongChi;
                thongKeService.SaveChange();
            }
        }
    }
}
