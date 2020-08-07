/*
 * Author: David Machado
 * Created: 2020-05-01
 * Updates:
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        private String lastButton = null;
        private const int MAXDIGIT = 20;

        //variable for which line the current math expression begins on 
        private int lineStart = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        //action when "C" button is clicked
        private void bClr_Click(object sender, RoutedEventArgs e)
        {
            tBlock1.Text = "0";
            alert.Text = "Cleared";

            //mark this as the last button which was clicked
            lastButton = "C";
        }

        //action when "+/-" button is clicked
        private void bPosNeg_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";
            String number = tBlock1.Text;

            //checks for the last button clicked
            if (lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "-0";
            }
            else
            {
                //checks if the number is already negative
                if (number[0] == '-')
                {
                    //remove "-" from the number
                    tBlock1.Text = number.Substring(1);
                }
                else
                {
                    //add "-" to the number
                    tBlock1.Text = "-" + number;
                }
            }
            //mark this as the last button which was clicked
            lastButton = "+/-";
        }

        //action when "%" button is clicked
        private void bPer_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks if the number length has reached the maximum allowed
            if (tBlock1.Text.Length <= MAXDIGIT)
            {
                //process number with the percent() function found in the Calculate class
                tBlock1.Text = Calculate.percent(tBlock1.Text);
            }
            else
            {
                alert.Text = "Maximum digits reached";
            }
            //mark this as the last button which was clicked
            lastButton = "per";
        }

        //action when "/" button is clicked
        private void bDiv_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //process number with the format() function found in the Calculate class
            tBlock1.Text = Calculate.format(tBlock1.Text);

            //add " /" to the last number within the textBlock
            tBlock2.Text = append() + " /";

            //mark this as the last button which was clicked
            lastButton = "/";
        }

        //action when "7" button is clicked
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "7";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-7";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "7";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "8" button is clicked
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "8";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-8";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "8";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }
            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "9" button is clicked
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "9";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-9";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "9";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }
            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "x" button is clicked
        private void bMul_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";
            tBlock1.Text = Calculate.format(tBlock1.Text);
            tBlock2.Text = append() + " x";

            //mark this as the last button which was clicked
            lastButton = "op";
        }

        //action when "4" button is clicked
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked  and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "4";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-4";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "4";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "5" button is clicked
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "5";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-5";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "5";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "6" button is clicked
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "6";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-6";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "6";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "-" button is clicked
        private void bMin_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";
            tBlock1.Text = Calculate.format(tBlock1.Text);
            tBlock2.Text = append() + " -";

            //mark this as the last button which was clicked
            lastButton = "op";
        }

        //action when "1" button is clicked
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "1";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-1";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "1";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "2" button is clicked
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "2";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-2";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "2";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "3" button is clicked
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "/" || lastButton == "equ")
            {
                tBlock1.Text = "3";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-3";
            }
            else if (lastButton == "num" || lastButton == "+/-" || lastButton == "." || lastButton == "per")
            {
                if (tBlock1.Text.Length <= MAXDIGIT)
                {
                    tBlock1.Text = tBlock1.Text + "3";
                }
                else
                {
                    alert.Text = "Maximum digits reached";
                }
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "+" button is clicked
        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";
            tBlock1.Text = Calculate.format(tBlock1.Text);
            tBlock2.Text = append() + " +";

            //mark this as the last button which was clicked
            lastButton = "op";
        }

        //action when "0" button is clicked
        private void b0_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked
            if (lastButton != "/")
            {
                if (lastButton == "op" || lastButton == "equ")
                {
                    tBlock1.Text = "0";
                }
                if (tBlock1.Text != "0" && tBlock1.Text != "-0")
                {
                    if (tBlock1.Text.Length <= MAXDIGIT)
                    {
                        tBlock1.Text = tBlock1.Text + "0";
                    }
                    else
                    {
                        alert.Text = "Maximum digits reached";
                    }
                }
            }
            else
            {
                alert.Text = "Cannot divide by 0";
            }

            //mark this as the last button which was clicked
            lastButton = "num";
        }

        //action when "." button is clicked
        private void bDec_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";

            //checks for the last button clicked and if number currently is "0"
            if (tBlock1.Text == "0" || lastButton == "op" || lastButton == "equ")
            {
                tBlock1.Text = "0.";
            }
            else if (tBlock1.Text == "-0")
            {
                tBlock1.Text = "-0.";
            }
            else if (tBlock1.Text.Length <= MAXDIGIT)
            {
                if (tBlock1.Text.Contains('.'))
                {
                    alert.Text = "Decimal already present";
                }
                else
                {
                    tBlock1.Text = tBlock1.Text + ".";
                }
            }

            //mark this as the last button which was clicked
            lastButton = ".";
        }

        //action when "=" button is clicked
        private void bEqu_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "";
            tBlock1.Text = Calculate.format(tBlock1.Text);
            tBlock2.Text = append() + " =";
            String answer = Calculate.format(calculate());

            //place the answer to the math expression on a new line
            tBlock2.Text = tBlock2.Text + Environment.NewLine + answer + Environment.NewLine;

            //place the answer to the math expression in the small textBlock
            tBlock1.Text = answer;

            //mark this as the last button which was clicked
            lastButton = "equ";
        }

        //action when "Reset" button is clicked
        private void bReset_Click(object sender, RoutedEventArgs e)
        {
            alert.Text = "Reset Complete";
            tBlock1.Text = "0";
            tBlock2.Text = "EMPTY";
            lineStart = 1;

            //mark this as the last button which was clicked
            lastButton = "Reset";
        }

        //function to add number to the large textBlock
        public String append()
        {
            if (tBlock2.Text == "EMPTY")
            {
                tBlock2.Text = tBlock1.Text;
            }
            else
            {
                //add number to a new line in the large textBlock
                tBlock2.Text = tBlock2.Text + Environment.NewLine + tBlock1.Text;
            }
            return tBlock2.Text;
        }

        //function to extract the operator from the String
        public String getOperator(String line)
        {
            String op = line[line.Length - 1].ToString();
            return op;
        }

        //function to extract the number from the String
        public String getNumber(String line)
        {
            String number = line.Substring(0, line.Length - 2);
            return number;
        }

        //function to calculate the numbers in the large textBlock starting with the specified line number
        public String calculate()
        {
            int lineNumber = 0;
            String num1 = null;
            String num2 = null;
            String op = null;
            String line;

            //initialize a new StringReader with the large textBlock as input
            StringReader sr = new StringReader(tBlock2.Text);
            while ((line = sr.ReadLine()) != null)
            {
                /*
                 * checks if this math expression is the first one within the large textBlock 
                 * or if there are multiple math expressions listed so that each line not
                 * associated with the current math expression can be skipped
                 */
                if (lineStart > 1 && lineStart > lineNumber + 1)
                {
                    lineNumber++;
                    continue;
                }
                lineNumber++;

                //checks if the current line is after the first line of the math expression
                if (lineNumber > lineStart)
                {
                    num2 = getNumber(line);

                    /*
                     * enter numbers on both sides of the specified operator into the appropriate 
                     * function found within Calculate class to obtain the result
                     */
                    if (op == "/")
                    {
                        num1 = Calculate.divide(num1, num2);
                    }
                    else if (op == "x")
                    {
                        num1 = Calculate.multiply(num1, num2);
                    }
                    else if (op == "-")
                    {
                        num1 = Calculate.subtract(num1, num2);
                    }
                    else if (op == "+")
                    {
                        num1 = Calculate.add(num1, num2);
                    }
                    op = getOperator(line);
                }
                else
                {
                    op = getOperator(line);
                    num1 = getNumber(line);
                }
            }
            //set the start of the new line to be placed after the answer and after a blank line
            lineStart = lineNumber + 3;
            String answer = num1;
            return answer;
        }
    }
}
