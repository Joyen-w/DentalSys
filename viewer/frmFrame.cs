using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Taskbar;
using DevExpress.XtraSplashScreen;
using DevExpress.Skins;
using DevExpress.Utils.Colors;
using DevExpress.XtraEditors.ColorWheel;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Helpers;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace DentalSys
{
    /// <summary>
    /// Frame Form
    /// </summary>
    public partial class frmFrame : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frmFrame()
        {
            InitializeComponent();
            InitSkinGallery();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
        }
        #endregion

        #region 变量.属性

        #endregion

        #region 方法



        #region SkinGallery
        void InitSkinGallery()
        {
            //DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        #endregion

        #endregion

        #region 事件

        private void frmFrame_Load(object sender, EventArgs e)
        {
            ribbonControl.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = ribbonControl;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.defaultLookAndFeel.LookAndFeel.StyleChanged += new EventHandler(LookAndFeel_StyleChanged);
            GlobalParm.SkinName = this.defaultLookAndFeel.LookAndFeel.SkinName;
        }

        private void LookAndFeel_StyleChanged(object sender, EventArgs e)
        {
            if (GlobalParm.IsOpenForm || GlobalParm.SkinName == this.defaultLookAndFeel.LookAndFeel.SkinName)
            {
                return;
            }
            GlobalParm.SkinName = this.defaultLookAndFeel.LookAndFeel.SkinName;
        }

        private void bbiExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi001_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm1 frm01 = new frm1();
            frm01.MdiParent = this;
            frm01.Show();
        }

        private void bbi002_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm2 frm02 = new frm2();
            frm02.MdiParent = this;
            frm02.Show();
        }

        #endregion

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            usCtlPatCureRecord usControl = new usCtlPatCureRecord();
            usControl.Dock = DockStyle.None;
            usControl.labelControl3.Text = "黄河之水天上来，奔流到海不复回！";
            usCtlPatRegInfo usCtl = new usCtlPatRegInfo();

            frmPatInfo frm = new frmPatInfo();
            frm.MdiParent = this;
            frm.navBarGroupControlContainer8.Controls.Add(usControl);
            frm.navBarGroupControlContainer9.Controls.Add(usCtl);
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatEmrInfo frm = new frmPatEmrInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatCureRecords frm = new frmPatCureRecords();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatChargeRecords frm = new frmPatChargeRecords();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatPacsInfo frm = new frmPatPacsInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatOutProcess frm = new frmPatOutProcess();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatReturnConsult frm = new frmPatReturnConsult();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatConsultInfo frm = new frmPatConsultInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatCommunicate frm = new frmPatCommunicate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStatBusiness frm = new frmStatBusiness();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStatChargeAccout frm = new frmStatChargeAccout();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStaffPerformance frm = new frmStaffPerformance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStatOutProcess frm = new frmStatOutProcess();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStoreMgtCurrentTotal frm = new frmStoreMgtCurrentTotal();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
