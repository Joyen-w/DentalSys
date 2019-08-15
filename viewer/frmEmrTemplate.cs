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
    public partial class frmEmrTemplate : frmBase
    {
        public frmEmrTemplate()
        {
            InitializeComponent();
        }

        private void frmEmrTemplate_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            ucEmrTemplate ucEmr = new ucEmrTemplate();
            ucEmr.Dock = DockStyle.Fill;
            this.panelControl4.Controls.Clear();
            this.panelControl4.Controls.Add(ucEmr);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            ucMainHpiPh uc = new ucMainHpiPh();
            uc.Dock = DockStyle.Fill;
            this.panelControl4.Controls.Clear();
            this.panelControl4.Controls.Add(uc);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            ucInspectCheck uc = new ucInspectCheck();
            uc.Dock = DockStyle.Fill;
            this.panelControl4.Controls.Clear();
            this.panelControl4.Controls.Add(uc);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            ucDiagnose uc = new ucDiagnose();
            uc.Dock = DockStyle.Fill;
            this.panelControl4.Controls.Clear();
            this.panelControl4.Controls.Add(uc);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            ucRecipelProject uc = new ucRecipelProject();
            uc.Dock = DockStyle.Fill;
            this.panelControl4.Controls.Clear();
            this.panelControl4.Controls.Add(uc);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            ucOrderAdvice uc = new ucOrderAdvice();
            uc.Dock = DockStyle.Fill;
            this.panelControl4.Controls.Clear();
            this.panelControl4.Controls.Add(uc);
        }
    }
}