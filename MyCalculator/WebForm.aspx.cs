using System;
using System.Web.UI;

namespace MyCalculator
{
    public partial class WebForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                double result = num1 + num2;
                lblAddResult.Text = "Addition Result: " + result.ToString();
            }
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                double result = num1 - num2;
                lblSubtractResult.Text = "Subtraction Result: " + result.ToString();
            }
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                double result = num1 * num2;
                lblMultiplyResult.Text = "Multiplication Result: " + result.ToString();
            }
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    lblDivideResult.Text = "Division Result: " + result.ToString();
                }
                else
                {
                    lblDivideResult.Text = "Cannot divide by zero.";
                }
            }
        }

        private bool IsValidInput()
        {
            double num1, num2;
            bool isNum1Valid = double.TryParse(txtNumber1.Text, out num1);
            bool isNum2Valid = double.TryParse(txtNumber2.Text, out num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                lblAddResult.Text = "Please enter valid numbers.";
                lblSubtractResult.Text = "";
                lblMultiplyResult.Text = "";
                lblDivideResult.Text = "";
                return false;
            }

            return true;
        }
    }
}