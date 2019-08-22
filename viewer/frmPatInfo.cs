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
    public partial class frmPatInfo : frmPatInfoBse
    {
        public frmPatInfo()
        {
            InitializeComponent();
        }

        private void frmPatInfo_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (this.simpleButton6.Text == "修改信息")
            {
                this.navBarControl3.Visible = false;
                this.ucPatInfo1.Visible = true;
                this.simpleButton6.Text = "确定";
                this.simpleButton8.Text = "取消";
                this.simpleButton9.Visible = true;
            }
            else
            {
                this.navBarControl3.Visible = true;
                this.ucPatInfo1.Visible = false;
                this.simpleButton9.Visible = false; ;
                this.simpleButton6.Text = "修改信息";
                this.simpleButton8.Text = "病历首页打印";
            }
        }
    }
}
