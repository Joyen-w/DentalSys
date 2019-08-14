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
    public partial class frmStoreMgtInventory :frmBase
    {
        public frmStoreMgtInventory()
        {
            InitializeComponent();
        }

        private void frmStoreMgtInventory_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ucStoreMgtInventoryFirst usCtl = new ucStoreMgtInventoryFirst();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ucStoreMgtInventoryLoss usCtl = new ucStoreMgtInventoryLoss();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ucStoreMgtInventoryOverage usCtl = new ucStoreMgtInventoryOverage();
            usCtl.Dock = DockStyle.Fill;
            this.panelControl3.Controls.Clear();
            this.panelControl3.Controls.Add(usCtl);
        }
    }
}