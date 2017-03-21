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
    public partial class ucGiaoVien : UserControl
    {
        public ucGiaoVien()
        {
            InitializeComponent();
            BLL_KetNoi db1 = new BLL_KetNoi(cls_Main.duongdanfileketnoi);
        }
        DTO_GiaoVien dtoGiaoVien;
        BLL_TruongHoc _th;
        string err;
        public void ThemGiaoVien()
        {
            if (txtgiaovien.Text == "")
            {
                ToastNotification.Show(this, "Vui lòng điền đủ thông tin!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;
            dtoGiaoVien = new DTO_GiaoVien()
            {
                NAME_TEACHER = txtgiaovien.Text.Trim()

            };

            numberr = _gv.GiaoVienThem(ref err, dtoGiaoVien);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            lblmagv.Text = "0";
            txtgiaovien.Clear();
            txtgiaovien.Enabled = true;
            btnLuuL.Enabled = true;
        }
        BLL_GiaoVien _gv;
        private void ucGiaoVien_Load(object sender, EventArgs e)
        {
            _gv = new BLL_GiaoVien(cls_Main.duongdanfileketnoi);
            _th = new BLL_TruongHoc(cls_Main.duongdanfileketnoi);
            LoadDanhSachNhanvien(ref err, cbGiaoVien);
            DanhSachGiaoVien();
            LoadDanhSachTruong(ref err, cbtruonghoc);
            DanhSachLichGiaoVien();
        }
        public void DanhSachGiaoVien()
        {
            DataTable dt = new DataTable(null);

            dt = _gv.GiaoVienLoad(ref err);
            lblsoluong.Text = dt.Rows.Count.ToString();
           if (dt.Rows.Count > 0)
                {
                    dgvgiaovien.DataSource = dt;
                }
                else
                {
                    dt.Rows.Clear();
                    dgvgiaovien.DataSource = dt;
                }
          
        }
        public void DanhSachLichGiaoVien()
        {
            DataTable dt = new DataTable(null);

            dt = _gv.GiaoVienCalenLoad(ref err);
            lblsoll.Text = dt.Rows.Count.ToString();
            if (dt.Rows.Count > 0)
            {
                dgvlichgv.DataSource = dt;
            }
            else
            {
                dt.Rows.Clear();
                dgvlichgv.DataSource = dt;
            }

        }
        public void CapNhatGiaoVien()
        {
            DataTable numberr;
            dtoGiaoVien = new DTO_GiaoVien()
            {
                NAME_TEACHER = txtgiaovien.Text.Trim(),
                ID_TEACHER=Convert.ToInt32(lblmagv.Text)
            };

            numberr = _gv.GiaoVienCapNhat(ref err, dtoGiaoVien);
            if (numberr.Rows.Count > 0) {
                lblmagv.Text = "0";
                txtgiaovien.Clear();
                txtgiaovien.Focus();
                ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
            }
        }

        public void XoaGiaoVien()
        {
            DataTable numberr;
            dtoGiaoVien = new DTO_GiaoVien()
            {
               
                ID_TEACHER = Convert.ToInt32(lblmagv.Text)
            };

            numberr = _gv.GiaoVienXoa(ref err, dtoGiaoVien);
            if (numberr.Rows.Count > 0) {
                lblmagv.Text = "0";
                txtgiaovien.Clear();
                txtgiaovien.Focus();
                ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        private void btnLuuL_Click(object sender, EventArgs e)
        {
            
            if(lblmagv.Text=="0")
            {
                ThemGiaoVien();
            }
            else
            {
                CapNhatGiaoVien();
            }
           
            DanhSachGiaoVien();
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

        public void LoadDanhSachPhong(ref string err, ComboBox combo, int th)
        {
            DataTable numberr;
            numberr = _th.PhongHocSelect(ref err, th);
            if (numberr.Rows.Count > 0)
            {
                combo.DataSource = numberr;
                combo.DisplayMember = "NAMES";
                combo.ValueMember = "ID_CLASS";
            }
        }
        private void dgvgiaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtgiaovien.Enabled = true;
            btnLuuL.Enabled = true;
            btnXoaP.Enabled = true;
            cls_Main.Viewdatalabel(dgvgiaovien, lblmagv, 1);
            cls_Main.Viewdata(dgvgiaovien, txtgiaovien, 2);
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            XoaGiaoVien();
            DanhSachGiaoVien();
        }

        private void btnHuyP_Click(object sender, EventArgs e)
        {
            lblmagv.Text = "0";
            txtgiaovien.Clear();
            txtgiaovien.Focus();
        }

        private void cbtruonghoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbtruonghoc.SelectedIndex >= 0)
            {
                LoadDanhSachPhong(ref err, cbPhongHoc, Convert.ToInt32(cbtruonghoc.SelectedValue));
            }
        }



        public void CalenGiaoVienThem()
        {
            if (txtghichu.Text == "")
            {
                ToastNotification.Show(this, "Vui lòng điền đủ thông tin!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;
            dtoGiaoVien = new DTO_GiaoVien()
            {
               ID_TEACHER=Convert.ToInt32(cbGiaoVien.SelectedValue),
               ID_CLASS=Convert.ToInt32(cbPhongHoc.SelectedValue),
               _Date = dtngaysua.Value.ToString("yyyy-MM-dd"),
               IM=txtghichu.Text

            };

            numberr = _gv.GiaoVienCalenThem(ref err, dtoGiaoVien);
            if (numberr.Rows.Count > 0) {
                cbGiaoVien.SelectedIndex = -1;
                cbPhongHoc.SelectedIndex = -1;
                cbtruonghoc.SelectedIndex = -1;
                txtghichu.Clear();
                ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        public void CalenGiaoVienCapNhat(int STT)
        {
           

            DataTable numberr;
            dtoGiaoVien = new DTO_GiaoVien()
            {
                ID_TEACHER = _id,
                ID_CLASS = _class,
                _Date = dtngaysua.Value.ToString("yyyy-MM-dd"),
                IM = txtghichu.Text

            };

            numberr = _gv.GiaoVienCalenCapNhat(ref err, dtoGiaoVien,STT);
            if (numberr.Rows.Count > 0) {
                cbGiaoVien.SelectedIndex = -1;
                cbPhongHoc.SelectedIndex = -1;
                cbtruonghoc.SelectedIndex = -1;
                txtghichu.Clear();
                ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        public void CalenGiaoVienXoa(int ma)
        {
          
            DataTable numberr;
           

            numberr = _gv.GiaoVienCalenXoa(ref err, ma);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
            else
            {
                ToastNotification.Show(this, "Lịch của giáo viên đang sử dụng, không thể xóa", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); 
            }
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
        
        private void btnLuuLich_Click(object sender, EventArgs e)
        {
            if(llbmastt.Text=="0")
            {
                CalenGiaoVienThem();
                buttonX4.Enabled = true;
                btnLuuL.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                CalenGiaoVienCapNhat(Convert.ToInt32(llbmastt.Text));
            }
          
            DanhSachLichGiaoVien();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            llbmastt.Text = "0";
            txtghichu.Enabled = true;
            btnLuuLich.Enabled = true;   btnHuy.Enabled = true;
            buttonX4.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            CalenGiaoVienXoa(Convert.ToInt32(llbmastt.Text));
            DanhSachLichGiaoVien();
        }
        int _class;
        int _id;
        private void dgvlichgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnLuuLich.Enabled = true;
            txtghichu.Enabled = true;
            llbmastt.Text = dgvlichgv.Rows[dgvlichgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
             _class=Convert.ToInt32(  dgvlichgv.Rows[dgvlichgv.CurrentCell.RowIndex].Cells[6].Value);
             _id = Convert.ToInt32(dgvlichgv.Rows[dgvlichgv.CurrentCell.RowIndex].Cells[5].Value);
             txtghichu.Text = dgvlichgv.Rows[dgvlichgv.CurrentCell.RowIndex].Cells[4].Value.ToString();
             cbGiaoVien.Text = dgvlichgv.Rows[dgvlichgv.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbGiaoVien.SelectedIndex = -1;
            cbPhongHoc.SelectedIndex = -1;
            cbtruonghoc.SelectedIndex = -1;
            txtghichu.Clear();

        }

      

     
    }
}
