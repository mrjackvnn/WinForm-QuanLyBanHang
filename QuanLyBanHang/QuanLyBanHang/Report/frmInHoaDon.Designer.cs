namespace QuanLyBanHang.Report
{
    partial class frmInHoaDon
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
            this.rpvInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpInHoaDon1 = new QuanLyBanHang.Report.rpInHoaDon();
            this.SuspendLayout();
            // 
            // rpvInHoaDon
            // 
            this.rpvInHoaDon.ActiveViewIndex = -1;
            this.rpvInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpvInHoaDon.Name = "rpvInHoaDon";
            this.rpvInHoaDon.Size = new System.Drawing.Size(800, 450);
            this.rpvInHoaDon.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rpInHoaDon1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.rpvInHoaDon);
            this.Name = "frmInHoaDon";
            this.Text = "IN HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvInHoaDon;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rpInHoaDon rpInHoaDon1;
    }
}