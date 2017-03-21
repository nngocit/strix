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
namespace LabsManager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        BLL_KetNoi db1 = new BLL_KetNoi(cls_Main.duongdanfileketnoi);
        private void btnluucauhinh_Click(object sender, EventArgs e)
        {
            FrmCauHinh conf = new FrmCauHinh();
            conf.Show();
        }
        DTO_User Dto_user;
        BLL_User _db;
        string err = "";


        public void ThemMavach()
        {
            DataTable _dt = new DataTable();
            Dto_user = new DTO_User();
            Dto_user.User = txtU.Text.Trim();
            Dto_user.Pass = txtP.Text.Trim();
            _dt= _db.DangNhap(ref err, Dto_user);
            if ( _dt.Rows.Count>0)
            {
                if (_dt.Rows[0]["ErrCode"].ToString()=="0")
                {
                    cls_Main._username = _dt.Rows[0]["ErrUser"].ToString();
                    this.Hide();
                    Form1 frmain = new Form1();
                    frmain.ShowDialog();
                }
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _db = new BLL_User(cls_Main.duongdanfileketnoi);
            lbltrangthai.Text = "";
            if (!db1.kiemtraketnoi(cls_Main.duongdanfileketnoi))
            {

                btnluucauhinh.Enabled = true;
                lbltrangthai.Text = "Vui lòng kiểm tra kết nối và khởi động lại";
            }
            else
            {
                btnluucauhinh.Enabled = false;
            }
        }

        private void btngdc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            ThemMavach();
        }
    }
}
