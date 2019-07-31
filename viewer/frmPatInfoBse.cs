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

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            frmNewPatient frm = new frmNewPatient();
            frm.ShowDialog();
        }
    }
}