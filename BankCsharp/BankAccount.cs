using System;

namespace Bank
{
    public class BankAccount
    {
        public int AccNum;
        public decimal Balance;
        public string OwnerName;
        public static int AccountNumber = 1;
        public BankAccount(int accNum, decimal balance, string ownerName)
        {
            AccNum = AccountNumber++;
            Balance = balance;
            OwnerName = ownerName;
            if (ownerName.Length < 1)
            {
                throw new ArgumentOutOfRangeException("Mandatory parameter");
            }
            if (balance <= 0)
            {
                throw new ArgumentOutOfRangeException("Cant create account with negative balance");
            }
        }

        public void Write()
        {
            Console.WriteLine($"AccNum: {AccNum}, Balance: {Balance}, OwnerName: {OwnerName}");
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException ("Cant make a deposit with 0");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException ("Cant make a withdraw with 0");
            }
            Balance -= amount;
        }


        public override string ToString()
        {
            return $"AccNum: {AccNum}, Balance: {Balance}, OwnerName: {OwnerName}";
        }
    }
    
}