using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingUsOut
{
    class Accounts
    {
        public static void AccountType(int accountType)
        {
            switch (accountType)
            {
                case 1:
                    float checkingBalance = 2.01f;
                    Console.WriteLine("\nYour checking account has a balance of $" + checkingBalance + "\n");
                    AccountTransactionPrompt(1);
                    break;

                case 2:
                    float investmentBlanace = 2001.05f;
                    Console.WriteLine("\nYour investment account has a blanace of $" + investmentBlanace + "\n");
                    AccountTransactionPrompt(2);
                    break;
            }
        }
        public static void AccountTransactionPrompt(int accountType)
        {
            switch (accountType)
            {
                case 1:
                    Console.WriteLine("\nWhat would you like to do with your checking account?\n");
                    Transactions(1,0);
                    break;
                case 2:
                    Console.WriteLine("Which investment account would you like to view?");
                    Console.WriteLine(" 1. Individual person account");
                    Console.WriteLine(" 2. Corporate investment account");
                    try
                    {
                        var investmentSelection = Convert.ToInt32(Console.ReadLine());
                        if (investmentSelection != 1 && investmentSelection !=2)
                        {
                            throw new Exception();
                        }
                        InvestmentTransactions(investmentSelection);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid selection");
                    }
                    break;
            }
        }

        private static void InvestmentTransactions(int investmentAccount)
        {
            switch(investmentAccount)
            {
                case 1:
                    Console.WriteLine("\nWhat would you like to do with your individual personal investment account?\n");
                    Transactions(2,1);
                    break;

                case 2:
                    Console.WriteLine("\nWhat would you like to do with your corporate investment account?\n");
                    Transactions(2,2);
                    break;
            }    
        }

        public static void Transactions(int accountType, int investmentType)
        {
            Console.WriteLine("Please select from what of the following options");
            Console.WriteLine(" 1: Deposit to account");
            Console.WriteLine(" 2: Withdraw from account");
            Console.WriteLine(" 3: Transfer between accounts");
            Console.WriteLine(" 4. Return to main menu");

            var transactionSelection = Console.ReadLine();

            var accountText = "";
            var investmentText = "";


            switch (accountType)
            {
                case 1:
                    accountText = "checking";
                    break;
                case 2:
                    accountText = "investment";
                    break;
            }
            switch (investmentType)
            {
                case 1:
                    investmentText = "personal";
                    break;
                case 2:
                    investmentText = "corporate";
                    break;

            }
            switch (Convert.ToInt32(transactionSelection))
            { 
                case 1:
                    Console.WriteLine("How much would you like to deposit into your " + investmentText + " " + accountText + " account?");
                    var depositValue = Console.ReadLine();
                    Console.WriteLine("$" + depositValue + " has successfully been deposited to your account");
                    break;

                case 2:
                    Console.WriteLine("How much would you like to withdraw from your " + investmentText + " " + accountText + "?");
                    var withdrawValue = Console.ReadLine();
                    if (accountType == 2 && investmentType == 1 )
                    {
                        if (Convert.ToInt32(withdrawValue) >= 500)
                        {
                            Console.WriteLine("Error: Unable to withdraw more than $500 from your " + investmentText + " " + accountText + " account");
                        }
                    }
                    else
                    {
                        Console.WriteLine("$" + withdrawValue + " has been been withdrawn from your account");
                    }
                    break;

                case 3:
                    Console.WriteLine("Which accounts would you like to transfer between?");
                    Console.WriteLine(" 1. Checking to Investment");
                    Console.WriteLine(" 2. Investment to Checking");
                    var doesntDoAnythingAnyways = Console.ReadLine();
                    Console.WriteLine("How much would you like to transfer?");
                    var transferValue = Console.ReadLine();
                    Console.WriteLine("$" + transferValue + " has been successfully transferred between accounts");
                    break;

                case 4:
                    return;
            }
        }
    }
}
