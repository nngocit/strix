namespace LabsManager.UC
{
    partial class ucsaoluu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcauhinhhethong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblthanhcong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnchon = new System.Windows.Forms.Button();
            this.txtduongdan = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnsaoluu = new System.Windows.Forms.Button();
            this.btngdc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btngdc);
            this.panel1.Controls.Add(this.lblcauhinhhethong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 37);
            this.panel1.TabIndex = 4;
            // 
            // lblcauhinhhethong
            // 
            this.lblcauhinhhethong.AutoSize = true;
            this.lblcauhinhhethong.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcauhinhhethong.ForeColor = System.Drawing.Color.White;
            this.lblcauhinhhethong.Location = new System.Drawing.Point(159, 11);
            this.lblcauhinhhethong.Name = "lblcauhinhhethong";
            this.lblcauhinhhethong.Size = new System.Drawing.Size(157, 25);
            this.lblcauhinhhethong.TabIndex = 0;
            this.lblcauhinhhethong.Text = "SAO LƯU DỮ LIỆU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblthanhcong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnchon);
            this.panel2.Controls.Add(this.txtduongdan);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.btnsaoluu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 120);
            this.panel2.TabIndex = 5;
            // 
            // lblthanhcong
            // 
            this.lblthanhcong.AutoSize = true;
            this.lblthanhcong.BackColor = System.Drawing.Color.Transparent;
            this.lblthanhcong.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblthanhcong.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblthanhcong.Location = new System.Drawing.Point(151, 44);
            this.lblthanhcong.Name = "lblthanhcong";
            this.lblthanhcong.Size = new System.Drawing.Size(0, 14);
            this.lblthanhcong.TabIndex = 203;
            this.lblthanhcong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(78, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 202;
            this.label1.Text = "Trạng thái:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnchon
            // 
            this.btnchon.BackColor = System.Drawing.Color.CadetBlue;
            this.btnchon.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnchon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnchon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnchon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.ForeColor = System.Drawing.Color.White;
            this.btnchon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchon.Location = new System.Drawing.Point(403, 15);
            this.btnchon.Margin = new System.Windows.Forms.Padding(4);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(60, 30);
            this.btnchon.TabIndex = 199;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = false;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(81, 21);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(299, 20);
            this.txtduongdan.TabIndex = 198;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label33.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label33.Location = new System.Drawing.Point(3, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(72, 14);
            this.label33.TabIndex = 197;
            this.label33.Text = "Đường dẫn:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnsaoluu
            // 
            this.btnsaoluu.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsaoluu.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnsaoluu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnsaoluu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnsaoluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaoluu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaoluu.ForeColor = System.Drawing.Color.White;
            this.btnsaoluu.Image = global::LabsManager.Properties.Resources.Data_Connect_32;
            this.btnsaoluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaoluu.Location = new System.Drawing.Point(184, 76);
            this.btnsaoluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnsaoluu.Name = "btnsaoluu";
            this.btnsaoluu.Size = new System.Drawing.Size(111, 33);
            this.btnsaoluu.TabIndex = 5;
            this.btnsaoluu.Text = "&Sao Lưu";
            this.btnsaoluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsaoluu.UseVisualStyleBackColor = false;
            this.btnsaoluu.Click += new System.EventHandler(this.btnsaoluu_Click);
            // 
            // btngdc
            // 
            this.btngdc.BackColor = System.Drawing.Color.Transparent;
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
            this.btngdc.Location = new System.Drawing.Point(429, 0);
            this.btngdc.Margin = new System.Windows.Forms.Padding(4);
            this.btngdc.Name = "btngdc";
            this.btngdc.Size = new System.Drawing.Size(64, 37);
            this.btngdc.TabIndex = 13;
            this.btngdc.Text = "Thoát";
            this.btngdc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngdc.UseVisualStyleBackColor = false;
            // 
            // ucsaoluu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucsaoluu";
            this.Size = new System.Drawing.Size(493, 157);
            this.Load += new System.EventHandler(this.ucsaoluu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btngdc;
        private System.Windows.Forms.Label lblcauhinhhethong;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label lblthanhcong;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.TextBox txtduongdan;
        internal System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnsaoluu;
    }
}
