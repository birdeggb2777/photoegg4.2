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
    public partial class ScanningLineForm : Form
    {
        Form1 form1;
        public ScanningLineForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        private void ScanningLine()
        {
            if (checkBox1.Checked==true&& checkBox2.Checked == true)form1.value_int_1 = 2;
            else if (checkBox1.Checked == true) form1.value_int_1 = 0;
            else if (checkBox2.Checked == true) form1.value_int_1 = 1;
            else form1.value_int_1 =3;
            form1.value_int_2 = trackBar1.Value;
            form1.ScanningLine(true);
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            ScanningLine();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ScanningLine();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            ScanningLine();
        }
        public bool define = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            define = true;
            this.Close();
        }
    }
}
