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
    public partial class ucsaoluu : UserControl
    {
        public ucsaoluu()
        {
            InitializeComponent();
          
        }
        string subdir = @"D:\LabsManager\DaTa";
        ketnoi _ketnoi;
        BLL_KetNoi db2;
        BLL_bkrt db1;
        string err;
        private string datanamestr;
        private void btnchon_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            var dlg = new SaveFileDialog();

            dlg.FileName = "LabsManager" + dt.Day + dt.Month + dt.Year+dt.Hour+dt.Minute+dt.Second;
            dlg.Filter = "File(*.bak)|*.bak";
            dlg.InitialDirectory = @"D:\LabsManager\DaTa\";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtduongdan.Text = dlg.FileName;
        }

        private void ucsaoluu_Load(object sender, EventArgs e)
        {
            db1 = new BLL_bkrt(cls_Main.duongdanfileketnoi);
            _ketnoi = new ketnoi();
            db2 = new BLL_KetNoi(cls_Main.duongdanfileketnoi, _ketnoi);
            datanamestr = _ketnoi.DatabaseName;
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
         //   if (File.Exists(cls_Main.duongdanfileketnoi))
           // {
              
           // }
        }

        private void btnsaoluu_Click(object sender, EventArgs e)
        {
            if (txtduongdan.Text == "")
            {
                MessageBox.Show("chưa chọn đường dẫn lưu");
                txtduongdan.Focus();
            }
            else
            {
                lblthanhcong.Text = "Đang sao lưu dữ liệu...";
                lblthanhcong.ForeColor = Color.Red;
                Application.DoEvents();
                // nếu đã tồn tại file.bak cùng tên thì hỏi có thay thế không, nếu chọn Có sẽ thay thế 
                if (File.Exists(txtduongdan.Text))
                {
                    File.Delete(txtduongdan.Text);
                }
            
                DataTable numberr;
                try
	                {	        
		                  numberr = db1.Ng_TK_SaoLuu1(ref err, datanamestr, txtduongdan.Text.Trim());
                          lblthanhcong.Text = "Sao lưu dữ liệu thành công";
                          lblthanhcong.ForeColor = Color.Teal;
	                }
	                catch 
	                {
		                
                             lblthanhcong.Text = "không thể backup CSDL! ";
                             lblthanhcong.ForeColor = Color.Red;

	                }
                               

           
                   
             
                 }

            }
        }
    }

