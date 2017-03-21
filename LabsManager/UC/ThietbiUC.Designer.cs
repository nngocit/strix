namespace LabsManager.UC
{
    partial class ThietbiUC
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
            this.lblten = new System.Windows.Forms.Label();
            this.lblmieuta = new System.Windows.Forms.Label();
            this.lblsudung = new System.Windows.Forms.Label();
            this.lblmuontitle = new System.Windows.Forms.Label();
            this.lblMuonFix = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoHỏngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picht = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picht)).BeginInit();
            this.SuspendLayout();
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.BackColor = System.Drawing.Color.White;
            this.lblten.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblten.Location = new System.Drawing.Point(41, 3);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(41, 11);
            this.lblten.TabIndex = 1;
            this.lblten.Text = "Active...";
            // 
            // lblmieuta
            // 
            this.lblmieuta.AutoSize = true;
            this.lblmieuta.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmieuta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblmieuta.Location = new System.Drawing.Point(43, 13);
            this.lblmieuta.Name = "lblmieuta";
            this.lblmieuta.Size = new System.Drawing.Size(48, 11);
            this.lblmieuta.TabIndex = 2;
            this.lblmieuta.Text = "Miêu tả ...";
            // 
            // lblsudung
            // 
            this.lblsudung.AutoSize = true;
            this.lblsudung.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsudung.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblsudung.Location = new System.Drawing.Point(44, 26);
            this.lblsudung.Name = "lblsudung";
            this.lblsudung.Size = new System.Drawing.Size(48, 11);
            this.lblsudung.TabIndex = 3;
            this.lblsudung.Text = "Miêu tả ...";
            // 
            // lblmuontitle
            // 
            this.lblmuontitle.AutoSize = true;
            this.lblmuontitle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmuontitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblmuontitle.Location = new System.Drawing.Point(3, 37);
            this.lblmuontitle.Name = "lblmuontitle";
            this.lblmuontitle.Size = new System.Drawing.Size(31, 11);
            this.lblmuontitle.TabIndex = 4;
            this.lblmuontitle.Text = "Mượn:";
            this.lblmuontitle.Visible = false;
            // 
            // lblMuonFix
            // 
            this.lblMuonFix.AutoSize = true;
            this.lblMuonFix.BackColor = System.Drawing.Color.White;
            this.lblMuonFix.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuonFix.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMuonFix.Location = new System.Drawing.Point(43, 38);
            this.lblMuonFix.Name = "lblMuonFix";
            this.lblMuonFix.Size = new System.Drawing.Size(30, 11);
            this.lblMuonFix.TabIndex = 5;
            this.lblMuonFix.Text = "{N/A}";
            this.lblMuonFix.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_id.Location = new System.Drawing.Point(8, 17);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(31, 11);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "Mượn:";
            this.lbl_id.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchToolStripMenuItem,
            this.báoHỏngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.Image = global::LabsManager.Properties.Resources._1446539914_menu;
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.danhSáchToolStripMenuItem.Text = "Danh sách";
            this.danhSáchToolStripMenuItem.Click += new System.EventHandler(this.danhSáchToolStripMenuItem_Click);
            // 
            // báoHỏngToolStripMenuItem
            // 
            this.báoHỏngToolStripMenuItem.Image = global::LabsManager.Properties.Resources._1446628448_Danger;
            this.báoHỏngToolStripMenuItem.Name = "báoHỏngToolStripMenuItem";
            this.báoHỏngToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.báoHỏngToolStripMenuItem.Text = "Báo hỏng";
            // 
            // picht
            // 
            this.picht.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picht.Location = new System.Drawing.Point(3, 3);
            this.picht.Name = "picht";
            this.picht.Size = new System.Drawing.Size(35, 31);
            this.picht.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picht.TabIndex = 0;
            this.picht.TabStop = false;
            this.picht.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.picht.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // ThietbiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblMuonFix);
            this.Controls.Add(this.lblmuontitle);
            this.Controls.Add(this.lblsudung);
            this.Controls.Add(this.lblmieuta);
            this.Controls.Add(this.picht);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.lbl_id);
            this.Name = "ThietbiUC";
            this.Size = new System.Drawing.Size(131, 51);
            this.MouseLeave += new System.EventHandler(this.ThietbiUC_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ThietbiUC_MouseHover);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblten;
        public System.Windows.Forms.Label lblmieuta;
        public System.Windows.Forms.Label lblsudung;
        public System.Windows.Forms.Label lblmuontitle;
        public System.Windows.Forms.Label lblMuonFix;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoHỏngToolStripMenuItem;
        public System.Windows.Forms.PictureBox picht;
    }
}
