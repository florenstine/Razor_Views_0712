using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ATMReplica
{
    static void Main()
    {
        Console.WriteLine("ATM Replica Application");

        double balance = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter deposit amount: ");
                    double deposit = double.Parse(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine($"\nYou deposited {deposit}. New balance: {balance}");
                    break;

                case 2:
                    Console.Write("\nEnter withdrawal amount: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    if (withdraw <= balance)
                    {
                        balance -= withdraw;
                        Console.WriteLine($"\nYou withdrew {withdraw}. Remaining balance: {balance}");
                    }
                    else
                    {
                        Console.WriteLine("\nInsufficient balance.");
                    }
                    break;

                case 3:
                    Console.WriteLine($"\nYour current balance is: {balance}");
                    break;

                case 4:
                    Console.WriteLine("\nThank you for using the ATM!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Try again.");
                    break;
            }
        }
    }
}

