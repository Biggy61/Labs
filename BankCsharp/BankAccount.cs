using System;

namespace Bank
{
    public class BankAccount
    {
        public int AccNum;
        public decimal Balance;
        public string OwnerName;
        public static int AccountNumber = 1;
        public BankAccount(decimal balance, string ownerName)
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

        public void WriteBefore()
        {
            Console.WriteLine($"AccNum: {AccNum}, Balance: {Balance}, OwnerName: {OwnerName}");
        }
        public void WriteAfter()
        {
            Console.WriteLine($"After: AccNum: {AccNum}, Balance: {Balance}, OwnerName: {OwnerName}");
        }
        public void Deposit(decimal amount)
        {
            WriteBefore();
            if (amount <= 0)
            {
                throw new InvalidOperationException ("Cant make a deposit with 0");
            }
            Balance += amount;
            WriteAfter();
        }

        public void Withdraw(decimal amount)
        {
            WriteBefore();
            if (amount <= 0)
            {
                throw new InvalidOperationException ("Cant make a withdraw with 0");
            }
            Balance -= amount;
            WriteAfter();
        }


        public override string ToString()
        {
            return $"AccNum: {AccNum}, Balance: {Balance}, OwnerName: {OwnerName}";
        }
    }
    
}