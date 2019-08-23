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
    public partial class frmCureCharge : frmBase
    {
        public frmCureCharge()
        {
            InitializeComponent();
        }

        private void frmCureCharge_Load(object sender, EventArgs e)
        {
            ucQueryDate uc = new ucQueryDate();
            uc.Name = "uc";
            uc.Dock = DockStyle.Fill;
            this.repositoryItemPopupContainerEdit1.PopupControl.Controls.Add(uc);
        }
    }
}