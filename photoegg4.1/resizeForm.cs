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
    public partial class resizeForm : Form
    {
        Form1 form1;
        public resizeForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        public bool define = false;
        public double tra1=1;
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            //form1.value_int_1 = trackBar1.Value;
            if (trackBar1.Value >= 0) tra1 = 1+(double)trackBar1.Value / 20;
            else tra1 = (21-(-(double)trackBar1.Value)) / 20;
            form1.TempBitmapResize(form1.originBitmap[form1.Now_Bitmap], tra1);
           // form1.value_double_1 = (double)(trackBar2.Value) / 10;
           // form1.oilPaint(true);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            define = true;
            this.Close();
        }
    }
}
