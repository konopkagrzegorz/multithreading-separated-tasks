namespace multithreading_separated_tasks
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrimeNumbersButton = new System.Windows.Forms.Button();
            this.FibonacciButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.PrimeTextBox = new System.Windows.Forms.RichTextBox();
            this.FibonacciTextBox = new System.Windows.Forms.RichTextBox();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.PrimesDropdown = new System.Windows.Forms.NumericUpDown();
            this.FibonacciDropdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PrimesDropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FibonacciDropdown)).BeginInit();
            this.SuspendLayout();
            // 
            // PrimeNumbersButton
            // 
            this.PrimeNumbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrimeNumbersButton.Location = new System.Drawing.Point(12, 12);
            this.PrimeNumbersButton.Name = "PrimeNumbersButton";
            this.PrimeNumbersButton.Size = new System.Drawing.Size(220, 70);
            this.PrimeNumbersButton.TabIndex = 0;
            this.PrimeNumbersButton.Text = "Wyznacz liczby pierwsze";
            this.PrimeNumbersButton.UseVisualStyleBackColor = true;
            this.PrimeNumbersButton.Click += new System.EventHandler(this.PrimeNumbersButton_Click);
            // 
            // FibonacciButton
            // 
            this.FibonacciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FibonacciButton.Location = new System.Drawing.Point(269, 12);
            this.FibonacciButton.Name = "FibonacciButton";
            this.FibonacciButton.Size = new System.Drawing.Size(220, 70);
            this.FibonacciButton.TabIndex = 1;
            this.FibonacciButton.Text = "Oblicz \"n\" wyraz ciągu Fibonacci\'ego";
            this.FibonacciButton.UseVisualStyleBackColor = true;
            this.FibonacciButton.Click += new System.EventHandler(this.FibonacciButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrawButton.Location = new System.Drawing.Point(521, 12);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(220, 70);
            this.DrawButton.TabIndex = 2;
            this.DrawButton.Text = "Rysuj";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // PrimeTextBox
            // 
            this.PrimeTextBox.Location = new System.Drawing.Point(12, 136);
            this.PrimeTextBox.Name = "PrimeTextBox";
            this.PrimeTextBox.Size = new System.Drawing.Size(220, 313);
            this.PrimeTextBox.TabIndex = 3;
            this.PrimeTextBox.Text = "";
            // 
            // FibonacciTextBox
            // 
            this.FibonacciTextBox.Location = new System.Drawing.Point(269, 136);
            this.FibonacciTextBox.Name = "FibonacciTextBox";
            this.FibonacciTextBox.Size = new System.Drawing.Size(220, 313);
            this.FibonacciTextBox.TabIndex = 4;
            this.FibonacciTextBox.Text = "";
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(521, 98);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(220, 351);
            this.DrawPanel.TabIndex = 5;
            // 
            // PrimesDropdown
            // 
            this.PrimesDropdown.Location = new System.Drawing.Point(112, 98);
            this.PrimesDropdown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PrimesDropdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrimesDropdown.Name = "PrimesDropdown";
            this.PrimesDropdown.Size = new System.Drawing.Size(120, 20);
            this.PrimesDropdown.TabIndex = 6;
            this.PrimesDropdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PrimesDropdown.ValueChanged += new System.EventHandler(this.PrimesDropdown_ValueChanged);
            // 
            // FibonacciDropdown
            // 
            this.FibonacciDropdown.Location = new System.Drawing.Point(369, 98);
            this.FibonacciDropdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FibonacciDropdown.Name = "FibonacciDropdown";
            this.FibonacciDropdown.Size = new System.Drawing.Size(120, 20);
            this.FibonacciDropdown.TabIndex = 7;
            this.FibonacciDropdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FibonacciDropdown.ValueChanged += new System.EventHandler(this.FibonacciDropdown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 461);
            this.Controls.Add(this.FibonacciDropdown);
            this.Controls.Add(this.PrimesDropdown);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.FibonacciTextBox);
            this.Controls.Add(this.PrimeTextBox);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.FibonacciButton);
            this.Controls.Add(this.PrimeNumbersButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PrimesDropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FibonacciDropdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrimeNumbersButton;
        private System.Windows.Forms.Button FibonacciButton;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.RichTextBox PrimeTextBox;
        private System.Windows.Forms.RichTextBox FibonacciTextBox;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.NumericUpDown PrimesDropdown;
        private System.Windows.Forms.NumericUpDown FibonacciDropdown;
    }
}

