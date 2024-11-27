using System;
using System.Threading.Tasks;

namespace Bank
{
    public class Transaction
    {
        public BankAccount FromAccount;
        public BankAccount ToAccount;
        public DateTime Date;
        public decimal Amount;
        public bool HumanVerificationNeeded;
        public Verification Verification { get; set; }
        public bool Verified = false;
        public Transaction(BankAccount fromAccount, BankAccount toAccount, DateTime date, decimal amount, bool humanVerificationNeeded)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Date = date;
            Amount = amount;
            HumanVerificationNeeded = humanVerificationNeeded;
            if (amount >= 100000) { humanVerificationNeeded = true; }
            else { humanVerificationNeeded = false; }
        }

        public void Write()
        {
            Console.WriteLine($"From: {FromAccount.OwnerName}: {FromAccount.Balance}, To {ToAccount.OwnerName}: {ToAccount.Balance}, Amount: {Amount}, Date: {Date}, HumanVerificationNeeded: {HumanVerificationNeeded}");
        }

        public void Execute()
        {
            FromAccount.Balance -= Amount;
            ToAccount.Balance += Amount;
        }
        public void DeniedTransaction(Verification verification)
        {
            Console.WriteLine($"\nVerification was denied:\n From Account: {FromAccount.AccNum}, {FromAccount.OwnerName} \n To Account: {ToAccount.AccNum}, {ToAccount.OwnerName} \n Amount: {Amount} \n FurtherInfo: {verification.FurtherInfo} \n Verifier: {verification.Verifier}");
        }
        public override string ToString()
        {
            return $"From: {FromAccount.OwnerName}: {FromAccount.Balance}, To {ToAccount.OwnerName}: {ToAccount.Balance}, Amount: {Amount}, Date: {Date}";
        }
    }
}