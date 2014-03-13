using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the
//information for a single bank account using the appropriate data types and descriptive names.
class BankAccData
{
    static void Main()
    {
        Console.WriteLine("Account holder first name:");
        string FirstName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Account holder middle name:");
        string MidName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Account holder last name:");
        string LastName = Console.ReadLine();

        int balance = 2320000;
        Console.Clear();
        Console.WriteLine("Bank name:");
        string bank = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("IBAN:");
        string iban = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Credit card number #1:");
        string bankaccount1 = Console.ReadLine();
        long BANKACCOUNT1;
        BANKACCOUNT1 = long.Parse(bankaccount1);

        Console.Clear();
        Console.WriteLine("Credit card number #2:");
        string bankaccount2 = Console.ReadLine();
        long BANKACCOUNT2;
        BANKACCOUNT2 = long.Parse(bankaccount2);

        Console.Clear();
        Console.WriteLine("Credit card number #3:");
        string bankaccount3 = Console.ReadLine();
        long BANKACCOUNT3;
        BANKACCOUNT3 = long.Parse(bankaccount3);

        Console.Clear();
        Console.WriteLine("Bank account details:\n\n Account holder name: {0} {1} {2}\n Bank:{3}\n Current balance: {4}\n \n IBAN:{5}\n Credit card #1: {6}\n Credit card #2: {7}\n Credit card #3: {8}\n\n\n",
        FirstName, MidName, LastName, bank, balance, iban, BANKACCOUNT1, BANKACCOUNT2, BANKACCOUNT3);
    }
}