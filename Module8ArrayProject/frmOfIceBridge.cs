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
        const int maxIndex = 8;

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
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string textBoxNumber = "";
            int userNumber = 0;
            textBoxNumber = txtNumber.Text;
            if (count < maxIndex)
            {


                try
                {
                    if (validateData())
                    {
                        userNumber = Convert.ToInt32(textBoxNumber);
                        Array.Resize(ref numbersEntered, numbersEntered.Length + 1);
                        numbersEntered[count] = userNumber;
                        count++;
                        txtNumber.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    lblMessageBox.Text = ex.Message + ex.GetType().ToString();
                }
            }
            else
            {
                lblMessageBox.Text = "Array is full, only 8 entries are allowed";
            }
        }

        public bool validateData ()
        {
            return
                IsBlank(txtNumber) &&
                IsDecimal(txtNumber)&&
                IsInt32(txtNumber) &&
                InRange(txtNumber);
        }

        public bool IsBlank(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                lblMessageBox.Text = "Number entry box is empty, please input a value";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsInt32(TextBox x)
        {
            string s = txtNumber.Text;
            int number = 0;
            if (int.TryParse(s, out number)) 
            {
                return true;
            }
            else
            {
                lblMessageBox.Text = "Please enter a numeric value";
                return false;
            }
        }

        public bool IsDecimal(TextBox x)
        {
            string s = txtNumber.Text;
            decimal number = 0;
            if (decimal.TryParse(s, out number))
            {
                return true;
            }
            else
            {
                lblMessageBox.Text = "Decimals are not allow in the entries";
                return false;
                
            }
        }
        public bool InRange(TextBox x)
        {
            int number = Convert.ToInt32(x.Text);
            if (number < -1000 || number > 1000)
            {
                lblMessageBox.Text = "Number is out of range, enter a value between -1000 and 1000";
                return false;
            }
            else
            {
                return true;
            }
            
                
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblArrayDisplay.Text = "";
            for (int i = 0; i < numbersEntered.Length; i++)
            {
                if (numbersEntered[i] != 0)
                {
                    lblArrayDisplay.Text = lblArrayDisplay.Text + Convert.ToString(numbersEntered[i]) + "\n";
                }
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            try
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
            catch (System.InvalidOperationException)
            {
                lblMessageBox.Text = "The array is currently empty";
            }

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
