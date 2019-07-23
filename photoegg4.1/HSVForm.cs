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
    public partial class HSVForm : Form
    {
        Form1 form1;
        public HSVForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        void View()
        {
            form1.value_int_1 = trackBar1.Value;
            form1.value_int_2 = trackBar2.Value;
            form1.value_int_3 = trackBar3.Value;
            form1.value_int_4 = trackBar4.Value;
            form1.value_bool_1 = checkBox1.Checked;
            form1.HSV(true);
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            View();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            View();
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            View();
        }

        private void TrackBar4_Scroll(object sender, EventArgs e)
        {
            View();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            View();
        }
        public bool define=false;
        private void Button1_Click(object sender, EventArgs e)
        {
            define = true;
            this.Close();
        }
    }
}
