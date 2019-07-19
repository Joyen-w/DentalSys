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
using System.Collections.Generic;
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

    }
}
