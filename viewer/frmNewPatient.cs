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
            frm.ShowDialog() ;
        }

        private void btnPatSource_Click(object sender, EventArgs e)
        {
            frmPatSource frm = new frmPatSource();
            frm.ShowDialog();
        }

        private void btnPatVip_Click(object sender, EventArgs e)
        {
            frmPatVip frm = new frmPatVip();
            frm.ShowDialog();
        }

        private void btnPatAddress_Click(object sender, EventArgs e)
        {
            frmPatAddress frm = new frmPatAddress();
            frm.ShowDialog();
        }

        private void btnPatAllergies_Click(object sender, EventArgs e)
        {
            frmPatAllergies frm = new frmPatAllergies();
            frm.ShowDialog();
        }

        private void btnPatMedicalHistory_Click(object sender, EventArgs e)
        {
            frmPatMedicalHistory frm = new frmPatMedicalHistory();
            frm.ShowDialog();
            
        }

        private void btnImpression_Click(object sender, EventArgs e)
        {
            frmPatImpression frm = new frmPatImpression();
            frm.ShowDialog();
        }

        private void btnPatNationality_Click(object sender, EventArgs e)
        {
            frmPatNationality frm = new frmPatNationality();
            frm.ShowDialog();
        }

        private void btnPatBrushTeeth_Click(object sender, EventArgs e)
        {
            frmPatBrushTeeth frm = new frmPatBrushTeeth();
            frm.ShowDialog();
        }

        private void btnPatClassify_Click(object sender, EventArgs e)
        {
            frmPatClassify frm = new frmPatClassify();
            frm.ShowDialog();
        }

    }
}