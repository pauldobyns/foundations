using System;

class BankAccount
{
    // create the balance field
    private decimal balance;

    //create a constructor

    public BankAccount()
    {
        balance = 0; //start with a zero balance
    }
    //create the deposit function

    public void Deposit(decimal DepAmt)
    {
        balance = balance + DepAmt;
    }
    // create the withdrawal function
    public void Withdrawal(decimal WithAmt) 
    {
        balance = 
            balance - WithAmt;
    }

    //create an accessing function to find what your current balance is
    public decimal GetBalance()  // returns the balance in decimal
    {
        return balance;//code here to deliver balance to end-user
    }
}

class Test
{
    static void Main()
    {
        BankAccount acct = new BankAccount();

        acct.Deposit(200m);
        acct.Withdrawal(40m);

        Console.WriteLine("The final balance is {0}", acct.GetBalance());

        Console.ReadLine();
    }
}