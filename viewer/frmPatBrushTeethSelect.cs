﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DentalSys.viewer
{
    public partial class frmPatBrushTeethSelect : frmBase
    {
        public frmPatBrushTeethSelect()
        {
            InitializeComponent();
        }

        private void frmBrushTeethSelect_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
