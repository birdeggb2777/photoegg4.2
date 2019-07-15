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
    public partial class BinarizationForm : Form
    {
        Form1 form1;
        public BinarizationForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            form1.value_int_1 = trackBar1.Value;
            form1.Binarization(true);
        }

        private void BinarizationForm_Load(object sender, EventArgs e)
        {
            form1.value_int_1 = trackBar1.Value;
            form1.Binarization(true);
        }
    }
}
