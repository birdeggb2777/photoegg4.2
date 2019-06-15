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
    public partial class tileForm : Form
    {
        Form1 form1;
        public tileForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        private void tile()
        {
            form1.value_int_1 = trackBar1.Value;
            form1.value_int_2 = trackBar2.Value;
            form1.tile(true);
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            tile();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            tile();
        }
    }
}
