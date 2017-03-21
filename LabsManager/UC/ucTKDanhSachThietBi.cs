using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LabsManager.BLL;
namespace LabsManager.UC
{
    public partial class ucTKDanhSachThietBi : UserControl
    {
        public ucTKDanhSachThietBi()
        {
            InitializeComponent();
        }
        BLL_ThietBi _tb;
        string err;
        private void ucTKDanhSachThietBi_Load(object sender, EventArgs e)
        {
            _tb = new BLL_ThietBi(cls_Main.duongdanfileketnoi);
        }
        public void ThongKeCty()
        {
            var dt = new DataTable();
            dt = _tb.TKThietBiCacLop(ref err);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "LabsManager.ReP.repDanhSachTinhTrangCacLop.rdlc";

            //List<ReportParameter> parameters = new List<ReportParameter>();
            //ReportParameter TienSo = new ReportParameter();
            //TienSo = new ReportParameter("TienSo", mdMainPhieuNhapN._TienSo);
            //parameters.Add(TienSo);
            //ReportParameter Chu = new ReportParameter();
            //Chu = new ReportParameter("TienChu", mdMainPhieuNhapN._TienThanhChu);
            //parameters.Add(Chu);
            //reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            var newdata = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(newdata);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeCty();
        }
    }
}
