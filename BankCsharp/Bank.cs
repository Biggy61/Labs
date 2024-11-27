using System;
using System.Collections.Generic;

namespace Bank
{
    public class Bank
    {
        public string Name;
        public List <BankAccount> _bankAccounts;
        public List <Transaction> _transactions;

        public Bank(string name, List<BankAccount> bankAccounts, List<Transaction> transactions)
        {
            Name = name;
            _bankAccounts = bankAccounts;
            _transactions = transactions;
        }

        public void AddAccount(BankAccount account)
        {
            _bankAccounts.Add(account);   
        }

        public void AddTransaction(Transaction transaction)
        {
            //_bankAccounts.FindAll(account => account.OwnerName == fromAccount.OwnerName).Add(toAccount);
            _transactions.Add(transaction);
        }

        public void WriteBankAccounts() { _bankAccounts.ForEach(bankAccount => Console.WriteLine(bankAccount.ToString())); }
        public void WriteTransactions(){ _transactions.ForEach(transaction => Console.WriteLine(transaction.ToString())); }

        public void VerifyLargeTransactions(string verifier)
        {
            Random rnd = new Random();
            foreach (Transaction transaction in _transactions)
            {
                if (transaction.HumanVerificationNeeded)
                {
                    int num = rnd.Next(0,4);
                    transaction.Verification = new Verification(verifier, DateTime.Now, (Verification.VerificationResults)num, "further information");
                    transaction.Verified = true;
                    if (transaction.Verification.VerificationResult == Verification.VerificationResults.Denied) transaction.DeniedTransaction(transaction.Verification);
                }

            }

        }
        
        /*public void Write<T>(List<T> list)
        {
            list.ForEach(i => Console.WriteLine(i));
            // foreach (var info in list)
            // {
            //     Console.WriteLine(info);
            // }
        }*/
    }
}