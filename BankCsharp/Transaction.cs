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
        public bool HumanVerificationNeeded { get; set; }
        public Verification Verification { get; set; }
        public bool Verified = false;
        public Transaction(BankAccount fromAccount, BankAccount toAccount, DateTime date, decimal amount)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Date = date;
            Amount = amount;
            if (amount > 100000) {
                HumanVerificationNeeded = true;
                return;
            }
            HumanVerificationNeeded = false;
        }

        public void WriteBefore()
        {
            Console.WriteLine($"From: {FromAccount.OwnerName}: {FromAccount.Balance}, To {ToAccount.OwnerName}: {ToAccount.Balance}, Amount: {Amount}, Date: {Date}, HumanVerificationNeeded: {HumanVerificationNeeded}");
        }
        public void WriteAfter()
        {
            Console.WriteLine($"After transaction: {FromAccount.OwnerName}: {FromAccount.Balance}, {ToAccount.OwnerName}: {ToAccount.Balance}, Date: {Date}");
        }


        public void Execute()
        {
            WriteBefore();
            FromAccount.Balance -= Amount;
            ToAccount.Balance += Amount;
            WriteAfter();
        }
        public void DeniedTransaction(Verification verification)
        {
            Console.WriteLine($"\nVerification was denied:\n From Account: {FromAccount.AccNum}, {FromAccount.OwnerName} \n To Account: {ToAccount.AccNum}, {ToAccount.OwnerName} \n Amount: {Amount} \n FurtherInfo: {verification.FurtherInfo} \n Verifier: {verification.Verifier}");
        }
        public override string ToString()
        {
            return $"From: {FromAccount.OwnerName}: {FromAccount.Balance}, To {ToAccount.OwnerName}: {ToAccount.Balance}, Amount: {Amount}, Date: {Date}, HumanVerificationNeeded: {HumanVerificationNeeded}";
        }
    }
}