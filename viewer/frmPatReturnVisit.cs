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
    public partial class frmPatReturnVisit : frmBase
    {
        public frmPatReturnVisit()
        {
            InitializeComponent();
        }

        private void frmPatReturnVisit_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmPatReivew frm = new frmPatReivew();
            frm.ShowDialog();
        }
    }
}