﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalSys
{
    public partial class ucPatEmrFirstVisit : UserControl
    {
        public ucPatEmrFirstVisit()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmPatEmrInfo frm = new frmPatEmrInfo();
            frm.ShowDialog();
        }
    }
}
