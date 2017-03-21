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
    public partial class LoaiThietBi : UserControl
    {
        public LoaiThietBi()
        {
            InitializeComponent();
            cls_Controls.Init(this.pnloaitb);
            cls_Controls.Init(this.groupPanel1);
         
        }
        BLL_KetNoi db1 = new BLL_KetNoi(cls_Main.duongdanfileketnoi);
        DTO_LoaiThietBi Dto_loaithietbi ;
        BLL_ThietBi _tb;
        BLL_LoaiThietBi _db;
        BLL_TruongHoc _th;
        string err = "";
        object context = null;
        public void LoaiThietBiLoad()
        {
            DataTable dt = new DataTable(null);
            
            dt = _db.LoaiThietBiLoad(ref err);
            superGridControl1.PrimaryGrid.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                lblsoluong.Text = dt.Rows.Count.ToString();
                superGridControl1.PrimaryGrid.DataSource = dt;
                
            }
            context = ((DataTable)dt).DefaultView;
            try
            {
                txtsoluong.DataBindings.Add(new Binding("Text", context, "NUM_NOW_INF"));
                txttangtrongnam.DataBindings.Add(new Binding("Text", context, "EXP_MACHINE"));
                txttenloaitb.DataBindings.Add(new Binding("Text", context, "NAMES_INF"));
                combongaythang.DataBindings.Add(new Binding("Text", context, "DAY_INF"));
            
                // combongaythang.DataBindings.Add(new Binding("Text", context, "DAY_INF"));
                lblid.DataBindings.Add(new Binding("Text", context, "ID_INF"));
            }
            catch (Exception e)
            {
                //timer1.Start();
                //ToastNotification.Show(this, "Đang tải danh sách", null, 5000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomRight);
                var loaithietbi = new LoaiThietBi();
                cls_Main.LoadUserControl2(cls_Controls._pn_Hienthi, loaithietbi);
                
            }
        }

        private void LoaiThietBi_Load(object sender, System.EventArgs e)
        {
            panel1.Visible = true;
          //  panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
            timer1.Start();
            timer2.Start();
            _db = new BLL_LoaiThietBi(cls_Main.duongdanfileketnoi);
            _th = new BLL_TruongHoc(cls_Main.duongdanfileketnoi);
            _tb = new BLL_ThietBi(cls_Main.duongdanfileketnoi);
            LoaiThietBiLoad();
            LoadDanhSachTruong(ref err, cbtruonghoc);
            cbtruonghoc.SelectedIndex = -1;
            
        }


        bool alowDraw = false;
        bool alowDrawgb = false;
        private void pnloaitb_MouseMove(object sender, MouseEventArgs e)
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

        private void pnloaitb_MouseUp(object sender, MouseEventArgs e)
        {
            alowDraw = false;
            this.Cursor = Cursors.Default;
        }

        private void pnloaitb_MouseDown(object sender, MouseEventArgs e)
        {
            alowDraw = true;
           
        }

        private void groupPanel1_MouseDown(object sender, MouseEventArgs e)
        {
             alowDrawgb = true;
        }

        private void groupPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            alowDrawgb = false;
            this.Cursor = Cursors.Default;
        }

        private void groupPanel1_MouseMove(object sender, MouseEventArgs e)
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

        private void btnlichsugiahandong_Click(object sender, EventArgs e)
        {
            pnloaitb.Visible = false;
        }

    /* 
     Load Danh Sach
     */
        public  void LoadDanhSachTruong(ref string err, ComboBox combo)
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

        public void LoadDanhSachPhong(ref string err, ComboBox combo,int th)
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
        public void ThemLoaiThietBi()
        {
            DataTable numberr;
            Dto_loaithietbi = new DTO_LoaiThietBi()
            {
             ID_CLASS1 = Convert.ToInt32(cbphonghoc.SelectedValue),
             NAMES_INF1 = txttenloaitb.Text.Trim(),
             Num_now = Convert.ToInt32(txtsoluong.Text),
             Exp_machine = Convert.ToInt32(txttangtrongnam.Text),
             Day_inf = combongaythang.Value.ToShortDateString(),
            };
            numberr = _db.LoaiThietBiInsert(ref err, Dto_loaithietbi);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        public void CapNhatLoaiThietBi()
        {
            DataTable numberr;
            Dto_loaithietbi = new DTO_LoaiThietBi();
            Dto_loaithietbi.ID_INF1 = Convert.ToInt32(lblid.Text);
           
            Dto_loaithietbi.NAMES_INF1 = txttenloaitb.Text.Trim();
            Dto_loaithietbi.Num_now = Convert.ToInt32(txtsoluong.Text);
            Dto_loaithietbi.Exp_machine = Convert.ToInt32(txttangtrongnam.Text);
            Dto_loaithietbi.Day_inf = combongaythang.Value.ToShortDateString();
            numberr = _db.LoaiThietBiUpdate(ref err, Dto_loaithietbi);
            if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
        }
        private void cbtruonghoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbtruonghoc.SelectedIndex >=0)
            {
                LoadDanhSachPhong(ref err, cbphonghoc, Convert.ToInt32(cbtruonghoc.SelectedValue));
            }
        }
        public void XoaLoaiThietBi()
        {
           // try
           // {
                DataTable numberr;
                Dto_loaithietbi = new DTO_LoaiThietBi();
                Dto_loaithietbi.ID_INF1 = Convert.ToInt32(lblid.Text);
                numberr = _db.LoaiThietBiDelete(ref err, Dto_loaithietbi);
                if (numberr.Rows.Count > 0) { ToastNotification.Show(this, numberr.Rows[0]["ErrMsg"].ToString(), null, 2000, (eToastGlowColor)eToastGlowColor.Blue, (eToastPosition)eToastPosition.BottomCenter); }
                else
                {
                    ToastNotification.Show(this, "Không thể xóa, hãy xóa những thiết bị có chung nhóm thiết bị này!", null, 2000, (eToastGlowColor)eToastGlowColor.Red, (eToastPosition)eToastPosition.BottomCenter); 
                }
           // }
          //  catch (Exception e)
          //  {

              //  
          //  }
            
          
        }
    
        private void btnThem_Click(object sender, EventArgs e)
        {
            cbphonghoc.SelectedIndex = -1;
            cbtruonghoc.SelectedIndex = -1;
            txttangtrongnam.Text = "0";
            txtsoluong.Text = "0";
            lblid.Text = "N/A";
            txttenloaitb.Clear();
            btnLuu.Enabled = true;
        }
        int ma;
        public void KiemTraLuu()
        {
            if(cbtruonghoc.SelectedIndex<0 || cbtruonghoc.SelectedIndex <0)
            {
                ToastNotification.Show(this, "Vui lòng chọn trường hoặc lớp họp", null, 3000, (eToastGlowColor)eToastGlowColor.Red, (eToastPosition)eToastPosition.BottomCenter);
                return;
            }
         
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            KiemTraLuu();
            if (lblid.Text == "N/A")
            {
                if (txttenloaitb.Text != "" || txtsoluong.Text != "0" || txttangtrongnam.Text != "0")
                {
                    ThemLoaiThietBi();
                    LoaiThietBiLoad();
                }
                else
                {
                    ToastNotification.Show(this, "Vui lòng điền đầy đủ thông tin", null, 3000, (eToastGlowColor)eToastGlowColor.Red, (eToastPosition)eToastPosition.BottomCenter);
                    return;
                }
            }
            else
            {
                if (txttenloaitb.Text != "" || txtsoluong.Text != "0" || txttangtrongnam.Text != "0")
                {
                    CapNhatLoaiThietBi();
                    LoaiThietBiLoad();
                }
                else
                {
                    ToastNotification.Show(this, "Vui lòng điền đầy đủ thông tin", null, 3000, (eToastGlowColor)eToastGlowColor.Red, (eToastPosition)eToastPosition.BottomCenter);
                    return;
                }
            }
             
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txttangtrongnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
        private void superGridControl1_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
           // SelectedElementCollection col = this.superGridControl1.PrimaryGrid.GetSelectedRows();
           // SelectedElementCollection s = superGridControl1.GetSelectedRows();
           // // GridContainer dh=e.GridRow.Index;
           // int dd = e.GridRow.Index;//Get the number of rows selected is from the beginning of 0
           // // MessageBox.Show(dd.ToString());
           // // GridRow g= col[dd] as GridRow;
           // //MessageBox.Show(g.Cells[0].Value.ToString());
           //// if (col.Count > 0)
           // //{
           //     GridRow r = col[1] as GridRow;
           //     //MessageBox.Show(r.Cells[0].Value.ToString());
           //     MessageBox.Show(r.RowHeaderText);
           // //}
           // //GridRow r = col[0] as GridRow;
           // //MessageBox.Show(r.Cells[0].Value.ToString());
            
        }

        private void superGridControl1_CellClick(object sender, GridCellClickEventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbphonghoc.SelectedIndex = -1;
            cbtruonghoc.SelectedIndex = -1;
            txttangtrongnam.Text = "0";
            txtsoluong.Text = "0";
            lblid.Text = "N/A";
            txttenloaitb.Clear();
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaLoaiThietBi();
            cbphonghoc.SelectedIndex = -1;
            cbtruonghoc.SelectedIndex = -1;
            txttangtrongnam.Text = "0";
            txtsoluong.Text = "0";
            lblid.Text = "N/A";
            txttenloaitb.Clear();
            btnLuu.Enabled = true;
            LoaiThietBiLoad();
        }

        private void cbtruonghoc_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cbtruonghoc.SelectedIndex >= 0)
            {
                LoadDanhSachPhong(ref err, cbphonghoc, Convert.ToInt32(cbtruonghoc.SelectedValue));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval==1500)
            {
                panel1.Visible = false;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Increment(1);
            if (timer2.Interval == 3000)
            {
                panel1.Visible = false;
                timer2.Stop();
            }
        }

       
       
      
       

     

      
    }
}
