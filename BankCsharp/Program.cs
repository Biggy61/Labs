using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ceskaBanka = new Bank("Bank", new List<BankAccount>(), new List<Transaction>());
            BankAccount richman = new BankAccount(0, 10000, "Vaclav");
            BankAccount radek = new BankAccount(0, 10000, "radek");
            ceskaBanka.AddAccount(richman);
            ceskaBanka.AddAccount(radek);
            ceskaBanka.WriteBankAccounts();

            Transaction vyplataPredDPH = new Transaction(richman, radek, DateTime.Now, 200000, false);
            Transaction vyplataPoDPH = new Transaction(richman, radek, DateTime.Now, 2000, false);
            ceskaBanka.AddTransaction(vyplataPredDPH);
            ceskaBanka.AddTransaction(vyplataPoDPH);
            ceskaBanka.WriteTransactions();


            BankAccount user1 = new BankAccount(0, 1000, "Pavel");
            BankAccount user2 = new BankAccount(0, 2000, "Vaclav");

            user1.Write();
            user1.Deposit(200);
            user1.Deposit(300);

            user2.Withdraw(100);
            user2.Write();
            Transaction transaction1 = new Transaction(user1, user2, DateTime.Now, 200, false);
            transaction1.Write();
            transaction1.Execute();
            transaction1.Write();

            Transaction transaction2 = new Transaction(user2, user1, DateTime.Now, 10, false);
            transaction2.Write();
            transaction2.Execute();
            transaction2.Write();

            Transaction transaction3 = new Transaction(user1, user2, DateTime.Now, 300, false);
            transaction3.Write();
            transaction3.Execute();
            transaction3.Write();

            Console.ReadKey();
        }
    }
}