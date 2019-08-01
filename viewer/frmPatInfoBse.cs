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
    public partial class frmPatInfoBse : frmBase
    {
        public frmPatInfoBse()
        {
            InitializeComponent();
        }

        private void frmPatInfoBse_Load(object sender, EventArgs e)
        {
            usCtlPatInfo us = new usCtlPatInfo();
            usCtlPatInfo us1 = new usCtlPatInfo();
            us1.Location = new Point(us.Location.X,us.Location.Y + 75);
            //this.navBarGroupControlContainer4.Height = us.Height + us1.Height + 75;
            this.navBarGroupControlContainer4.Controls.AddRange(new Control[] { us, us1 });
            //this.panelControl4.Controls.AddRange(new Control[] { us,us1});
          
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            frmNewPatient frm = new frmNewPatient();
            frm.ShowDialog();
        }
    }
}