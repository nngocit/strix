using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabsManager.BLL;
using LabsManager.DTO;
using DevComponents.DotNetBar;

namespace LabsManager.UC
{
    public partial class ucMuonthietbi : UserControl
    {
        public ucMuonthietbi()
        {
            InitializeComponent();
        }
        string err;
        int ma;
        BLL_ThietBi _tbb;
        BLL_GiaoVien _gv;
        DTO_ThietBi _dttb;
        DTO_GiaoVien _dtogv;
        BLL_LoaiThietBi _ltb;
        private void ucMuonthietbi_Load(object sender, EventArgs e)
        {

            cbgiaovien.SelectedIndex = -1;
            _tbb = new BLL_ThietBi(cls_Main.duongdanfileketnoi);
            _gv = new BLL_GiaoVien(cls_Main.duongdanfileketnoi);
            lblmaid.Text = String.Format("Mã thiết bị {0}",  cls_Main._Luachon.ToString());
            ThongTin(cls_Main._Luachon);
            LoadDanhSachNhanvien(ref err, cbnhanvien);
            LoadDanhSachNhanvien(ref err, cbgiaovien);
            if (cls_Main._now_st == 2 || cls_Main._fix_st == 3)
            {
                ToastNotification.Show(this, "Tình trạng thiết bị đang không hoạt động hoặc đang sửa chữa, không thể mượn lúc này. Hệ thống sẽ yêu cung cầu thông tin để sửa chữa.", null, 1000, (eToastGlowColor)eToastGlowColor.Red, (eToastPosition)eToastPosition.BottomCenter);
                this.Cursor = Cursors.WaitCursor;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                circularProgress1.Visible = true;
                circularProgress1.IsRunning = true;
                cbgiaovien.Enabled = false;
                cblichgv.Enabled = false;
                cbnhanvien.Enabled = false;
                lblchuyentrang.Visible = true;
                _TChuyen.Enabled = true;
                txtlydomuon.Enabled = false;
            }
            if (cls_Main._rent_st == 3 )
            {
                ToastNotification.Show(this, "Thiết bị đang được mượn vui lòng quay trở lại sau, Hoặc chọn chức năng trã thiết bị", null, 2000, (eToastGlowColor)eToastGlowColor.Red, (eToastPosition)eToastPosition.BottomCenter);
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btntrathietbi.Enabled = true;
                cbgiaovien.Enabled = false;
                cblichgv.Enabled = false;
                cbnhanvien.Enabled = false;
                txtlydomuon.Enabled = false;
            }
           
        }


        public int GetMaxID()
        {
            return Convert.ToInt32(_tbb.ThietBiGetMax(ref err).Rows[0]["STT"]);
        }

