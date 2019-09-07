using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoegg4._1
{
    public partial class rgbNormalForm : Form
    {
        Form1 form1;
        public rgbNormalForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        public bool define = false;

        private void Button1_Click(object sender, EventArgs e)
        {
            define = true;
            this.Close();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            SetValue();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            SetValue();
        }

        private void RgbNormalForm_Load(object sender, EventArgs e)
        {
           
        }
        public void SetValue()
        {
            form1.value_int_1 =trackBar1.Value;
            form1.value_int_2 = trackBar2.Value;
            form1.value_int_3 = trackBar3.Value;
            form1.RGBNormal(true);
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            SetValue();
        }
    }
}
