using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingUsOut
{
    class Program
    {


        static void Main(string[] args)
        {
            var complete = false;

            var userName = UserGreeting();

            while (complete == false)
            {
                complete = BankingConsole(userName);
            }
        }

        public static string UserGreeting()
        {
            Console.WriteLine("Welcome to Check Us Out. We are America's favorite bank.");
            Console.WriteLine("Please enter your name to proceed...");

            var userName = Console.ReadLine();
            return userName;
        }

        private static bool BankingConsole(string userName)
        {
            var complete = false;

            Console.WriteLine("\n" + "Hello " + userName + ", You have an available checking and investment account with Check Us Out.");
            Console.WriteLine("Please select the number corresponding with the account type you would like to view...");
            Console.WriteLine(" 1: Checking");
            Console.WriteLine(" 2. Investment");
            var accountSelection = Console.ReadLine();
            try
            {
                switch (accountSelection)
                {
                    case "1":
                        Accounts.AccountType(1);
                        break;
                    case "2":
                        Accounts.AccountType(2);
                        break;
                }
                if (accountSelection != "1" && accountSelection != "2")
                {
                    throw new Exception("Invalid Selection");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Invalid selection");
                return complete;
            }
            return complete;
        }
    }

}
