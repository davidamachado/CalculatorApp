using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CalculatorApp
{
    class Calculate
    {
        //fuction to add both operands on each side of operator
        public static String add(String a, String b)
        {
            String answer = null;
            CultureInfo cultures = new CultureInfo("en-US");
            decimal x = Convert.ToDecimal(a, cultures);
            decimal y = Convert.ToDecimal(b, cultures);
            decimal z = x + y;
            answer = z.ToString();
            return answer;
        }

        //fuction to subtract operand (String) b from operand (String) a
        public static String subtract(String a, String b)
        {
            String answer = null;
            CultureInfo cultures = new CultureInfo("en-US");
            decimal x = Convert.ToDecimal(a, cultures);
            decimal y = Convert.ToDecimal(b, cultures);
            decimal z = x - y;
            answer = z.ToString();
            return answer;
        }

        //function to multiply both operands 
        public static String multiply(String a, String b)
        {
            String answer = null;
            CultureInfo cultures = new CultureInfo("en-US");
            decimal x = Convert.ToDecimal(a, cultures);
            decimal y = Convert.ToDecimal(b, cultures);
            decimal z = x * y;
            answer = z.ToString();
            return answer;
        }

        //function to divine operand (String) a by operand (String) b
        public static String divide(String a, String b)
        {
            String answer = null;
            CultureInfo cultures = new CultureInfo("en-US");
            decimal x = Convert.ToDecimal(a, cultures);
            decimal y = Convert.ToDecimal(b, cultures);
            decimal z = x / y;
            answer = z.ToString();
            return answer;
        }

        //function to divide the input by 100
        public static String percent(String a)
        {
            String answer = null;
            CultureInfo cultures = new CultureInfo("en-US");
            decimal x = Convert.ToDecimal(a, cultures);
            decimal y = x / 100;
            answer = y.ToString();
            return answer;
        }

        /*
         * function to remove excess zeros from numbers with decimals, delete decimal if
         * followed by no numbers, change -0 to 0, and handle numbers in scientific 
         * notation that equal 0
         */
        public static String format(String value)
        {
            while (value.EndsWith("0") && value.Contains("."))
            {
                value = value.Substring(0, value.Length - 1);
            }
            if (value.EndsWith("."))
            {
                value = value.Substring(0, value.Length - 1);
            }
            if (value == "-0")
            {
                value = "0";
            }
            if (value.Length > 1)
            {
                if (value.StartsWith("0E") || value.StartsWith("-0E"))
                {
                    value = "0";
                }
            }
            return value;
        }
    }
}
