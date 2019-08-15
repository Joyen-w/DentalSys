namespace DentalSys
{
    partial class frmVipUpgrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVipUpgrade));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ucQueryText1 = new DentalSys.ucQueryText();
            this.ucQueryDate1 = new DentalSys.ucQueryDate();
            ((System.ComponentModel.ISupportInitialize)(this.pcBase)).BeginInit();
            this.pcBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBase
            // 
            this.pcBase.Controls.Add(this.panelControl3);
            this.pcBase.Size = new System.Drawing.Size(1036, 539);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ucQueryText1);
            this.panelControl3.Controls.Add(this.ucQueryDate1);
            this.panelControl3.Controls.Add(this.comboBoxEdit1);
            this.panelControl3.Controls.Add(this.simpleButton13);
            this.panelControl3.Controls.Add(this.simpleButton12);
            this.panelControl3.Controls.Add(this.simpleButton5);
            this.panelControl3.Controls.Add(this.simpleButton6);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1032, 105);
            this.panelControl3.TabIndex = 4;
            // 
            // simpleButton13
            // 
            this.simpleButton13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton13.Appearance.Options.UseFont = true;
            this.simpleButton13.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.Image")));
            this.simpleButton13.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton13.Location = new System.Drawing.Point(803, 7);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(75, 26);
            this.simpleButton13.TabIndex = 37;
            this.simpleButton13.ToolTip = "确定";
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton12.Appearance.Options.UseFont = true;
            this.simpleButton12.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton12.Location = new System.Drawing.Point(629, 6);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(75, 26);
            this.simpleButton12.TabIndex = 36;
            this.simpleButton12.Text = "医嘱";
            this.simpleButton12.ToolTip = "修改";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton5.Location = new System.Drawing.Point(884, 7);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 26);
            this.simpleButton5.TabIndex = 30;
            this.simpleButton5.ToolTip = "取消";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.Image")));
            this.simpleButton6.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton6.Location = new System.Drawing.Point(722, 7);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 26);
            this.simpleButton6.TabIndex = 29;
            this.simpleButton6.ToolTip = "编辑";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "患者信息";
            this.comboBoxEdit1.Location = new System.Drawing.Point(10, 12);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "患者信息",
            "就诊日期"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 26);
            this.comboBoxEdit1.TabIndex = 38;
            // 
            // ucQueryText1
            // 
            this.ucQueryText1.Location = new System.Drawing.Point(116, 10);
            this.ucQueryText1.Name = "ucQueryText1";
            this.ucQueryText1.Size = new System.Drawing.Size(208, 32);
            this.ucQueryText1.TabIndex = 47;
            // 
            // ucQueryDate1
            // 
            this.ucQueryDate1.Location = new System.Drawing.Point(116, 10);
            this.ucQueryDate1.Name = "ucQueryDate1";
            this.ucQueryDate1.Size = new System.Drawing.Size(256, 33);
            this.ucQueryDate1.TabIndex = 46;
            // 
            // frmVipUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 539);
            this.Name = "frmVipUpgrade";
            this.Text = "会员升级";
            this.Load += new System.EventHandler(this.frmVipUpgrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBase)).EndInit();
            this.pcBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton13;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private ucQueryDate ucQueryDate1;
        private ucQueryText ucQueryText1;
    }
}