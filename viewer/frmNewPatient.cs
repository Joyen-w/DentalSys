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
    public partial class frmNewPatient : frmBase
    {
        public frmNewPatient()
        {
            InitializeComponent();
        }

        private void frmNewPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPatNoRule_Click(object sender, EventArgs e)
        {
            frmPaitentNoRule frm = new frmPaitentNoRule();
            frm.Show();
        }

        private void btnPatSource_Click(object sender, EventArgs e)
        {
            frmPatSource frm = new frmPatSource();
            frm.Show();
        }
    }
}