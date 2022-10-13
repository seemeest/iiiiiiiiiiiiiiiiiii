
    using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iiiiiiiiiiiiiiiiiii
{

    public class GetGra
    {

        public void GetGray(ref Bitmap bitmap, int start, int end)
        {


            for (int i = 0; i < bitmap.Height; i++)
                for (int j = start; j < end - 1; j++)
                {
                    Debug.Print("Поток номер " + System.Threading.Thread.CurrentThread.ManagedThreadId.ToString() + " i=" + i + " j=" + j);
                    var pixel = bitmap.GetPixel(j, i);
                    int RGB = (pixel.R + pixel.G + pixel.B) / 3;
                    bitmap.SetPixel(j, i, Color.FromArgb(pixel.A, RGB, RGB, RGB));
                }


            SystemInfo.Workedout++;

            Thread.CurrentThread.Abort();
        }
    }
        public static  class setGrays
        {
        public static void GetGray(this Bitmap bitmap)
        {

            //Parallel.Invoke( () =>
            //{
            //    for (int i = 0; i < bitmap.Height/5; i++)
            //    {
            //        for (int j = 0; j < bitmap.Width ; j++)
            //        {

            //            var pixel = bitmap.GetPixel(j, i);
            //            int RGB = (pixel.R + pixel.G + pixel.B) / 3;
            //            bitmap.SetPixel(j, i, Color.FromArgb(pixel.A, RGB, RGB, RGB));
            //        }
            //    }
            //},


            //);


            //for (int i = 0; i < bitmap.Height; i++)
            //    for (int j = 0; j < bitmap.Width; j++)
            //    {

            //        var pixel = bitmap.GetPixel(j, i);
            //        int RGB = (pixel.R + pixel.G + pixel.B) / 3;
            //        bitmap.SetPixel(j, i, Color.FromArgb(pixel.A, RGB, RGB, RGB));
            //    }

            Random random = new Random();
            for (int i = 0; i < bitmap.Height; i++)
                for (int j = 0; j < bitmap.Width; j++)
                {

                    var pixel = bitmap.GetPixel(j, i);
                    if ( pixel.G < 70 || pixel.B < 70 || pixel.R < 70)
                    {
                        bitmap.SetPixel(j, i, Color.FromArgb(pixel.A, random.Next(255), random.Next(255), random.Next(255)));
                    }
                    else
                    {
                        continue;
                    }


                }



        }
        }




    }


  
