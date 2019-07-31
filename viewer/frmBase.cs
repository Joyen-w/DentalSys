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
    public partial class frmBase : Form
    {
        public frmBase()
        {
            GlobalParm.IsOpenForm = true;
            InitializeComponent();           
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            this.defaultLookAndFeel.LookAndFeel.SkinName = GlobalParm.SkinName;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(GlobalParm.SkinName);
            GlobalParm.IsOpenForm = false;
        }
    }
}
