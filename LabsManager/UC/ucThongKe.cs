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
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
        }

        private void lbltkthietbi_Click(object sender, EventArgs e)
        {
            var ucTKDanhSachThietBi = new ucTKDanhSachThietBi();
            cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, ucTKDanhSachThietBi);
        }
    }
}
