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
    public partial class frmStoreMgtCurrentTotal : frmBase
    {
        public frmStoreMgtCurrentTotal()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            usCtlStoreMgtCurrentTotal usCtl = new usCtlStoreMgtCurrentTotal();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            usCtlStoreMgtCurrentQuery usCtl = new usCtlStoreMgtCurrentQuery();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            usCtlStoreMgtCurrentDetail usCtl = new usCtlStoreMgtCurrentDetail();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }
    }
}