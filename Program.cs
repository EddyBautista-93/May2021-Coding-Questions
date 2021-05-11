using System;
using System.Collections.Generic;

namespace May2021_Coding_Questions
{
    class Program
    {
        //5/11/2021

        //Create a function that transforms any positive number to a string representing the number in words.The function should work for all numbers between 0 and 999999.

        //Examples
        //number2words(0)  ==>  "zero"
        //number2words(1)  ==>  "one"
        //number2words(9)  ==>  "nine"
        //number2words(10)  ==>  "ten"
        //number2words(17)  ==>  "seventeen"
        //number2words(20)  ==>  "twenty"
        //number2words(21)  ==>  "twenty-one"
        //number2words(45)  ==>  "forty-five"
        //number2words(80)  ==>  "eighty"
        //number2words(99)  ==>  "ninety-nine"
        //number2words(100)  ==>  "one hundred"
        //number2words(301)  ==>  "three hundred one"
        //number2words(799)  ==>  "seven hundred ninety-nine"
        //number2words(800)  ==>  "eight hundred"
        //number2words(950)  ==>  "nine hundred fifty"
        //number2words(1000)  ==>  "one thousand"
        //number2words(1002)  ==>  "one thousand two"
        //number2words(3051)  ==>  "three thousand fifty-one"
        //number2words(7200)  ==>  "seven thousand two hundred"
        //number2words(7219)  ==>  "seven thousand two hundred nineteen"
        //number2words(8330)  ==>  "eight thousand three hundred thirty"
        //number2words(99999)  ==>  "ninety-nine thousand nine hundred ninety-nine"
        //number2words(888888)  ==>  "eight hundred eighty-eight thousand eight hundred eighty-eight"


        public static string Number2Words(int n)
        {
            if (n == 0)
                return "zero";
            if (n < 0)
                return "minus " + Number2Words(Math.Abs(n));

            string words = "";

            if ((n / 1000000) > 0)
            {
                words += Number2Words(n/ 1000000) + " million ";
                n %= 1000000;
            }

            if ((n/ 1000) > 0)
            {
                words += Number2Words(n / 1000) + " thousand ";
                n %= 1000;
            }

            if ((n / 100) > 0)
            {
                words += Number2Words(n / 100) + " hundred ";
                n %= 100;
            }

            if (n > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (n < 20)
                    words += unitsMap[n];
                else
                {
                    words += tensMap[n / 10];
                    if ((n % 10) > 0)
                        words += "-" + unitsMap[n % 10];
                }
            }

            return words.Trim();

        }




        static void Main(string[] args)
        {
            
        }
    }
}
