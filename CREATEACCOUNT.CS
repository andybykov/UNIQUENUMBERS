/* Лабоаторная 6. Упражнение 2. Генерация номеров банковских счетов  */
using System;

class CreateAccount
{
    static void Main() 
    {
        BankAccount berts = NewBankAccount();
        Write(berts);
        
        BankAccount freds = NewBankAccount();
        Write(freds);
    }
    
    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();

        //Console.Write("Enter the account number   : ");
        //long number = long.Parse(Console.ReadLine());        
        //long number = BankAccount.NextNumber(); // получаем номер из метода

        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());
        
        //created.accNo = number;
        //created.accBal = balance;
        //created.accType = AccountType.Checking;
        created.Populate(balance);
        
        return created;
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
    }
}
