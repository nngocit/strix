namespace LabsManager.UC
{
    partial class ucThongKe
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
            this.lbltkthietbi = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(4, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 47;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbltkthietbi
            // 
            this.lbltkthietbi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbltkthietbi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltkthietbi.ForeColor = System.Drawing.Color.White;
            this.lbltkthietbi.Image = global::LabsManager.Properties.Resources._1446620087_icon_80;
            this.lbltkthietbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltkthietbi.Location = new System.Drawing.Point(46, -1);
            this.lbltkthietbi.Name = "lbltkthietbi";
            this.lbltkthietbi.Size = new System.Drawing.Size(89, 48);
            this.lbltkthietbi.TabIndex = 48;
            this.lbltkthietbi.Text = "Thiết Bị |";
            this.lbltkthietbi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbltkthietbi.Click += new System.EventHandler(this.lbltkthietbi_Click);
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.lbltkthietbi);
            this.Controls.Add(this.button1);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1198, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltkthietbi;
    }
}
