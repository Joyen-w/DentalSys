using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalSys
{
    public partial class frm1 : frmBase
    {
        public frm1()
        {
            InitializeComponent();            
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.panelControl3.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.panelControl2.Visible = false;
        }
    }
}
