using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DentalSys
{
    public partial class frmStatChargeAccout : frmBase
    {
        public frmStatChargeAccout()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            usCtlStatCharge usCtl = new usCtlStatCharge();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            usCtlStatAccoutDate usCtl = new usCtlStatAccoutDate();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            usCtlStatOwe usCtl = new usCtlStatOwe();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            usCtlStatAccountDetail usCtl = new usCtlStatAccountDetail();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            usCtlStatPrePayBalance usCtl = new usCtlStatPrePayBalance();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            usCtlStatChargeAccount usCtl = new usCtlStatChargeAccount();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            usCtlStatPrePayment usCtl = new usCtlStatPrePayment();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void frmStatChargeAccout_Load(object sender, EventArgs e)
        {

        }
    }
}