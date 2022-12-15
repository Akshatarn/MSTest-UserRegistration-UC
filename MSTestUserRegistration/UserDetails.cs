using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTestUserRegistration
{
    public class UserDetails
    {
        public static bool FirstName(string userInput)
        {
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
        public static bool LastName(string userInput)
        {
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$"; 
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
        public static bool EmailId(string userInput)
        {
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
        public static bool MobileNumber(string userInput)
        {
            string regexCondition = "^[9]{1}[1]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
        public static bool PassMin8Char(string userInput)
        {
            string regexCondition = "^[a-zA-Z0-9]{8,}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
        public static bool PassMin8CharAnd1UpperCase(string userInput)
        {
            string regexCondition = "^(?=.*[A-Z]).{1,}[a-zA-Z0-9]{7,}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
        public static bool UpperCase1AndNumeric1(string userInput)
        {
            string regexCondition = "^(?=.*[A-Z]).{1,}(?=.*[0-9]).{1,}[a-zA-Z0-9]{6,}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
    }
}
