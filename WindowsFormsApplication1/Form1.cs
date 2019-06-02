using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point start = new Point(100, 100);
            Point end = new Point(120, 150);

            int deltaX = Math.Abs(end.X - start.X);
            int deltaY = Math.Abs(end.Y - start.Y);
            int x = start.X;
            int y = start.Y;

            int incX = 1;
            int incY = 1;

            if (start.X > end.X)
            {
                incX *= -1;
            }
            else if (start.Y > end.Y)
            {
                incY *= -1;
            }

            int error = deltaX - deltaY;

            while (true)
            {
                PutPixel(x, y);
                if (x == end.X && y == end.Y) break;
                int e2 = 2 * error;
                if (e2 > -deltaY)
                {
                    error -= deltaY;
                    x += incX;
                }
                if (e2 < deltaX)
                {
                    error += deltaX;
                    y += incY;
                }
            }

            // draw circle
            //DrawCircle();
        }

        private void DrawCircle()
        {

            Point center = new Point(100, 100);
            int radius = 50;
            int x = 0;
            int y = radius;

            while (x <= y)
            {
                PutPixel(center.X + x, center.Y + y);
                PutPixel(center.X + x, center.Y - y);
                PutPixel(center.X + y, center.Y + x);
                PutPixel(center.X + y, center.Y - x);

                PutPixel(center.X - x, center.Y + y);
                PutPixel(center.X - x, center.Y - y);
                PutPixel(center.X - y, center.Y + x);
                PutPixel(center.X - y, center.Y - x);

                x++;

                int v1 = Math.Abs(x * x + y * y - radius * radius);
                int v2 = Math.Abs(x * x + (y - 1) * (y - 1) - radius * radius);
                //Console.WriteLine(v1 + ", " + v2);

                if (v1 > v2)
                {
                    y--;
                    //Console.WriteLine();
                }
            }
        }

        List<Point> points = new List<Point>();
        private void PutPixel(int x, int y)
        {
            points.Add(new Point(x, y));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (Point p in points)
                e.Graphics.DrawRectangle(Pens.Black, p.X, p.Y, 1, 1);
        }
    }
}
