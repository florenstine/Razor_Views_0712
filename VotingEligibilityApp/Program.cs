using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VotingEligibility
{
    static void Main()
    {
        Console.WriteLine("Voting Eligibility Application");

        // Ask for age
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Ask for citizenship
        Console.Write("Are you a Filipino citizen? (yes/no): ");
        string citizen = Console.ReadLine().ToLower();

        // Check conditions
        if (age >= 18 && citizen == "yes")
        {
            Console.WriteLine("\nYou are eligible to vote!");
        }
        else
        {
            Console.WriteLine("\nYou are NOT eligible to vote.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
