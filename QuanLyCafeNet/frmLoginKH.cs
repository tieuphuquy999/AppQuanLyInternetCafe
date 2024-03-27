using QuanLyCafeNet.Data;
using QuanLyCafeNet.Service;
using QuanLyCafeNet.View_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafeNet
{
    public delegate void NhanOrder(DanhSachMon a);
    public delegate void TurnOn(May may,AccountKH acc);
    public delegate void TurnOff(May may);
    


    public partial class frmLoginKH : Form
    {
        public event NhanOrder nhanOrder;
        public event TurnOn turnOn;
        public event TurnOff turnOff;
        AccountKHService accountKHService;
        MayService mayService;
        DanhMucService danhMucService;
        MonService monService;
        System.Globalization.CultureInfo fVND = new System.Globalization.CultureInfo("vi-VN");
        private String formatVnd = "{0:#,##0d}";
        DanhSachMon danhSachMon;
        May may;
        AccountKH acc;
        double tongTien;
        Button monChon;
        DateTime gioBD;
        double STCL;

        public frmLoginKH()
        {
            InitializeComponent();
            accountKHService = new AccountKHService();
            mayService = new MayService();
            danhMucService = new DanhMucService();
            monService = new MonService();

            //IDMay = mayService.GetMays().FirstOrDefault().IDMay;
            //this.Controls.Remove(pnlCen);
            disableTXT();
            this.Controls.Remove(pnlOrder);
            this.Controls.Remove(grpConnect); 
        }

        private void disableTXT()
        {
            txtPGC.Enabled = false;
            txtTCL.Enabled = false;
            txtTGCL.Enabled = false;
            txtTGSD.Enabled = false;
            STCL = 0;
        }

        private void frmLoginKH_Load(object sender, EventArgs e)
        {
            cbxMaMay.DataSource = mayService.GetMays();
            cbxMaMay.ValueMember = "IDMay";
            cbxMaMay.DisplayMember = "TenMay";
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

                acc = accountKHService.GetAccountKHs().Where(a => a.USERR.Equals(user) && a.PASS.Equals(pass)).FirstOrDefault();
                if (acc == null)
                {
                    throw new Exception("Sai mật khẩu hoặc tên đăng nhập!");
                }
                if(acc.SoTien == 0)
                {
                    throw new Exception("Tài khoản hết tiền!");
                }

                may = mayService.GetMays().Where(m => m.IDMay == cbxMaMay.SelectedValue.ToString()).FirstOrDefault();

                if (this.turnOn != null)
                    turnOn(may,acc);

                gioBD = DateTime.Now;

                STCL = acc.SoTien;
                this.Controls.Remove(this.pnlCen);
                this.Controls.Add(grpConnect);
                danhSachMon = new DanhSachMon();
                danhSachMon.IDMay = may.IDMay;
                lblUSER.Text = acc.USERR;
                txtUser.Text = null;
                txtPass.Text = null;
                txtTCL.Text = String.Format(fVND, "{0:C0}", acc.SoTien);
                txtPGC.Text = String.Format(fVND, "{0:C0}", may.LoaiMay.PhiSuDung);
                txtTGSD.Text = "00:00";
                double GCL = acc.SoTien / may.LoaiMay.PhiSuDung;
                txtTGCL.Text = (int)GCL + ":" + GCL % 1 * 60;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.pnlOrder);
            initPnlOrder();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.pnlOrder);
            dgvDSOrder.DataSource = null;
            txtTongTien.Text = "";
            tongTien = 0;
        }
        ///

        private void initPnlOrder()
        {
            cbxDanhMuc.DataSource = danhMucService.GetDanhMucs();
            cbxDanhMuc.DisplayMember = "TenDanhMuc";
            cbxDanhMuc.ValueMember = "MaDanhMuc";
            LoadMonAn(cbxDanhMuc.SelectedValue.ToString());
        }
        private void cbxDanhMuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pnlMonAn.Controls.Clear();
            string maDanhMuc = cbxDanhMuc.SelectedValue.ToString();
            LoadMonAn(maDanhMuc);
        }

        private void LoadMonAn(string maDanhMuc)
        {
            int x = 26;
            int y = 29;
            int count = 0;
            foreach (var mon in monService.GetMonTheoDanhMuc(maDanhMuc))
            {
                TaoMon(x, y, mon);
                count++;
                if (count % 5 == 0)
                {
                    y += 110;
                    x = 26;
                    continue;
                }
                x += 110;
            }
        }
        private void TaoMon(int x, int y, Mon mon)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(100, 80);
            btn.Text = mon.TenMon + "\n" + String.Format(fVND, "{0:C0}", mon.DonGia);
            btn.TextAlign = ContentAlignment.BottomCenter;

            string duongDanHinh = "../../pic/sp/" + mon.Hinh;

            if (File.Exists(duongDanHinh))
                btn.Image = Image.FromFile(duongDanHinh);
            else
                btn.Image = Image.FromFile("../../pic/sp/default.jpg");

            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.Tag = mon;
            btn.BackColor = Color.White;
            btn.Click += Btn_Click;
            pnlMonAn.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (monChon == null)
            {
                monChon = sender as Button;
                monChon.BackColor = Color.Blue;
                btnAdd.Enabled = true;
            }
            else if (monChon == sender as Button)
            {
                monChon.BackColor = Color.White;
                monChon = null;
                btnAdd.Enabled = false;
                return;
            }
            else
            {
                monChon.BackColor = Color.White;
                monChon = sender as Button;
                monChon.BackColor = Color.Blue;
                btnAdd.Enabled = true;
            }
            nupSoLuong.Value = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(nupSoLuong.Value.ToString()) <= 0)
                {
                    throw new Exception("Chọn số lượng");
                }
                MonDat monDat = new MonDat();
                Mon mon = (Mon)monChon.Tag;
                monDat.maMon = mon.MaMon;
                monDat.tenMon = mon.TenMon;
                monDat.donGia = mon.DonGia;
                monDat.dvt = mon.DVT;
                monDat.soLuong = int.Parse(nupSoLuong.Value.ToString());
                //code them       //   
                if (danhSachMon == null)
                {
                    danhSachMon = new DanhSachMon();
                    danhSachMon.IDMay = may.IDMay;
                }
                danhSachMon.ThemMon(monDat);
                dgvDSOrder.DataSource = null;
                dgvDSOrder.DataSource = danhSachMon.GetDanhSachMonDat();
                dgvDSOrder.Refresh();
                tongTien = double.Parse(danhSachMon.GetDanhSachMonDat().Sum(m => m.thanhTien).ToString());
                txtTongTien.Text = String.Format(fVND, formatVnd, tongTien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bthXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSOrder.SelectedRows.Count > 0)
            {
                MonDat monDat = danhSachMon.GetDanhSachMonDat().Where(m => m.maMon == dgvDSOrder.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
                if(monDat == null)
                {
                    return;
                }
                danhSachMon.XoaMon(monDat);

                dgvDSOrder.DataSource = null;
                dgvDSOrder.DataSource = danhSachMon.GetDanhSachMonDat();
                dgvDSOrder.Refresh();
            }
        }

        private void btnGuiOrder_Click(object sender, EventArgs e)
        {
            if(this.nhanOrder!=null)
                nhanOrder(danhSachMon);
            danhSachMon = null;
            this.Controls.Remove(pnlOrder);

            dgvDSOrder.DataSource = null;
            dgvDSOrder.Refresh();
        }

        private void cbxMaMay_SelectedValueChanged(object sender, EventArgs e)
        {
            lblTenMay.Text = cbxMaMay.Text;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            this.Controls.Add(this.pnlCen);

            if (this.turnOff != null)
                turnOff(may);

            lblUSER.Text = null;
            txtPGC.Text = null;
            txtTCL.Text = null;
            txtTGCL.Text = null;
            txtTGSD.Text = null;

            this.Controls.Remove(grpConnect);
            acc.SoTien = STCL;
            accountKHService.SaveChange();
            
            may = null;
            acc = null;
        }

        private void brnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new frmDoiMatKhau(acc.USERR).Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (acc == null)
                return;
            int gio = DateTime.Now.Hour - gioBD.Hour;
            int phut = DateTime.Now.Minute - gioBD.Minute;
            txtTGSD.Text = gio + ":" + phut;
            double GCL = acc.SoTien / may.LoaiMay.PhiSuDung;
            if (gio >= (int)GCL && phut >= GCL % 1 * 60)
            {
                this.Controls.Add(this.pnlCen);

                if (this.turnOff != null)
                    turnOff(may);

                lblUSER.Text = null;
                txtPGC.Text = null;
                txtTCL.Text = null;
                txtTGCL.Text = null;
                txtTGSD.Text = null;

                this.Controls.Remove(grpConnect);
                may = null;
                acc = null;

                MessageBox.Show("Tài khoản hết tiền");

                acc.SoTien = 0;
                accountKHService.SaveChange();
            }
            STCL = acc.SoTien - (gio + (float)phut / 60) * may.LoaiMay.PhiSuDung;
            txtTGCL.Text = ((int)GCL-gio) + ":" + (int)(GCL%1*60-phut);
            txtTCL.Text = String.Format(fVND, "{0:C0}", STCL);
            //txtTCL.Text = (acc.SoTien - (gio + (float)phut / 60) * may.LoaiMay.PhiSuDung).ToString("0.##");
        }



    }
}
