using System.CodeDom;
using System.Reflection.Emit;

namespace Login_System_x_Calculator
{
    public partial class Form1 : Form
    {
        string firstNumber = "";
        string secondNumber = "";
        string operation = "";
        double result = 0;
        string currentNumber = "0";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void del_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber.Substring(0, currentNumber.Length - 1);
            ResultMenu.Text = currentNumber;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            firstNumber = "";
            secondNumber = "";
            operation = "";
            ResultMenu.Text = "";
            currentNumber = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            
            if (operation != "")
            {
                firstNumber = currentNumber.Substring(0, currentNumber.IndexOf(operation));
                secondNumber = currentNumber.Substring(currentNumber.IndexOf(operation) + 1);
                if(firstNumber!="" && secondNumber!="")
                {
                    switch (operation)
                    {
                        case "+":
                            result = Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber);
                            break;
                        case "-":
                            result = Convert.ToDouble(firstNumber) - Convert.ToDouble(secondNumber);
                            break;
                        case "*":
                            result = Convert.ToDouble(firstNumber) * Convert.ToDouble(secondNumber);
                            break;
                        case "/":
                            if (secondNumber == "0") MessageBox.Show("No Zero Division");
                            else result = Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber);
                            break;
                        default:
                            break;
                    }
                    currentNumber = result.ToString();
                    ResultMenu.Text = currentNumber;
                    firstNumber = "";
                    secondNumber = "";
                    operation = "";
                }
                
            }

            
            

        }

        private void number1_Click(object sender, EventArgs e)
        {
            currentNumber += "1";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            currentNumber += "2";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            currentNumber += "3";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;

        }

        private void number4_Click(object sender, EventArgs e)
        {
            currentNumber += "4";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;

        }

        private void number5_Click(object sender, EventArgs e)
        {
            currentNumber += "5";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;

        }

        private void number6_Click(object sender, EventArgs e)
        {
            currentNumber += "6";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;

        }

        private void number7_Click(object sender, EventArgs e)
        {
            currentNumber += "7";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;

        }

        private void number8_Click(object sender, EventArgs e)
        {
            currentNumber += "8";
            if (currentNumber[0] == '0' && currentNumber[1]!=',' && currentNumber.Length > 1) currentNumber=currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;

        }

        private void number9_Click(object sender, EventArgs e)
        {
            currentNumber += "9";
            if (currentNumber[0] == '0' && currentNumber[1] != ',' && currentNumber.Length > 1) currentNumber = currentNumber.Substring(1);
            ResultMenu.Text = currentNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultMenu.Text = currentNumber;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (currentNumber.Contains('+') || currentNumber.Contains('-') || currentNumber.Contains('*') || currentNumber.Contains('/')) return;
            if (operation!="") {
                equals_Click(sender, e); 
            }
            operation = "+";
            if (currentNumber.EndsWith("-") || currentNumber.EndsWith("+") || currentNumber.EndsWith("*") || currentNumber.EndsWith("/"))
            {
                currentNumber = currentNumber.Replace(currentNumber[currentNumber.Length - 1], '+');
            }
            else currentNumber += operation;
            ResultMenu.Text = currentNumber;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (currentNumber.Contains('+') || currentNumber.Contains('-') || currentNumber.Contains('*') || currentNumber.Contains('/')) return;
            if (operation != "")
            {
                equals_Click(sender, e);
            }
            operation = "-";
            if (currentNumber.EndsWith("-") || currentNumber.EndsWith("+") || currentNumber.EndsWith("*") || currentNumber.EndsWith("/"))
            {
                currentNumber = currentNumber.Replace(currentNumber[currentNumber.Length - 1], '-');
            }
            else currentNumber += operation;
            ResultMenu.Text = currentNumber;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (currentNumber.Contains('+') || currentNumber.Contains('-') || currentNumber.Contains('*') || currentNumber.Contains('/')) return;
            if (operation != "")
            {
                equals_Click(sender, e);
            }
            operation = "*";
            if (currentNumber.EndsWith("-") || currentNumber.EndsWith("+") || currentNumber.EndsWith("*") || currentNumber.EndsWith("/"))
            {
                currentNumber = currentNumber.Replace(currentNumber[currentNumber.Length - 1], '*');
            }
            else
                currentNumber += operation;
            ResultMenu.Text = currentNumber;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (currentNumber.Contains('+') || currentNumber.Contains('-') || currentNumber.Contains('*') || currentNumber.Contains('/')) return;
            if (operation != "")
            {
                equals_Click(sender, e);
            }
            operation ="/";
            if (currentNumber.EndsWith("-") || currentNumber.EndsWith("+") || currentNumber.EndsWith("*") || currentNumber.EndsWith("/"))
            {
                currentNumber = currentNumber.Replace(currentNumber[currentNumber.Length - 1], '/');
            }
            else
                currentNumber += operation;
            ResultMenu.Text = currentNumber;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if(operation=="")
            {
                if (!currentNumber.Contains(',')) currentNumber += ",";
            }
            else if (operation != "")
            {
                if (!currentNumber.Substring(currentNumber.IndexOf(operation)).Contains(",")) currentNumber += ",";
            }
            ResultMenu.Text = currentNumber;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            
            if(currentNumber!="0")currentNumber += "0";
            ResultMenu.Text = currentNumber;
        }
    }
}