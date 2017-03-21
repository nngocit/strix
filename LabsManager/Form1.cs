using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabsManager.UC;
namespace LabsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cls_Controls._pn_UControls = this.pnthongtinchucnang;
            cls_Controls._pn_Hienthi = this.pnMain;
            cls_Main.pnlMain = pnMain;
        }

        private void btntuychinh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblnguoidung.Text = cls_Main._username;
            
        }

        private void btndanhmuc_Click(object sender, EventArgs e)
        {
            var danhmuc = new DanhMuc();
            cls_Main.LoadUserControl(cls_Controls._pn_UControls, danhmuc, 7);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            var thongke = new ucThongKe();
            cls_Main.LoadUserControl(cls_Controls._pn_UControls, thongke, 7);
        }

        private void btnhethong_Click(object sender, EventArgs e)
        {
            var saoluuphuchoi = new ucsaoluuphuchoi();
            cls_Main.LoadUserControl(cls_Controls._pn_UControls, saoluuphuchoi, 7);
        }
    }
}
