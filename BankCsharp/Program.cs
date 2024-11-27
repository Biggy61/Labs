using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ceskaBanka = new Bank("Bank", new List<BankAccount>(), new List<Transaction>());
            
            BankAccount richman = new BankAccount(400000, "richman");
            BankAccount radek = new BankAccount(1, "radek");
            ceskaBanka.AddAccount(richman);
            ceskaBanka.AddAccount(radek);
            ceskaBanka.WriteBankAccounts();

            Transaction vyplataPredDPH = new Transaction(richman, radek, DateTime.Now, 200000);
    
            Transaction vyplataPoDPH = new Transaction(richman, radek, DateTime.Now, 2000);
            vyplataPredDPH.Execute();
            vyplataPoDPH.Execute();
            ceskaBanka.AddTransaction(vyplataPredDPH);
            ceskaBanka.AddTransaction(vyplataPoDPH);
            //ceskaBanka.WriteTransactions();
            ceskaBanka.WriteBankAccounts();
            BankAccount user1 = new BankAccount(1000, "Pavel");
            BankAccount user2 = new BankAccount(2000, "Vaclav");

            user1.Deposit(200);
            user1.Deposit(300);
            user2.Withdraw(100);

            Transaction transaction1 = new Transaction(user1, user2, DateTime.Now, 200);
            transaction1.Execute();

            Transaction transaction2 = new Transaction(user2, user1, DateTime.Now, 10);
            transaction2.Execute();

            Transaction transaction3 = new Transaction(user1, user2, DateTime.Now, 300);
            transaction3.Execute();

            ceskaBanka.VerifyLargeTransactions("Blud");

            Console.ReadKey();
        }
    }
}