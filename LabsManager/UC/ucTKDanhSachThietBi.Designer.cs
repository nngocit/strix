﻿namespace LabsManager.UC
{
    partial class ucTKDanhSachThietBi
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Segoe UI Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.Location = new System.Drawing.Point(705, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 492);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucTKDanhSachThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ucTKDanhSachThietBi";
            this.Size = new System.Drawing.Size(1365, 599);
            this.Load += new System.EventHandler(this.ucTKDanhSachThietBi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
    }
}