        public void LoadDanhSachNhanvien(ref string err, ComboBox combo)
        {
            DataTable numberr;
            numberr = _gv.GiaoVienLoad(ref err);
            if (numberr.Rows.Count > 0)
            {
                combo.DataSource = numberr;
                combo.DisplayMember = "NAME_TEACHER";
                combo.ValueMember = "ID_TEACHER";
            }
        }
        public void LoadLichNhanvien(ref string err, ComboBox combo)
        {
            _dtogv = new DTO_GiaoVien()
            {
              ID_TEACHER=Convert.ToInt32(cbgiaovien.SelectedValue),
              ID_CLASS= cls_Main._PhongValue
	          
            };
            DataTable numberr;
            numberr = _gv.LichGiaoVien(ref err, _dtogv);
            if (numberr.Rows.Count > 0)
            {
                combo.DataSource = numberr;
                combo.DisplayMember = "ThongTin";
                combo.ValueMember = "STT";
            }
            else
            {
                combo.SelectedIndex = -1;
                combo.DataSource = numberr;

            }
        }
        public void ThongTin(int ma)
        {
            DataTable numberr;
            numberr = _tbb.ThietBiSelectThongTinTBMuon(ref err, ma);
            if (numberr.Rows.Count > 0)
            {
                try
                {
                    cls_Main._Id_inf_mac = Convert.ToInt32(numberr.Rows[0]["ID_INF_MAC"]);
                    cls_Main._names_inf = numberr.Rows[0]["NAMES_INF"].ToString();
                    cls_Main._nameclass = numberr.Rows[0]["NAMES"].ToString();
                    cls_Main._name_inf_mac = numberr.Rows[0]["NAMES_INF_MAC"].ToString();
                    cls_Main._now_st = Convert.ToInt32(numberr.Rows[0]["NOW_STATUS"]);
                    cls_Main._fix_st = Convert.ToInt32(numberr.Rows[0]["FIX_STATUS"]);
                    cls_Main._rent_st = Convert.ToInt32(numberr.Rows[0]["RENT_STATUS"]);
                }
                catch 
                {      
                }
             
            }
            txttenthietbi.Text = cls_Main._name_inf_mac.ToString();
            txtloaithietbi.Text = cls_Main._names_inf.ToString();
            txtlop.Text = cls_Main._nameclass.ToString();
            switch (cls_Main._now_st)
            {
                case 1: txttinhtranghientai.Text = "Hoạt động";
                    return;
                case 2: txttinhtranghientai.Text = "Không Hoạt động";
                    return;
                default:
                    break;
            }
             

        }
        int a = 5;
        private void _TChuyen_Tick(object sender, EventArgs e)
        {
            
         
            a -= 1;
            
            if (a == 0)
            {
                a = 5;
                this.Cursor = Cursors.Default;
                var ucBaoHThietBi = new ucBaoHThietBi();
                cls_Main.LoadUserControl3(cls_Controls.pncontrol, ucBaoHThietBi);


                _TChuyen.Stop();
                _TChuyen.Enabled = false;
            }
            else
            {
               
                lblchuyentrang.Text = string.Format("Đang chuyển trong vòng {0} giây", a);
               
            }
           
        }

        public void MuonThietBi()
        {
            DataTable numberr;
            _dttb = new DTO_ThietBi()
            {
                STT=GetMaxID()+1,
                ID_CALEN=Convert.ToInt32(cblichgv.SelectedValue),
	            ID_INF_MAC =cls_Main._Id_inf_mac,
	            ID_STATUS = 3, 
	            ID_TEACHER = Convert.ToInt32( cbnhanvien.SelectedValue),
	            DATE_TIME =DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
	            REASON_RENT =txtlydomuon.Text.Trim(),
                DATE_RENT = dtngaymuon.Value.ToString("yyyy-MM-dd HH:mm:ss")
            };

            numberr = _tbb.MuonThietBi(ref err, _dttb);
            if (numberr.Rows.Count > 0) {

                var thietbi = new ThietBi();
                
                cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, thietbi);
                thietbi.ThietBiSelectOld();
                 }
        }
        public int GetSTT(int _stt)
        {           
              return Convert.ToInt32(_tbb.GetSTT(ref err, _stt).Rows[0][0]); 
        }
        public void TraThietBi()
        {
            DataTable numberr;
            _dttb = new DTO_ThietBi()
            {
               
                STT=GetSTT(cls_Main._Id_inf_mac),
                DATE_RENT=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                ID_INF_MAC=cls_Main._Id_inf_mac
            };

            numberr = _tbb.TraThietBi(ref err, _dttb);
         

                var thietbi = new ThietBi();

                cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, thietbi);
                thietbi.ThietBiSelectOld();
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            MuonThietBi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtloaithietbi.Clear();
            txtlop.Clear();
            txtlydomuon.Clear();
            txttenthietbi.Clear();
            txttinhtranghientai.Clear();
            cbnhanvien.SelectedIndex = -1;
            lblmaid.Text = "{0}";
            cls_Main._Luachon=0;
        }

        private void cbgiaovien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbgiaovien.SelectedIndex >=0)
            {
                LoadLichNhanvien(ref err, cblichgv);
            }
        }

        private void btntrathietbi_Click(object sender, EventArgs e)
        {
           
                TraThietBi();
            
           
        }
     
    }
}
