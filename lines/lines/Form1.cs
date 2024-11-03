using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lines
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics g = null;

        static int center_x, center_y;//store the centre of our canvas
        static int start_x, start_y;
        static int end_x, end_y;

        static int my_angle = 0;
        static int my_length = 0;
        static int my_increment = 0;
        static int num_lines = 0;              
        public Form1()
        {
            InitializeComponent();
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }
                
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawLine(Graphics graphics);
        }
        private void DrawLine()
        {
            Point[] points =
            {
                new Point(start_x, start_y),
                new Point(start_x + 100, start_y + 100)
            };

            g.DrawLines(myPen, points);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            my_length = Int32.Parse(length.Text);
            my_increment = Int32.Parse(increment.Text);
            my_angle = Int32.Parse(angle.Text);

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;


            canvas.Refresh();
            drawLine();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
