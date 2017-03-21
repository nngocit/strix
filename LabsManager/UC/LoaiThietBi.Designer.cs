namespace LabsManager.UC
{
    partial class LoaiThietBi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.cbtruonghoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbphonghoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.txttenloaitb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.combongaythang = new MetroFramework.Controls.MetroDateTime();
            this.txttangtrongnam = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsoluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.pnloaitb = new System.Windows.Forms.Panel();
            this.btnlichsugiahandong = new System.Windows.Forms.Button();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnloaitb.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // cbtruonghoc
            // 
            this.cbtruonghoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtruonghoc.FormattingEnabled = true;
            this.cbtruonghoc.Location = new System.Drawing.Point(102, 32);
            this.cbtruonghoc.Name = "cbtruonghoc";
            this.cbtruonghoc.Size = new System.Drawing.Size(144, 21);
            this.cbtruonghoc.TabIndex = 1;
            this.cbtruonghoc.SelectionChangeCommitted += new System.EventHandler(this.cbtruonghoc_SelectionChangeCommitted_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 147;
            this.label11.Text = "Trường:";
            // 
            // cbphonghoc
            // 
            this.cbphonghoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbphonghoc.FormattingEnabled = true;
            this.cbphonghoc.Location = new System.Drawing.Point(102, 62);
            this.cbphonghoc.Name = "cbphonghoc";
            this.cbphonghoc.Size = new System.Drawing.Size(143, 21);
            this.cbphonghoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 149;
            this.label1.Text = "Phòng:";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblsoluong);
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.Controls.Add(this.lblid);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.txttenloaitb);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.combongaythang);
            this.groupPanel1.Controls.Add(this.txttangtrongnam);
            this.groupPanel1.Controls.Add(this.txtsoluong);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.btnHuy);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.cbphonghoc);
            this.groupPanel1.Controls.Add(this.cbtruonghoc);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.label11);
            this.groupPanel1.Location = new System.Drawing.Point(124, 48);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(273, 315);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BackgroundImage = global::LabsManager.Properties.Resources.parallex_inner1321;
            this.groupPanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.Navy;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 181;
            this.groupPanel1.Tag = "Chức năng";
            this.groupPanel1.Text = "Chức năng";
            this.groupPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupPanel1_MouseDown);
            this.groupPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.groupPanel1_MouseMove);
            this.groupPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.groupPanel1_MouseUp);
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblsoluong.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblsoluong.Location = new System.Drawing.Point(237, 8);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(27, 13);
            this.lblsoluong.TabIndex = 166;
            this.lblsoluong.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(179, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 165;
            this.label9.Text = "Số lượng:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblid.Location = new System.Drawing.Point(38, 8);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 13);
            this.lblid.TabIndex = 164;
            this.lblid.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 163;
            this.label7.Text = "Mã ID:";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(21, 268);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.Symbol = "";
            this.btnXoa.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.SymbolSize = 10F;
            this.btnXoa.TabIndex = 160;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txttenloaitb
            // 
            // 
            // 
            // 
            this.txttenloaitb.Border.Class = "TextBoxBorder";
            this.txttenloaitb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttenloaitb.Location = new System.Drawing.Point(101, 95);
            this.txttenloaitb.Name = "txttenloaitb";
            this.txttenloaitb.PreventEnterBeep = true;
            this.txttenloaitb.Size = new System.Drawing.Size(144, 20);
            this.txttenloaitb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 159;
            this.label5.Text = "Tên loại thiết bị:";
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(169, 236);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 23);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.Symbol = "";
            this.btnLuu.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.SymbolSize = 10F;
            this.btnLuu.TabIndex = 158;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // combongaythang
            // 
            this.combongaythang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.combongaythang.Location = new System.Drawing.Point(102, 196);
            this.combongaythang.MinimumSize = new System.Drawing.Size(0, 29);
            this.combongaythang.Name = "combongaythang";
            this.combongaythang.Size = new System.Drawing.Size(144, 29);
            this.combongaythang.TabIndex = 6;
            // 
            // txttangtrongnam
            // 
            // 
            // 
            // 
            this.txttangtrongnam.Border.Class = "TextBoxBorder";
            this.txttangtrongnam.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttangtrongnam.Location = new System.Drawing.Point(102, 163);
            this.txttangtrongnam.Name = "txttangtrongnam";
            this.txttangtrongnam.PreventEnterBeep = true;
            this.txttangtrongnam.Size = new System.Drawing.Size(144, 20);
            this.txttangtrongnam.TabIndex = 5;
            this.txttangtrongnam.Text = "0";
            this.txttangtrongnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttangtrongnam_KeyPress);
            // 
            // txtsoluong
            // 
            // 
            // 
            // 
            this.txtsoluong.Border.Class = "TextBoxBorder";
            this.txtsoluong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsoluong.Location = new System.Drawing.Point(101, 128);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.PreventEnterBeep = true;
            this.txtsoluong.Size = new System.Drawing.Size(144, 20);
            this.txtsoluong.TabIndex = 4;
            this.txtsoluong.Text = "0";
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "Ngày tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "Tăng trong năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Số lượng:";
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(169, 268);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(76, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.Symbol = "";
            this.btnHuy.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.SymbolSize = 10F;
            this.btnHuy.TabIndex = 151;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(21, 236);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.Symbol = "";
            this.btnThem.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.SymbolSize = 10F;
            this.btnThem.TabIndex = 150;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroProgressBar1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(421, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 511);
            this.panel1.TabIndex = 182;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(327, 191);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(231, 10);
            this.metroProgressBar1.TabIndex = 2;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressBar1.UseCustomBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(385, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đang tải danh sách";
            // 
            // pnloaitb
            // 
            this.pnloaitb.BackColor = System.Drawing.Color.SlateBlue;
            this.pnloaitb.BackgroundImage = global::LabsManager.Properties.Resources.parallex_inner1321;
            this.pnloaitb.Controls.Add(this.btnlichsugiahandong);
            this.pnloaitb.Controls.Add(this.superGridControl1);
            this.pnloaitb.Controls.Add(this.labelX1);
            this.pnloaitb.Location = new System.Drawing.Point(421, 48);
            this.pnloaitb.Name = "pnloaitb";
            this.pnloaitb.Size = new System.Drawing.Size(802, 315);
            this.pnloaitb.TabIndex = 0;
            this.pnloaitb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnloaitb_MouseDown);
            this.pnloaitb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnloaitb_MouseMove);
            this.pnloaitb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnloaitb_MouseUp);
            // 
            // btnlichsugiahandong
            // 
            this.btnlichsugiahandong.BackColor = System.Drawing.Color.Transparent;
            this.btnlichsugiahandong.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnlichsugiahandong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnlichsugiahandong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnlichsugiahandong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlichsugiahandong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlichsugiahandong.ForeColor = System.Drawing.Color.White;
            this.btnlichsugiahandong.Image = global::LabsManager.Properties.Resources._1446628448_Danger;
            this.btnlichsugiahandong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlichsugiahandong.Location = new System.Drawing.Point(731, 1);
            this.btnlichsugiahandong.Margin = new System.Windows.Forms.Padding(4);
            this.btnlichsugiahandong.Name = "btnlichsugiahandong";
            this.btnlichsugiahandong.Size = new System.Drawing.Size(70, 25);
            this.btnlichsugiahandong.TabIndex = 180;
            this.btnlichsugiahandong.Text = "Đóng";
            this.btnlichsugiahandong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlichsugiahandong.UseVisualStyleBackColor = false;
            this.btnlichsugiahandong.Click += new System.EventHandler(this.btnlichsugiahandong_Click);
            // 
            // superGridControl1
            // 
            this.superGridControl1.BackColor = System.Drawing.Color.White;
            background1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.superGridControl1.DefaultVisualStyles.GroupByStyles.Default.Background = background1;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superGridControl1.ForeColor = System.Drawing.Color.Black;
            this.superGridControl1.Location = new System.Drawing.Point(0, 26);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowEdit = false;
            this.superGridControl1.PrimaryGrid.AutoExpandSetGroup = true;
            gridColumn1.DataPropertyName = "ID_INF";
            gridColumn1.HeaderText = "ID_INF";
            gridColumn1.Name = "";
            gridColumn1.Visible = false;
            gridColumn2.DataPropertyName = "NAMES";
            gridColumn2.HeaderText = "Phòng";
            gridColumn2.InfoImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn2.Name = "";
            gridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn3.DataPropertyName = "NAMES_INF";
            gridColumn3.HeaderText = "Loại Thiết Bị";
            gridColumn3.InfoImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn3.Name = "";
            gridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn4.DataPropertyName = "NUM_NOW_INF";
            gridColumn4.HeaderText = "Số lượng hiện tại";
            gridColumn4.InfoImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn4.Name = "";
            gridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn5.DataPropertyName = "EXP_MACHINE";
            gridColumn5.HeaderText = "Tăng trong năm";
            gridColumn5.InfoImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn5.Name = "";
            gridColumn6.DataPropertyName = "DAY_INF";
            gridColumn6.HeaderText = "Ngày";
            gridColumn6.InfoImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn6.Name = "";
            gridColumn7.DataPropertyName = "TinhTrang";
            gridColumn7.HeaderText = "Tình Trạng";
            gridColumn7.Name = "";
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn6);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn7);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 20;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.superGridControl1.PrimaryGrid.EnableCellExpressions = true;
            this.superGridControl1.PrimaryGrid.EnableColumnFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableRowFiltering = true;
            this.superGridControl1.PrimaryGrid.EnsureVisibleAfterGrouping = true;
            this.superGridControl1.PrimaryGrid.Filter.FilterImage = global::LabsManager.Properties.Resources.parallex_inner1321;
            this.superGridControl1.PrimaryGrid.GroupByRow.BackgroundImage = global::LabsManager.Properties.Resources.parallex_inner1321;
            this.superGridControl1.PrimaryGrid.GroupByRow.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.Center;
            this.superGridControl1.PrimaryGrid.GroupByRow.GroupBoxLayout = DevComponents.DotNetBar.SuperGrid.GroupBoxLayout.Flat;
            this.superGridControl1.PrimaryGrid.GroupByRow.GroupBoxStyle = DevComponents.DotNetBar.SuperGrid.GroupBoxStyle.RoundedRectangular;
            this.superGridControl1.PrimaryGrid.GroupByRow.Visible = true;
            this.superGridControl1.PrimaryGrid.GroupHeaderHeight = 20;
            this.superGridControl1.PrimaryGrid.ShowRowHeaders = false;
            this.superGridControl1.Size = new System.Drawing.Size(801, 251);
            this.superGridControl1.TabIndex = 2;
            this.superGridControl1.Text = "superGridControl1";
            this.superGridControl1.CellClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellClickEventArgs>(this.superGridControl1_CellClick);
            this.superGridControl1.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.superGridControl1_RowDoubleClick);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(317, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(160, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "DANH SÁCH LOẠI THIẾT BỊ";
            // 
            // LoaiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.pnloaitb);
            this.DoubleBuffered = true;
            this.Name = "LoaiThietBi";
            this.Size = new System.Drawing.Size(1365, 599);
            this.Load += new System.EventHandler(this.LoaiThietBi_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnloaitb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnloaitb;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private System.Windows.Forms.Button btnlichsugiahandong;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ComboBox cbphonghoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtruonghoc;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttangtrongnam;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private MetroFramework.Controls.MetroDateTime combongaythang;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenloaitb;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label label9;



    }
}
