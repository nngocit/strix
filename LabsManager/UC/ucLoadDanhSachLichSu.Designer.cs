namespace LabsManager.UC
{
    partial class ucLoadDanhSachLichSu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvthietbi = new MetroFramework.Controls.MetroGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMES_INF_MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TEACHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._REASON_FIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DATE_FIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DATE_FIX_COMPLETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._REASON_RENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DATE_RENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DATE_RENT_COMPLETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._REASON_ERROR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthietbi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvthietbi
            // 
            this.dgvthietbi.AllowUserToAddRows = false;
            this.dgvthietbi.AllowUserToDeleteRows = false;
            this.dgvthietbi.AllowUserToResizeRows = false;
            this.dgvthietbi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvthietbi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvthietbi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvthietbi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvthietbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvthietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ThongTin,
            this.NAME_STATUS,
            this.NAMES_INF_MAC,
            this.NAME_TEACHER,
            this._REASON_FIX,
            this._DATE_FIX,
            this._DATE_FIX_COMPLETE,
            this._REASON_RENT,
            this._DATE_RENT,
            this._DATE_RENT_COMPLETE,
            this._REASON_ERROR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvthietbi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvthietbi.EnableHeadersVisualStyles = false;
            this.dgvthietbi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvthietbi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvthietbi.Location = new System.Drawing.Point(3, 26);
            this.dgvthietbi.Name = "dgvthietbi";
            this.dgvthietbi.ReadOnly = true;
            this.dgvthietbi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvthietbi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvthietbi.RowHeadersVisible = false;
            this.dgvthietbi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvthietbi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvthietbi.Size = new System.Drawing.Size(1168, 145);
            this.dgvthietbi.TabIndex = 170;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 30;
            // 
            // ThongTin
            // 
            this.ThongTin.DataPropertyName = "ThongTin";
            this.ThongTin.HeaderText = "Thông Tin";
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.ReadOnly = true;
            // 
            // NAME_STATUS
            // 
            this.NAME_STATUS.DataPropertyName = "NAME_STATUS";
            this.NAME_STATUS.HeaderText = "Trạng thái";
            this.NAME_STATUS.Name = "NAME_STATUS";
            this.NAME_STATUS.ReadOnly = true;
            // 
            // NAMES_INF_MAC
            // 
            this.NAMES_INF_MAC.DataPropertyName = "NAMES_INF_MAC";
            this.NAMES_INF_MAC.HeaderText = "Thiết bị";
            this.NAMES_INF_MAC.Name = "NAMES_INF_MAC";
            this.NAMES_INF_MAC.ReadOnly = true;
            // 
            // NAME_TEACHER
            // 
            this.NAME_TEACHER.DataPropertyName = "NAME_TEACHER";
            this.NAME_TEACHER.HeaderText = "Giáo viên";
            this.NAME_TEACHER.Name = "NAME_TEACHER";
            this.NAME_TEACHER.ReadOnly = true;
            // 
            // _REASON_FIX
            // 
            this._REASON_FIX.DataPropertyName = "_REASON_FIX";
            this._REASON_FIX.HeaderText = "Lý do sửa";
            this._REASON_FIX.Name = "_REASON_FIX";
            this._REASON_FIX.ReadOnly = true;
            // 
            // _DATE_FIX
            // 
            this._DATE_FIX.DataPropertyName = "_DATE_FIX";
            this._DATE_FIX.HeaderText = "Ngày sửa";
            this._DATE_FIX.Name = "_DATE_FIX";
            this._DATE_FIX.ReadOnly = true;
            // 
            // _DATE_FIX_COMPLETE
            // 
            this._DATE_FIX_COMPLETE.DataPropertyName = "_DATE_FIX_COMPLETE";
            this._DATE_FIX_COMPLETE.HeaderText = "Ngày sửa hoàn tất";
            this._DATE_FIX_COMPLETE.Name = "_DATE_FIX_COMPLETE";
            this._DATE_FIX_COMPLETE.ReadOnly = true;
            // 
            // _REASON_RENT
            // 
            this._REASON_RENT.DataPropertyName = "_REASON_RENT";
            this._REASON_RENT.HeaderText = "Lý do mượn";
            this._REASON_RENT.Name = "_REASON_RENT";
            this._REASON_RENT.ReadOnly = true;
            // 
            // _DATE_RENT
            // 
            this._DATE_RENT.DataPropertyName = "_DATE_RENT";
            this._DATE_RENT.HeaderText = "Ngày mượn";
            this._DATE_RENT.Name = "_DATE_RENT";
            this._DATE_RENT.ReadOnly = true;
            // 
            // _DATE_RENT_COMPLETE
            // 
            this._DATE_RENT_COMPLETE.DataPropertyName = "_DATE_RENT_COMPLETE";
            this._DATE_RENT_COMPLETE.HeaderText = "Ngày trã";
            this._DATE_RENT_COMPLETE.Name = "_DATE_RENT_COMPLETE";
            this._DATE_RENT_COMPLETE.ReadOnly = true;
            // 
            // _REASON_ERROR
            // 
            this._REASON_ERROR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._REASON_ERROR.DataPropertyName = "_REASON_ERROR";
            this._REASON_ERROR.HeaderText = "Nguyên nhân lỗi";
            this._REASON_ERROR.Name = "_REASON_ERROR";
            this._REASON_ERROR.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 171;
            this.label3.Text = "DANH SÁCH LỊCH SỬ HOẠT ĐỘNG";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblsoluong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsoluong.Location = new System.Drawing.Point(272, 10);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(27, 13);
            this.lblsoluong.TabIndex = 224;
            this.lblsoluong.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(211, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 223;
            this.label8.Text = "Số lượng:";
            // 
            // ucLoadDanhSachLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvthietbi);
            this.Name = "ucLoadDanhSachLichSu";
            this.Size = new System.Drawing.Size(1174, 174);
            this.Load += new System.EventHandler(this.ucLoadDanhSachLichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthietbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvthietbi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMES_INF_MAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TEACHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn _REASON_FIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DATE_FIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DATE_FIX_COMPLETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _REASON_RENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DATE_RENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DATE_RENT_COMPLETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _REASON_ERROR;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label label8;
    }
}
