namespace gameoflife
{
    partial class form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CellNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CellNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // CellNumeric
            // 
            this.CellNumeric.Location = new System.Drawing.Point(264, 7);
            this.CellNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CellNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CellNumeric.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.CellNumeric.Name = "CellNumeric";
            this.CellNumeric.Size = new System.Drawing.Size(62, 25);
            this.CellNumeric.TabIndex = 0;
            this.CellNumeric.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.CellNumeric.ValueChanged += new System.EventHandler(this.CellNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cell Count";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CellNumeric);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form";
            this.ShowIcon = false;
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.form_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CellNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CellNumeric;
        private System.Windows.Forms.Label label1;
    }
}

