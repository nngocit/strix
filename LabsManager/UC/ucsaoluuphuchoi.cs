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
    public partial class ucsaoluuphuchoi : UserControl
    {
        public ucsaoluuphuchoi()
        {
            InitializeComponent();
          
        }
        
        private void lblsaoluu_Click(object sender, EventArgs e)
        {
            var saoluu = new ucsaoluu();
            cls_Main.LoadUserControl(cls_Controls._pn_Hienthi, saoluu,2);
        }

        private void lblloaithietbi_Click(object sender, EventArgs e)
        {
            var phuchoi = new ucphuchoi();
            cls_Main.LoadUserControl(cls_Controls._pn_Hienthi, phuchoi, 2);
        }

      
    }
}
