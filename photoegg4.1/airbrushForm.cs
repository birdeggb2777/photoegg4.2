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
    public partial class airbrushForm : Form
    {
        Form1 form1;
        public airbrushForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) form1.value_bool_1 = true;
            else form1.value_bool_1 = false;
            form1.value_int_1 = trackBar1.Value;
            form1.airbrush(true);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) form1.value_bool_1 = true;
            else form1.value_bool_1 = false;
            form1.value_int_1 = trackBar1.Value;
            form1.airbrush(true);
        }
        public bool define = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            define = true;
            this.Close();
        }
    }
}
