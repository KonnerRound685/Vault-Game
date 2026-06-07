using System;
using System.Text; 

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "4576";
            string enteredPassword;
            int alarmTracker = 0;

            bool isVaultLocked = true;


            Console.WriteLine("Welcome to the vault!");
            Console.WriteLine("Try guess the vault password, ill give you a hint 5764");
            Console.WriteLine("You only have 10 attemps before the vault is permanently locked! Good luck.");


            while (isVaultLocked)
            {

                enteredPassword = Console.ReadLine();

                if (enteredPassword == password)
                {
                    Console.WriteLine("Well done! Correct password entered, the vault is now open!");
                    isVaultLocked = false;
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid password.");
                    alarmTracker++;
                    isVaultLocked = true;
                    Console.WriteLine(alarmTracker + " incorrect attempt(s).");
                }

                if (alarmTracker >= 10)
                {
                    Console.WriteLine("ALERT: Too many incorrect attempts! The vault is now permanently locked.");
                    isVaultLocked = false;
                }
            }

            Console.WriteLine("\nThank you for playing!");
        }
    }

}
