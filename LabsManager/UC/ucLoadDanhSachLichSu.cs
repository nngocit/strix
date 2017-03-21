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

namespace LabsManager.UC
{
    public partial class ucLoadDanhSachLichSu : UserControl
    {
        public ucLoadDanhSachLichSu()
        {
            InitializeComponent();
        }
        BLL_ThietBi _tbb;
        string err;
        private void ucLoadDanhSachLichSu_Load(object sender, EventArgs e)
        {
               _tbb = new BLL_ThietBi(cls_Main.duongdanfileketnoi); 
            DataTable dt = new DataTable(null);
                dt = _tbb.ThietBiLoad(ref err, cls_Main._Luachon);
                lblsoluong.Text = dt.Rows.Count.ToString();
                if (dt.Rows.Count > 0)
                {
                    dgvthietbi.DataSource = dt;
                }
                else
                {
                    dt.Rows.Clear();
                    dgvthietbi.DataSource = dt;
                }
            }
           
        }
    }


