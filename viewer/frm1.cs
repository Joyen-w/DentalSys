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
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new SqlHelper(EnumBiz.onlineDB).HospitalInfo().Hospitalname);
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int t = getline();
            Graphics g = this.textBox1.CreateGraphics();
            SizeF ss = g.MeasureString("测试", this.textBox1.Font);
            int h = (int)ss.Height + 3;
            if (t <= 5)
            {
                this.textBox1.Height = t * h;
                this.textBox1.ScrollBars = ScrollBars.None;
            }
            else
            {
                this.textBox1.Height = 5 * h;
                this.textBox1.ScrollBars = ScrollBars.Vertical;
            }
        }
        private int getline()
        {
            Graphics g = this.textBox1.CreateGraphics();
            int lines = 0;
            foreach (string s in this.textBox1.Lines)
            {
                SizeF ss = g.MeasureString(s, this.textBox1.Font);
                lines += ((int)ss.Width / this.textBox1.Width + 1);
            }

            return lines;
        }
      
    }
}
