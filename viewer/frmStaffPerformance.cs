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
    public partial class frmStaffPerformance : frmBase
    {
        public frmStaffPerformance()
        {
            InitializeComponent();
        }

        private void frmStaffPerformance_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            usCtlStaffChargeClassify usCtl = new usCtlStaffChargeClassify();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            usCtlStaffNurseCharge usCtl = new usCtlStaffNurseCharge();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            usCtlStaffItemCharge usCtl = new usCtlStaffItemCharge();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            usCtlStaffConsultPerformance usCtl = new usCtlStaffConsultPerformance();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }
    }
}