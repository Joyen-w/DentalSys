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
    public partial class ucPatList : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPatList()
        {
            InitializeComponent();
            this.panelControl3.Visible = false;
        }

        private void panelControl4_MouseHover(object sender, EventArgs e)
        {
            this.panelControl3.Visible = true;
        }

        private void labelControl6_MouseHover(object sender, EventArgs e)
        {
            this.panelControl3.Visible = true;
        }

        private void panelControl1_MouseLeave(object sender, EventArgs e)
        {
            this.panelControl3.Visible = false;
        }
    }
}
