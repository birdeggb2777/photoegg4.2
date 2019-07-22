using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using pix;
namespace photoegg4._1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public List<Bitmap> originBitmap = new List<Bitmap>();
        public pixelOperate Pixel_C = new pixelOperate();
        public int Now_Bitmap = -1;

        /// <summary>
        /// 影像操作的參數
        /// </summary>
        public bool open_temp_perate = true;
        public int value_int_1 = 0;
        public int value_int_2 = 0;
        public int value_int_3 = 0;
        public int value_int_4 = 0;
        public int value_int_5 = 0;
        public double value_double_1 = 0;
        public double value_double_2 = 0;
        public double value_double_3 = 0;
        public double value_double_4 = 0;
        public double value_double_5 = 0;
        public bool value_bool_1 = false;
        public bool value_bool_2 = false;
        public bool value_bool_3 = false;
        public bool value_bool_4 = false;
        public bool value_bool_5 = false;

        /// <summary>
        /// 
        /// </summary>
        public bool isTemp = false;
        public enum colorFunction
        {
            NULL, colorTo255, colorToGray, brightness, blurry, HSV, pasteImage, emboss,
            mosaic, horizontalFlip, verticalFlip, tile, ToneSeparation, Overexposed, oilPaint, ColorNoise, Binarization,
            ScanningLine, airbrush, kaleidoscope, contrast, BrightnessContrast
        };
        public colorFunction tempOperate = colorFunction.NULL;
        public Form1()
        {
            InitializeComponent();
        }

        private void 載入圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "圖片檔 (*.png;*.jpg;*.bmp;*.gif;*.tif)|*.png;*.jpg;*.bmp;*.gif;*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap a = new Bitmap(openFileDialog1.FileName);
                originBitmap.Add(a);
                pictureBox1.Image = a;
                Now_Bitmap++;
              //  BrightnessContrast(false);
                //airbrush(false);
                //ScanningLine(false);
                // ColorNoise(false);
                //oilPaint(false);
                /*  System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
                  sw.Reset();//碼表歸零
                  sw.Start();//碼表開始計時
                  value_int_1 = 50;
                blurry(false);
                  //
                  sw.Stop();//碼錶停止
                  MessageBox.Show(sw.Elapsed.TotalMilliseconds.ToString());*/

            }
        }
        public void Pixel_Operate(colorFunction fun)
        {
            int func = (int)fun;
            open_temp_perate = false;
            Bitmap MyNewBmp = (Bitmap)originBitmap[Now_Bitmap];
            Bitmap MyNewBmp2 = (Bitmap)originBitmap[Now_Bitmap].Clone();
            Rectangle MyRec = new Rectangle(0, 0, MyNewBmp.Width, MyNewBmp.Height);
            Rectangle MyRec2 = new Rectangle(0, 0, MyNewBmp2.Width, MyNewBmp2.Height);
            BitmapData MyBmpData = MyNewBmp.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData MyBmpData2 = MyNewBmp2.LockBits(MyRec2, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            unsafe
            {
                if (func == (int)colorFunction.colorTo255)
                    Pixel_C.colorTo255((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.colorToGray)
                    Pixel_C.colorToGray((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.brightness)
                    Pixel_C.brightness((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.blurry)
                    Pixel_C.blurry3((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 30);
                else if (func == (int)colorFunction.HSV)
                    Pixel_C.ConvertHSV((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, value_int_1, value_int_2, value_int_3, 4, value_bool_1, value_int_4);
                else if (func == (int)colorFunction.pasteImage)
                    Pixel_C.pasteImage((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, MyNewBmp2.Width, MyNewBmp2.Height, 300, 300, 4);
                else if (func == (int)colorFunction.emboss)
                    Pixel_C.emboss((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, -5, 5, false);
                else if (func == (int)colorFunction.mosaic)
                    Pixel_C.mosaic((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.horizontalFlip)
                    Pixel_C.horizontalFlip((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.verticalFlip)
                    Pixel_C.verticalFlip((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.tile)
                    Pixel_C.tile((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 20, 10);
                else if (func == (int)colorFunction.ToneSeparation)
                    Pixel_C.ToneSeparation((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 150);
                else if (func == (int)colorFunction.Overexposed)
                    Pixel_C.Overexposed((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.oilPaint)
                    Pixel_C.oilpaint((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 8, 0.5);
                else if (func == (int)colorFunction.ColorNoise)
                    Pixel_C.ColorNoise((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 0.5);
                else if (func == (int)colorFunction.Binarization)
                    Pixel_C.Binarization((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 127);
                else if (func == (int)colorFunction.ScanningLine)
                    Pixel_C.ScanningLine((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 2, 2);
                else if (func == (int)colorFunction.airbrush)
                    Pixel_C.airbrush((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, true, 35);
                else if (func == (int)colorFunction.kaleidoscope)
                    Pixel_C.kaleidoscope((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.contrast)
                    Pixel_C.contrast((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 50);
                else if (func == (int)colorFunction.BrightnessContrast)
                    Pixel_C.BrightnessContrast((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 50, 50);
            }
            MyNewBmp.UnlockBits(MyBmpData);
            MyNewBmp2.UnlockBits(MyBmpData2);
            open_temp_perate = true;
        }
        public void Pixel_Operate_Temp(colorFunction fun)
        {
            bool check = open_temp_perate;
            open_temp_perate = false;
            int func = (int)fun;
            Bitmap MyNewBmp = (Bitmap)originBitmap[Now_Bitmap];
            Bitmap MyNewBmp2 = (Bitmap)MyNewBmp.Clone();
            Bitmap TempBmp = (Bitmap)MyNewBmp.Clone();
            Rectangle MyRec = new Rectangle(0, 0, MyNewBmp.Width, MyNewBmp.Height);
            BitmapData MyBmpData = MyNewBmp.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData MyBmpData2 = MyNewBmp2.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData MyBmpData3 = TempBmp.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            unsafe
            {
                if (func == (int)colorFunction.colorTo255)
                    Pixel_C.colorTo255((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.colorToGray)
                    Pixel_C.colorToGray((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.brightness)
                    Pixel_C.brightness((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.blurry)
                    Pixel_C.blurry3((byte*)MyBmpData3.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.HSV)
                    Pixel_C.ConvertHSV((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, value_int_1, value_int_2, value_int_3, 4, value_bool_1, value_int_4);
                else if (func == (int)colorFunction.emboss)
                    Pixel_C.emboss((byte*)MyBmpData3.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2, value_bool_1);
                else if (func == (int)colorFunction.mosaic)
                    Pixel_C.mosaic((byte*)MyBmpData3.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.tile)
                    Pixel_C.tile((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2);
                else if (func == (int)colorFunction.ToneSeparation)
                    Pixel_C.ToneSeparation((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.oilPaint)
                    Pixel_C.oilpaint((byte*)MyBmpData3.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_double_1);
                else if (func == (int)colorFunction.ColorNoise)
                    Pixel_C.ColorNoise((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_double_1);
                else if (func == (int)colorFunction.Binarization)
                    Pixel_C.Binarization((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.ScanningLine)
                    Pixel_C.ScanningLine((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2);
                else if (func == (int)colorFunction.airbrush)
                    Pixel_C.airbrush((byte*)MyBmpData3.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_bool_1, value_int_1);
                else if (func == (int)colorFunction.BrightnessContrast)
                    Pixel_C.BrightnessContrast((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2);
            }
            MyNewBmp.UnlockBits(MyBmpData);
            MyNewBmp2.UnlockBits(MyBmpData2);
            TempBmp.UnlockBits(MyBmpData3);
            if (check != true)
                pictureBox1.Image = TempBmp;
            else
                TimerBitmap = (Bitmap)TempBmp.Clone();
            open_temp_perate = true;

            //tempOperate = colorFunction.NULL;
        }
        private void 反向ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.colorTo255);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }
        private void flipX()
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.horizontalFlip);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }
        private void flipY()
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.verticalFlip);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }
        public void ScanningLine(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.ScanningLine);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.ScanningLine);
            }
        }
        public void airbrush(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.airbrush);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.airbrush);
            }
        }
        public void Binarization(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.Binarization);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.Binarization);
            }
        }
        public void tile(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.tile);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.tile);
            }
        }
        private void 詼諧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.colorToGray);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }
        private void 萬花筒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.kaleidoscope);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }
        public void mosaic(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.mosaic);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.mosaic);
            }
        }
        public void BrightnessContrast(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.BrightnessContrast);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.BrightnessContrast);
            }
        }
        public void contrast(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.contrast);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.contrast);
            }
        }
        public void brightness(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.brightness);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.brightness);
            }
        }
        public void pasteImage(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.pasteImage);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.pasteImage);
            }
        }
        public void blurry(bool istemp)
        {
            if (Now_Bitmap < 0) return;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.blurry);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                tempOperate = colorFunction.blurry;
                if (open_temp_perate == true)
                {
                    timer_int_1 = value_int_1;
                    Thread thread2 = new Thread(new ThreadStart(TimerOperate));
                    thread2.Start();
                    timer1.Start();
                }

            }
        }
        public void HSV(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.HSV);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.HSV);
            }
        }
        public void emboss(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.emboss);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.emboss);
            }
        }
        public void ToneSeparation(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.ToneSeparation);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.ToneSeparation);
            }
        }
        public void oilPaint(bool istemp)
        {
            if (Now_Bitmap < 0) return;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.oilPaint);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                tempOperate = colorFunction.oilPaint;
                if (open_temp_perate == true)
                {
                    timer_int_1 = value_int_1;
                    timer_double_1 = value_double_1;
                    Thread thread2 = new Thread(new ThreadStart(TimerOperate));
                    thread2.Start();
                    timer1.Start();
                }

            }
        }
        public void ColorNoise(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.ColorNoise);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.ColorNoise);
            }
        }
        private void 亮度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brightnessForm form = new brightnessForm(this);
            form.Show();
        }

        private void 模糊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            blurryForm form = new blurryForm(this);
            form.Show();
        }

        private void HSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSVForm form = new HSVForm(this);
            form.Show();
        }

        private void 浮雕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            embossForm form = new embossForm(this);
            form.Show();
        }

        private void 馬賽克ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mosaicForm form = new mosaicForm(this);
            form.Show();
        }

        private void 磁磚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tileForm form = new tileForm(this);
            form.Show();
        }

        private void 水平翻轉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flipX();
        }

        private void 垂直翻轉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flipY();
        }

        private void 色調分離ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToneSeparationForm form = new ToneSeparationForm(this);
            form.Show();
        }

        private void 曝光過度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Now_Bitmap < 0) return;
            Pixel_Operate(colorFunction.Overexposed);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 彩色雜點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorNoiseForm form = new ColorNoiseForm(this);
            form.Show();
        }

        private void 油畫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            OilPaintForm form = new OilPaintForm(this);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void TimerOperate()
        {
            Pixel_Operate_Temp(tempOperate);
        }
        private bool checkTimerValue()
        {
            if (timer_int_1 != value_int_1) return false;
            if (timer_int_2 != value_int_2) return false;
            if (timer_int_3 != value_int_3) return false;
            if (timer_int_4 != value_int_4) return false;
            if (timer_int_5 != value_int_5) return false;
            if (timer_double_1 != value_double_1) return false;
            if (timer_double_2 != value_double_2) return false;
            if (timer_double_3 != value_double_3) return false;
            if (timer_double_4 != value_double_4) return false;
            if (timer_double_5 != value_double_5) return false;
            if (timer_bool_1 != value_bool_1) return false;
            if (timer_bool_2 != value_bool_2) return false;
            if (timer_bool_3 != value_bool_3) return false;
            if (timer_bool_4 != value_bool_4) return false;
            if (timer_bool_5 != value_bool_5) return false;
            return true;
        }
        private void resetTimerValue()
        {
            timer_int_1 = value_int_1;
            timer_int_2 = value_int_2;
            timer_int_3 = value_int_3;
            timer_int_4 = value_int_4;
            timer_int_5 = value_int_5;
            timer_double_1 = value_double_1;
            timer_double_2 = value_double_2;
            timer_double_3 = value_double_3;
            timer_double_4 = value_double_4;
            timer_double_5 = value_double_5;
            timer_bool_1 = value_bool_1;
            timer_bool_2 = value_bool_2;
            timer_bool_3 = value_bool_3;
            timer_bool_4 = value_bool_4;
            timer_bool_5 = value_bool_5;
        }
        Bitmap TimerBitmap = null;
        public int timer_int_1 = 0;
        public int timer_int_2 = 0;
        public int timer_int_3 = 0;
        public int timer_int_4 = 0;
        public int timer_int_5 = 0;
        public double timer_double_1 = 0;
        public double timer_double_2 = 0;
        public double timer_double_3 = 0;
        public double timer_double_4 = 0;
        public double timer_double_5 = 0;
        public bool timer_bool_1 = false;
        public bool timer_bool_2 = false;
        public bool timer_bool_3 = false;
        public bool timer_bool_4 = false;
        public bool timer_bool_5 = false;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //if (open_temp_perate == false) return;
            if (TimerBitmap != null)
            {
                pictureBox1.Image = TimerBitmap;
                TimerBitmap = null;
                if (checkTimerValue() == false && open_temp_perate == true)
                {
                    resetTimerValue();
                    if (tempOperate == colorFunction.oilPaint) oilPaint(true);
                    if (tempOperate == colorFunction.blurry) blurry(true);
                    //Thread thread2 = new Thread(new ThreadStart(TimerOperate));
                    //thread2.Start();
                }
                else if (checkTimerValue() == true && open_temp_perate == true)
                {
                    tempOperate = colorFunction.NULL;
                    timer1.Stop();
                }
            }
        }

        private void 二值化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            BinarizationForm form = new BinarizationForm(this);
            form.Show();
        }

        private void 掃描線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            ScanningLineForm form = new ScanningLineForm(this);
            form.Show();
        }

        private void 噴槍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            airbrushForm form = new airbrushForm(this);
            form.Show();
        }

        private void 亮度對比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            BrightnessContrastForm form = new BrightnessContrastForm(this);
            form.Show();
        }
    }
}


/* System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
          sw.Reset();//碼表歸零
          sw.Start();//碼表開始計時
                     /////////////////////////*/

///////////////////////////
/*  sw.Stop();//碼錶停止

  MessageBox.Show(sw.Elapsed.TotalMilliseconds.ToString());*/
