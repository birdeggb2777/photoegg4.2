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
    public partial class brightness2Form : Form
    {
        Form1 form1;
        public brightness2Form(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            form1.value_double_1 = 0 + ((double)((trackBar1.Value)-10) / 10);
            form1.brightness2(true);
        }
        public bool define = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            define = true;
            this.Close();
        }
    }
}
