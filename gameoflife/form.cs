using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameoflife
{
    public partial class form : Form
    {

        public form()
        {
            InitializeComponent();
        }

        float MouseX = 0.0f;
        float MouseY = 0.0f;
        int RefreshRate = 144; //use 60 if your screen is 60hz

        int CellCount = 60;
        int CellSize = 10;
        int StartPadding = 30;
        private void form_Load(object sender, EventArgs e)
        {

        }


        protected override async void OnPaint(PaintEventArgs e)
        {
            var StartTime = DateTime.Now;

            for (int i = StartPadding / CellSize; i < CellCount; i++)
            {
                e.Graphics.DrawLine(Pens.Black, i * CellSize, StartPadding, i * CellSize, CellCount * CellSize);
                e.Graphics.DrawLine(Pens.Black, StartPadding, i * CellSize, CellCount * CellSize, i * CellSize);
            }

            e.Graphics.FillRectangle(Brushes.Red, new RectangleF(MouseX - 2.5f, MouseY - 2.5f, 5, 5));

            await Task.Delay(Math.Max(1000 / RefreshRate - (int)(DateTime.Now - StartTime).TotalMilliseconds, 0));
            this.Invalidate();
            base.OnPaint(e);
        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            MouseX = (float)e.X;
            MouseY = (float)e.Y;
        }
    }
}
