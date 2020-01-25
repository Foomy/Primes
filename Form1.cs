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
            long number;
            string inputValue = textBoxInput.Text;

            if ("" != inputValue) {
                number = Convert.ToInt64(inputValue);

                Primes primes = new Primes();

                textBoxIsPrime.Text     = "Nein";
                checkBoxIsPrime.Checked = false;

                if (primes.isPrime(number)) {
                    textBoxIsPrime.Text     = "Ja";
                    checkBoxIsPrime.Checked = true;
                }

                textBoxNextPrime.Text = Convert.ToString(primes.nextPrime(number));
                textBoxPrevPrime.Text = Convert.ToString(primes.prevPrime(number));
            }
            else {
                string caption = "Fehler!";
                string message = "Please enter a natural number.";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
