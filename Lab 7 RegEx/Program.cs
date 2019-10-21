using System;
using System.Text.RegularExpressions;

namespace Day_7_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name...");
            Console.WriteLine(TestingOnTheReg(Console.ReadLine(),@"[A-Z]{1}[a-z]{1,30}",1));
            Console.Write("Enter an e-mail...");
            Console.WriteLine(TestingOnTheReg(Console.ReadLine(),@"[a-zA-Z0-9]{5,30}@[a-zA-Z1-9]{5,10}\.[a-zA-Z1-9]{2,3}",2));
            Console.Write("Enter a phone number (XXX-XXX-XXXX)...");
            Console.WriteLine(TestingOnTheReg(Console.ReadLine(), @"[0-9]{3}-[0-9]{3}-[0-9]{4}",3));
            Console.Write("Enter a date (mm/dd/yyyy)...");
            //^(?:(?:(?:0?[13578]|1[02])(\/)31)\1|(?:(?:0?[1,3-9]|1[0-2])(\/)(?:29|30)\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:0?2(\/)29\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:(?:0?[1-9])|(?:1[0-2]))(\/|-|\.)(?:0?[1-9]|1\d|2[0-8])\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$
            Console.WriteLine(TestingOnTheReg(Console.ReadLine(), @"[0-1]{1}[0-9]{1}\/[0-3]{1}[0-9]{1}\/[0-9]{4}", 4));
        }

        public static string TestingOnTheReg(string input, string expression, int type)
        {
            bool passed;
            if (Regex.IsMatch(input, expression))
            {
                passed = true;
            }
            else
            {
                passed = false;
            }
            if(passed == true)
            {
                switch (type)
                {
                    case 1:
                        return "This is a valid name";
                    case 2:
                        return "This is a valid e-mail";
                    case 3:
                        return "This is a valid phone number";
                    case 4:
                        return "This is a valid date";
                    default:
                        return "This is broken. Horribly.";
                }
            }
            else
            {
                switch (type)
                {
                    case 1:
                        return "This is not a valid name";
                    case 2:
                        return "This is not a valid e-mail";
                    case 3:
                        return "This is not a valid phone number";
                    case 4:
                        return "This is not a valid date";
                    default:
                        return "This is still broken. Horribly. Still.";
                }
            }
            return "Ohh, that didn't work...";
        }
    }
}

