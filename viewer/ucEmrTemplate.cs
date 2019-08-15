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
    public partial class ucEmrTemplate : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEmrTemplate()
        {
            InitializeComponent();
        }

        private void vGridControl1_SizeChanged(object sender, EventArgs e)
        {
            int recordWidth = (vGridControl1.Width - vGridControl1.RowHeaderWidth);
            vGridControl1.RecordWidth = recordWidth - 4;
        }
    }
}
