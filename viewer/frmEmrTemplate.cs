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
            this.simpleButton13.Visible = false;
            this.simpleButton6.Text = "编辑";
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string str = simpleButton6.Text;
            if (str == "编辑")
            {
                simpleButton6.Text = "确定";
                this.simpleButton13.Visible = true;
            }
            else
            {
                simpleButton6.Text = "编辑";
                this.simpleButton13.Visible = false;
            }
               
        }
    }
}