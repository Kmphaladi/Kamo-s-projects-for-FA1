using System;
namespace ATMSystem;

class BankingCTU
{
    public static void Main()
    {
        Console.WriteLine("===== CTU SIMPLE ATM SYSTEM ===== ");
        string name = "";
        while (true)
        {
            Console.WriteLine("HI , WHAT IS YOUR NAME? ");
            name = Console.ReadLine();

            // Checking if the name contains any digits
            if (name.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid name! Name cannot contain numbers.");
                Console.WriteLine();
                continue;
            }
            // Checking if the name is empty or null
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name! Please enter your name.");
                continue;
            }
            break;
        }
        // Display welcome message and name in uppercase
        Console.WriteLine("\nWELCOME " + name.ToUpper() + "!");
        decimal balance = 0;
        // Prompting user for account balance and validate input
        while (true)
        {
            Console.Write("Enter account balance: ");
            string input = Console.ReadLine();
            // Validating if the input is a valid decimal number
            if (!decimal.TryParse(input, out balance))
            {
                Console.WriteLine("Invalid. Please enter numbers only.");
                continue;
            }
            // Validating if the balance is negative
            if (balance < 0)
            {
                Console.WriteLine("Invalid. Balance cannot be negative.");
                continue;
            }

            break;
        }

        while (true)
        {
            Console.Write("Enter withdrawal amount: ");
            string inputWithdrawal = Console.ReadLine();
            // Validating if the input is a valid decimal number
            if (!decimal.TryParse(inputWithdrawal, out decimal withdrawal))
            {
                Console.WriteLine("Invalid! Please enter numbers only.");
                continue;
            }
            // Validating if the withdrawal amount is higher than the balance
            if (withdrawal > balance)
            {
                Console.WriteLine("Insufficient funds, your withdrawal amount exceeds your balance. Try Again");
                continue;
            }

            decimal newBalance = balance - withdrawal;
            Console.WriteLine($"Withdrawal successful! \nUpdated balance: {newBalance:C}");
            break;
        }
        // Displaying the transaction time in the specified format
        Console.WriteLine($"Transaction Time: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
    }
}


