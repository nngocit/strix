using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabsManager.UC
{
    public partial class DanhMuc : UserControl
    {
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void lblloaithietbi_Click(object sender, EventArgs e)
        {
            var loaithietbi = new LoaiThietBi();
            cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, loaithietbi);
        }

        private void lblunitest_Click(object sender, EventArgs e)
        {
            var thietbi = new ThietBi();
            cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, thietbi);
        }

        private void lbldoanhthu_Click(object sender, EventArgs e)
        {
            var phongtruong = new ucPhong();
            cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, phongtruong);
        }

        private void lblgiaovien_Click(object sender, EventArgs e)
        {
            var ucGiaoVien = new ucGiaoVien();
            cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, ucGiaoVien);
        }

        private void lblnguoidung_Click(object sender, EventArgs e)
        {
            var ucUser = new ucUser();
            cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, ucUser);
        }

      
    }
}
