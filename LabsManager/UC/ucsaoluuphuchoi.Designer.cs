namespace LabsManager.UC
{
    partial class ucsaoluuphuchoi
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblloaithietbi = new System.Windows.Forms.Label();
            this.lblsaoluu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::LabsManager.Properties.Resources._1446620438_Next;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 47;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblloaithietbi
            // 
            this.lblloaithietbi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblloaithietbi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloaithietbi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblloaithietbi.Image = global::LabsManager.Properties.Resources._1446619994_icon_61;
            this.lblloaithietbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblloaithietbi.Location = new System.Drawing.Point(156, 0);
            this.lblloaithietbi.Name = "lblloaithietbi";
            this.lblloaithietbi.Size = new System.Drawing.Size(88, 48);
            this.lblloaithietbi.TabIndex = 11;
            this.lblloaithietbi.Text = "Phục hồi |";
            this.lblloaithietbi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblloaithietbi.Click += new System.EventHandler(this.lblloaithietbi_Click);
            // 
            // lblsaoluu
            // 
            this.lblsaoluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsaoluu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaoluu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsaoluu.Image = global::LabsManager.Properties.Resources._1446620001_icon_60;
            this.lblsaoluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblsaoluu.Location = new System.Drawing.Point(66, 0);
            this.lblsaoluu.Name = "lblsaoluu";
            this.lblsaoluu.Size = new System.Drawing.Size(84, 48);
            this.lblsaoluu.TabIndex = 10;
            this.lblsaoluu.Text = "Sao lưu|";
            this.lblsaoluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblsaoluu.Click += new System.EventHandler(this.lblsaoluu_Click);
            // 
            // ucsaoluuphuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblloaithietbi);
            this.Controls.Add(this.lblsaoluu);
            this.Name = "ucsaoluuphuchoi";
            this.Size = new System.Drawing.Size(1198, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloaithietbi;
        private System.Windows.Forms.Label lblsaoluu;
        private System.Windows.Forms.Button button1;
    }
}
