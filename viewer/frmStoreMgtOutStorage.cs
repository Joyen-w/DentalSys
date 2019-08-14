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
    public partial class frmStoreMgtOutStorage : frmBase
    {
        public frmStoreMgtOutStorage()
        {
            InitializeComponent();
        }

        private void frmStoreMgtOutStorage_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ucStoreMgtOutOrder usCtl = new ucStoreMgtOutOrder();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ucStoreMgtOutDetail usCtl = new ucStoreMgtOutDetail();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ucStoreMgtOutStat usCtl = new ucStoreMgtOutStat();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }
    }
}