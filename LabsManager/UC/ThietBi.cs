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
    public partial class ThietBi : UserControl
    {
        public ThietBi()
        {
            InitializeComponent();
            
            cls_Controls.pncontrol = pncontrol;
        }
        int SoThietBi = 0;
        string err;
        BLL_LoaiThietBi _db;
        DTO_ThietBi dt_thietbi;
        BLL_ThietBi _tbb;
    
        BLL_TruongHoc _th;
        public void LiningMachine(DataTable dt, Panel contain)
        {
            int ButtPerLine = 8;
            int left = 30;
            int top = 10;
            int NumOfLine = 0;
            int i = 0;
            int j = 0;
            int count = 0;
            SoThietBi = dt.Rows.Count;
            count = 0;
            contain.Controls.Clear();
            NumOfLine = Convert.ToInt32(dt.Rows.Count / ButtPerLine);
            if (NumOfLine * ButtPerLine < dt.Rows.Count)
                NumOfLine = NumOfLine + 1;

            for (i = 1; i <= NumOfLine; i++)
            {
                for (j = 0; j <= ButtPerLine - 1; j++)
                {
                    count = count + 1;
                    if (count <= SoThietBi)
                    {
                        
                            ThietBiL(dt.Rows[count - 1]["NAMES_INF_MAC"].ToString(),
                         left + (128 + 5) * j, top, contain, count,
                         dt.Rows[count - 1]["IM_MACHINE"].ToString(), dt.Rows[count - 1]["NOW_STATUS1"].ToString(), Convert.ToInt32(dt.Rows[count - 1]["NOW_STATUS"]), Convert.ToInt32(dt.Rows[count - 1]["RENTT"].ToString()), Convert.ToInt32(dt.Rows[count - 1]["FIXX"].ToString()),Convert.ToInt32(dt.Rows[count - 1]["ID_INF_MAC"].ToString()),Convert.ToInt32(dt.Rows[count - 1]["ID_INF"].ToString()));
                        
                      
                    }
                }
                top = top+60;
            }
         
        }
    

        public void ThietBiL(string NameOfButt, int left, int top, Panel contain,int count,string mt,string tt,int st,int rent,int fix,int _lblid, int maloaitb)
        {
            ThietbiUC newButt = new ThietbiUC();

           var _with1 = newButt;
           _with1.Name = _lblid.ToString();
            if (_with1.Name == "cmd1"+_lblid)
            {
               
                _with1.ForeColor = Color.White;
              
            }
           
            _with1.lblten.Text = NameOfButt;

            if (st == 1)
            {
                _with1.lblsudung.Text = tt;
                _with1.lblmieuta.Text = mt;
                _with1.lblsudung.ForeColor = Color.Gray;
                _with1.lblMuonFix.Visible = false;
                _with1.lblmuontitle.Visible = false;
                if (rent == 3)
                {
                    _with1.lblMuonFix.Visible = true; _with1.lblmuontitle.Visible = true;
                    _with1.lblMuonFix.Text = "Đang mượn";
                    _with1.lblMuonFix.ForeColor = Color.Teal;
                };

            }
            else
            {

                _with1.lblsudung.Text = tt;
                _with1.lblmieuta.Text = mt;
                _with1.lblsudung.ForeColor = Color.PaleVioletRed;
                _with1.lblmuontitle.Visible = false;
                if (fix == 4)
                {
                    _with1.lblMuonFix.Visible = true;
                    _with1.lblMuonFix.Text = "Đang sửa";
                    _with1.lblMuonFix.ForeColor = Color.SpringGreen;
                }
            }



            if (maloaitb == 2)
            {
                _with1.picht.Image = null;
                _with1.picht.SizeMode = PictureBoxSizeMode.StretchImage;
                _with1.picht.Image = Properties.Resources._64_64_7a4c085c58d540d7bd9527af2e4964dd__1_;
              
            }
            else
            {
                _with1.picht.Image = null;
                _with1.picht.SizeMode = PictureBoxSizeMode.StretchImage;
                _with1.picht.Image = Properties.Resources._1448269194_SDKs_copy_Android;
                
            }
               _with1.lbl_id.Text = _lblid.ToString();
            _with1.Location = new Point(left, top);
          
            
            contain.Controls.Add(newButt);
            newButt.Click += new EventHandler(this.ButtonTang_Click);
            
        }
        public void Details()
        {
            mtlichsu.Checked = true;
            var thietbilichsu = new ucLoadDanhSachLichSu();
            cls_Main.LoadUserControl3(cls_Controls.pncontrol, thietbilichsu);


        }
        private void ButtonTang_Click(object sender, EventArgs e) 
        {
            ThietbiUC dynamicButton = (sender as ThietbiUC);
            cls_Main._Luachon = (Convert.ToInt32(dynamicButton.Name));
            Details();
        }

     

        public void load()
        {
            DataTable dt = new DataTable(null);

            dt = _db.ThietBiLoad(ref err, Convert.ToInt32(cboLoaitb.SelectedValue), Convert.ToInt32(cbphonghoc.SelectedValue));
            lblsoluong.Text = dt.Rows.Count.ToString(); 
            if (dt.Rows.Count > 0)
            {
              
                LiningMachine(dt, pnhienthi);
            }
        }
        public void LoadDanhSachPhong(ref string err, ComboBox combo)
        {
            DataTable numberr;
            numberr = _th.PhongHocLoad(ref err);
            if (numberr.Rows.Count > 0)
            {
                combo.DataSource = numberr;
                combo.DisplayMember = "NAMES";
                combo.ValueMember = "ID_CLASS";

            }
        }
        public  void LoadDanhSachThietBi(ref string err, ComboBox combo)
        {
            DataTable numberr;
            numberr = _db.ThietBiLoadCombo(ref err,Convert.ToInt32(cbphonghoc.SelectedValue));
            if (numberr.Rows.Count > 0)
            {
                combo.DataSource = numberr;
                combo.DisplayMember = "NAMES_INF";
                combo.ValueMember = "ID_INF";

            }
            else
            {
                cboLoaitb.SelectedIndex = -1;
                cboLoaitb.DataSource = numberr;
                
            }
        }

        public void ThietBiSelectOld()
        {
            DataTable dt = new DataTable();
            dt = _db.ThietBiLoad(ref err, cls_Main._LopValue, cls_Main._PhongValue);
            if (dt.Rows.Count > 0)
            {
                LiningMachine(dt, pnhienthi);
            }

        }

        private void ThietBi_Load(object sender, EventArgs e)
        {
            _tbb = new BLL_ThietBi(cls_Main.duongdanfileketnoi);
            _db = new BLL_LoaiThietBi(cls_Main.duongdanfileketnoi);
            _th = new BLL_TruongHoc(cls_Main.duongdanfileketnoi);
            
            cbphonghoc.SelectedIndex = -1;
            cboLoaitb.SelectedIndex = -1;
            load();
            LoadDanhSachPhong(ref err, cbphonghoc);
           
            var thietbilichsu = new ucLoadDanhSachLichSu();
            cls_Main.LoadUserControl3(cls_Controls.pncontrol, thietbilichsu);
         


        }

        private void cbphonghoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbphonghoc.SelectedIndex >=0)
            {
                cls_Main._PhongValue = Convert.ToInt32(cbphonghoc.SelectedValue);
                LoadDanhSachThietBi(ref err, cboLoaitb);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbphonghoc.SelectedIndex = -1;
            cboLoaitb.SelectedIndex = -1;
            cbphonghoc.SelectedIndex = -1;
            txtghichu.Clear();
            txttentb.Clear();
            btnLuu.Enabled = true;
        }
        public void ThemThietBi()
        {
            DataTable numberr;
            dt_thietbi = new DTO_ThietBi() {
                ID_INF= Convert.ToInt32(cboLoaitb.SelectedValue),
                NAMES_INF_MAC = txttentb.Text,
                DAY_INF_MAC = cbdatengaytb.Value.ToString("yyyy-MM-dd"),
                IM_MACHINE = txtghichu.Text
            };

            numberr = _db.ThietBiInsert(ref err, dt_thietbi);
           if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThemThietBi();
            DataTable dt = new DataTable(null);
            dt = _db.ThietBiLoad(ref err,Convert.ToInt32(cboLoaitb.SelectedValue), Convert.ToInt32(cbphonghoc.SelectedValue));
            lblsoluong.Text = dt.Rows.Count.ToString(); 
            if (dt.Rows.Count > 0)
            {
                LiningMachine(dt, pnhienthi);
            }
            else
            {
                lblsoluong.Text = "0";
            }
        }

        private void cboLoaitb_SelectionChangeCommitted(object sender, EventArgs e)
        {
       
            if (cboLoaitb.SelectedIndex >= 0)
            {
                cls_Main._LopValue = Convert.ToInt32(cboLoaitb.SelectedValue);
                DataTable dt = new DataTable(null);
                dt = _db.ThietBiLoad(ref err, Convert.ToInt32(cboLoaitb.SelectedValue), Convert.ToInt32(cbphonghoc.SelectedValue));
                lblsoluong.Text = dt.Rows.Count.ToString(); 
                if (dt.Rows.Count > 0)
                {

                    LiningMachine(dt, pnhienthi);
                }
                else
                {
                    pnhienthi.Controls.Clear();
                }
            }
        }

      

        private void rdmuonthietbi_CheckedChanged(object sender, EventArgs e)
        {
            if (cls_Main._Luachon == 0)
            {
                ToastNotification.Show(this, "Vui lòng chọn thiết bị cần mượn !", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
            }
            else
            {
                var ucMuonthietbi = new ucMuonthietbi();
                cls_Main.LoadUserControl3(cls_Controls.pncontrol, ucMuonthietbi);
            }
        }

        private void mthoatdongtb_CheckedChanged(object sender, EventArgs e)
        {
            if (cls_Main._Luachon == 0)
            {
               
                ToastNotification.Show(this, "Vui lòng chọn thiết bị !", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
            }
            else
            {
                var ucThietBiKhongHoatDong = new ucThietBiKhongHoatDong();
                cls_Main.LoadUserControl3(cls_Controls.pncontrol, ucThietBiKhongHoatDong);
            }
           
        }

        private void mtsuachua_CheckedChanged(object sender, EventArgs e)
        {
            if (cls_Main._Luachon == 0)
            {
                ToastNotification.Show(this, "Vui lòng chọn thiết bị !", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
            }
            else
            {
                var ucBaoHThietBi = new ucBaoHThietBi();
                cls_Main.LoadUserControl3(cls_Controls.pncontrol, ucBaoHThietBi);
            }
           
        }

        public void ThietBiDel()
        {
            DataTable dt2 = new DataTable();
            dt2 = _tbb.ThietBiDel(ref err, cls_Main._Luachon);
            if(dt2.Rows.Count >0)
            {
                ToastNotification.Show(this, "Xóa thành công thiết bị!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                DataTable dt = new DataTable(null);
                dt = _db.ThietBiLoad(ref err, Convert.ToInt32(cboLoaitb.SelectedValue), Convert.ToInt32(cbphonghoc.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    lblsoluong.Text = dt.Rows.Count.ToString();
                    LiningMachine(dt, pnhienthi);
                }
          
            }
            else
            {
                ToastNotification.Show(this, "Xóa không thành công thiết bị!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThietBiDel();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboLoaitb.SelectedIndex = -1;
            cbphonghoc.SelectedIndex = -1;
            txttentb.Clear();
            txtghichu.Clear();

        }

      

   
    }
}
