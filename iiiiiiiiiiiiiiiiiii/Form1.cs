using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AForge.Video;
using AForge.Video.DirectShow;

namespace iiiiiiiiiiiiiiiiiii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         videoDevise = new FilterInfoCollection(FilterCategory.VideoInputDevice);
          videoCaptureDevice = new VideoCaptureDevice(videoDevise[0].MonikerString);

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
         //setGrays= new setGrays();

        }
        //  setGrays setGrays;
        Image img;

        Graphics g;
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {


            
                      bitmap = new Bitmap(eventArgs.Frame, 250 , 500);

            //  bitmap.ParallelForGrey();
          bitmap.GetGray();
           
            bitmap = new Bitmap(bitmap, new Size(this.Width, this.Height)); 
            img = bitmap;
            
           // img.RotateFlip(RotateFlipType.Rotate180FlipY);
           
            pictureBox1.Image = img;
            
          
        }

        public static Bitmap bitmap;

        static  FilterInfoCollection videoDevise = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        static VideoCaptureDevice videoCaptureDevice = new VideoCaptureDevice(videoDevise[0].MonikerString);

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
