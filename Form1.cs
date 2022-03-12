using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrimesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ulong number = ReadAndSanitizeInput(textBoxInput);

            if (number > 1) {
                Primes primes = new Primes();

                textBoxIsPrime.Text = "Nein";

                if (primes.isPrime(number)) {
                    textBoxIsPrime.Text = "Ja";
                }

                textBoxNextPrime.Text = Convert.ToString(primes.nextPrime(number));
                textBoxPrevPrime.Text = Convert.ToString(primes.prevPrime(number));
            }
            else {
                string caption = "Fehler!";
                string message = "Bitte geben Sie eine positive ganze Zahl größer 1 ein.";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private ulong ReadAndSanitizeInput(TextBox textBoxInput)
        {
            ulong inputNumber;
            string inputValue = textBoxInput.Text;

            if ("" != inputValue) {
                UInt64.TryParse(inputValue, out inputNumber);

                return inputNumber;
            }

            return 0;
        }
    }
}