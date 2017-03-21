using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LabsManager.BLL;
using LabsManager.DAO;
using LabsManager.DTO;
namespace LabsManager.UC
{
    public partial class ucphuchoi : UserControl
    {
        public ucphuchoi()
        {
            InitializeComponent();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFile = new OpenFileDialog();
            OFile.Title = "Data of sParkingManager";
            OFile.Filter = "File(*.bak)|*.bak";
            OFile.InitialDirectory = @"D:\sParkingDaTa\DaTa\";



            if (OFile.ShowDialog() == DialogResult.OK)
            {
                txtduongdan.Text = OFile.FileName;

            }
        }
        ketnoi _ketnoi;
        BLL_KetNoi db2;
        BLL_bkrt db1;
        string err; 
        private string datanamestr;
        public void Laytendata()
        {
            if (File.Exists(cls_Main.duongdanfileketnoi))
            {
                _ketnoi = new ketnoi();
                db2 = new BLL_KetNoi(cls_Main.duongdanfileketnoi, _ketnoi);
                datanamestr = _ketnoi.DatabaseName;
            }
        }
        private void btnphuchoi_Click(object sender, EventArgs e)
        {
            if (txtduongdan.Text == "")
            {
                MessageBox.Show("chưa chọn đường dẫn lưu");
                txtduongdan.Focus();
            }
            else
            {
                lblthanhcong.Text = "Đang phục hồi dữ liệu...";
                lblthanhcong.ForeColor = Color.Red;
                Application.DoEvents();

                try
                {

                    string phuchoi = "use master ALTER DATABASE " + datanamestr +
                                     " SET SINGLE_USER WITH ROLLBACK IMMEDIATE" +
                                     " RESTORE DATABASE " + datanamestr + " FROM DISK = N'" +
                                     txtduongdan.Text.Trim() + "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10" +
                                     " ALTER DATABASE " + datanamestr + " SET MULTI_USER";



                    if (db1.Phuchoi(phuchoi, ref err))
                    {
                        lblthanhcong.Text = "Phục hồi dữ liệu thành công";
                        lblthanhcong.ForeColor = Color.Teal;
                    }
                    else
                    {
                        lblthanhcong.Text = "Phục hồi dữ liệu không thành công";
                        lblthanhcong.ForeColor = Color.Red;

                    }
                }
                catch (Exception ex)
                {

                    lblthanhcong.Text = "Dữ liệu có thể đang được sử dụng, Vui lòng thử lại lần sau.";
                    lblthanhcong.ForeColor = Color.SandyBrown;
                    err = ex.Message;


                }
            }
        }

        private void ucphuchoi_Load(object sender, EventArgs e)
        {
            db1 = new BLL_bkrt(cls_Main.duongdanfileketnoi);
            Laytendata();
        }
    }
}
