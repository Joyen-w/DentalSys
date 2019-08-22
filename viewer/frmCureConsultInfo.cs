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
    public partial class frmCureConsultInfo : frmBase
    {
        public frmCureConsultInfo()
        {
            InitializeComponent();
        }

        #region 方法

        private void textBoxNewLine(TextBox txbox)
        {
            int t = getline(txbox);
            Graphics g = txbox.CreateGraphics();
            SizeF ss = g.MeasureString("测试", txbox.Font);
            int h = (int)ss.Height + 3;
            if (t <= 5)
            {
                txbox.Height = t * h;
                txbox.ScrollBars = ScrollBars.None;
            }
            else
            {
                txbox.Height = 5 * h;
                txbox.ScrollBars = ScrollBars.Vertical;
            }
        }
        private int getline(TextBox txbox)
        {
            Graphics g = txbox.CreateGraphics();
            int lines = 0;
            foreach (string s in txbox.Lines)
            {
                SizeF ss = g.MeasureString(s, txbox.Font);
                lines += ((int)ss.Width / txbox.Width + 1);
            }

            return lines;
        }
        #endregion

        #region 事件
        private void frmConsultInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxNewLine(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxNewLine(textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBoxNewLine(textBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBoxNewLine(textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBoxNewLine(textBox5);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBoxNewLine(textBox6);
        }
        #endregion


    }
}