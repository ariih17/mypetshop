using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void btnLStockBarang_Click(object sender, EventArgs e)
        {
            CRStockBarang crstock = new CRStockBarang();

            LapStockBarang frmlapstockbrg = new LapStockBarang();
            frmlapstockbrg.CRStockBrg.ReportSource = crstock;
            frmlapstockbrg.CRStockBrg.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            frmlapstockbrg.Show();
        }

        private void btnLBiayaLain_Click(object sender, EventArgs e)
        {
            CRBiayaTambahan crbiaya = new CRBiayaTambahan();

            LapBiayaTambahan frmlapbiaya = new LapBiayaTambahan();
            frmlapbiaya.CRLBiayaTambahan.ReportSource = crbiaya;
            frmlapbiaya.CRLBiayaTambahan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            frmlapbiaya.Show();
        }
    }
}
