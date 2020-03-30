using System;

namespace BankV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount("Kristian Spaqaj");

            myAccount.Deposit(2000);
            Console.WriteLine($"Account balance for {myAccount.accountHolderName} is : {myAccount.Balance}");

            myAccount.Withdraw(1500);
            Console.WriteLine($"Account balance for {myAccount.accountHolderName} is : {myAccount.Balance}");

            // The LAST line of code should be ABOVE this line
        }
    }
}