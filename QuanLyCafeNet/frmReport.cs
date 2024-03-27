using Microsoft.Reporting.WinForms;
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
    public partial class frmReport : Form
    {
        ThongKeService thongKeService;
        public frmReport()
        {
            InitializeComponent();
            thongKeService = new ThongKeService();
            ReportDataSource reportDataSource = new ReportDataSource();
            DataSetThongKe dataSetThongKe = new DataSetThongKe();
            foreach(ThongKe tk in thongKeService.GetThongKes())
            {
                DataRow dr = dataSetThongKe.DataTableThongKe.NewRow();
                dr["MaThongKe"] = tk.MaThongKe;
                dr["Thang"] = tk.Thang;
                dr["Nam"] = tk.Nam;
                dr["TongChi"] = tk.TongChi;
                dr["TongThu"] = tk.TongThu;
                dataSetThongKe.DataTableThongKe.Rows.Add(dr);
            }
            reportDataSource.Name = "DataSetThongKe";
            reportDataSource.Value = dataSetThongKe.DataTableThongKe;

            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = "..//..//ReportThongKe.rdlc";
            reportViewer1.RefreshReport();

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
