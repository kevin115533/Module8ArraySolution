using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module8ArrayProject
{
    public partial class frmOfIceBridge : Form
    {
        int[] numbersEntered = { };
        int count = 0;
        const int maxIndex = 12;

        public frmOfIceBridge()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOfIceBridge_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (numbersEntered.Length > maxIndex)
            {
                lblMessageBox.Text = "Array is full";
            }
            else
            {
                int userNumber = 0;
                string textBoxNumber = "";

                textBoxNumber = txtNumber.Text;

                try
                {
                    userNumber = Convert.ToInt32(textBoxNumber);
                }
                catch (Exception)
                {
                    lblMessageBox.Text = "Please enter an numeric value";
                }
                if (userNumber < -1000 || userNumber > 1000)
                {
                    lblMessageBox.Text = "Please enter a value between -1000 and 1000";
                }
                else
                {
                    Array.Resize(ref numbersEntered, numbersEntered.Length + 1);
                    numbersEntered[count] = userNumber;
                    count++;
                    //txtNumber.Text = "";
                }
            }
        }

        public bool IsDecimal(TextBox textBox, String name) 
        {
            decimal number = 0;
            if(Decimal.TryParse(textBox.Text, out number)){
                return true;
            }
            else
            {
                
                return false;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblArrayDisplay.Text = "";
            for(int i = 0; i < numbersEntered.Length; i++)
            {
                if (numbersEntered[i] != 0)
                {
                    lblArrayDisplay.Text = lblArrayDisplay.Text + Convert.ToString(numbersEntered[i]) + "\n";
                }
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            int highest = numbersEntered.Max();
            int lowest = numbersEntered.Min();
            decimal sum = 0;
            decimal numberCount = numbersEntered.Length;
            
            for (int i = 0; i < numbersEntered.Length; i++)
            {
                sum = sum + numbersEntered[i];
            }

            decimal average = sum / numberCount;
            string strHighest = Convert.ToString(highest);
            string strLowest = Convert.ToString(lowest);
            string strAverage = average.ToString("F3");
            string strNumberCount = Convert.ToString(numberCount);

            lblMessageBox.Text = "Average Number: " + strAverage + "\n" +
                "Highest Number: " + strHighest + "\n" +
                "Lowest Number: " + strLowest + "\n" +
                "Amount of Numbers: " + strNumberCount;

            count = 0;
            for (int i = 0; i < numbersEntered.Length; i++)
            {
                numbersEntered[i] = 0;
            }

            lblArrayDisplay.Text = "";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            for (int i = 0; i < numbersEntered.Length; i++)
            {
                numbersEntered[i] = 0;
            }
            Array.Resize(ref numbersEntered, 0);
            lblArrayDisplay.Text = "";
            lblMessageBox.Text = "Array has been cleared";
        }
    }
}
