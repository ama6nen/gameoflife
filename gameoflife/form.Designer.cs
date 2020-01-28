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
            this.components = new System.ComponentModel.Container();
            this.CellNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.StepButton = new System.Windows.Forms.Button();
            this.GOFTimer = new System.Windows.Forms.Timer(this.components);
            this.ToggleGOF = new System.Windows.Forms.Button();
            this.Delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveConfiguration = new System.Windows.Forms.Button();
            this.LoadConfiguration = new System.Windows.Forms.Button();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CellNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // CellNumeric
            // 
            this.CellNumeric.Location = new System.Drawing.Point(468, 7);
            this.CellNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CellNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CellNumeric.Minimum = new decimal(new int[] {
            60,
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
            this.label1.Location = new System.Drawing.Point(536, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cell Count";
            // 
            // StepButton
            // 
            this.StepButton.Location = new System.Drawing.Point(68, 5);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(50, 25);
            this.StepButton.TabIndex = 2;
            this.StepButton.Text = "Step";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // GOFTimer
            // 
            this.GOFTimer.Tick += new System.EventHandler(this.GOFTimer_Tick);
            // 
            // ToggleGOF
            // 
            this.ToggleGOF.Location = new System.Drawing.Point(12, 5);
            this.ToggleGOF.Name = "ToggleGOF";
            this.ToggleGOF.Size = new System.Drawing.Size(50, 25);
            this.ToggleGOF.TabIndex = 3;
            this.ToggleGOF.Text = "Start";
            this.ToggleGOF.UseVisualStyleBackColor = true;
            this.ToggleGOF.Click += new System.EventHandler(this.ToggleGOF_Click);
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(345, 7);
            this.Delay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Delay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(62, 25);
            this.Delay.TabIndex = 5;
            this.Delay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Delay.ValueChanged += new System.EventHandler(this.Delay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delay";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(124, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(48, 25);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveConfiguration
            // 
            this.SaveConfiguration.Location = new System.Drawing.Point(209, 5);
            this.SaveConfiguration.Name = "SaveConfiguration";
            this.SaveConfiguration.Size = new System.Drawing.Size(62, 25);
            this.SaveConfiguration.TabIndex = 8;
            this.SaveConfiguration.Text = "Save";
            this.SaveConfiguration.UseVisualStyleBackColor = true;
            this.SaveConfiguration.Click += new System.EventHandler(this.SaveConfiguration_Click);
            // 
            // LoadConfiguration
            // 
            this.LoadConfiguration.Location = new System.Drawing.Point(277, 5);
            this.LoadConfiguration.Name = "LoadConfiguration";
            this.LoadConfiguration.Size = new System.Drawing.Size(62, 25);
            this.LoadConfiguration.TabIndex = 9;
            this.LoadConfiguration.Text = "Load";
            this.LoadConfiguration.UseVisualStyleBackColor = true;
            this.LoadConfiguration.Click += new System.EventHandler(this.LoadConfiguration_Click);
            // 
            // SaveDialog
            // 
            this.SaveDialog.Filter = "Game of Life files|*.gof";
            this.SaveDialog.Title = "Save Configuration";
            // 
            // OpenDialog
            // 
            this.OpenDialog.Filter = "Game of Life files|*.gof";
            this.OpenDialog.Title = "Load configuration";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 444);
            this.Controls.Add(this.LoadConfiguration);
            this.Controls.Add(this.SaveConfiguration);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.ToggleGOF);
            this.Controls.Add(this.StepButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CellNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Timer GOFTimer;
        private System.Windows.Forms.Button ToggleGOF;
        private System.Windows.Forms.NumericUpDown Delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveConfiguration;
        private System.Windows.Forms.Button LoadConfiguration;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
    }
}

