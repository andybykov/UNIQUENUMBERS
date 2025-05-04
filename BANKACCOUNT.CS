
class BankAccount 
{
    public void Populate(decimal balance)
    {
        accNo = NextNumber(); // получаем номер счета из метода
        accBal = balance;
        accType = AccountType.Checking;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }

    // Метод возвращает инкрементированное значение поля nextAccNo
    private static long NextNumber()
    {
        return nextAccNo++;
    }

    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123; // переменная для хранения следующего значения счета
}
