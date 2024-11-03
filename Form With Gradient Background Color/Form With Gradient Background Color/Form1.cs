using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Form_With_Gradient_Background_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 55, 173, 1), 1);

            Rectangle area = new Rectangle(0,0,this.Width -1, this.Height -1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 55, 173), Color.FromArgb(245, 51, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}