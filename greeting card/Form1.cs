using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace greeting_card
{
    public partial class frontPage : Form
    {
        public frontPage()
        {
            InitializeComponent();
        }

        private void frontPage_Click(object sender, EventArgs e)
        {
            //making front page click anywhere to begin
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString("Constellations", drawFont, drawBrush, 100, 40);
            Thread.Sleep(500);
            g.DrawString("By Aizlea Sharp", drawFont, drawBrush, 90, 160);
            Thread.Sleep(1000);
            g.Clear(Color.MediumTurquoise);

            //Constellations (pen, x, y, width, height) 
            
            g.FillEllipse(drawBrush, 62, 95, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 62, 122, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 47, 128, 10, 10);
            Thread.Sleep(500);        
            g.FillEllipse(drawBrush, 44, 142, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 107, 120, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 146, 111, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 116, 63, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 170, 17, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 85, 205, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 93, 173, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 124, 167, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 135, 177, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 161, 192, 10, 10);
            Thread.Sleep(500);

            //lines 
            Pen drawPen = new Pen(Color.White, 4);
            g.DrawLine(drawPen, 66, 98, 66, 125);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 66, 125, 51, 131);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 51, 131, 48, 146);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 66, 98, 111, 124);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 111, 124, 150, 115);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 66, 98, 120, 67);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 120, 67, 174, 21);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 48, 146, 89, 209);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 89, 209, 97, 177);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 97, 177, 128, 171);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 128, 171, 139, 181);
            Thread.Sleep(500);
            g.DrawLine(drawPen, 139, 181, 165, 196);
            Thread.Sleep(500);

            //words on the right 
            drawBrush.Color = Color.White;
            g.DrawString("aquarius", drawFont, drawBrush, 200, 40);
            Thread.Sleep(500);
            g.DrawString("It is a constellation for the month of January.", drawFont, drawBrush, 150, 100);
            Thread.Sleep(500);
            g.DrawString("It's name is Latin for water-carrier", drawFont, drawBrush, 150, 150);
            Thread.Sleep(500);

        }
    }
}
