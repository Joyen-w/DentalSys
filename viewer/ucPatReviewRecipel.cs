using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DentalSys
{
    public partial class ucPatReviewRecipel : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPatReviewRecipel()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmCureConsultInfo frm = new frmCureConsultInfo();
            frm.ShowDialog();
        }


    }
}
