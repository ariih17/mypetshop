﻿
namespace PetShop
{
    partial class LapStockBarang
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
            this.CRStockBrg = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRStockBrg
            // 
            this.CRStockBrg.ActiveViewIndex = -1;
            this.CRStockBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRStockBrg.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRStockBrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRStockBrg.Location = new System.Drawing.Point(0, 0);
            this.CRStockBrg.Name = "CRStockBrg";
            this.CRStockBrg.Size = new System.Drawing.Size(800, 450);
            this.CRStockBrg.TabIndex = 0;
            // 
            // LapStockBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRStockBrg);
            this.Name = "LapStockBarang";
            this.Text = "LapStockBarang";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRStockBrg;
    }
}