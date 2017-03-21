using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LabsManager.BLL;
using LabsManager.DTO;
using DevComponents.DotNetBar;
namespace LabsManager.UC
{
    public partial class ucThietBiKhongHoatDong : UserControl
    {

        DataTable numberr;
        BLL_ThietBi _tbb;
        DTO_ThietBi _dttb;
   
    
        string err;

        
        public ucThietBiKhongHoatDong()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                    DataTable numberr;
                    _dttb = new DTO_ThietBi()
                    {
                        ID_INF_MAC = cls_Main._Luachon
                    };
                if (cbtinhtrang.SelectedIndex==1)
                {
                    numberr = _tbb.ThietBiKhongHoatDong(ref err, _dttb,0);
                    if (numberr.Rows.Count > 0)
                    {
                        var thietbi = new ThietBi();
                        cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, thietbi);
                        thietbi.ThietBiSelectOld();
                    }
                }
                else
                {
                    numberr = _tbb.ThietBiKhongHoatDong(ref err, _dttb, 1);
                    if (numberr.Rows.Count > 0)
                    {
                        var thietbi = new ThietBi();
                        cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, thietbi);
                        thietbi.ThietBiSelectOld();
                    }
                }
          
        }
        public void KiemTra()
        {
            DataTable dtdangsua = new DataTable();
            _dttb = new DTO_ThietBi()
            {
                ID_INF_MAC = cls_Main._Luachon
            };
            numberr = _tbb.ThietBiDangMuon(ref err, _dttb);
            dtdangsua = _tbb.TinhTrangThietBi(ref err, _dttb);
            if (numberr.Rows.Count > 0)
            {
                if (numberr.Rows[0]["ErrCode"].ToString() == "1")
                {
                    
                    ToastNotification.Show(this, "Thiết bị phải được trã trước khi ghi nhận là không hoạt động!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.TopCenter);
                    cbtinhtrang.Enabled = false;
                    btnLuu.Enabled = false;
                    lblchuyentrang.Visible = true;
                    tchuyen.Enabled = true;
                    circularProgress1.Visible = true;
                    circularProgress1.IsRunning = true;
                    return;
                }
                else
                {
                    cbtinhtrang.Enabled = true;
                    btnLuu.Enabled = true;
                }
            }
            if (dtdangsua.Rows.Count > 0)
            {
                if (dtdangsua.Rows[0]["FIX_STATUS"].ToString() == "4")
                {
                    ToastNotification.Show(this, "Thiết bị này chưa được sửa chữa hoàn tất.!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.TopCenter);
                    cbtinhtrang.Enabled = false;
                    btnLuu.Enabled = false;
                    lblchuyentrang.Visible = true;
                    _timersuachua.Enabled = true;
                    circularProgress1.Visible = true;
                    circularProgress1.IsRunning = true;
                    return;
                }
            }
        }
        private void ucThietBiKhongHoatDong_Load(object sender, EventArgs e)
        {
            _tbb = new BLL_ThietBi(cls_Main.duongdanfileketnoi);
            KiemTra();
        }

        private void cblichgv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
        int a = 5;
        private void tchuyen_Tick(object sender, EventArgs e)
        {
            a -= 1;

            if (a == 0)
            {
                a = 5;
                this.Cursor = Cursors.Default;
                var ucMuonthietbi = new ucMuonthietbi();
                cls_Main.LoadUserControl3(cls_Controls.pncontrol, ucMuonthietbi);


                tchuyen.Stop();
                tchuyen.Enabled = false;
            }
            else
            {

                lblchuyentrang.Text = string.Format("Đang chuyển trong vòng {0} giây", a);

            }
        }

        private void _timersuachua_Tick(object sender, EventArgs e)
        {
            a -= 1;

            if (a == 0)
            {
                a = 5;
                this.Cursor = Cursors.Default;
                var ucBaoHThietBi = new ucBaoHThietBi();
                cls_Main.LoadUserControl3(cls_Controls.pncontrol, ucBaoHThietBi);


                _timersuachua.Stop();
                _timersuachua.Enabled = false;
            }
            else
            {

                lblchuyentrang.Text = string.Format("Đang chuyển trong vòng {0} giây", a);

            }
        }

     
    }
}
