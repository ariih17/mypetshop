
namespace PetShop
{
    partial class LapBiayaTambahan
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
            this.CRLBiayaTambahan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRLBiayaTambahan
            // 
            this.CRLBiayaTambahan.ActiveViewIndex = -1;
            this.CRLBiayaTambahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRLBiayaTambahan.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRLBiayaTambahan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRLBiayaTambahan.Location = new System.Drawing.Point(0, 0);
            this.CRLBiayaTambahan.Name = "CRLBiayaTambahan";
            this.CRLBiayaTambahan.Size = new System.Drawing.Size(800, 450);
            this.CRLBiayaTambahan.TabIndex = 0;
            // 
            // LapBiayaTambahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRLBiayaTambahan);
            this.Name = "LapBiayaTambahan";
            this.Text = "LapBiayaTambahan";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRLBiayaTambahan;
    }
}