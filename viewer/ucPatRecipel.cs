﻿using System;
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
    public partial class ucPatRecipel : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPatRecipel()
        {
            InitializeComponent();
        }

        static int i = 1;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmCureConsultInfo frm = new frmCureConsultInfo();
            frm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ucPatRecipelItem uc = new ucPatRecipelItem();
            uc.Name = "uc" + i;

            uc.Location = new Point(ucPatCureItem21.Location.X, ucPatCureItem21.Location.Y + (ucPatCureItem21.Height * i));

            this.panelControl6.Controls.Add(uc);
            this.labelControl4.Location = new Point(labelControl4.Location.X, uc.Location.Y + uc.Height + 5);
            this.labelControl5.Location = new Point(labelControl5.Location.X, uc.Location.Y + uc.Height + 5);
            i++;

            this.panelControl1.Height = this.panelControl6.Height;
        }

        private void ucPatCureItem_Load(object sender, EventArgs e)
        {
            this.panelControl1.Height = this.panelControl6.Height;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmCureCharge frm = new frmCureCharge();
            frm.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmCureInsert frm = new frmCureInsert();
            frm.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frmPatReivew frm = new frmPatReivew();
            frm.ShowDialog();
        }
    }
}
