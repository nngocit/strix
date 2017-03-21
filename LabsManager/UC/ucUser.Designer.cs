namespace LabsManager.UC
{
    partial class ucUser
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
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnmoi = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboquyenhan = new System.Windows.Forms.ComboBox();
            this.combonvpq = new System.Windows.Forms.ComboBox();
            this.btnphanquyen = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnloaitb = new System.Windows.Forms.Panel();
            this.btnlichsugiahandong = new System.Windows.Forms.Button();
            this.dgvdanhsach = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnloaitb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cbnhanvien);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblid);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnhuybo);
            this.groupBox3.Controls.Add(this.btnmoi);
            this.groupBox3.Controls.Add(this.btnluu);
            this.groupBox3.Controls.Add(this.txtmk);
            this.groupBox3.Controls.Add(this.txttendn);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(210, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 165);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo tài khoản cho nhân viên";
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(143, 56);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(148, 21);
            this.cbnhanvien.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "Tên Nhân Viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Black;
            this.lblid.Location = new System.Drawing.Point(140, 31);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 16);
            this.lblid.TabIndex = 122;
            this.lblid.Text = "0";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label21.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label21.Location = new System.Drawing.Point(36, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 120;
            this.label21.Text = "Mã Nhân Viên:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(36, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 113;
            this.label12.Text = "Mật Khẩu:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(36, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "Tên Đăng Nhập:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnhuybo
            // 
            this.btnhuybo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnhuybo.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnhuybo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnhuybo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnhuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuybo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnhuybo.ForeColor = System.Drawing.Color.White;
            this.btnhuybo.Location = new System.Drawing.Point(386, 118);
            this.btnhuybo.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(82, 34);
            this.btnhuybo.TabIndex = 9;
            this.btnhuybo.Text = "&Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnmoi
            // 
            this.btnmoi.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnmoi.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnmoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnmoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmoi.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnmoi.ForeColor = System.Drawing.Color.White;
            this.btnmoi.Location = new System.Drawing.Point(386, 35);
            this.btnmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnmoi.Name = "btnmoi";
            this.btnmoi.Size = new System.Drawing.Size(82, 34);
            this.btnmoi.TabIndex = 7;
            this.btnmoi.Text = "&Tạo mới";
            this.btnmoi.UseVisualStyleBackColor = false;
            this.btnmoi.Click += new System.EventHandler(this.btnmoi_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnluu.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnluu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnluu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Location = new System.Drawing.Point(386, 78);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(82, 34);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "&Cập Nhật";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(143, 130);
            this.txtmk.Multiline = true;
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(148, 23);
            this.txtmk.TabIndex = 3;
            // 
            // txttendn
            // 
            this.txttendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendn.Location = new System.Drawing.Point(143, 95);
            this.txttendn.Multiline = true;
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(148, 24);
            this.txttendn.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.comboquyenhan);
            this.groupBox4.Controls.Add(this.combonvpq);
            this.groupBox4.Controls.Add(this.btnphanquyen);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.Location = new System.Drawing.Point(701, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 165);
            this.groupBox4.TabIndex = 121;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phân quyền nhân viên";
            // 
            // comboquyenhan
            // 
            this.comboquyenhan.FormattingEnabled = true;
            this.comboquyenhan.Items.AddRange(new object[] {
            "- Quản trị cao cấp",
            "- Quản trị",
            "- Thành viên"});
            this.comboquyenhan.Location = new System.Drawing.Point(100, 86);
            this.comboquyenhan.Name = "comboquyenhan";
            this.comboquyenhan.Size = new System.Drawing.Size(122, 21);
            this.comboquyenhan.TabIndex = 11;
            this.comboquyenhan.SelectedIndexChanged += new System.EventHandler(this.comboquyenhan_SelectedIndexChanged);
            // 
            // combonvpq
            // 
            this.combonvpq.FormattingEnabled = true;
            this.combonvpq.Location = new System.Drawing.Point(100, 47);
            this.combonvpq.Name = "combonvpq";
            this.combonvpq.Size = new System.Drawing.Size(122, 21);
            this.combonvpq.TabIndex = 10;
            this.combonvpq.SelectedIndexChanged += new System.EventHandler(this.combonvpq_SelectedIndexChanged);
            // 
            // btnphanquyen
            // 
            this.btnphanquyen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnphanquyen.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnphanquyen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnphanquyen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnphanquyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphanquyen.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnphanquyen.ForeColor = System.Drawing.Color.White;
            this.btnphanquyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnphanquyen.Location = new System.Drawing.Point(298, 51);
            this.btnphanquyen.Margin = new System.Windows.Forms.Padding(4);
            this.btnphanquyen.Name = "btnphanquyen";
            this.btnphanquyen.Size = new System.Drawing.Size(89, 56);
            this.btnphanquyen.TabIndex = 12;
            this.btnphanquyen.Text = "&Phân Quyền";
            this.btnphanquyen.UseVisualStyleBackColor = false;
            this.btnphanquyen.Click += new System.EventHandler(this.btnphanquyen_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label17.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label17.Location = new System.Drawing.Point(6, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 117;
            this.label17.Text = "Quyền Hạn:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(6, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 111;
            this.label16.Text = "Tên Nhân Viên:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnloaitb
            // 
            this.pnloaitb.BackColor = System.Drawing.Color.SlateBlue;
            this.pnloaitb.BackgroundImage = global::LabsManager.Properties.Resources.parallex_inner1321;
            this.pnloaitb.Controls.Add(this.btnlichsugiahandong);
            this.pnloaitb.Controls.Add(this.dgvdanhsach);
            this.pnloaitb.Controls.Add(this.labelX1);
            this.pnloaitb.Location = new System.Drawing.Point(467, 225);
            this.pnloaitb.Name = "pnloaitb";
            this.pnloaitb.Size = new System.Drawing.Size(540, 188);
            this.pnloaitb.TabIndex = 184;
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
            this.btnlichsugiahandong.Location = new System.Drawing.Point(775, 1);
            this.btnlichsugiahandong.Margin = new System.Windows.Forms.Padding(4);
            this.btnlichsugiahandong.Name = "btnlichsugiahandong";
            this.btnlichsugiahandong.Size = new System.Drawing.Size(70, 25);
            this.btnlichsugiahandong.TabIndex = 180;
            this.btnlichsugiahandong.Text = "Đóng";
            this.btnlichsugiahandong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlichsugiahandong.UseVisualStyleBackColor = false;
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.BackColor = System.Drawing.Color.White;
            this.dgvdanhsach.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            background1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvdanhsach.DefaultVisualStyles.GroupByStyles.Default.Background = background1;
            this.dgvdanhsach.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvdanhsach.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdanhsach.ForeColor = System.Drawing.Color.Black;
            this.dgvdanhsach.Location = new System.Drawing.Point(3, 26);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.PrimaryGrid.AllowEdit = false;
            this.dgvdanhsach.PrimaryGrid.AutoExpandSetGroup = true;
            gridColumn1.DataPropertyName = "IDUsername";
            gridColumn1.HeaderText = "Tài khoản";
            gridColumn1.Name = "IDUsername";
            gridColumn2.DataPropertyName = "NAME_TEACHER";
            gridColumn2.HeaderText = "Họ và tên";
            gridColumn2.Name = "NAME_TEACHER";
            gridColumn3.DataPropertyName = "CheDo";
            gridColumn3.HeaderText = "Quyền hạn";
            gridColumn3.Name = "CheDo";
            gridColumn4.DataPropertyName = "ID_User";
            gridColumn4.Name = "ID_User";
            gridColumn4.Visible = false;
            this.dgvdanhsach.PrimaryGrid.Columns.Add(gridColumn1);
            this.dgvdanhsach.PrimaryGrid.Columns.Add(gridColumn2);
            this.dgvdanhsach.PrimaryGrid.Columns.Add(gridColumn3);
            this.dgvdanhsach.PrimaryGrid.Columns.Add(gridColumn4);
            this.dgvdanhsach.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdanhsach.PrimaryGrid.EnableCellExpressions = true;
            this.dgvdanhsach.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvdanhsach.PrimaryGrid.EnableFiltering = true;
            this.dgvdanhsach.PrimaryGrid.EnableRowFiltering = true;
            this.dgvdanhsach.PrimaryGrid.EnsureVisibleAfterGrouping = true;
            this.dgvdanhsach.PrimaryGrid.Filter.FilterImage = global::LabsManager.Properties.Resources.parallex_inner1321;
            this.dgvdanhsach.PrimaryGrid.GroupByRow.BackgroundImage = global::LabsManager.Properties.Resources.parallex_inner1321;
            this.dgvdanhsach.PrimaryGrid.GroupByRow.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.Center;
            this.dgvdanhsach.PrimaryGrid.GroupByRow.FilterImageVisibility = DevComponents.DotNetBar.SuperGrid.ImageVisibility.Auto;
            this.dgvdanhsach.PrimaryGrid.GroupByRow.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.None;
            this.dgvdanhsach.PrimaryGrid.GroupByRow.GroupBoxLayout = DevComponents.DotNetBar.SuperGrid.GroupBoxLayout.Flat;
            this.dgvdanhsach.PrimaryGrid.GroupByRow.Visible = true;
            this.dgvdanhsach.PrimaryGrid.ShowRowHeaders = false;
            this.dgvdanhsach.Size = new System.Drawing.Size(534, 159);
            this.dgvdanhsach.TabIndex = 2;
            this.dgvdanhsach.Text = "superGridControl1";
            this.dgvdanhsach.Click += new System.EventHandler(this.dgvdanhsach_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(226, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(142, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnloaitb);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(1365, 599);
            this.Load += new System.EventHandler(this.ucUser_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnloaitb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label lblid;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboquyenhan;
        private System.Windows.Forms.ComboBox combonvpq;
        private System.Windows.Forms.Button btnphanquyen;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnloaitb;
        private System.Windows.Forms.Button btnlichsugiahandong;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvdanhsach;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cbnhanvien;
        internal System.Windows.Forms.Label label1;
    }
}
