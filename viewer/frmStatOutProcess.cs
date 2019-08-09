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
    public partial class frmStatOutProcess : frmBase
    {
        public frmStatOutProcess()
        {
            InitializeComponent();
        }

        private void frmStatOutProcess_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            usCtlOutProcessDetail usCtl = new usCtlOutProcessDetail();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            usCtlOutProcessType usCtl = new usCtlOutProcessType();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }
    }
}