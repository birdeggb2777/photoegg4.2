﻿using System;
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
    public partial class OilPaintForm : Form
    {
        Form1 form1;
        public OilPaintForm(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            OilPaint();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            OilPaint();
        }
        private void OilPaint()
        {
            form1.value_int_1 = trackBar1.Value;
            form1.value_double_1 = (double)(trackBar2.Value) / 10;        
            form1.oilPaint(true);
        }
    }
}
