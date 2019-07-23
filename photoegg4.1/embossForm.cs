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
    public partial class embossForm : Form
    {
        Form1 form1;
        public embossForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        private void emboss()
        {
            int tra1 = trackBar1.Value;
            int tra2 = trackBar2.Value;
            if (tra2 == 0)
            {
                form1.value_int_1 = tra1;
                form1.value_int_2 = 0;
            }
            if (tra2 == 1)
            {
                form1.value_int_1 = tra1;
                form1.value_int_2 = tra1;
            }
            if (tra2 == 2)
            {
                form1.value_int_1 = 0;
                form1.value_int_2 = tra1;
            }
            if (tra2 == 3)
            {
                form1.value_int_1 = -tra1;
                form1.value_int_2 = tra1;
            }
            if (tra2 == 4)
            {
                form1.value_int_1 = -tra1;
                form1.value_int_2 = 0;
            }
            if (tra2 == 5)
            {
                form1.value_int_1 = -tra1;
                form1.value_int_2 = -tra1;
            }
            if (tra2 == 6)
            {
                form1.value_int_1 = 0;
                form1.value_int_2 = -tra1;
            }
            if (tra2 == 7)
            {
                form1.value_int_1 = tra1;
                form1.value_int_2 = -tra1;
            }
            form1.value_bool_1 = checkBox1.Checked;
            form1.emboss(true);
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            emboss();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            emboss();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            emboss();
        }
        public bool define = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            define = true;
            this.Close(); 
        }
    }
}
