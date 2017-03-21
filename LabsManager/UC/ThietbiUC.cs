using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace LabsManager.UC
{
    public partial class ThietbiUC : UserControl
    {
        public ThietbiUC()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void ThietbiUC_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            ToastNotification.Show(this, "Xem chi tiết.", null, 2000, (eToastGlowColor)eToastGlowColor.Green, (eToastPosition)eToastPosition.BottomCenter);
        }

        private void ThietbiUC_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cls_Main._Luachon.ToString());
        }

       

       
    }
}