namespace LabsManager
{
    partial class FrmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnketnoi = new System.Windows.Forms.Button();
            this.btnluucauhinh = new System.Windows.Forms.Button();
            this.txtP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtU = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngdc = new System.Windows.Forms.Button();
            this.lblcauhinhhethong = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnketnoi);
            this.panel2.Controls.Add(this.btnluucauhinh);
            this.panel2.Controls.Add(this.txtP);
            this.panel2.Controls.Add(this.txtU);
            this.panel2.Controls.Add(this.lbltrangthai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 184);
            this.panel2.TabIndex = 4;
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrangthai.ForeColor = System.Drawing.Color.Red;
            this.lbltrangthai.Location = new System.Drawing.Point(119, 2);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(96, 21);
            this.lbltrangthai.TabIndex = 20;
            this.lbltrangthai.Text = "lblTrangThai";
            // 
            // btnketnoi
            // 
            this.btnketnoi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnketnoi.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnketnoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnketnoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnketnoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnketnoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnketnoi.ForeColor = System.Drawing.Color.White;
            this.btnketnoi.Image = global::LabsManager.Properties.Resources.Data_Connect_32;
            this.btnketnoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnketnoi.Location = new System.Drawing.Point(23, 140);
            this.btnketnoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(116, 38);
            this.btnketnoi.TabIndex = 3;
            this.btnketnoi.Text = " &Đăng Nhập";
            this.btnketnoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnketnoi.UseVisualStyleBackColor = false;
            this.btnketnoi.Click += new System.EventHandler(this.btnketnoi_Click);
            // 
            // btnluucauhinh
            // 
            this.btnluucauhinh.BackColor = System.Drawing.Color.CadetBlue;
            this.btnluucauhinh.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnluucauhinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnluucauhinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnluucauhinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluucauhinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluucauhinh.ForeColor = System.Drawing.Color.White;
            this.btnluucauhinh.Image = global::LabsManager.Properties.Resources.Save_32;
            this.btnluucauhinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluucauhinh.Location = new System.Drawing.Point(176, 140);
            this.btnluucauhinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnluucauhinh.Name = "btnluucauhinh";
            this.btnluucauhinh.Size = new System.Drawing.Size(116, 38);
            this.btnluucauhinh.TabIndex = 4;
            this.btnluucauhinh.Text = "&Cấu Hình";
            this.btnluucauhinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluucauhinh.UseVisualStyleBackColor = false;
            this.btnluucauhinh.Click += new System.EventHandler(this.btnluucauhinh_Click);
            // 
            // txtP
            // 
            // 
            // 
            // 
            this.txtP.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtP.Border.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground2;
            this.txtP.Border.BackColorGradientAngle = 9;
            this.txtP.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopRight;
            this.txtP.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.txtP.Border.BorderBottomWidth = 1;
            this.txtP.Border.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtP.Border.BorderColor2 = System.Drawing.Color.LightSeaGreen;
            this.txtP.Border.BorderColorLight = System.Drawing.Color.LightBlue;
            this.txtP.Border.BorderColorLight2 = System.Drawing.SystemColors.ButtonFace;
            this.txtP.Border.BorderGradientAngle = 98;
            this.txtP.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.txtP.Border.BorderLeftColor = System.Drawing.Color.AliceBlue;
            this.txtP.Border.BorderLeftWidth = 1;
            this.txtP.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtP.Border.BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtP.Border.BorderRightWidth = 1;
            this.txtP.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtP.Border.Class = "RichTextBoxBorder";
            this.txtP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtP.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtP.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square;
            this.txtP.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtP.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.txtP.Location = new System.Drawing.Point(23, 72);
            this.txtP.Name = "txtP";
            this.txtP.PreventEnterBeep = true;
            this.txtP.Size = new System.Drawing.Size(269, 24);
            this.txtP.TabIndex = 2;
            this.txtP.UseSystemPasswordChar = true;
            this.txtP.WatermarkImage = global::LabsManager.Properties.Resources._1446560473_Key;
            this.txtP.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtP.WatermarkText = "Mật khẩu";
            // 
            // txtU
            // 
            // 
            // 
            // 
            this.txtU.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtU.Border.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground2;
            this.txtU.Border.BackColorGradientAngle = 9;
            this.txtU.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopRight;
            this.txtU.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.txtU.Border.BorderBottomWidth = 1;
            this.txtU.Border.BorderColor = System.Drawing.Color.PaleGreen;
            this.txtU.Border.BorderColor2 = System.Drawing.Color.LightSeaGreen;
            this.txtU.Border.BorderColorLight = System.Drawing.Color.LightBlue;
            this.txtU.Border.BorderColorLight2 = System.Drawing.SystemColors.ButtonFace;
            this.txtU.Border.BorderGradientAngle = 98;
            this.txtU.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDotDot;
            this.txtU.Border.BorderLeftColor = System.Drawing.Color.AliceBlue;
            this.txtU.Border.BorderLeftWidth = 1;
            this.txtU.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtU.Border.BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtU.Border.BorderRightWidth = 1;
            this.txtU.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtU.Border.Class = "RichTextBoxBorder";
            this.txtU.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtU.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtU.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square;
            this.txtU.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtU.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.txtU.Location = new System.Drawing.Point(23, 37);
            this.txtU.Name = "txtU";
            this.txtU.PreventEnterBeep = true;
            this.txtU.Size = new System.Drawing.Size(269, 24);
            this.txtU.TabIndex = 1;
            this.txtU.WatermarkImage = global::LabsManager.Properties.Resources._1446560365_user_alt;
            this.txtU.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtU.WatermarkText = "Tên truy cập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btngdc);
            this.panel1.Controls.Add(this.lblcauhinhhethong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 37);
            this.panel1.TabIndex = 3;
            // 
            // btngdc
            // 
            this.btngdc.BackColor = System.Drawing.Color.Transparent;
            this.btngdc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btngdc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngdc.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btngdc.FlatAppearance.BorderSize = 0;
            this.btngdc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btngdc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btngdc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngdc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngdc.ForeColor = System.Drawing.Color.Transparent;
            this.btngdc.Image = global::LabsManager.Properties.Resources.orkut_16;
            this.btngdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngdc.Location = new System.Drawing.Point(265, 0);
            this.btngdc.Margin = new System.Windows.Forms.Padding(4);
            this.btngdc.Name = "btngdc";
            this.btngdc.Size = new System.Drawing.Size(64, 37);
            this.btngdc.TabIndex = 13;
            this.btngdc.Text = "Thoát";
            this.btngdc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngdc.UseVisualStyleBackColor = false;
            this.btngdc.Click += new System.EventHandler(this.btngdc_Click);
            // 
            // lblcauhinhhethong
            // 
            this.lblcauhinhhethong.AutoSize = true;
            this.lblcauhinhhethong.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcauhinhhethong.ForeColor = System.Drawing.Color.White;
            this.lblcauhinhhethong.Location = new System.Drawing.Point(119, 4);
            this.lblcauhinhhethong.Name = "lblcauhinhhethong";
            this.lblcauhinhhethong.Size = new System.Drawing.Size(134, 30);
            this.lblcauhinhhethong.TabIndex = 0;
            this.lblcauhinhhethong.Text = "ĐĂNG NHẬP ";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 221);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnluucauhinh;
        private System.Windows.Forms.Button btnketnoi;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btngdc;
        private System.Windows.Forms.Label lblcauhinhhethong;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtP;
        private DevComponents.DotNetBar.Controls.TextBoxX txtU;
    }
}