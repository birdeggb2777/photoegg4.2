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
using photoegg4._1.Properties;
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
            ScanningLine, airbrush, kaleidoscope, contrast, BrightnessContrast, brightness2, allFlip, rgbNormal, oilPaint2,
            blurry2, sharp, ColorPencil, glassBlurry
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
                /* for (int i = 15; i >0; i-=7)
                 {
                     value_int_1 = i;
                     Pixel_Operate(colorFunction.mosaic);
                 }*/
                // BitmapResize(originBitmap[Now_Bitmap],5);
                // BitmapResize(originBitmap[Now_Bitmap], 0.2);
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
        private void 輸出圖片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Png Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "輸出圖片";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originBitmap[originBitmap.Count - 1].Save(saveFileDialog1.FileName);
            }
        }
        public void Pixel_Operate(colorFunction fun)
        {
            int func = (int)fun;
            open_temp_perate = false;
            Bitmap MyNewBmp = (Bitmap)originBitmap[Now_Bitmap];
            if (func == (int)colorFunction.oilPaint2) { BitmapResize(MyNewBmp, value_double_1); }
            if (func == (int)colorFunction.oilPaint2) { BitmapResize(MyNewBmp, value_double_2); }
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
                else if (func == (int)colorFunction.brightness2)
                    Pixel_C.brightness2((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_double_1);
                else if (func == (int)colorFunction.blurry)
                    Pixel_C.blurry3((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.HSV)
                    Pixel_C.ConvertHSV((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, value_int_1, value_int_2, value_int_3, 4, value_bool_1, value_int_4);
                else if (func == (int)colorFunction.pasteImage)
                    Pixel_C.pasteImage((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, MyNewBmp2.Width, MyNewBmp2.Height, 300, 300, 4);
                else if (func == (int)colorFunction.emboss)
                    Pixel_C.emboss((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2, value_bool_1);
                else if (func == (int)colorFunction.mosaic)
                    Pixel_C.mosaic((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.horizontalFlip)
                    Pixel_C.horizontalFlip((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.allFlip)
                    Pixel_C.AllFlip((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.verticalFlip)
                    Pixel_C.verticalFlip((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.tile)
                    Pixel_C.tile((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2);
                else if (func == (int)colorFunction.ToneSeparation)
                    Pixel_C.ToneSeparation((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.Overexposed)
                    Pixel_C.Overexposed((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.oilPaint)
                    Pixel_C.oilpaint((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_double_1);
                else if (func == (int)colorFunction.ColorNoise)
                    Pixel_C.ColorNoise((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_double_1);
                else if (func == (int)colorFunction.Binarization)
                    Pixel_C.Binarization((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.ScanningLine)
                    Pixel_C.ScanningLine((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2);
                else if (func == (int)colorFunction.airbrush)
                    Pixel_C.airbrush((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_bool_1, value_int_1);
                else if (func == (int)colorFunction.kaleidoscope)
                    Pixel_C.kaleidoscope((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                else if (func == (int)colorFunction.contrast)
                    Pixel_C.contrast((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 50);
                else if (func == (int)colorFunction.BrightnessContrast)
                    Pixel_C.BrightnessContrast((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2);
                else if (func == (int)colorFunction.rgbNormal)
                    Pixel_C.rgbNormal((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2, value_int_3);
                else if (func == (int)colorFunction.oilPaint2)
                    Pixel_C.ToneSeparation((byte*)MyBmpData.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.sharp)
                    Pixel_C.sharp((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                else if (func == (int)colorFunction.ColorPencil)
                    Pixel_C.sharp((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, 5);
                else if (func == (int)colorFunction.glassBlurry)
                    Pixel_C.mosaic((byte*)MyBmpData.Scan0, (byte*)MyBmpData2.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
            }
            MyNewBmp.UnlockBits(MyBmpData);
            MyNewBmp2.UnlockBits(MyBmpData2);
            /*if (func == (int)colorFunction.glassBlurry)
            {
                Bitmap MyNewBmp_ = (Bitmap)MyNewBmp.Clone();
                for (int i = value_int_1; i > 0; i -= value_int_2)
                {
                    Bitmap MyNewBmp1_ = (Bitmap)MyNewBmp_.Clone();
                    Bitmap MyNewBmp2_ = (Bitmap)MyNewBmp_.Clone();
                    BitmapData MyBmpData1_ = MyNewBmp1_.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    BitmapData MyBmpData2_ = MyNewBmp2_.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    try
                    {
                        unsafe
                        {
                            Pixel_C.mosaic((byte*)MyBmpData3_.Scan0, (byte*)MyBmpData2_.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, i);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("ERROR：程式內部發生錯誤");
                    }
                    MyNewBmp2_.UnlockBits(MyBmpData2_);
                    MyNewBmp1_.UnlockBits(MyBmpData1_);
                    MyNewBmp_ = (Bitmap)TempBmp_.Clone();
                    MyNewBmp2_.Dispose();
                    TempBmp_.Dispose();
                }
                TempBmp = (Bitmap)MyNewBmp_.Clone();
            }*/
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
            if (func == (int)colorFunction.oilPaint2) { BitmapResize(TempBmp, value_double_1); }
            if (func == (int)colorFunction.oilPaint2) { BitmapResize(TempBmp, value_double_2); }
            Rectangle MyRec = new Rectangle(0, 0, MyNewBmp.Width, MyNewBmp.Height);
            //BitmapData MyBmpData = MyNewBmp.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData MyBmpData2 = MyNewBmp2.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData MyBmpData3 = TempBmp.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            try
            {
                unsafe
                {
                    if (func == (int)colorFunction.colorTo255)
                        Pixel_C.colorTo255((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                    else if (func == (int)colorFunction.colorToGray)
                        Pixel_C.colorToGray((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4);
                    else if (func == (int)colorFunction.brightness)
                        Pixel_C.brightness((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                    else if (func == (int)colorFunction.brightness2)
                        Pixel_C.brightness2((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_double_1);
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
                    else if (func == (int)colorFunction.rgbNormal)
                        Pixel_C.rgbNormal((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1, value_int_2, value_int_3);
                    else if (func == (int)colorFunction.oilPaint2)
                        Pixel_C.ToneSeparation((byte*)MyBmpData3.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, value_int_1);
                    //else if (func == (int)colorFunction.glassBlurry)
                    //   ;

                }
            }
            catch
            {
                MessageBox.Show("ERROR：程式內部發生錯誤");
            }
            //MyNewBmp.UnlockBits(MyBmpData);
            MyNewBmp2.UnlockBits(MyBmpData2);
            TempBmp.UnlockBits(MyBmpData3);
            if (func == (int)colorFunction.glassBlurry)
            {
                Bitmap MyNewBmp_ = (Bitmap)MyNewBmp.Clone();
                for (int i = value_int_1; i > 0; i -= value_int_2)
                {
                    Bitmap MyNewBmp2_ = (Bitmap)MyNewBmp_.Clone();
                    Bitmap TempBmp_ = (Bitmap)MyNewBmp_.Clone();
                    BitmapData MyBmpData2_ = MyNewBmp2_.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    BitmapData MyBmpData3_ = TempBmp_.LockBits(MyRec, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    try
                    {
                        unsafe
                        {
                            Pixel_C.mosaic((byte*)MyBmpData3_.Scan0, (byte*)MyBmpData2_.Scan0, MyNewBmp.Width, MyNewBmp.Height, 4, i);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("ERROR：程式內部發生錯誤");
                    }
                    MyNewBmp2_.UnlockBits(MyBmpData2_);
                    TempBmp_.UnlockBits(MyBmpData3_);
                    MyNewBmp_ = (Bitmap)TempBmp_.Clone();
                    MyNewBmp2_.Dispose();
                    TempBmp_.Dispose();
                }
                TempBmp = (Bitmap)MyNewBmp_.Clone();
            }

            if (check != true)
                pictureBox1.Image = TempBmp;
            else
                TimerBitmap = (Bitmap)TempBmp.Clone();
            open_temp_perate = true;

            //tempOperate = colorFunction.NULL;
        }

        private void BitmapResize(Bitmap b, double size = 0.5)
        {
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //g.Clear(Color.Transparent);
            g.DrawImage(b, new Rectangle(0, 0, (int)(b.Width * size), (int)(b.Height * size)), new Rectangle(0, 0, b.Width, b.Height), GraphicsUnit.Pixel);
        }
        private void flipX()
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.horizontalFlip);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }
        private void AllFlip()
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.allFlip);
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
        public void glassBlurry(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.glassBlurry);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.glassBlurry);
            }
        }
        public void RGBNormal(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.rgbNormal);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.rgbNormal);
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
        private void 反向ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.colorTo255);
            pictureBox1.Image = originBitmap[Now_Bitmap];
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
        public void brightness2(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.brightness2);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.brightness2);
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
        public void oilPaint2(bool istemp)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            if (istemp == false)
            {
                Pixel_Operate(colorFunction.oilPaint2);
                pictureBox1.Image = originBitmap[Now_Bitmap];
            }
            else
            {
                Pixel_Operate_Temp(colorFunction.oilPaint2);
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
            form.ShowDialog();
            if (form.define == false)
            {
                value_int_1 = 0;
                blurry(true);
            }
            else blurry(false);
            form.Dispose();
        }

        private void HSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSVForm form = new HSVForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else HSV(false);
            form.Dispose();
        }

        private void 浮雕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            embossForm form = new embossForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else emboss(false);
            form.Dispose();
        }

        private void 馬賽克ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mosaicForm form = new mosaicForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else mosaic(false);
            form.Dispose();
        }

        private void 磁磚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tileForm form = new tileForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else tile(false);
            form.Dispose();
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
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else ToneSeparation(false);
            form.Dispose();
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
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else ColorNoise(false);
            form.Dispose();
        }

        private void 油畫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            OilPaintForm form = new OilPaintForm(this);
            form.ShowDialog();
            if (form.define == false)
            {
                value_int_1 = 1;
                value_double_1 = 0.5;
                oilPaint(true);
            }
            else oilPaint(false);
            form.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Bitmap a = new Bitmap(Resources.house);
            originBitmap.Add(a);
            pictureBox1.Image = a;
            Now_Bitmap++;
            // value_double_1 = 2;
            // brightness2(false);
            //AllFlip();
            // flipX();
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
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else Binarization(false);
            form.Dispose();
        }

        private void 掃描線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            ScanningLineForm form = new ScanningLineForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else ScanningLine(false);
            form.Dispose();
        }

        private void 噴槍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            airbrushForm form = new airbrushForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else airbrush(false);
            form.Dispose();
        }

        private void 亮度對比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            BrightnessContrastForm form = new BrightnessContrastForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else BrightnessContrast(false);
            form.Dispose();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap a = new Bitmap(Clipboard.GetImage());
                originBitmap.Add(a);
                pictureBox1.Image = a;
                Now_Bitmap++;
            }
            catch
            {
                MessageBox.Show("貼上圖片失敗，請確認剪貼簿中是否有圖片");
            }
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetImage(originBitmap[Now_Bitmap]);
            }
            catch
            {
                MessageBox.Show("複製圖片失敗，請確認影像有被正確開啟");
            }
        }

        private void 明暗度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            brightness2Form form = new brightness2Form(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else brightness2(false);
            form.Dispose();
        }

        private void 旋轉180度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllFlip();
        }

        private void RGB色彩調整ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            rgbNormalForm form = new rgbNormalForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else RGBNormal(false);
            form.Dispose();
        }
        /*
        private void 倍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitmapResize(originBitmap[Now_Bitmap],0.5);
            BitmapResize(originBitmap[Now_Bitmap], 2);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 倍ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BitmapResize(originBitmap[Now_Bitmap], 0.25);
            BitmapResize(originBitmap[Now_Bitmap], 4);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 倍ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BitmapResize(originBitmap[Now_Bitmap], 0.1);
            BitmapResize(originBitmap[Now_Bitmap], 10);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 倍ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BitmapResize(originBitmap[Now_Bitmap], 0.05);
            BitmapResize(originBitmap[Now_Bitmap], 20);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 倍ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BitmapResize(originBitmap[Now_Bitmap], 0.02);
            BitmapResize(originBitmap[Now_Bitmap], 50);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }
        */
        private void 高效油畫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            OilPaintForm2 form = new OilPaintForm2(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else oilPaint2(false);
            form.Dispose();
            /* BitmapResize(originBitmap[Now_Bitmap], 0.1);

             BitmapResize(originBitmap[Now_Bitmap],10);
             value_int_1 = 65;
             ToneSeparation(false);*/
        }

        private void 高效模糊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            blurryForm2 form = new blurryForm2(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else oilPaint2(false);
            form.Dispose();
        }

        private void 色鉛筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.ColorPencil);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 銳利化ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            value_int_1 = 1;
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.sharp);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 更銳利化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            value_int_1 = 2;
            if (open_temp_perate == false) return;
            if (Now_Bitmap < 0) return;
            open_temp_perate = false;
            Pixel_Operate(colorFunction.sharp);
            pictureBox1.Image = originBitmap[Now_Bitmap];
        }

        private void 玻璃模糊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTimerValue();
            glassBlurryForm form = new glassBlurryForm(this);
            form.ShowDialog();
            if (form.define == false) pictureBox1.Image = originBitmap[Now_Bitmap];
            else
            {
                for (var i = value_int_1; i > 0; i -= value_int_2)
                {
                    value_int_1 = i;
                    glassBlurry(false);
                }
             }
            form.Dispose();
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
