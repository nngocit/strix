using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
namespace LabsManager
{
    class cls_Main
    {

        public static Form1 _frmmain;
        public static Panel pnlMain;
        public static string _username = "";
        public static bool frmcauhinhketnoi = false;
        public static string duongdanfileketnoi = Application.StartupPath + @"\login.ini";
        public static int _Luachon = 0;
        public static int _Id_inf_mac=0;
        public static string _names_inf = "";
        public static string _name_inf_mac = "";
        public static string _nameclass = "";
        public static int _now_st = 0;
        public static int _fix_st = 0;
        public static int _rent_st = 0;

        public static int _PhongValue;
        public static int _LopValue;

        public static void LoadUserControl(Control nen, Control ucontrol, int a)
        {
            nen.Controls.Clear();
            ucontrol.Top = (nen.Height - ucontrol.Height) / 2;
            ucontrol.Left = (nen.Width - ucontrol.Width) / a;
            nen.Controls.Add(ucontrol);
            nen.Dock = System.Windows.Forms.DockStyle.Top;
            
        }

        public static void LoadUserControl2(Control nen, Control ucontrol)
        {
            nen.Controls.Clear();
          
            nen.Controls.Add(ucontrol);
            nen.Dock = System.Windows.Forms.DockStyle.Fill;
            
        }
        public static void LoadUserControl3(Control nen, Control UControl)
        {
            nen.Controls.Clear();
            UControl.Top = (nen.Height - UControl.Height) / 5;
            UControl.Left = (nen.Width - UControl.Width) /7;
            nen.Controls.Add(UControl);
        }

        #region //HienThiDGV 6 Overload
        public static void Viewdata(DataGridView l,  TextBox a, string col)
        {
            a.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }
        public static void Viewdata(SuperGridControl l, TextBox a, string col)
        {
           
            //a.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }
        public static void Viewdata(DataGridView l, DLLDungChung.MyTextBox a, string col)
        {
            a.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }
        public static void Viewdata(DataGridView l, TextBox a, int col)
        {
            a.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }
        public static void Viewdata(DataGridView l, ComboBox a, int col)
        {
            a.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }

        public static void Viewdata(DataGridView l, ComboBox a, string col)
        {
            a.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }

        public static void Viewdatalabel(DataGridView l, Label lb, string col)
        {
            lb.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }
        public static void Viewdatalabel(DataGridView l, Label lb, int col)
        {
            lb.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }
        public static int Viewdatalabel(DataGridView l, ref int  a, string col)
        {
          a =  Convert.ToInt32(l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString());
            return a;
        }
        public static void Viewdatacombobox(DataGridView l, ComboBox lb, string col)
        {
            lb.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();

        }
        public static void Viewdatadatetime(DataGridView l, DateTimePicker lb, string col)
        {
            lb.Text = l.Rows[l.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }
       
        #endregion
    }
}
