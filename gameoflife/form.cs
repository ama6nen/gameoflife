using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

            int CellX = MousePos.X / CellSize;
            int CellY = (MousePos.Y - StartPadding) / CellSize;

            foreach (var point in AliveCells) //draw filled rectangles of alive cells
                e.Graphics.FillRectangle(Brushes.Black, new RectangleF(point.X * CellSize, point.Y * CellSize + StartPadding, CellSize, CellSize));

            //check if hypothetical cell is within actual grid and not for example at the buttons
            if (CellX >= -MaxNumber && CellY >= 0 && CellX < CellCount && CellY < CellCount - MaxNumber)
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
                e.Graphics.FillRectangle(Brushes.Gray, new RectangleF(CellX * CellSize, CellY * CellSize + StartPadding, CellSize, CellSize));
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

        //inefficient algorithm, but it will do for small games with no notable performance loss
        int GetAliveNeighborCount(int x, int y)
        {
            int count = 0;

            for (int a = -1; a <= 1; a++) //basically check if any of the 8 close neighbors are alive
            {
                for (int b = -1; b <= 1; b++)
                {
                    if (a == 0 && b == 0)
                        continue;

                    if (AliveCells.Contains(new Point(x + a, y + b)))
                        count++;
                }
            }
            return count;
        }

        int Generation = 0;
        void Step()
        {
            int MaxNumber = StartPadding / CellSize;
            var NewAliveCells = new List<Point>();
            for (int x = 0; x < CellCount; x++)
            {
                for (int y = 0; y < CellCount - MaxNumber; y++)
                {
                    int neighbors = GetAliveNeighborCount(x, y);
                    if (AliveCells.Contains(new Point(x, y))) //basically check if cell is alive
                    {
                        //dont let overpopulated or underpopulated cells go into next gneeration
                        if (neighbors == 2 || neighbors == 3)
                            NewAliveCells.Add(new Point(x, y));
                    }
                    else if (neighbors == 3) //if a cell is dead and has 3 neighbors, it is "born"
                        NewAliveCells.Add(new Point(x, y));
                }
            }
            AliveCells = NewAliveCells;
            Generation++;
            this.Text = "Game of Life - Generation: " + Generation;
        }
        private void StepButton_Click(object sender, EventArgs e)
        => Step();

        private void GOFTimer_Tick(object sender, EventArgs e)
        => Step();

        private void ToggleGOF_Click(object sender, EventArgs e)
        {
            if (ToggleGOF.Text == "Start")
            {
                GOFTimer.Start();
                ToggleGOF.Text = "Stop";
            }
            else
            {
                GOFTimer.Stop();
                ToggleGOF.Text = "Start";
            }
        }

        private void Delay_ValueChanged(object sender, EventArgs e)
        => GOFTimer.Interval = (int)Delay.Value;

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AliveCells.Clear();
            Generation = 0;
        }

        private void SaveConfiguration_Click(object sender, EventArgs e)
        {
            if(SaveDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new FileStream(SaveDialog.FileName, FileMode.OpenOrCreate);
                var writer = new BinaryWriter(stream);

                foreach(var point in AliveCells)
                {
                    writer.Write(point.X);
                    writer.Write(point.Y);
                }
                writer.Close();
                stream.Close();
            }
        }

        private void LoadConfiguration_Click(object sender, EventArgs e)
        {
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                AliveCells.Clear();
                var stream = new FileStream(OpenDialog.FileName, FileMode.Open);
                var reader = new BinaryReader(stream);

                while (stream.Position < stream.Length && stream.CanRead)
                {
                    var x = reader.ReadInt32();
                    var y = reader.ReadInt32();
                    AliveCells.Add(new Point(x, y));
                }

                reader.Close();
                stream.Close();
            }
        }
    }
}
