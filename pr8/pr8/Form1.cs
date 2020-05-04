using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void one()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            Pen a = new Pen(Color.Black, 1); ;
            Pen b = new Pen(Color.Red, 2);
            Font drawFont = new Font("Arial", 9);
            Font signatureFont = new Font("Arial", 7);
            SolidBrush drawBrash = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            int sizeWidth = Form1.ActiveForm.Width;
            int sizeHeight = Form1.ActiveForm.Height;
            Point center = new Point(((int)(sizeWidth / 2) - 8), (int)((sizeHeight / 2) - 19));

            g.DrawLine(a, 10, center.Y, center.X, center.Y);
            g.DrawLine(a, center.X, center.Y, 2 * center.X - 10, center.Y);
            g.DrawLine(a, center.X, 10, center.X, 2 * center.Y - 10);
            g.DrawLine(a, center.X, center.Y, center.X, 2 * center.Y - 10);

            g.DrawString("X", drawFont, drawBrash, new PointF(2 * center.X - 20, center.Y + 10), drawFormat);
            g.DrawString("Y", drawFont, drawBrash, new PointF(center.X + 10, 5), drawFormat);
            g.DrawString("0", drawFont, drawBrash, new PointF(center.X - 10, center.Y + 1), drawFormat);

            g.DrawLine(a, center.X, 5, center.X + 5, 20);
            g.DrawLine(a, center.X, 5, center.X - 5, 20);
            g.DrawLine(a, 2 * center.X - 5, center.Y, 2 * center.X - 20, center.Y - 5);
            g.DrawLine(a, 2 * center.X - 5, center.Y, 2 * center.X - 20, center.Y + 5);



            int stepForAxes = 25;
            int lenghtShtrih = 2;
            int maxValueForAxesX = 16;
            int maxValueForAxesY = 12;

            float oneDivX = (float)maxValueForAxesX / ((float)center.X / (float)stepForAxes);
            float oneDivY = (float)maxValueForAxesY / ((float)center.Y / (float)stepForAxes);

            for (int i = center.X, j = center.X, k = 1; i < 2 * center.X - 30; j -= stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, i, center.Y - lenghtShtrih, i, center.Y + lenghtShtrih);
                g.DrawLine(a, j, center.Y - lenghtShtrih, j, center.Y + lenghtShtrih);

                if(i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDivX).ToString("0.0"), signatureFont, drawBrash, new Point(i + stepForAxes - 5, center.Y + 6), drawFormat);
                    g.DrawString(("- " + (k * oneDivX).ToString("0.0")), signatureFont, drawBrash, new Point(j + stepForAxes - 60, center.Y + 6), drawFormat);
                }
            }
            for (int i = center.Y, j = center.Y, k = 1; i < 2 * center.Y - 30; j -= stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, center.X - lenghtShtrih, i, center.X + lenghtShtrih, i);
                g.DrawLine(a, center.X - lenghtShtrih, j, center.X + lenghtShtrih, j);
                if (i < 2 * center.Y - 55)
                {
                    g.DrawString((k * oneDivY).ToString("0.0"), signatureFont, drawBrash, new Point(center.X - 25, j + stepForAxes - 60), drawFormat);
                    g.DrawString(("- " + (k * oneDivY).ToString("0.0")), signatureFont, drawBrash, new Point(center.X - 25, i + stepForAxes - 5), drawFormat);
                }
            }



            int numOfPoint = 100;
            float[] first = new float[numOfPoint];
            for(int i = 0; i < numOfPoint; i++)
            {
                first[i] = (float)maxValueForAxesX / (float)numOfPoint * (i + 1) - 6;
            }
            float[] second = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                second[i] = (float)(Math.Pow(Math.E, first[i] / 2) * Math.Sin(2 * first[i]));
            }

            Point[] pointOne = new Point[numOfPoint];
            float tempX = 1 / oneDivX * stepForAxes;
            float tempY = 1 / oneDivY * stepForAxes;
            for (int i = 0; i < numOfPoint; i++)
            {
                pointOne[i].X = center.X + (int)(first[i] * tempX);
                pointOne[i].Y = center.Y - (int)(second[i] * tempY);
            }

            g.DrawCurve(b, pointOne);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            one();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            one();
        }
    }
}
