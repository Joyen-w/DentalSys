namespace DentalSys
{
    partial class frmPaitentNoRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaitentNoRule));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton19 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcBase)).BeginInit();
            this.pcBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBase
            // 
            this.pcBase.Controls.Add(this.simpleButton6);
            this.pcBase.Controls.Add(this.simpleButton5);
            this.pcBase.Controls.Add(this.labelControl1);
            this.pcBase.Controls.Add(this.radioGroup1);
            this.pcBase.Controls.Add(this.panelControl1);
            this.pcBase.Size = new System.Drawing.Size(562, 353);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton19);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(558, 35);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton19
            // 
            this.simpleButton19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton19.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.simpleButton19.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton19.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton19.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.simpleButton19.Appearance.Options.UseBackColor = true;
            this.simpleButton19.Appearance.Options.UseBorderColor = true;
            this.simpleButton19.Appearance.Options.UseFont = true;
            this.simpleButton19.Appearance.Options.UseForeColor = true;
            this.simpleButton19.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton19.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton19.Image")));
            this.simpleButton19.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton19.Location = new System.Drawing.Point(529, 3);
            this.simpleButton19.Name = "simpleButton19";
            this.simpleButton19.Size = new System.Drawing.Size(26, 27);
            this.simpleButton19.TabIndex = 78;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(189, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 23);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "病历号规则设置";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroup1.Location = new System.Drawing.Point(2, 37);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "年月+3位流水号  （示例 14年11月：1411001、1411002、WH1411003）"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "年月+2位流水号  （示例 14年11月27日：14112701、WH14112701）"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "年月日+3位流水号（示例 14年11月27日：141127001、WH141127001）"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "流水号自由递增  （示例 000001、000002、WH000001）"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "自己填写病历号  （系统交不产生病历号，默认全部为临时患者）")});
            this.radioGroup1.Size = new System.Drawing.Size(558, 242);
            this.radioGroup1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 285);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(255, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "*注：WH表示病历号前缀，登记时系统自动记忆";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.Location = new System.Drawing.Point(264, 310);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(111, 31);
            this.simpleButton6.TabIndex = 57;
            this.simpleButton6.Text = "取消";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.Cursor = System.Windows.Forms.Cursors.Default;
            this.simpleButton5.Location = new System.Drawing.Point(134, 310);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(111, 31);
            this.simpleButton5.TabIndex = 56;
            this.simpleButton5.Text = "确定";
            // 
            // frmPaitentNoRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 353);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaitentNoRule";
            this.Text = "frmPaitentNoRule";
            ((System.ComponentModel.ISupportInitialize)(this.pcBase)).EndInit();
            this.pcBase.ResumeLayout(false);
            this.pcBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton19;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}