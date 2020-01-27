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

        private void form_Load(object sender, EventArgs e)
        => Size = new Size(StartPadding + (CellCount - 2) * CellSize, StartPadding + CellCount * CellSize + 3);

        readonly int RefreshRate = 144; //use 60 if your screen is 60hz
        readonly int StartPadding = 40; //dont change this

        //Mouse information
        Point MousePos = new Point(0, 0);
        bool ClickedMouse = false;

        //Cell information
        int CellCount = 60;
        int CellSize = 10;
        List<Point> AliveCells = new List<Point>();


        protected override async void OnPaint(PaintEventArgs e)
        {
            var StartTime = DateTime.Now;
            int MaxNumber = StartPadding / CellSize;
            for (int i = 0; i < CellCount + 1; i++) //draw the grid
            {
                e.Graphics.DrawLine(Pens.Black, i * CellSize, StartPadding, i * CellSize, CellCount * CellSize);
                if (i >= MaxNumber) //we dont want to draw for the first StartPadding pixels due to it containing buttons and such
                    e.Graphics.DrawLine(Pens.Black, 0, i * CellSize, CellCount * CellSize, i * CellSize);
            }

            int CellX = (MousePos.X - StartPadding) / CellSize;
            int CellY = (MousePos.Y - StartPadding) / CellSize;

            foreach (var point in AliveCells) //draw filled rectangles of alive cells
                e.Graphics.FillRectangle(Brushes.Black, new RectangleF(point.X * CellSize + StartPadding, point.Y * CellSize + StartPadding, CellSize, CellSize));


            //check if hypothetical cell is within actual grid and not for example at the buttons
            if (CellX >= -MaxNumber && CellY >= 0 && CellX < CellCount - MaxNumber && CellY < CellCount - MaxNumber)
            {
                if (ClickedMouse)
                {
                    var point = new Point(CellX, CellY);
                    if (AliveCells.Contains(point))
                        AliveCells.Remove(point);
                    else
                        AliveCells.Add(point);
                    ClickedMouse = false;
                }
                //Show mouse hover as gray
                e.Graphics.FillRectangle(Brushes.Gray, new RectangleF(CellX * CellSize + StartPadding, CellY * CellSize + StartPadding, CellSize, CellSize));
            }


            //refresh accordingly
            await Task.Delay(Math.Max(1000 / RefreshRate - (int)(DateTime.Now - StartTime).TotalMilliseconds, 0));
            this.Invalidate();
            base.OnPaint(e);
        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        => MousePos = new Point(e.X, e.Y);

        private void CellNumeric_ValueChanged(object sender, EventArgs e)
        {
            CellCount = (int)CellNumeric.Value;
            Size = new Size(StartPadding + (CellCount - 2) * CellSize, StartPadding + CellCount * CellSize + 3);
        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        => ClickedMouse = true;

    }
}
