using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabsManager.BLL;
using LabsManager.DTO;
using DevComponents.DotNetBar;

namespace LabsManager.UC
{
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }
        BLL_User _db;
        string err = "";
        object context = null;
        DTO_User dtuer = new DTO_User();
        public void DanhSachUserLoad()
        {
            DataTable dt = new DataTable(null);

            dt = _db.LoadDanhSachTaiKhoan(ref err);
            dgvdanhsach.PrimaryGrid.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                dgvdanhsach.PrimaryGrid.DataSource = dt;

            }
            context = ((DataTable)dt).DefaultView;
            try
            {
                txttendn.DataBindings.Add(new Binding("Text", context, "IDUsername"));
                //txttennv.DataBindings.Add(new Binding("Text", context, "NAME_TEACHER"));
                lblid.DataBindings.Add(new Binding("Text", context, "ID_User"));

          
            }
            catch (Exception e)
            {
              

            }
        }
        BLL_GiaoVien _gv;
        private void ucUser_Load(object sender, EventArgs e)
        {
            _db = new BLL_User(cls_Main.duongdanfileketnoi);
            _gv = new BLL_GiaoVien(cls_Main.duongdanfileketnoi);
            DanhSachUserLoad();
            LoadDanhSachNhanvien(ref err, cbnhanvien);
            LoadDanhSachNhanvienPQ(ref err, combonvpq);
            cbnhanvien.SelectedIndex = -1;
            combonvpq.SelectedIndex = -1;
            txttendn.Enabled = false;
            txtmk.Enabled = false;
            cbnhanvien.Enabled = false;
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
        public void LoadDanhSachNhanvienPQ(ref string err, ComboBox combo)
        {
            DataTable numberr;
            numberr = _db.ListPQ(ref err);
            if (numberr.Rows.Count > 0)
            {
                combo.DataSource = numberr;
                combo.DisplayMember = "IDUsername";
                combo.ValueMember = "ID_User";
            }
        }
        
        public void Them()
        {
            if (cbnhanvien.SelectedIndex <0)
            {
                ToastNotification.Show(this, "Chưa chọn giáo viên", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            if (txttendn.Text ==""&& txtmk.Text =="")
            {
                ToastNotification.Show(this, "Vui lòng điền đủ thông tin!", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;
            dtuer = new     DTO_User()
            {

                Pass=txtmk.Text,
                User=txttendn.Text
            };

            numberr = _db.Them(ref err, dtuer,Convert.ToInt32(cbnhanvien.SelectedValue));
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }

        public void CapNhat()
        {
            if (txtmk.Text =="")
            {
                ToastNotification.Show(this, "Vui lòng chọn mật khẩu", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }

            DataTable numberr;

            numberr = _db.UserUpdate(ref err, Convert.ToInt32(lblid.Text), txtmk.Text);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        public void PhanQuyen()
        {
            
            if (combonvpq.SelectedIndex < 0)
            {
                ToastNotification.Show(this, "Chưa chọn giáo viên", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }
            if (comboquyenhan.SelectedIndex < 0)
            {
                ToastNotification.Show(this, "Chưa chọn quyền hạn", null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }


            DataTable numberr;

            numberr = _db.PhanQuyen(ref err, Convert.ToInt32(combonvpq.SelectedValue), qh);
           if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if(lblid.Text=="0")
            {
                if (cbnhanvien.SelectedIndex >= 0)
                {
                    Them(); // mặc định là 2.
                    var ucUser = new ucUser();
                    cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, ucUser);
                }
            }
            else
            {
                CapNhat();
            }
            DanhSachUserLoad();

        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            lblid.Text = "0";
            txtmk.Clear();
            txttendn.Clear();
            txttendn.Focus();
            cbnhanvien.Enabled = true;
            txttendn.Enabled = true;
            txtmk.Enabled = true;
        }

        private void btnphanquyen_Click(object sender, EventArgs e)
        {
            PhanQuyen();
            var ucUser = new ucUser();
            cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, ucUser);
        }

        private void combonvpq_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        int qh;
        private void comboquyenhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboquyenhan.SelectedIndex>=0)
            {
                if (comboquyenhan.SelectedIndex == 0)
                {
                    qh = 0;
                }
                if (comboquyenhan.SelectedIndex == 1)
                {
                    qh = 1;
                }
                if (comboquyenhan.SelectedIndex == 2)
                {
                    qh = 2;
                }
            }
        }

        private void dgvdanhsach_Click(object sender, EventArgs e)
        {
           
            cbnhanvien.Enabled = false;
            txttendn.Enabled = false;
            txtmk.Clear();
            txtmk.Enabled = true;
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            txtmk.Clear();
            txttendn.Clear();
            cbnhanvien.SelectedIndex = -1;
            lblid.Text = "0";
        }
    }
}
