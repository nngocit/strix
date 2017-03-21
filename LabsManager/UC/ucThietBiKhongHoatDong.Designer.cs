namespace LabsManager.UC
{
    partial class ucThietBiKhongHoatDong
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
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.tchuyen = new System.Windows.Forms.Timer(this.components);
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.lblchuyentrang = new System.Windows.Forms.Label();
            this._timersuachua = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbtinhtrang.Location = new System.Drawing.Point(514, 65);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(170, 21);
            this.cbtinhtrang.TabIndex = 216;
            this.cbtinhtrang.SelectionChangeCommitted += new System.EventHandler(this.cblichgv_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(412, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 215;
            this.label9.Text = "Tình trạng thiết bị:";
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(722, 65);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 23);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.Symbol = "";
            this.btnLuu.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.SymbolSize = 10F;
            this.btnLuu.TabIndex = 217;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tchuyen
            // 
            this.tchuyen.Interval = 1000;
            this.tchuyen.Tick += new System.EventHandler(this.tchuyen_Tick);
            // 
            // circularProgress1
            // 
            this.circularProgress1.AnimationSpeed = 56;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(487, 126);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.Size = new System.Drawing.Size(47, 29);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 228;
            this.circularProgress1.Value = 100;
            this.circularProgress1.Visible = false;
            // 
            // lblchuyentrang
            // 
            this.lblchuyentrang.AutoSize = true;
            this.lblchuyentrang.BackColor = System.Drawing.Color.Transparent;
            this.lblchuyentrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchuyentrang.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblchuyentrang.Location = new System.Drawing.Point(540, 132);
            this.lblchuyentrang.Name = "lblchuyentrang";
            this.lblchuyentrang.Size = new System.Drawing.Size(156, 13);
            this.lblchuyentrang.TabIndex = 227;
            this.lblchuyentrang.Text = "Đang chuyển trong vòng 5 giây";
            this.lblchuyentrang.Visible = false;
            // 
            // _timersuachua
            // 
            this._timersuachua.Interval = 1000;
            this._timersuachua.Tick += new System.EventHandler(this._timersuachua_Tick);
            // 
            // ucThietBiKhongHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.lblchuyentrang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbtinhtrang);
            this.Controls.Add(this.label9);
            this.Name = "ucThietBiKhongHoatDong";
            this.Size = new System.Drawing.Size(1174, 174);
            this.Load += new System.EventHandler(this.ucThietBiKhongHoatDong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbtinhtrang;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private System.Windows.Forms.Timer tchuyen;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private System.Windows.Forms.Label lblchuyentrang;
        private System.Windows.Forms.Timer _timersuachua;
    }
}
