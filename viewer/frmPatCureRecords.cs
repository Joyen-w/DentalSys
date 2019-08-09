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
    public partial class frmPatCureRecords : frmPatInfoBse
    {
        public frmPatCureRecords()
        {
            InitializeComponent();
        }

        private void frmCureRecords_Load(object sender, EventArgs e)
        {
            usCtlPatCureItem usCtrl1 = new usCtlPatCureItem();
            usCtlPatCureItem usCtrl = new usCtlPatCureItem();

            usCtrl1.Location = new Point(usCtrl.Location.X, usCtrl.Location.Y + usCtrl.Height + 5);
            this.panelControl4.Controls.AddRange(new Control[] {   usCtrl, usCtrl1 });
        }
    }
}