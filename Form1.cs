using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class Form1 : Form
    {
        readonly int diameter = 28;
        readonly List<Circle> circles = new List<Circle>();
        readonly int k;

        public Form1(int k)
        {
            this.k = k;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void DrawEllipse(PaintEventArgs e, int x, int y, int diameter)
        {
            // method to draw one circle with border black
            Pen blackPen = new Pen(Color.Black, 1);
            e.Graphics.DrawEllipse(blackPen, x, y, diameter, diameter);
        }

        private void FillEllipse(PaintEventArgs e, int x, int y, int diameter)
        {
            // method to fill one circle with fill color blue
            Brush brush = new SolidBrush(Color.FromArgb(255, 25, 25, 255));
            e.Graphics.FillEllipse(brush, x * diameter, y * diameter, diameter, diameter);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // draw 1000 circles
            for (int i = 1; i < 22; i++)
            {
                for (int j = 0; circles.Count() < 1000 && (j * diameter) + diameter < Screen.FromControl(this).Bounds.Width; j++)
                {
                    circles.Add(new Circle(j, i, diameter));
                    DrawEllipse(e, j * diameter, i * diameter, diameter);
                }
            }
            double time = 200 / Convert.ToDouble(k) * 1000;
            this.Text = $"Workers Available: {k}   |   Estimated Time: {time}";
            StartPaintingCircles(e);
        }

        private void StartPaintingCircles(PaintEventArgs e)
        {
            // paint/fill 1000 circles
            foreach (var circle in circles)
            {
                FillEllipse(e, circle.x, circle.y, circle.diameter);
                Thread.Sleep(200 / k);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
