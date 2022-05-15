using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multithreading_separated_tasks
{
    public partial class Form1 : Form
    {
        int MaxPrimeNumber = 0;
        int FibonacciNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void PrimeNumbersButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < MaxPrimeNumber + 1; i++)
                {
                    if (IsPrime(i))
                    {
                        PrimeTextBox.Invoke((MethodInvoker)delegate { PrimeTextBox.Text += (Environment.NewLine + i); });
                    }
                }
            });
        }


        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private long CalculateFibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
            }
        }

        private void PrimesDropdown_ValueChanged(object sender, EventArgs e)
        {
            MaxPrimeNumber = Int32.Parse(PrimesDropdown.Value.ToString());
        }

        private void FibonacciDropdown_ValueChanged(object sender, EventArgs e)
        {
            FibonacciNumber = Int32.Parse(FibonacciDropdown.Value.ToString());
        }

        private void FibonacciButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                long number = CalculateFibonacci(FibonacciNumber);
                Invoke((MethodInvoker)delegate { FibonacciTextBox.Text += (Environment.NewLine + number); });
            });
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Random random = new Random();
                for (int i = 0; i < 100; i++)
                {
                    DrawPanel
                    .CreateGraphics()
                    .DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(random.Next(0, DrawPanel.Width), random.Next(0, DrawPanel.Height), 5,5));
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
