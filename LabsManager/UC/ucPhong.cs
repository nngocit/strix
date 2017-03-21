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
using DevComponents.DotNetBar.SuperGrid;
namespace LabsManager.UC
{
    public partial class ucPhong : UserControl
    {
        public ucPhong()
        {
            InitializeComponent();
            cls_Controls.Init(this.groupPanel1);
            cls_Controls.Init(this.groupPanel2);
            cls_Controls.Init(this.pnloaitb);
        }
        object context = null;
        string err = "";
        bool alowDraw = false;
        bool alowDrawgb = false;
        bool alowDrawgc = false;

        BLL_KetNoi db1 = new BLL_KetNoi(cls_Main.duongdanfileketnoi);
        DTO_TruongHoc dtoTruongHoc;
        DTO_PhongHoc dtoPhongHoc;
        BLL_ThietBi _tb;
        BLL_LoaiThietBi _db;
        BLL_TruongHoc _th;
       

        private void groupPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            alowDraw = true;
        }

        private void groupPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (alowDraw)
                {
                    this.Cursor = Cursors.SizeAll;
                    ToastNotification.Show(this, "Đang duy chuyển ...", null, 5000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomRight);
                }

            }
        }

        private void groupPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            alowDraw = false;
            this.Cursor = Cursors.Default;
        }

        private void groupPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            alowDrawgb = true;
        }

        private void groupPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (alowDrawgb)
                {
                    this.Cursor = Cursors.SizeAll;
                    ToastNotification.Show(this, "Đang duy chuyển ...", null, 5000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomRight);
                }

            }
        }

        private void groupPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            alowDrawgb = false;
            this.Cursor = Cursors.Default;
        }

        private void pnloaitb_MouseDown(object sender, MouseEventArgs e)
        {
            alowDrawgc = true;
        }

        private void pnloaitb_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (alowDrawgc)
                {
                    this.Cursor = Cursors.SizeAll;
                    ToastNotification.Show(this, "Đang duy chuyển ...", null, 5000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomRight);
                }

            }
        }

        private void pnloaitb_MouseUp(object sender, MouseEventArgs e)
        {
            alowDrawgc = false;
            this.Cursor = Cursors.Default;
        }

      
        public void DanhSachPhongLoad()
        {
            DataTable dt = new DataTable(null);

            dt = _th.LopHocLoadAll(ref err);
            superGridControl2.PrimaryGrid.Rows.Clear();
            lblsoll.Text = dt.Rows.Count.ToString();
            if (dt.Rows.Count > 0)
            {
                superGridControl2.PrimaryGrid.DataSource = dt;

            }
            context = ((DataTable)dt).DefaultView;
            try
            {
                txttenphong.DataBindings.Add(new Binding("Text", context, "NAMES"));
               

                // combongaythang.DataBindings.Add(new Binding("Text", context, "DAY_INF"));
                lblidphong.DataBindings.Add(new Binding("Text", context, "ID_CLASS"));
            }
            catch (Exception e)
            {
                //timer1.Start();
                //ToastNotification.Show(this, "Đang tải danh sách", null, 5000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomRight);
                var phongtruong = new ucPhong();
                cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, phongtruong);

            }
        }
        private void superGridControl1_CellClick(object sender, GridCellClickEventArgs e)
        {
            txttentruong.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            btnLuuL.Enabled = true;
            btnXoaP.Enabled = true;
        }
        public void DanhSachTruongLoadAll()
        {
            DataTable dt = new DataTable(null);

            dt = _th.TruongHocLoadAll(ref err);
            superGridControl1.PrimaryGrid.Rows.Clear();
            lblsoluong.Text = dt.Rows.Count.ToString();
            if (dt.Rows.Count > 0)
            {
                superGridControl1.PrimaryGrid.DataSource = dt;

            }
            context = ((DataTable)dt).DefaultView;
            try
            {
                txttentruong.DataBindings.Add(new Binding("Text", context, "NAME"));
                txtdiachi.DataBindings.Add(new Binding("Text", context, "ADDRESSs"));
                txtsdt.DataBindings.Add(new Binding("Text", context, "PHONES"));
                // combongaythang.DataBindings.Add(new Binding("Text", context, "DAY_INF"));
                lblidtruong.DataBindings.Add(new Binding("Text", context, "SCHOOL"));
            }
            catch (Exception e)
            {
                //timer1.Start();
                //ToastNotification.Show(this, "Đang tải danh sách", null, 5000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomRight);
                var phong = new ucPhong();
                cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, phong);

            }
        }

        public void ThemPhong()
        {
            if( txttentruong.Text =="" && txtdiachi.Text=="" && txtsdt.Text=="")
            {
                ToastNotification.Show(this, "Vui lòng điền đủ thông tin!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;
            dtoPhongHoc = new DTO_PhongHoc()
            { 
                SCHOOL = Convert.ToInt32(cbTruongHoc.SelectedValue),
               NAMES = txttenphong.Text.Trim()
                  
            };

            numberr = _th.PhongHocInsert(ref err, dtoPhongHoc);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }


        public void ThemTruong()
        {
            if (txttenphong.Text == "")
            {
                ToastNotification.Show(this, "Vui lòng điền đủ thông tin!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;
            dtoTruongHoc = new DTO_TruongHoc()
            {
               
                NAME = txttentruong.Text,
                ADDRESS = txtdiachi.Text,
                PHONE = txtsdt.Text
            };

            numberr = _th.TruongHocInsert(ref err, dtoTruongHoc);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        public void XoaTruong()
        {
           
            DataTable numberr;
            dtoTruongHoc = new DTO_TruongHoc()
            {

                ID = Convert.ToInt32(lblidtruong.Text)
            };

            numberr = _th.TruongHocXoa(ref err, dtoTruongHoc);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        public void CapNhatTruong()
        {
            if (txttenphong.Text == "")
            {
                ToastNotification.Show(this, "Vui lòng điền đủ thông tin!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;
            dtoTruongHoc = new DTO_TruongHoc()
            {
                ID = Convert.ToInt32(lblidtruong.Text),
                NAME = txttentruong.Text,
                ADDRESS = txtdiachi.Text,
                PHONE = txtsdt.Text
            };

            numberr = _th.TruongHocUpdate(ref err, dtoTruongHoc);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
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
        public void LoadDanhSachTruong(ref string err, ComboBox combo)
        {
            DataTable numberr;
            numberr = _th.TruongHocLoad(ref err);
            if (numberr.Rows.Count > 0)
            {
                combo.DataSource = numberr;
                combo.DisplayMember = "NAME";
                combo.ValueMember = "SCHOOL";
            }
        }
        private void ucPhong_Load(object sender, EventArgs e)
        {
          //  timer1.Start();
            _db = new BLL_LoaiThietBi(cls_Main.duongdanfileketnoi);
            _th = new BLL_TruongHoc(cls_Main.duongdanfileketnoi);
            _tb = new BLL_ThietBi(cls_Main.duongdanfileketnoi);
            LoadDanhSachTruong(ref  err, cbTruongHoc);
          
            DanhSachPhongLoad();
            DanhSachTruongLoadAll();
        }
        public void CapNhatPhong()
        {
            if (txttenphong.Text == "")
            {
                ToastNotification.Show(this, "Vui lòng điền đủ thông tin!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;
            dtoPhongHoc = new DTO_PhongHoc()
            {
                ID_CLASS=Convert.ToInt32(lblidphong.Text),
                SCHOOL = Convert.ToInt32(cbTruongHoc.SelectedValue),
                NAMES = txttenphong.Text.Trim()
                

            };

            numberr = _th.PhongHocCapNhat(ref err, dtoPhongHoc);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }


        public void XoaPhong()
        {
          

            DataTable numberr;
            dtoPhongHoc = new DTO_PhongHoc()
            {
                ID_CLASS = Convert.ToInt32(lblidphong.Text),
             


            };

            numberr = _th.PhongHocXoa(ref err, dtoPhongHoc);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lblidphong.Text == "0")
            {
                ThemPhong();
            }
            else
            {
                CapNhatPhong();
            }
            DanhSachPhongLoad();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            lblidphong.Text = "0";
            txttenphong.Enabled = true;
            txttenphong.Clear();
            txttenphong.Focus();
            btnLuu.Enabled = true;
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
          lblidtruong.Text="0";
            
            txttentruong.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            btnThemP.Enabled = false;
            btnXoaP.Enabled = false;
            btnLuuL.Enabled = true;
            btnHuyP.Enabled = true;
            txttentruong.Clear();
            txttentruong.Focus();
            txtdiachi.Clear();
            txtsdt.Clear();
        }

        private void btnLuuL_Click(object sender, EventArgs e)
        {
            btnThemP.Enabled = true;
            btnLuuL.Enabled = false;
            btnXoaP.Enabled = false;
            btnHuyP.Enabled = false;
            if (lblidtruong.Text == "0")
            {
                ThemTruong();
            }
            else
            {
                CapNhatTruong();
            }
            DanhSachTruongLoadAll();
        }

        private void btnHuyP_Click(object sender, EventArgs e)
        {
            txttentruong.Clear();
            txttentruong.Focus();
            txtdiachi.Clear();
            txtsdt.Clear();
            lblidtruong.Text = "0";

        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            XoaTruong();
            btnHuyP.Enabled = false;
            DanhSachTruongLoadAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaPhong();
            DanhSachPhongLoad();
        }

        private void superGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void superGridControl2_CellClick(object sender, GridCellClickEventArgs e)
        {
            txttenphong.Enabled = true;
         
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txttenphong.Clear();
            txttenphong.Focus();
            lblidphong.Text = "0";
            txtsdt.Clear();
        }

      
      
    }
}

