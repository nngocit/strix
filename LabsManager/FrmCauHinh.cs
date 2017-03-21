using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LabsManager.BLL;
using LabsManager.DTO;


namespace LabsManager
{
    public partial class FrmCauHinh : Form
    {
        public FrmCauHinh()
        {
            InitializeComponent();
        }
        ketnoi _ketnoi;
        BLL_KetNoi db2;

        private string err;
        BLL_KetNoi db = new BLL_KetNoi();
        BLL_KetNoi db1 = new BLL_KetNoi(cls_Main.duongdanfileketnoi);
        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            if (File.Exists(cls_Main.duongdanfileketnoi))
            {
                _ketnoi = new ketnoi();
                db2 = new BLL_KetNoi(cls_Main.duongdanfileketnoi, _ketnoi);
                txtserver.Text = _ketnoi.ServerName;
                txtdatabase.Text = _ketnoi.DatabaseName;
                txtuser.Text = _ketnoi.UserName;
                txtpass.Text = _ketnoi.PassWord;
            }
            lbltrangthai.Visible = false;
            btnketnoi.Enabled = false;
        }

        private void btnluucauhinh_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtserver.Text))
            {
                if (!String.IsNullOrEmpty(txtdatabase.Text))
                {
                    if (!String.IsNullOrEmpty(txtuser.Text))
                    {
                        if (!String.IsNullOrEmpty(txtpass.Text))
                        {
                            if (db.saveduongdan(Application.StartupPath + @"\login.ini", ref err, txtserver.Text, txtdatabase.Text, txtuser.Text, txtpass.Text))
                            {
                                MessageBox.Show("Tạo kết nối thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Không tạo được kết nối", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xin nhập mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            txtpass.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtuser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Xin nhập tên database", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtdatabase.Focus();
                }
            }
            else
            {
                MessageBox.Show("Xin nhập tên server", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtserver.Focus();
            }
            btnketnoi.Enabled = true;
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            if (db1.kiemtraketnoi(cls_Main.duongdanfileketnoi))
            {
                if (MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    Close();
                }
            }
            else
            {
                lbltrangthai.Visible = true;
                lbltrangthai.Text = "Kết nối không thành công";
                
            }
        }
    }
}
